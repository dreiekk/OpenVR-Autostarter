namespace OpenVR_Autostarter
{
    partial class EditTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTaskForm));
            radioButtonStart_Start = new RadioButton();
            textBoxProgramPath = new TextBox();
            buttonChooseProgram = new Button();
            buttonSave = new Button();
            buttonCancel = new Button();
            radioButtonStart_Nothing = new RadioButton();
            radioButtonStart_Stop = new RadioButton();
            radioButtonStop_Stop = new RadioButton();
            radioButtonStop_Nothing = new RadioButton();
            radioButtonStop_Start = new RadioButton();
            groupBoxStart = new GroupBox();
            groupBox1 = new GroupBox();
            openFileDialog = new OpenFileDialog();
            checkBoxForceClose = new CheckBox();
            checkBoxCloseByProcessName = new CheckBox();
            textBoxProcessName = new TextBox();
            textBoxStartArguments = new TextBox();
            buttonChooseProcessName = new Button();
            groupBoxOptions = new GroupBox();
            checkBoxPreventAlreadyRunning = new CheckBox();
            checkBoxStartMinimized = new CheckBox();
            labelStartArguments = new Label();
            labelUUID = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            checkBoxEnabled = new CheckBox();
            textBoxName = new TextBox();
            groupBoxStart.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxOptions.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonStart_Start
            // 
            radioButtonStart_Start.AutoSize = true;
            radioButtonStart_Start.Checked = true;
            radioButtonStart_Start.Location = new Point(7, 22);
            radioButtonStart_Start.Name = "radioButtonStart_Start";
            radioButtonStart_Start.Size = new Size(97, 19);
            radioButtonStart_Start.TabIndex = 4;
            radioButtonStart_Start.TabStop = true;
            radioButtonStart_Start.Text = "start program";
            radioButtonStart_Start.UseVisualStyleBackColor = true;
            // 
            // textBoxProgramPath
            // 
            textBoxProgramPath.Location = new Point(6, 22);
            textBoxProgramPath.Name = "textBoxProgramPath";
            textBoxProgramPath.Size = new Size(353, 23);
            textBoxProgramPath.TabIndex = 6;
            // 
            // buttonChooseProgram
            // 
            buttonChooseProgram.Location = new Point(365, 22);
            buttonChooseProgram.Name = "buttonChooseProgram";
            buttonChooseProgram.Size = new Size(113, 23);
            buttonChooseProgram.TabIndex = 7;
            buttonChooseProgram.Text = "choose file";
            buttonChooseProgram.UseVisualStyleBackColor = true;
            buttonChooseProgram.Click += ButtonChooseProgram_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(340, 487);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(421, 487);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // radioButtonStart_Nothing
            // 
            radioButtonStart_Nothing.AutoSize = true;
            radioButtonStart_Nothing.Location = new Point(7, 72);
            radioButtonStart_Nothing.Name = "radioButtonStart_Nothing";
            radioButtonStart_Nothing.Size = new Size(84, 19);
            radioButtonStart_Nothing.TabIndex = 14;
            radioButtonStart_Nothing.TabStop = true;
            radioButtonStart_Nothing.Text = "do nothing";
            radioButtonStart_Nothing.UseVisualStyleBackColor = true;
            // 
            // radioButtonStart_Stop
            // 
            radioButtonStart_Stop.AutoSize = true;
            radioButtonStart_Stop.Location = new Point(6, 47);
            radioButtonStart_Stop.Name = "radioButtonStart_Stop";
            radioButtonStart_Stop.Size = new Size(101, 19);
            radioButtonStart_Stop.TabIndex = 18;
            radioButtonStart_Stop.TabStop = true;
            radioButtonStart_Stop.Text = "close program";
            radioButtonStart_Stop.UseVisualStyleBackColor = true;
            // 
            // radioButtonStop_Stop
            // 
            radioButtonStop_Stop.AutoSize = true;
            radioButtonStop_Stop.Checked = true;
            radioButtonStop_Stop.Location = new Point(6, 47);
            radioButtonStop_Stop.Name = "radioButtonStop_Stop";
            radioButtonStop_Stop.Size = new Size(101, 19);
            radioButtonStop_Stop.TabIndex = 22;
            radioButtonStop_Stop.TabStop = true;
            radioButtonStop_Stop.Text = "close program";
            radioButtonStop_Stop.UseVisualStyleBackColor = true;
            // 
            // radioButtonStop_Nothing
            // 
            radioButtonStop_Nothing.AutoSize = true;
            radioButtonStop_Nothing.Location = new Point(6, 72);
            radioButtonStop_Nothing.Name = "radioButtonStop_Nothing";
            radioButtonStop_Nothing.Size = new Size(84, 19);
            radioButtonStop_Nothing.TabIndex = 21;
            radioButtonStop_Nothing.TabStop = true;
            radioButtonStop_Nothing.Text = "do nothing";
            radioButtonStop_Nothing.UseVisualStyleBackColor = true;
            // 
            // radioButtonStop_Start
            // 
            radioButtonStop_Start.AutoSize = true;
            radioButtonStop_Start.Location = new Point(6, 22);
            radioButtonStop_Start.Name = "radioButtonStop_Start";
            radioButtonStop_Start.Size = new Size(97, 19);
            radioButtonStop_Start.TabIndex = 19;
            radioButtonStop_Start.TabStop = true;
            radioButtonStop_Start.Text = "start program";
            radioButtonStop_Start.UseVisualStyleBackColor = true;
            // 
            // groupBoxStart
            // 
            groupBoxStart.Controls.Add(radioButtonStart_Nothing);
            groupBoxStart.Controls.Add(radioButtonStart_Start);
            groupBoxStart.Controls.Add(radioButtonStart_Stop);
            groupBoxStart.Location = new Point(12, 75);
            groupBoxStart.Name = "groupBoxStart";
            groupBoxStart.Size = new Size(245, 100);
            groupBoxStart.TabIndex = 29;
            groupBoxStart.TabStop = false;
            groupBoxStart.Text = "when VR runtime starts...";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonStop_Start);
            groupBox1.Controls.Add(radioButtonStop_Nothing);
            groupBox1.Controls.Add(radioButtonStop_Stop);
            groupBox1.Location = new Point(263, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 100);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "when VR runtime stops...";
            // 
            // checkBoxForceClose
            // 
            checkBoxForceClose.AutoSize = true;
            checkBoxForceClose.Location = new Point(13, 159);
            checkBoxForceClose.Name = "checkBoxForceClose";
            checkBoxForceClose.Size = new Size(270, 19);
            checkBoxForceClose.TabIndex = 28;
            checkBoxForceClose.Text = "kill process instead of soft-closing its windows";
            checkBoxForceClose.UseVisualStyleBackColor = true;
            // 
            // checkBoxCloseByProcessName
            // 
            checkBoxCloseByProcessName.AutoSize = true;
            checkBoxCloseByProcessName.Location = new Point(14, 92);
            checkBoxCloseByProcessName.Name = "checkBoxCloseByProcessName";
            checkBoxCloseByProcessName.Size = new Size(407, 19);
            checkBoxCloseByProcessName.TabIndex = 25;
            checkBoxCloseByProcessName.Text = "close program by ProcessName instead of Process Path (recommended)";
            checkBoxCloseByProcessName.UseVisualStyleBackColor = true;
            checkBoxCloseByProcessName.CheckedChanged += CheckBoxCloseByProcessName_CheckedChanged;
            // 
            // textBoxProcessName
            // 
            textBoxProcessName.Enabled = false;
            textBoxProcessName.Location = new Point(13, 117);
            textBoxProcessName.Name = "textBoxProcessName";
            textBoxProcessName.Size = new Size(346, 23);
            textBoxProcessName.TabIndex = 23;
            // 
            // textBoxStartArguments
            // 
            textBoxStartArguments.Location = new Point(13, 57);
            textBoxStartArguments.Name = "textBoxStartArguments";
            textBoxStartArguments.Size = new Size(465, 23);
            textBoxStartArguments.TabIndex = 8;
            // 
            // buttonChooseProcessName
            // 
            buttonChooseProcessName.Enabled = false;
            buttonChooseProcessName.Location = new Point(365, 117);
            buttonChooseProcessName.Name = "buttonChooseProcessName";
            buttonChooseProcessName.Size = new Size(113, 23);
            buttonChooseProcessName.TabIndex = 26;
            buttonChooseProcessName.Text = "choose process";
            buttonChooseProcessName.UseVisualStyleBackColor = true;
            buttonChooseProcessName.Click += ButtonChooseProcessName_Click;
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBoxOptions.Controls.Add(checkBoxPreventAlreadyRunning);
            groupBoxOptions.Controls.Add(checkBoxStartMinimized);
            groupBoxOptions.Controls.Add(labelStartArguments);
            groupBoxOptions.Controls.Add(textBoxStartArguments);
            groupBoxOptions.Controls.Add(textBoxProcessName);
            groupBoxOptions.Controls.Add(checkBoxCloseByProcessName);
            groupBoxOptions.Controls.Add(checkBoxForceClose);
            groupBoxOptions.Controls.Add(buttonChooseProcessName);
            groupBoxOptions.Location = new Point(12, 244);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Size = new Size(484, 237);
            groupBoxOptions.TabIndex = 32;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Options";
            // 
            // checkBoxPreventAlreadyRunning
            // 
            checkBoxPreventAlreadyRunning.AutoSize = true;
            checkBoxPreventAlreadyRunning.Location = new Point(13, 209);
            checkBoxPreventAlreadyRunning.Name = "checkBoxPreventAlreadyRunning";
            checkBoxPreventAlreadyRunning.Size = new Size(414, 19);
            checkBoxPreventAlreadyRunning.TabIndex = 31;
            checkBoxPreventAlreadyRunning.Text = "prevent start of program if already running (requires ProcessName above)";
            checkBoxPreventAlreadyRunning.UseVisualStyleBackColor = true;
            checkBoxPreventAlreadyRunning.CheckedChanged += checkBoxPreventAlreadyRunning_CheckedChanged;
            // 
            // checkBoxStartMinimized
            // 
            checkBoxStartMinimized.AutoSize = true;
            checkBoxStartMinimized.Location = new Point(13, 184);
            checkBoxStartMinimized.Name = "checkBoxStartMinimized";
            checkBoxStartMinimized.Size = new Size(157, 19);
            checkBoxStartMinimized.TabIndex = 30;
            checkBoxStartMinimized.Text = "start program minimized";
            checkBoxStartMinimized.UseVisualStyleBackColor = true;
            // 
            // labelStartArguments
            // 
            labelStartArguments.AutoSize = true;
            labelStartArguments.Location = new Point(13, 35);
            labelStartArguments.Name = "labelStartArguments";
            labelStartArguments.Size = new Size(223, 15);
            labelStartArguments.TabIndex = 29;
            labelStartArguments.Text = "(optional) start program with arguments:";
            // 
            // labelUUID
            // 
            labelUUID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelUUID.ForeColor = SystemColors.ControlDark;
            labelUUID.Location = new Point(12, 487);
            labelUUID.Name = "labelUUID";
            labelUUID.Size = new Size(322, 23);
            labelUUID.TabIndex = 33;
            labelUUID.Text = "UUID: New Task";
            labelUUID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxProgramPath);
            groupBox2.Controls.Add(buttonChooseProgram);
            groupBox2.Location = new Point(12, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(484, 57);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Program Path / URI";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxEnabled);
            groupBox3.Controls.Add(textBoxName);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(484, 57);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "Task Name";
            // 
            // checkBoxEnabled
            // 
            checkBoxEnabled.AutoSize = true;
            checkBoxEnabled.Checked = true;
            checkBoxEnabled.CheckState = CheckState.Checked;
            checkBoxEnabled.Location = new Point(399, 24);
            checkBoxEnabled.Name = "checkBoxEnabled";
            checkBoxEnabled.Size = new Size(68, 19);
            checkBoxEnabled.TabIndex = 36;
            checkBoxEnabled.Text = "Enabled";
            checkBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(6, 22);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(371, 23);
            textBoxName.TabIndex = 6;
            // 
            // EditTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 518);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(labelUUID);
            Controls.Add(groupBoxOptions);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxStart);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditTaskForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Task";
            FormClosing += EditTaskForm_FormClosing;
            groupBoxStart.ResumeLayout(false);
            groupBoxStart.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxOptions.ResumeLayout(false);
            groupBoxOptions.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonStart_Start;
        private System.Windows.Forms.TextBox textBoxProgramPath;
        private System.Windows.Forms.Button buttonChooseProgram;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButtonStart_Nothing;
        private System.Windows.Forms.RadioButton radioButtonStart_Stop;
        private System.Windows.Forms.RadioButton radioButtonStop_Stop;
        private System.Windows.Forms.RadioButton radioButtonStop_Nothing;
        private System.Windows.Forms.RadioButton radioButtonStop_Start;
        private System.Windows.Forms.GroupBox groupBoxStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox checkBoxForceClose;
        private System.Windows.Forms.CheckBox checkBoxCloseByProcessName;
        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.TextBox textBoxStartArguments;
        private System.Windows.Forms.Button buttonChooseProcessName;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Label labelStartArguments;
        private System.Windows.Forms.Label labelUUID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private CheckBox checkBoxStartMinimized;
        private CheckBox checkBoxPreventAlreadyRunning;
    }
}