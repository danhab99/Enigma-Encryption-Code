namespace Enigma_Encryptor
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tv_Files = new System.Windows.Forms.TreeView();
            this.wb_Display = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txb_Plugboards_Cypher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Plugboards_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Plugboards_Delete = new System.Windows.Forms.Button();
            this.btn_Plugboards_Add = new System.Windows.Forms.Button();
            this.btn_Plugboards_MoveDown = new System.Windows.Forms.Button();
            this.btn_Plugboards_MoveUp = new System.Windows.Forms.Button();
            this.lsb_Plugboards = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.num_Rotors_IP = new System.Windows.Forms.NumericUpDown();
            this.txb_Rotors_Cypher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Rotors_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Rotors_Delete = new System.Windows.Forms.Button();
            this.btn_Rotors_Add = new System.Windows.Forms.Button();
            this.btn_Rotors_MoveDown = new System.Windows.Forms.Button();
            this.btn_Rotors_MoveUp = new System.Windows.Forms.Button();
            this.lsb_Rotors = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cxb_LockThread = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_RootFolder = new System.Windows.Forms.TextBox();
            this.btn_FileDialog = new System.Windows.Forms.Button();
            this.btn_Work = new System.Windows.Forms.Button();
            this.prb_Progress = new System.Windows.Forms.ProgressBar();
            this.btn_FolderDialog = new System.Windows.Forms.Button();
            this.FBD_FindFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.OFD_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SFD_SaveConfig = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Plugboards_Update = new System.Windows.Forms.Button();
            this.btn_Rotors_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Rotors_IP)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv_Files);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wb_Display);
            this.splitContainer1.Size = new System.Drawing.Size(461, 190);
            this.splitContainer1.SplitterDistance = 126;
            this.splitContainer1.TabIndex = 0;
            // 
            // tv_Files
            // 
            this.tv_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_Files.Location = new System.Drawing.Point(0, 0);
            this.tv_Files.Name = "tv_Files";
            this.tv_Files.Size = new System.Drawing.Size(126, 190);
            this.tv_Files.TabIndex = 0;
            this.tv_Files.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Files_NodeMouseClick);
            // 
            // wb_Display
            // 
            this.wb_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_Display.Location = new System.Drawing.Point(0, 0);
            this.wb_Display.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_Display.Name = "wb_Display";
            this.wb_Display.ScriptErrorsSuppressed = true;
            this.wb_Display.Size = new System.Drawing.Size(331, 190);
            this.wb_Display.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 256);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 199);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Plugboards_Update);
            this.tabPage1.Controls.Add(this.txb_Plugboards_Cypher);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txb_Plugboards_Name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Plugboards_Delete);
            this.tabPage1.Controls.Add(this.btn_Plugboards_Add);
            this.tabPage1.Controls.Add(this.btn_Plugboards_MoveDown);
            this.tabPage1.Controls.Add(this.btn_Plugboards_MoveUp);
            this.tabPage1.Controls.Add(this.lsb_Plugboards);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(453, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plugboards";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txb_Plugboards_Cypher
            // 
            this.txb_Plugboards_Cypher.Location = new System.Drawing.Point(181, 82);
            this.txb_Plugboards_Cypher.Name = "txb_Plugboards_Cypher";
            this.txb_Plugboards_Cypher.Size = new System.Drawing.Size(258, 20);
            this.txb_Plugboards_Cypher.TabIndex = 13;
            this.txb_Plugboards_Cypher.DoubleClick += new System.EventHandler(this.FillTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cypher:";
            // 
            // txb_Plugboards_Name
            // 
            this.txb_Plugboards_Name.Location = new System.Drawing.Point(215, 39);
            this.txb_Plugboards_Name.Name = "txb_Plugboards_Name";
            this.txb_Plugboards_Name.Size = new System.Drawing.Size(100, 20);
            this.txb_Plugboards_Name.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Label (Optional):";
            // 
            // btn_Plugboards_Delete
            // 
            this.btn_Plugboards_Delete.Location = new System.Drawing.Point(240, 143);
            this.btn_Plugboards_Delete.Name = "btn_Plugboards_Delete";
            this.btn_Plugboards_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Plugboards_Delete.TabIndex = 9;
            this.btn_Plugboards_Delete.Text = "&Delete";
            this.btn_Plugboards_Delete.UseVisualStyleBackColor = true;
            this.btn_Plugboards_Delete.Click += new System.EventHandler(this.btn_Plugboards_Delete_Click);
            // 
            // btn_Plugboards_Add
            // 
            this.btn_Plugboards_Add.Location = new System.Drawing.Point(159, 143);
            this.btn_Plugboards_Add.Name = "btn_Plugboards_Add";
            this.btn_Plugboards_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Plugboards_Add.TabIndex = 8;
            this.btn_Plugboards_Add.Text = "&Add";
            this.btn_Plugboards_Add.UseVisualStyleBackColor = true;
            this.btn_Plugboards_Add.Click += new System.EventHandler(this.btn_Plugboards_Add_Click);
            // 
            // btn_Plugboards_MoveDown
            // 
            this.btn_Plugboards_MoveDown.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plugboards_MoveDown.Location = new System.Drawing.Point(132, 143);
            this.btn_Plugboards_MoveDown.Name = "btn_Plugboards_MoveDown";
            this.btn_Plugboards_MoveDown.Size = new System.Drawing.Size(23, 23);
            this.btn_Plugboards_MoveDown.TabIndex = 7;
            this.btn_Plugboards_MoveDown.Text = "↓";
            this.btn_Plugboards_MoveDown.UseVisualStyleBackColor = true;
            this.btn_Plugboards_MoveDown.Click += new System.EventHandler(this.btn_Plugboards_MoveDown_Click);
            // 
            // btn_Plugboards_MoveUp
            // 
            this.btn_Plugboards_MoveUp.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plugboards_MoveUp.Location = new System.Drawing.Point(132, 6);
            this.btn_Plugboards_MoveUp.Name = "btn_Plugboards_MoveUp";
            this.btn_Plugboards_MoveUp.Size = new System.Drawing.Size(23, 23);
            this.btn_Plugboards_MoveUp.TabIndex = 6;
            this.btn_Plugboards_MoveUp.Text = "↑";
            this.btn_Plugboards_MoveUp.UseVisualStyleBackColor = true;
            this.btn_Plugboards_MoveUp.Click += new System.EventHandler(this.btn_Plugboards_MoveUp_Click);
            // 
            // lsb_Plugboards
            // 
            this.lsb_Plugboards.FormattingEnabled = true;
            this.lsb_Plugboards.Location = new System.Drawing.Point(6, 6);
            this.lsb_Plugboards.Name = "lsb_Plugboards";
            this.lsb_Plugboards.Size = new System.Drawing.Size(120, 160);
            this.lsb_Plugboards.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Rotors_Update);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.num_Rotors_IP);
            this.tabPage2.Controls.Add(this.txb_Rotors_Cypher);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txb_Rotors_Name);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_Rotors_Delete);
            this.tabPage2.Controls.Add(this.btn_Rotors_Add);
            this.tabPage2.Controls.Add(this.btn_Rotors_MoveDown);
            this.tabPage2.Controls.Add(this.btn_Rotors_MoveUp);
            this.tabPage2.Controls.Add(this.lsb_Rotors);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(453, 173);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rotors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Initial Position:";
            // 
            // num_Rotors_IP
            // 
            this.num_Rotors_IP.Location = new System.Drawing.Point(215, 108);
            this.num_Rotors_IP.Name = "num_Rotors_IP";
            this.num_Rotors_IP.Size = new System.Drawing.Size(120, 20);
            this.num_Rotors_IP.TabIndex = 23;
            // 
            // txb_Rotors_Cypher
            // 
            this.txb_Rotors_Cypher.Location = new System.Drawing.Point(181, 82);
            this.txb_Rotors_Cypher.Name = "txb_Rotors_Cypher";
            this.txb_Rotors_Cypher.Size = new System.Drawing.Size(258, 20);
            this.txb_Rotors_Cypher.TabIndex = 22;
            this.txb_Rotors_Cypher.DoubleClick += new System.EventHandler(this.FillTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cypher:";
            // 
            // txb_Rotors_Name
            // 
            this.txb_Rotors_Name.Location = new System.Drawing.Point(215, 39);
            this.txb_Rotors_Name.Name = "txb_Rotors_Name";
            this.txb_Rotors_Name.Size = new System.Drawing.Size(100, 20);
            this.txb_Rotors_Name.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Label (Optional):";
            // 
            // btn_Rotors_Delete
            // 
            this.btn_Rotors_Delete.Location = new System.Drawing.Point(240, 143);
            this.btn_Rotors_Delete.Name = "btn_Rotors_Delete";
            this.btn_Rotors_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Rotors_Delete.TabIndex = 18;
            this.btn_Rotors_Delete.Text = "&Delete";
            this.btn_Rotors_Delete.UseVisualStyleBackColor = true;
            this.btn_Rotors_Delete.Click += new System.EventHandler(this.btn_Rotors_Delete_Click);
            // 
            // btn_Rotors_Add
            // 
            this.btn_Rotors_Add.Location = new System.Drawing.Point(159, 143);
            this.btn_Rotors_Add.Name = "btn_Rotors_Add";
            this.btn_Rotors_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Rotors_Add.TabIndex = 17;
            this.btn_Rotors_Add.Text = "&Add";
            this.btn_Rotors_Add.UseVisualStyleBackColor = true;
            this.btn_Rotors_Add.Click += new System.EventHandler(this.btn_Rotors_Add_Click);
            // 
            // btn_Rotors_MoveDown
            // 
            this.btn_Rotors_MoveDown.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rotors_MoveDown.Location = new System.Drawing.Point(132, 143);
            this.btn_Rotors_MoveDown.Name = "btn_Rotors_MoveDown";
            this.btn_Rotors_MoveDown.Size = new System.Drawing.Size(23, 23);
            this.btn_Rotors_MoveDown.TabIndex = 16;
            this.btn_Rotors_MoveDown.Text = "↓";
            this.btn_Rotors_MoveDown.UseVisualStyleBackColor = true;
            this.btn_Rotors_MoveDown.Click += new System.EventHandler(this.btn_Rotors_MoveDown_Click);
            // 
            // btn_Rotors_MoveUp
            // 
            this.btn_Rotors_MoveUp.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rotors_MoveUp.Location = new System.Drawing.Point(132, 6);
            this.btn_Rotors_MoveUp.Name = "btn_Rotors_MoveUp";
            this.btn_Rotors_MoveUp.Size = new System.Drawing.Size(23, 23);
            this.btn_Rotors_MoveUp.TabIndex = 15;
            this.btn_Rotors_MoveUp.Text = "↑";
            this.btn_Rotors_MoveUp.UseVisualStyleBackColor = true;
            this.btn_Rotors_MoveUp.Click += new System.EventHandler(this.btn_Rotors_MoveUp_Click);
            // 
            // lsb_Rotors
            // 
            this.lsb_Rotors.FormattingEnabled = true;
            this.lsb_Rotors.Location = new System.Drawing.Point(6, 6);
            this.lsb_Rotors.Name = "lsb_Rotors";
            this.lsb_Rotors.Size = new System.Drawing.Size(120, 160);
            this.lsb_Rotors.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cxb_LockThread);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(453, 194);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cxb_LockThread
            // 
            this.cxb_LockThread.AutoSize = true;
            this.cxb_LockThread.Location = new System.Drawing.Point(9, 91);
            this.cxb_LockThread.Name = "cxb_LockThread";
            this.cxb_LockThread.Size = new System.Drawing.Size(87, 17);
            this.cxb_LockThread.TabIndex = 2;
            this.cxb_LockThread.Text = "Lock Thread";
            this.cxb_LockThread.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Import";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txb_RootFolder
            // 
            this.txb_RootFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_RootFolder.Location = new System.Drawing.Point(12, 12);
            this.txb_RootFolder.Name = "txb_RootFolder";
            this.txb_RootFolder.Size = new System.Drawing.Size(381, 20);
            this.txb_RootFolder.TabIndex = 3;
            this.txb_RootFolder.TextChanged += new System.EventHandler(this.txb_RootFolder_TextChanged);
            // 
            // btn_FileDialog
            // 
            this.btn_FileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FileDialog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FileDialog.Location = new System.Drawing.Point(435, 12);
            this.btn_FileDialog.Name = "btn_FileDialog";
            this.btn_FileDialog.Size = new System.Drawing.Size(38, 20);
            this.btn_FileDialog.TabIndex = 4;
            this.btn_FileDialog.Text = "...";
            this.btn_FileDialog.UseVisualStyleBackColor = true;
            this.btn_FileDialog.Click += new System.EventHandler(this.btn_FileDialog_Click);
            // 
            // btn_Work
            // 
            this.btn_Work.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Work.Location = new System.Drawing.Point(12, 452);
            this.btn_Work.Name = "btn_Work";
            this.btn_Work.Size = new System.Drawing.Size(461, 23);
            this.btn_Work.TabIndex = 5;
            this.btn_Work.Text = "Work!";
            this.btn_Work.UseVisualStyleBackColor = true;
            // 
            // prb_Progress
            // 
            this.prb_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prb_Progress.Location = new System.Drawing.Point(8, 481);
            this.prb_Progress.Name = "prb_Progress";
            this.prb_Progress.Size = new System.Drawing.Size(461, 23);
            this.prb_Progress.TabIndex = 6;
            // 
            // btn_FolderDialog
            // 
            this.btn_FolderDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FolderDialog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FolderDialog.Location = new System.Drawing.Point(399, 12);
            this.btn_FolderDialog.Name = "btn_FolderDialog";
            this.btn_FolderDialog.Size = new System.Drawing.Size(30, 20);
            this.btn_FolderDialog.TabIndex = 4;
            this.btn_FolderDialog.Text = "//";
            this.btn_FolderDialog.UseVisualStyleBackColor = true;
            this.btn_FolderDialog.Click += new System.EventHandler(this.btn_FolderDialog_Click);
            // 
            // FBD_FindFolder
            // 
            this.FBD_FindFolder.ShowNewFolderButton = false;
            // 
            // OFD_OpenFile
            // 
            this.OFD_OpenFile.Filter = "Any|*.*";
            this.OFD_OpenFile.Multiselect = true;
            this.OFD_OpenFile.Title = "Open A File";
            // 
            // btn_Plugboards_Update
            // 
            this.btn_Plugboards_Update.Enabled = false;
            this.btn_Plugboards_Update.Location = new System.Drawing.Point(321, 143);
            this.btn_Plugboards_Update.Name = "btn_Plugboards_Update";
            this.btn_Plugboards_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Plugboards_Update.TabIndex = 14;
            this.btn_Plugboards_Update.Text = "Update";
            this.btn_Plugboards_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Rotors_Update
            // 
            this.btn_Rotors_Update.Enabled = false;
            this.btn_Rotors_Update.Location = new System.Drawing.Point(321, 143);
            this.btn_Rotors_Update.Name = "btn_Rotors_Update";
            this.btn_Rotors_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Rotors_Update.TabIndex = 25;
            this.btn_Rotors_Update.Text = "Update";
            this.btn_Rotors_Update.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 516);
            this.Controls.Add(this.prb_Progress);
            this.Controls.Add(this.btn_Work);
            this.Controls.Add(this.btn_FolderDialog);
            this.Controls.Add(this.btn_FileDialog);
            this.Controls.Add(this.txb_RootFolder);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Enigma Encryptor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Rotors_IP)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tv_Files;
        private System.Windows.Forms.WebBrowser wb_Display;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Plugboards_Delete;
        private System.Windows.Forms.Button btn_Plugboards_Add;
        private System.Windows.Forms.Button btn_Plugboards_MoveDown;
        private System.Windows.Forms.Button btn_Plugboards_MoveUp;
        private System.Windows.Forms.ListBox lsb_Plugboards;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_RootFolder;
        private System.Windows.Forms.Button btn_FileDialog;
        private System.Windows.Forms.TextBox txb_Plugboards_Cypher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Plugboards_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_Rotors_IP;
        private System.Windows.Forms.TextBox txb_Rotors_Cypher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Rotors_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Rotors_Delete;
        private System.Windows.Forms.Button btn_Rotors_Add;
        private System.Windows.Forms.Button btn_Rotors_MoveDown;
        private System.Windows.Forms.Button btn_Rotors_MoveUp;
        private System.Windows.Forms.ListBox lsb_Rotors;
        private System.Windows.Forms.Button btn_Work;
        private System.Windows.Forms.ProgressBar prb_Progress;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_FolderDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cxb_LockThread;
        private System.Windows.Forms.FolderBrowserDialog FBD_FindFolder;
        private System.Windows.Forms.OpenFileDialog OFD_OpenFile;
        private System.Windows.Forms.SaveFileDialog SFD_SaveConfig;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Plugboards_Update;
        private System.Windows.Forms.Button btn_Rotors_Update;
    }
}

