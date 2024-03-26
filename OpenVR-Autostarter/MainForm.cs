using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Valve.VR;
using OpenVR_Autostarter;
using System.Threading;
using System.IO;

namespace OpenVR_Autostarter
{
    public partial class MainForm : FormEscapeClosable
    {
        const string application_key = "dreiekk.OpenVR-Autostarter";

        bool openvr_active = false;
        bool firstProgramStartup = true;
        bool readyToDie = false;
        bool isMainFormShown = false;

        public AutostarterConfig config;

        public MainForm()
        {
            InitializeComponent();
            labelVersion.Text = 'v' + Application.ProductVersion;
            config = new AutostarterConfig();
            LoadConfig();
            RefreshTaskListView();
        }

        public void HideTracked()
        {
            Hide();
            isMainFormShown = false;
        }

        public void ShowTracked()
        {
            Show();
            isMainFormShown = true;
        }

        private void RefreshTaskListView()
        {
            listViewTasks.Items.Clear();

            foreach (AutostartTask task in config.Tasks)
            {
                ListViewItem listViewItem = new ListViewItem()
                {
                    Name = task.UUID,
                    Text = task.Enabled ? "YES" : "NO"
                };
                listViewItem.SubItems.Add(task.Name);
                listViewItem.SubItems.Add(task.StartAction.ToString());
                listViewItem.SubItems.Add(task.StopAction.ToString());
                listViewItem.SubItems.Add(task.ProgramPath);
                listViewItem.SubItems.Add(task.ProgramArguments);

                listViewTasks.Items.Add(listViewItem);
            }
        }

        private static string GetConfigurationPath()
        {
            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "openvr_autostarter.xml"
            );
        }

