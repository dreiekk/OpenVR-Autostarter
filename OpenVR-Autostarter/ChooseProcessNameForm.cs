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

namespace OpenVR_Autostarter
{
    public partial class ChooseProcessNameForm : FormEscapeClosable
    {
        public ChooseProcessNameForm()
        {
            InitializeComponent();
        }

        private void ListViewProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSelect.Enabled = true;
        }

        public string GetSelectedProcessName()
        {
            return listViewProcesses.SelectedItems[0].Text;
        }

        private void ChooseProcessNameForm_Load(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private async void RefreshProcessList()
        {
            buttonSelect.Enabled = false;
            progressBar.Visible = true;
            buttonRefresh.Enabled = false;
            listViewProcesses.Items.Clear();
            List<string> processNames = await Task.Run(() => GetProcessList());
            foreach (string processName in processNames)
            {
                listViewProcesses.Items.Add(processName);
            }
            progressBar.Visible = false;
            buttonRefresh.Enabled = true;
        }

        private static List<string> GetProcessList()
        {
            Process[] runningProcesses = Process.GetProcesses();
            List<string> processNames = new List<string>();
            foreach (Process process in runningProcesses)
            {
                try
                {
                    if (process.MainModule != null)
                    {
                        if (processNames.Contains(process.ProcessName))
                            continue;

                        processNames.Add(process.ProcessName);
                    }
                }
                catch { }
            }
            return processNames;
        }

        private void ListViewProcesses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonSelect.PerformClick();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }
    }
}
