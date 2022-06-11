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
    public partial class MainForm : Form
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            //
        }

        private void RefreshTaskListView()
        {
            listViewTasks.Items.Clear();

            foreach (AutostartTask task in config.Tasks)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Name = task.UUID;
                listViewItem.Text = task.Enabled ? "YES" : "NO";
                listViewItem.SubItems.Add(task.Name);
                listViewItem.SubItems.Add(task.StartAction.ToString());
                listViewItem.SubItems.Add(task.StopAction.ToString());
                listViewItem.SubItems.Add(task.ProgramPath);
                listViewItem.SubItems.Add(task.ProgramArguments);

                listViewTasks.Items.Add(listViewItem);
            }
        }

        private string GetConfigurationPath()
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
                catch (Exception ex)
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

        private void buttonNew_Click(object sender, EventArgs e)
        {
            openEditTaskDialog(null);
        }

        private void listViewTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewTasks.SelectedItems.Count != 1) return;
            openEditTaskDialog(listViewTasks.SelectedItems[0].Name);
        }

        private Tuple<AutostartTask, int> findTaskInConfigByUUID(string uuid)
        {
            AutostartTask task = null;
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

        private void openEditTaskDialog(string uuid)
        {
            bool isNewTask = uuid == null;
            AutostartTask task = null;
            int taskIndex = -1;
            if (isNewTask == false)
            {
                (task, taskIndex) = findTaskInConfigByUUID(uuid);
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
                AutostartTask taskToSave = editTaskForm.getTaskFromInputs();

                if (isNewTask)
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count != 1) return;
            openEditTaskDialog(listViewTasks.SelectedItems[0].Name);
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/dreiekk/OpenVR-Autostarter") { UseShellExecute = true });
        }

        private string getManifestPath()
        {
            return Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "manifest.vrmanifest"));
        }

        //private void buttonRegisterManifest_Click(object sender, EventArgs e)
        //{
        //    EVRInitError peError = EVRInitError.None;
        //    CVRSystem cvr = OpenVR.Init(ref peError, EVRApplicationType.VRApplication_Background);

        //    if (peError != EVRInitError.None)
        //    {
        //        MessageBox.Show("Could not initialize OpenVR runtime." + Environment.NewLine + "Please start your VR application." + Environment.NewLine + Environment.NewLine + "Error: " + peError.ToString(), "No OpenVR running", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //}

        //private void buttonCheckManifest_Click(object sender, EventArgs e)
        //{
        //    string statustext = $"ID: {application_key}" + Environment.NewLine;

        //    string application_exists = "NO (ERROR)";
        //    try
        //    {
        //        application_exists = OpenVR.Applications.IsApplicationInstalled(application_key) == true ? "YES" : "NO";
        //    }
        //    catch (NullReferenceException ex) { }
        //    statustext += $"Application exists in VR runtime? : {application_exists}" + Environment.NewLine;

        //    string application_autolaunch = "NO (ERROR)";
        //    try
        //    {
        //        application_autolaunch = OpenVR.Applications.GetApplicationAutoLaunch(application_key) == true ? "YES" : "NO";
        //    }
        //    catch (NullReferenceException ex) { }
        //    statustext += $"Autolaunch enabled? : {application_autolaunch}" + Environment.NewLine + Environment.NewLine;

        //    string manifest_path = getManifestPath();
        //    statustext += "Manifest path:" + Environment.NewLine + Environment.NewLine + manifest_path;

        //    MessageBox.Show(statustext, "vrmanifest status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private async void TimerOpenVRPolling_Tick(object sender, EventArgs e)
        {
            EVRInitError peError = EVRInitError.None;
            CVRSystem cvr = await Task.Run(() => { return OpenVR.Init(ref peError, EVRApplicationType.VRApplication_Background); });

            if (peError != EVRInitError.None)
            {
                //MessageBox.Show("Could not initialize OpenVR runtime." + Environment.NewLine + "Please start your VR application." + Environment.NewLine + Environment.NewLine + "Error: " + peError.ToString(), "No OpenVR running", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                // disable until first startup is through...
                timerOpenVRPolling.Enabled = false;

                // register vrmanifest
                RegisterVRManifest();

                // first startup, start programs
                await StartPrograms();

                // first startup ends, enabling timer again
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

        private void RegisterVRManifest()
        {
            try
            {
                if (OpenVR.Applications.IsApplicationInstalled(application_key))
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                //
            }

            string manifest_path = getManifestPath();
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
                tpf.setInfoText($"{action} {task.Name} ({index}/{total})...");

                if (task.StartAction == StartStopAction.START_PROGRAM)
                {
                    await startProcess(tpf, task);
                }
                else
                {
                    await stopProcess(tpf, task);
                }
                
                await Task.Run(() => { Thread.Sleep(1000); });
            }

            tpf.Close();
        }

        private async Task startProcess(TaskProgressForm tpf, AutostartTask task)
        {
            Func<string> temp = () =>
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = task.ProgramPath;
                    psi.WorkingDirectory = Path.GetDirectoryName(task.ProgramPath);
                    psi.Arguments = task.ProgramArguments;
                    Process.Start(psi);
                    return "";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            };
            string result = await Task.Run(temp);

            if (result != "")
            {
                tpf.setInfoText($"Error starting {task.Name}, skipping...");
                await Task.Run(() => { Thread.Sleep(2000); });
            }
        }

        private async Task stopProcess(TaskProgressForm tpf, AutostartTask task)
        {
            Process[] runningProcesses = await Task.Run(() => { return Process.GetProcesses(); });

            List<Process> targetProcesses = await Task.Run(() =>
            {
                List<Process> returnProcesses = new List<Process>();
                foreach (Process process in runningProcesses)
                {
                    try
                    {
                        if (process.MainModule != null)
                        {
                            if ((task.CloseByProcessName && process.ProcessName == task.ProcessName)
                                || (task.CloseByProcessName == false && process.MainModule.FileName == task.ProgramPath))
                            {
                                returnProcesses.Add(process);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                return returnProcesses;
            });

            if (targetProcesses.Count <= 0)
            {
                tpf.setInfoText($"{task.Name} is not running, skipping to next task...");
                await Task.Run(() => { Thread.Sleep(2000); });
            }
            else
            {
                foreach (Process p in targetProcesses)
                {
                    if (task.ForceKillAfterTime)
                    {
                        await Task.Run(() => { p.Kill(); });
                    }
                    else
                    {
                        await Task.Run(() => { p.CloseMainWindow(); });
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
                tpf.setInfoText($"{action} {task.Name} ({index}/{total})...");

                if (task.StopAction == StartStopAction.START_PROGRAM)
                {
                    await startProcess(tpf, task);
                }
                else
                {
                    await stopProcess(tpf, task);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count != 1) return;
            string uuid = listViewTasks.SelectedItems[0].Name;
            (AutostartTask task, int taskIndex) = findTaskInConfigByUUID(uuid);
            if (task == null)
            {
                MessageBox.Show("The task you want to delete could not be found.", "Could not find task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            config.Tasks.RemoveAt(taskIndex);
            SaveConfig();
            RefreshTaskListView();
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count != 1) return;
            string uuid = listViewTasks.SelectedItems[0].Name;
            (AutostartTask task, int taskIndex) = findTaskInConfigByUUID(uuid);
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

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count != 1) return;
            string uuid = listViewTasks.SelectedItems[0].Name;
            (AutostartTask task, int taskIndex) = findTaskInConfigByUUID(uuid);
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

        private async void buttonTestStart_Click(object sender, EventArgs e)
        {
            await StartPrograms();
        }

        private async void buttonTestStop_Click(object sender, EventArgs e)
        {
            await StopPrograms();
        }
    }
}
