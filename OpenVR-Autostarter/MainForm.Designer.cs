namespace OpenVR_Autostarter
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnHeaderEnabled = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStartAction = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStopAction = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPath = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStartArguments = new System.Windows.Forms.ColumnHeader();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.timerOpenVRPolling = new System.Windows.Forms.Timer(this.components);
            this.buttonTestStart = new System.Windows.Forms.Button();
            this.buttonTestStop = new System.Windows.Forms.Button();
            this.contextMenuStripTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewTasks
            // 
            this.listViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEnabled,
            this.columnHeaderName,
            this.columnHeaderStartAction,
            this.columnHeaderStopAction,
            this.columnHeaderPath,
            this.columnHeaderStartArguments});
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(12, 12);
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(655, 285);
            this.listViewTasks.TabIndex = 0;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewTasks_MouseDoubleClick);
            // 
            // columnHeaderEnabled
            // 
            this.columnHeaderEnabled.Text = "Enabled";
            this.columnHeaderEnabled.Width = 55;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 120;
            // 
            // columnHeaderStartAction
            // 
            this.columnHeaderStartAction.Text = "VR-Start-Action";
            this.columnHeaderStartAction.Width = 100;
            // 
            // columnHeaderStopAction
            // 
            this.columnHeaderStopAction.Text = "VR-Stop-Action";
            this.columnHeaderStopAction.Width = 100;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Program path";
            this.columnHeaderPath.Width = 170;
            // 
            // columnHeaderStartArguments
            // 
            this.columnHeaderStartArguments.Text = "Start arguments";
            this.columnHeaderStartArguments.Width = 100;
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelGitHub.Location = new System.Drawing.Point(12, 317);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(118, 15);
            this.linkLabelGitHub.TabIndex = 1;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "View on GitHub";
            this.linkLabelGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.Location = new System.Drawing.Point(580, 317);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(192, 15);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "OpenVR-Autostarter v0.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(673, 245);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(99, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(673, 274);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNew.Location = new System.Drawing.Point(673, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(99, 23);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "OpenVR-Autostarter";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripTray.Name = "contextMenuStrip1";
            this.contextMenuStripTray.Size = new System.Drawing.Size(149, 48);
            // 
            // showSettingsToolStripMenuItem
            // 
            this.showSettingsToolStripMenuItem.Name = "showSettingsToolStripMenuItem";
            this.showSettingsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.showSettingsToolStripMenuItem.Text = "Show Settings";
            this.showSettingsToolStripMenuItem.Click += new System.EventHandler(this.ShowSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveUp.Location = new System.Drawing.Point(673, 167);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(99, 23);
            this.buttonMoveUp.TabIndex = 8;
            this.buttonMoveUp.Text = "Move up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveDown.Location = new System.Drawing.Point(673, 196);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(99, 23);
            this.buttonMoveDown.TabIndex = 9;
            this.buttonMoveDown.Text = "Move down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // timerOpenVRPolling
            // 
            this.timerOpenVRPolling.Enabled = true;
            this.timerOpenVRPolling.Tick += new System.EventHandler(this.TimerOpenVRPolling_Tick);
            // 
            // buttonTestStart
            // 
            this.buttonTestStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonTestStart.Location = new System.Drawing.Point(136, 313);
            this.buttonTestStart.Name = "buttonTestStart";
            this.buttonTestStart.Size = new System.Drawing.Size(169, 23);
            this.buttonTestStart.TabIndex = 10;
            this.buttonTestStart.Text = "Simulate VR Startup";
            this.buttonTestStart.UseVisualStyleBackColor = true;
            this.buttonTestStart.Click += new System.EventHandler(this.buttonTestStart_Click);
            // 
            // buttonTestStop
            // 
            this.buttonTestStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonTestStop.Location = new System.Drawing.Point(311, 313);
            this.buttonTestStop.Name = "buttonTestStop";
            this.buttonTestStop.Size = new System.Drawing.Size(169, 23);
            this.buttonTestStop.TabIndex = 11;
            this.buttonTestStop.Text = "Simulate VR Shutdown";
            this.buttonTestStop.UseVisualStyleBackColor = true;
            this.buttonTestStop.Click += new System.EventHandler(this.buttonTestStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 341);
            this.Controls.Add(this.buttonTestStop);
            this.Controls.Add(this.buttonTestStart);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.listViewTasks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 380);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenVR-Autostarter Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStripTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ColumnHeader columnHeaderStartAction;
        private System.Windows.Forms.ColumnHeader columnHeaderEnabled;
        private System.Windows.Forms.ColumnHeader columnHeaderStopAction;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderStartArguments;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Timer timerOpenVRPolling;
        private System.Windows.Forms.ToolStripMenuItem showSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonTestStart;
        private System.Windows.Forms.Button buttonTestStop;
    }
}