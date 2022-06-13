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
            this.radioButtonStart_Start = new System.Windows.Forms.RadioButton();
            this.textBoxProgramPath = new System.Windows.Forms.TextBox();
            this.buttonChooseProgram = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radioButtonStart_Nothing = new System.Windows.Forms.RadioButton();
            this.radioButtonStart_Stop = new System.Windows.Forms.RadioButton();
            this.radioButtonStop_Stop = new System.Windows.Forms.RadioButton();
            this.radioButtonStop_Nothing = new System.Windows.Forms.RadioButton();
            this.radioButtonStop_Start = new System.Windows.Forms.RadioButton();
            this.groupBoxStart = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxForceClose = new System.Windows.Forms.CheckBox();
            this.checkBoxCloseByProcessName = new System.Windows.Forms.CheckBox();
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.textBoxStartArguments = new System.Windows.Forms.TextBox();
            this.buttonChooseProcessName = new System.Windows.Forms.Button();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.labelStartArguments = new System.Windows.Forms.Label();
            this.labelUUID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxStart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonStart_Start
            // 
            this.radioButtonStart_Start.AutoSize = true;
            this.radioButtonStart_Start.Checked = true;
            this.radioButtonStart_Start.Location = new System.Drawing.Point(7, 22);
            this.radioButtonStart_Start.Name = "radioButtonStart_Start";
            this.radioButtonStart_Start.Size = new System.Drawing.Size(97, 19);
            this.radioButtonStart_Start.TabIndex = 4;
            this.radioButtonStart_Start.TabStop = true;
            this.radioButtonStart_Start.Text = "start program";
            this.radioButtonStart_Start.UseVisualStyleBackColor = true;
            // 
            // textBoxProgramPath
            // 
            this.textBoxProgramPath.Location = new System.Drawing.Point(6, 22);
            this.textBoxProgramPath.Name = "textBoxProgramPath";
            this.textBoxProgramPath.Size = new System.Drawing.Size(353, 23);
            this.textBoxProgramPath.TabIndex = 6;
            // 
            // buttonChooseProgram
            // 
            this.buttonChooseProgram.Location = new System.Drawing.Point(365, 22);
            this.buttonChooseProgram.Name = "buttonChooseProgram";
            this.buttonChooseProgram.Size = new System.Drawing.Size(113, 23);
            this.buttonChooseProgram.TabIndex = 7;
            this.buttonChooseProgram.Text = "choose file";
            this.buttonChooseProgram.UseVisualStyleBackColor = true;
            this.buttonChooseProgram.Click += new System.EventHandler(this.ButtonChooseProgram_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(340, 441);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(421, 441);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // radioButtonStart_Nothing
            // 
            this.radioButtonStart_Nothing.AutoSize = true;
            this.radioButtonStart_Nothing.Location = new System.Drawing.Point(7, 72);
            this.radioButtonStart_Nothing.Name = "radioButtonStart_Nothing";
            this.radioButtonStart_Nothing.Size = new System.Drawing.Size(84, 19);
            this.radioButtonStart_Nothing.TabIndex = 14;
            this.radioButtonStart_Nothing.TabStop = true;
            this.radioButtonStart_Nothing.Text = "do nothing";
            this.radioButtonStart_Nothing.UseVisualStyleBackColor = true;
            // 
            // radioButtonStart_Stop
            // 
            this.radioButtonStart_Stop.AutoSize = true;
            this.radioButtonStart_Stop.Location = new System.Drawing.Point(6, 47);
            this.radioButtonStart_Stop.Name = "radioButtonStart_Stop";
            this.radioButtonStart_Stop.Size = new System.Drawing.Size(101, 19);
            this.radioButtonStart_Stop.TabIndex = 18;
            this.radioButtonStart_Stop.TabStop = true;
            this.radioButtonStart_Stop.Text = "close program";
            this.radioButtonStart_Stop.UseVisualStyleBackColor = true;
            // 
            // radioButtonStop_Stop
            // 
            this.radioButtonStop_Stop.AutoSize = true;
            this.radioButtonStop_Stop.Checked = true;
            this.radioButtonStop_Stop.Location = new System.Drawing.Point(6, 47);
            this.radioButtonStop_Stop.Name = "radioButtonStop_Stop";
            this.radioButtonStop_Stop.Size = new System.Drawing.Size(101, 19);
            this.radioButtonStop_Stop.TabIndex = 22;
            this.radioButtonStop_Stop.TabStop = true;
            this.radioButtonStop_Stop.Text = "close program";
            this.radioButtonStop_Stop.UseVisualStyleBackColor = true;
            // 
            // radioButtonStop_Nothing
            // 
            this.radioButtonStop_Nothing.AutoSize = true;
            this.radioButtonStop_Nothing.Location = new System.Drawing.Point(6, 72);
            this.radioButtonStop_Nothing.Name = "radioButtonStop_Nothing";
            this.radioButtonStop_Nothing.Size = new System.Drawing.Size(84, 19);
            this.radioButtonStop_Nothing.TabIndex = 21;
            this.radioButtonStop_Nothing.TabStop = true;
            this.radioButtonStop_Nothing.Text = "do nothing";
            this.radioButtonStop_Nothing.UseVisualStyleBackColor = true;
            // 
            // radioButtonStop_Start
            // 
            this.radioButtonStop_Start.AutoSize = true;
            this.radioButtonStop_Start.Location = new System.Drawing.Point(6, 22);
            this.radioButtonStop_Start.Name = "radioButtonStop_Start";
            this.radioButtonStop_Start.Size = new System.Drawing.Size(97, 19);
            this.radioButtonStop_Start.TabIndex = 19;
            this.radioButtonStop_Start.TabStop = true;
            this.radioButtonStop_Start.Text = "start program";
            this.radioButtonStop_Start.UseVisualStyleBackColor = true;
            // 
            // groupBoxStart
            // 
            this.groupBoxStart.Controls.Add(this.radioButtonStart_Nothing);
            this.groupBoxStart.Controls.Add(this.radioButtonStart_Start);
            this.groupBoxStart.Controls.Add(this.radioButtonStart_Stop);
            this.groupBoxStart.Location = new System.Drawing.Point(12, 75);
            this.groupBoxStart.Name = "groupBoxStart";
            this.groupBoxStart.Size = new System.Drawing.Size(245, 100);
            this.groupBoxStart.TabIndex = 29;
            this.groupBoxStart.TabStop = false;
            this.groupBoxStart.Text = "when VR runtime starts...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonStop_Start);
            this.groupBox1.Controls.Add(this.radioButtonStop_Nothing);
            this.groupBox1.Controls.Add(this.radioButtonStop_Stop);
            this.groupBox1.Location = new System.Drawing.Point(263, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 100);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "when VR runtime stops...";
            // 
            // checkBoxForceClose
            // 
            this.checkBoxForceClose.AutoSize = true;
            this.checkBoxForceClose.Location = new System.Drawing.Point(13, 159);
            this.checkBoxForceClose.Name = "checkBoxForceClose";
            this.checkBoxForceClose.Size = new System.Drawing.Size(270, 19);
            this.checkBoxForceClose.TabIndex = 28;
            this.checkBoxForceClose.Text = "kill process instead of soft-closing its windows";
            this.checkBoxForceClose.UseVisualStyleBackColor = true;
            // 
            // checkBoxCloseByProcessName
            // 
            this.checkBoxCloseByProcessName.AutoSize = true;
            this.checkBoxCloseByProcessName.Location = new System.Drawing.Point(14, 92);
            this.checkBoxCloseByProcessName.Name = "checkBoxCloseByProcessName";
            this.checkBoxCloseByProcessName.Size = new System.Drawing.Size(407, 19);
            this.checkBoxCloseByProcessName.TabIndex = 25;
            this.checkBoxCloseByProcessName.Text = "close program by ProcessName instead of Process Path (recommended)";
            this.checkBoxCloseByProcessName.UseVisualStyleBackColor = true;
            this.checkBoxCloseByProcessName.CheckedChanged += new System.EventHandler(this.CheckBoxCloseByProcessName_CheckedChanged);
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.Enabled = false;
            this.textBoxProcessName.Location = new System.Drawing.Point(13, 117);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(346, 23);
            this.textBoxProcessName.TabIndex = 23;
            // 
            // textBoxStartArguments
            // 
            this.textBoxStartArguments.Location = new System.Drawing.Point(13, 57);
            this.textBoxStartArguments.Name = "textBoxStartArguments";
            this.textBoxStartArguments.Size = new System.Drawing.Size(465, 23);
            this.textBoxStartArguments.TabIndex = 8;
            // 
            // buttonChooseProcessName
            // 
            this.buttonChooseProcessName.Enabled = false;
            this.buttonChooseProcessName.Location = new System.Drawing.Point(365, 117);
            this.buttonChooseProcessName.Name = "buttonChooseProcessName";
            this.buttonChooseProcessName.Size = new System.Drawing.Size(113, 23);
            this.buttonChooseProcessName.TabIndex = 26;
            this.buttonChooseProcessName.Text = "choose process";
            this.buttonChooseProcessName.UseVisualStyleBackColor = true;
            this.buttonChooseProcessName.Click += new System.EventHandler(this.ButtonChooseProcessName_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.labelStartArguments);
            this.groupBoxOptions.Controls.Add(this.textBoxStartArguments);
            this.groupBoxOptions.Controls.Add(this.textBoxProcessName);
            this.groupBoxOptions.Controls.Add(this.checkBoxCloseByProcessName);
            this.groupBoxOptions.Controls.Add(this.checkBoxForceClose);
            this.groupBoxOptions.Controls.Add(this.buttonChooseProcessName);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 244);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(484, 189);
            this.groupBoxOptions.TabIndex = 32;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // labelStartArguments
            // 
            this.labelStartArguments.AutoSize = true;
            this.labelStartArguments.Location = new System.Drawing.Point(13, 35);
            this.labelStartArguments.Name = "labelStartArguments";
            this.labelStartArguments.Size = new System.Drawing.Size(223, 15);
            this.labelStartArguments.TabIndex = 29;
            this.labelStartArguments.Text = "(optional) start program with arguments:";
            // 
            // labelUUID
            // 
            this.labelUUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUUID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelUUID.Location = new System.Drawing.Point(12, 441);
            this.labelUUID.Name = "labelUUID";
            this.labelUUID.Size = new System.Drawing.Size(322, 23);
            this.labelUUID.TabIndex = 33;
            this.labelUUID.Text = "UUID: New Task";
            this.labelUUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxProgramPath);
            this.groupBox2.Controls.Add(this.buttonChooseProgram);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 57);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program Path";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxEnabled);
            this.groupBox3.Controls.Add(this.textBoxName);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 57);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Task Name";
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Checked = true;
            this.checkBoxEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnabled.Location = new System.Drawing.Point(399, 24);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(68, 19);
            this.checkBoxEnabled.TabIndex = 36;
            this.checkBoxEnabled.Text = "Enabled";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(371, 23);
            this.textBoxName.TabIndex = 6;
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 472);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelUUID);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxStart);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTaskForm_FormClosing);
            this.groupBoxStart.ResumeLayout(false);
            this.groupBoxStart.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}