        private void LoadConfig()
        {
            string configFilePath = GetConfigurationPath();

            if (File.Exists(configFilePath))
            {
                try
                {
                    config = XmlHelper.FromXmlFile<AutostarterConfig>(configFilePath);
                }
                catch
                {
                    MessageBox.Show("Fatal error: Could not load config file at:" + Environment.NewLine + Environment.NewLine + configFilePath + Environment.NewLine + Environment.NewLine + "Closing application to prevent override.", "Could not load config", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    readyToDie = true;
                    Application.Exit();
                }
                return;
            }

            config = new AutostarterConfig();
            XmlHelper.ToXmlFile(config, configFilePath);
        }

        private void SaveConfig()
        {
            string configFilePath = GetConfigurationPath();
            XmlHelper.ToXmlFile(config, configFilePath);
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            OpenEditTaskDialog(null);
        }

        private void ListViewTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewTasks.SelectedItems.Count != 1) return;
            OpenEditTaskDialog(listViewTasks.SelectedItems[0].Name);
        }

        private Tuple<AutostartTask?, int> FindTaskInConfigByUUID(string uuid)
        {
            AutostartTask? task = null;
            int taskIndex = -1;
            foreach (AutostartTask searchtask in config.Tasks)
            {
                taskIndex++;
                if (searchtask.UUID == uuid)
                {
                    task = searchtask;
                    break;
                }
            }
            return Tuple.Create(task, taskIndex);
        }

        private void OpenEditTaskDialog(string? uuid)
        {
            AutostartTask? task = null;
            int taskIndex = -1;
            if (uuid != null)
            {
                (task, taskIndex) = FindTaskInConfigByUUID(uuid);
                if (task == null)
                {
                    MessageBox.Show("The task you want to edit could not be found.", "Could not find task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            EditTaskForm editTaskForm = new EditTaskForm(task);

            DialogResult dr = editTaskForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                editTaskForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                AutostartTask taskToSave = editTaskForm.GetTaskFromInputs();

                if (uuid == null)
                {
                    config.Tasks.Add(taskToSave);
                }
                else
                {
                    config.Tasks[taskIndex] = taskToSave;
                }
                SaveConfig();
                editTaskForm.Close();
                RefreshTaskListView();
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count != 1) return;
            OpenEditTaskDialog(listViewTasks.SelectedItems[0].Name);
        }

        private void LinkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/dreiekk/OpenVR-Autostarter") { UseShellExecute = true });
        }

        private static string GetManifestPath()
        {
            string? executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            if (executablePath == null)
            {
                throw new Exception("Could not get Application Executable Path");
            }
            return Path.GetFullPath(Path.Combine(executablePath, "manifest.vrmanifest"));
        }

        private async void TimerOpenVRPolling_Tick(object sender, EventArgs e)
        {
            EVRInitError peError = EVRInitError.None;
            CVRSystem cvr = await Task.Run(() => { return OpenVR.Init(ref peError, EVRApplicationType.VRApplication_Background); });

            if (peError != EVRInitError.None)
            {
                openvr_active = false;
                timerOpenVRPolling.Interval = 5000;

                if (firstProgramStartup)
                {
                    ShowTracked();
                }
                firstProgramStartup = false;
                return;
            }
            firstProgramStartup = false;

            if (openvr_active == false)
            {
                openvr_active = true;

                // first startup
                timerOpenVRPolling.Enabled = false;
                RegisterVRManifest();
                await StartPrograms();
                timerOpenVRPolling.Enabled = true;
            }

            timerOpenVRPolling.Interval = 2000;

            VREvent_t ev = new VREvent_t() { };
            while (cvr.PollNextEvent(ref ev, uint.MaxValue))
            {
                if (ev.eventType == (uint)EVREventType.VREvent_Quit)
                {
                    timerOpenVRPolling.Enabled = false;
                    OpenVR.System.AcknowledgeQuit_Exiting();

                    await StopPrograms();

                    OpenVR.Shutdown();
                    openvr_active = false;
                    timerOpenVRPolling.Enabled = true;

                    if (isMainFormShown == false)
                    {
                        readyToDie = true;
                        Application.Exit();
                    }
                    break;
                }
            }
        }

        private static void RegisterVRManifest()
        {
            try
            {
                if (OpenVR.Applications.IsApplicationInstalled(application_key))
                {
                    return;
                }
            }
            catch { }

            string manifest_path = GetManifestPath();
            Debug.WriteLine(manifest_path);
            Debug.WriteLine("Is Application installed? : " + OpenVR.Applications.IsApplicationInstalled(application_key));
            Debug.WriteLine("Installing manifest...");
            EVRApplicationError manifest_error = OpenVR.Applications.AddApplicationManifest(manifest_path, false);
            if (manifest_error != EVRApplicationError.None)
            {
                Debug.WriteLine("Could not add application manifest: " + OpenVR.Applications.GetApplicationsErrorNameFromEnum(manifest_error));
            }
            else
            {
                Debug.WriteLine("Successfully installed manifest with no errors: " + OpenVR.Applications.GetApplicationsErrorNameFromEnum(manifest_error));

                Debug.WriteLine("Is Application installed? : " + OpenVR.Applications.IsApplicationInstalled(application_key));

                Debug.WriteLine("Enabling overlay autostart...");
                EVRApplicationError autostart_error = OpenVR.Applications.SetApplicationAutoLaunch(application_key, true);
                if (autostart_error != EVRApplicationError.None)
                {
                    Debug.WriteLine("Could not enable autostart: " + OpenVR.Applications.GetApplicationsErrorNameFromEnum(autostart_error));
                }
            }
        }

        private async Task StartPrograms()
        {
            TaskProgressForm tpf = new TaskProgressForm();
            tpf.Show();

            int total = 0;
            foreach (AutostartTask task in config.Tasks)
            {
                if (task.Enabled && task.StartAction != StartStopAction.DO_NOTHING) total++;
            }

            int index = 0;
            foreach (AutostartTask task in config.Tasks)
            {
                if (task.Enabled == false || task.StartAction == StartStopAction.DO_NOTHING) continue;

                string action = task.StartAction == StartStopAction.START_PROGRAM ? "Starting" : "Closing";

                index++;
                tpf.SetInfoText($"{action} {task.Name} ({index}/{total})...");

                if (task.StartAction == StartStopAction.START_PROGRAM)
                {
                    await StartProcess(tpf, task);
                }
                else
                {
                    await StopProcess(tpf, task);
                }
                
                await Task.Run(() => { Thread.Sleep(1000); });
            }

            tpf.Close();
        }

        private static async Task StartProcess(TaskProgressForm tpf, AutostartTask task)
        {
            string temp()
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = task.ProgramPath,
                        WorkingDirectory = Path.GetDirectoryName(task.ProgramPath),
                        Arguments = task.ProgramArguments,
                        UseShellExecute = true
                    };
                    if (task.StartMinimized)
                    {
                        psi.WindowStyle = ProcessWindowStyle.Minimized;
                    }
                    if (task.PreventAlreadyRunning)
                    {
                        Process[] runningProcesses = Process.GetProcesses();
                        foreach (Process process in runningProcesses)
                        {
                            try
                            {
                                if (process.ProcessName == task.ProcessName)
                                {
                                    return "already_running";
                                }
                            }
                            catch { }
                        }                            
                    }
                    Process.Start(psi);
                    return "";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            string result = await Task.Run(temp);

            if (result == "already_running")
            {
                tpf.SetInfoText($"Program of {task.Name} already running, skipping...");
            }
            else if (result != "")
            {
                tpf.SetInfoText($"Error starting {task.Name}, skipping...");
                await Task.Run(() => { Thread.Sleep(2000); });
            }
        }

        private static async Task StopProcess(TaskProgressForm tpf, AutostartTask task)
        {
            async Task<List<Process>> GetTargetProcesses()
            {
                Process[] runningProcesses = await Task.Run(() => { return Process.GetProcesses(); });
                return await Task.Run(() =>
                {
                    List<Process> returnProcesses = new List<Process>();
                    foreach (Process process in runningProcesses)
                    {
                        try
                        {
                            if ((task.CloseByProcessName && process.ProcessName == task.ProcessName)
                                || (task.CloseByProcessName == false && process.MainModule != null && process.MainModule.FileName == task.ProgramPath))
                            {
                                returnProcesses.Add(process);
                            }
                        }
                        catch { }
                    }
                    return returnProcesses;
                });
            };

            List<Process> targetProcesses = await GetTargetProcesses();

            if (targetProcesses.Count <= 0)
            {
                tpf.SetInfoText($"{task.Name} is not running, skipping to next task...");
                await Task.Run(() => { Thread.Sleep(2000); });
            }
            else
            {
                if (task.ForceKillAfterTime)
                {
                    foreach (Process p in targetProcesses)
                    {
                        await Task.Run(() => { p.Kill(); });
                    }
                }
                else
                {
                    for (int i = 0; i < targetProcesses.Count; i++)
                    {
                        foreach (Process p in targetProcesses)
                        {
                            try
                            {
                                p.CloseMainWindow();
                            }
                            catch { }
                        }
                        targetProcesses = await GetTargetProcesses();
                    }
                }
            }
        }

        private async Task StopPrograms()
        {
            TaskProgressForm tpf = new TaskProgressForm();
            tpf.Show();

            int total = 0;
            foreach (AutostartTask task in config.Tasks)
            {
                if (task.Enabled && task.StopAction != StartStopAction.DO_NOTHING) total++;
            }

            int index = 0;
            foreach (AutostartTask task in config.Tasks)
            {
                if (task.Enabled == false || task.StopAction == StartStopAction.DO_NOTHING) continue;

                string action = task.StopAction == StartStopAction.START_PROGRAM ? "Starting" : "Closing";

                index++;
                tpf.SetInfoText($"{action} {task.Name} ({index}/{total})...");

                if (task.StopAction == StartStopAction.START_PROGRAM)
                {
                    await StartProcess(tpf, task);
                }
                else
                {
                    await StopProcess(tpf, task);
                }

                await Task.Run(() => { Thread.Sleep(1000); });
            }
            tpf.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readyToDie = true;
            Application.Exit();
        }

        private void ShowSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTracked();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (openvr_active == false)
            {
                readyToDie = true;
            }
            if (!readyToDie)
            {
                e.Cancel = true;
                HideTracked();
                return;
            }
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
            Application.Exit();
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowTracked();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count != 1) return;
            string uuid = listViewTasks.SelectedItems[0].Name;
            (AutostartTask? task, int taskIndex) = FindTaskInConfigByUUID(uuid);
            if (task == null)
            {
                MessageBox.Show("The task you want to delete could not be found.", "Could not find task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            config.Tasks.RemoveAt(taskIndex);
            SaveConfig();
            RefreshTaskListView();
        }

        private void ButtonMoveUp_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count != 1) return;
            string uuid = listViewTasks.SelectedItems[0].Name;
            (AutostartTask? task, int taskIndex) = FindTaskInConfigByUUID(uuid);
            if (task == null)
            {
                MessageBox.Show("The task you want to move could not be found.", "Could not find task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (taskIndex > 0)
            {
                AutostartTask partnerTask = config.Tasks[taskIndex - 1];
                config.Tasks[taskIndex - 1] = task;
                config.Tasks[taskIndex] = partnerTask;
            }
            else
            {
                MessageBox.Show("The task you want to move is already first.", "Could not move task", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SaveConfig();
            RefreshTaskListView();
        }

        private void ButtonMoveDown_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count != 1) return;
            string uuid = listViewTasks.SelectedItems[0].Name;
            (AutostartTask? task, int taskIndex) = FindTaskInConfigByUUID(uuid);
            if (task == null)
            {
                MessageBox.Show("The task you want to move could not be found.", "Could not find task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (taskIndex < config.Tasks.Count-1)
            {
                AutostartTask partnerTask = config.Tasks[taskIndex + 1];
                config.Tasks[taskIndex + 1] = task;
                config.Tasks[taskIndex] = partnerTask;
            }
            else
            {
                MessageBox.Show("The task you want to move is already last.", "Could not move task", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SaveConfig();
            RefreshTaskListView();
        }

        private async void ButtonTestStart_Click(object sender, EventArgs e)
        {
            await StartPrograms();
        }

        private async void ButtonTestStop_Click(object sender, EventArgs e)
        {
            await StopPrograms();
        }
    }
}
