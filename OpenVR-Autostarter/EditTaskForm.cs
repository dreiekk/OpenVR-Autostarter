using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenVR_Autostarter
{
    public partial class EditTaskForm : FormEscapeClosable
    {
        private AutostartTask task = new AutostartTask();
        private bool cancelClicked = false;

        public EditTaskForm(AutostartTask TaskToLoad = null)
        {
            InitializeComponent();
            if (TaskToLoad != null)
            {
                LoadTask(TaskToLoad);
            }
            else
            {
                Text = "New Task";
            }
        }

        private void checkBoxCloseByProcessName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCloseByProcessName.Checked)
            {
                textBoxProcessName.Enabled = true;
                buttonChooseProcessName.Enabled = true;
            }
            else
            {
                textBoxProcessName.Enabled = false;
                buttonChooseProcessName.Enabled = false;
            }
        }

        private void buttonChooseProcessName_Click(object sender, EventArgs e)
        {
            ChooseProcessNameForm chooseProcessNameForm = new ChooseProcessNameForm();

            DialogResult dr = chooseProcessNameForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                chooseProcessNameForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                textBoxProcessName.Text = chooseProcessNameForm.getSelectedProcessName();
                chooseProcessNameForm.Close();
            }
        }

        private void buttonChooseProgram_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                textBoxProgramPath.Text = openFileDialog.FileName;
            }
        }

        private void LoadTask(AutostartTask _task)
        {
            task = _task;
            textBoxName.Text = task.Name;
            checkBoxEnabled.Checked = task.Enabled;
            labelUUID.Text = task.UUID;
            switch (task.StartAction)
            {
                case StartStopAction.START_PROGRAM:
                    radioButtonStart_Start.Checked = true;
                    break;
                case StartStopAction.STOP_PROGRAM:
                    radioButtonStart_Stop.Checked = true;
                    break;
                default:
                    radioButtonStart_Nothing.Checked = true;
                    break;
            }
            switch(task.StopAction)
            {
                case StartStopAction.START_PROGRAM:
                    radioButtonStop_Start.Checked = true;
                break;
                case StartStopAction.STOP_PROGRAM:
                    radioButtonStop_Stop.Checked = true;
                break;
                default:
                    radioButtonStop_Nothing.Checked = true;
                break;
            }
            textBoxProgramPath.Text = task.ProgramPath;
            textBoxStartArguments.Text = task.ProgramArguments;
            checkBoxCloseByProcessName.Checked = task.CloseByProcessName;
            textBoxProcessName.Text = task.ProcessName;
            checkBoxForceClose.Checked = task.ForceKillAfterTime;
        }

        public AutostartTask getTaskFromInputs()
        {
            task.Name = textBoxName.Text.Trim();
            task.Enabled = checkBoxEnabled.Checked;

            if (radioButtonStart_Start.Checked) task.StartAction = StartStopAction.START_PROGRAM;
            else if (radioButtonStart_Stop.Checked) task.StartAction = StartStopAction.STOP_PROGRAM;
            else task.StartAction = StartStopAction.DO_NOTHING;

            if (radioButtonStop_Start.Checked) task.StopAction = StartStopAction.START_PROGRAM;
            else if (radioButtonStop_Stop.Checked) task.StopAction = StartStopAction.STOP_PROGRAM;
            else task.StopAction = StartStopAction.DO_NOTHING;

            task.ProgramPath = textBoxProgramPath.Text.Trim();
            task.ProgramArguments = textBoxStartArguments.Text.Trim();
            task.CloseByProcessName = checkBoxCloseByProcessName.Checked;
            task.ProcessName = textBoxProcessName.Text.Trim();
            task.ForceKillAfterTime = checkBoxForceClose.Checked;
            return task;
        }

        private void EditTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || cancelClicked)
            {
                return;
            }

            if (textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("Task Name should not be empty", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }

            if (textBoxProgramPath.Text.Trim() == "")
            {
                MessageBox.Show("Program Path should not be empty", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }

            if (checkBoxCloseByProcessName.Checked && textBoxProcessName.Text.Trim() == "")
            {
                MessageBox.Show("Process Name should not be empty", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancelClicked = true;
            Close();
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
