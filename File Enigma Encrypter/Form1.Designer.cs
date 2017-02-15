namespace File_Enigma_Encrypter
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
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_Position_Rotor1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Codex_Rotor1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_Position_Rotor2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Codex_Rotor2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.num_Position_Rotor3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Codex_Rotor3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_Plugboard = new System.Windows.Forms.TextBox();
            this.btn_Position = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_url = new System.Windows.Forms.TextBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.prb_FileProgress = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Position_Rotor1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Position_Rotor2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Position_Rotor3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "Vault|*vault";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_Position_Rotor1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_Codex_Rotor1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotor 1";
            // 
            // num_Position_Rotor1
            // 
            this.num_Position_Rotor1.Location = new System.Drawing.Point(115, 45);
            this.num_Position_Rotor1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Position_Rotor1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Position_Rotor1.Name = "num_Position_Rotor1";
            this.num_Position_Rotor1.Size = new System.Drawing.Size(65, 20);
            this.num_Position_Rotor1.TabIndex = 3;
            this.num_Position_Rotor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Position_Rotor1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Position_Rotor1.DoubleClick += new System.EventHandler(this.IRandomFill);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codex";
            // 
            // txb_Codex_Rotor1
            // 
            this.txb_Codex_Rotor1.Location = new System.Drawing.Point(54, 19);
            this.txb_Codex_Rotor1.MaxLength = 2147483647;
            this.txb_Codex_Rotor1.Name = "txb_Codex_Rotor1";
            this.txb_Codex_Rotor1.Size = new System.Drawing.Size(256, 20);
            this.txb_Codex_Rotor1.TabIndex = 1;
            this.txb_Codex_Rotor1.DoubleClick += new System.EventHandler(this.SRandomFill);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_Position_Rotor2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txb_Codex_Rotor2);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotor 2";
            // 
            // num_Position_Rotor2
            // 
            this.num_Position_Rotor2.Location = new System.Drawing.Point(115, 45);
            this.num_Position_Rotor2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Position_Rotor2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Position_Rotor2.Name = "num_Position_Rotor2";
            this.num_Position_Rotor2.Size = new System.Drawing.Size(65, 20);
            this.num_Position_Rotor2.TabIndex = 3;
            this.num_Position_Rotor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Position_Rotor2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Position_Rotor2.DoubleClick += new System.EventHandler(this.IRandomFill);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codex";
            // 
            // txb_Codex_Rotor2
            // 
            this.txb_Codex_Rotor2.Location = new System.Drawing.Point(54, 19);
            this.txb_Codex_Rotor2.MaxLength = 2147483647;
            this.txb_Codex_Rotor2.Name = "txb_Codex_Rotor2";
            this.txb_Codex_Rotor2.Size = new System.Drawing.Size(256, 20);
            this.txb_Codex_Rotor2.TabIndex = 1;
            this.txb_Codex_Rotor2.DoubleClick += new System.EventHandler(this.SRandomFill);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.num_Position_Rotor3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txb_Codex_Rotor3);
            this.groupBox3.Location = new System.Drawing.Point(12, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 76);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rotor 3";
            // 
            // num_Position_Rotor3
            // 
            this.num_Position_Rotor3.Location = new System.Drawing.Point(115, 45);
            this.num_Position_Rotor3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Position_Rotor3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Position_Rotor3.Name = "num_Position_Rotor3";
            this.num_Position_Rotor3.Size = new System.Drawing.Size(65, 20);
            this.num_Position_Rotor3.TabIndex = 3;
            this.num_Position_Rotor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Position_Rotor3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Position_Rotor3.DoubleClick += new System.EventHandler(this.IRandomFill);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codex";
            // 
            // txb_Codex_Rotor3
            // 
            this.txb_Codex_Rotor3.Location = new System.Drawing.Point(54, 19);
            this.txb_Codex_Rotor3.MaxLength = 2147483647;
            this.txb_Codex_Rotor3.Name = "txb_Codex_Rotor3";
            this.txb_Codex_Rotor3.Size = new System.Drawing.Size(256, 20);
            this.txb_Codex_Rotor3.TabIndex = 1;
            this.txb_Codex_Rotor3.DoubleClick += new System.EventHandler(this.SRandomFill);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txb_Plugboard);
            this.groupBox4.Location = new System.Drawing.Point(12, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 49);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plugboard";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Codex";
            // 
            // txb_Plugboard
            // 
            this.txb_Plugboard.Location = new System.Drawing.Point(54, 19);
            this.txb_Plugboard.MaxLength = 2147483647;
            this.txb_Plugboard.Name = "txb_Plugboard";
            this.txb_Plugboard.Size = new System.Drawing.Size(256, 20);
            this.txb_Plugboard.TabIndex = 1;
            this.txb_Plugboard.DoubleClick += new System.EventHandler(this.SRandomFill);
            // 
            // btn_Position
            // 
            this.btn_Position.Location = new System.Drawing.Point(12, 339);
            this.btn_Position.Name = "btn_Position";
            this.btn_Position.Size = new System.Drawing.Size(316, 23);
            this.btn_Position.TabIndex = 6;
            this.btn_Position.Text = "Opperate";
            this.btn_Position.UseVisualStyleBackColor = true;
            this.btn_Position.Click += new System.EventHandler(this.btn_Position_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_url
            // 
            this.txb_url.Location = new System.Drawing.Point(12, 12);
            this.txb_url.Name = "txb_url";
            this.txb_url.Size = new System.Drawing.Size(286, 20);
            this.txb_url.TabIndex = 0;
            // 
            // openDialog
            // 
            this.openDialog.Filter = "Any|*.*";
            // 
            // prb_FileProgress
            // 
            this.prb_FileProgress.Location = new System.Drawing.Point(12, 370);
            this.prb_FileProgress.Name = "prb_FileProgress";
            this.prb_FileProgress.Size = new System.Drawing.Size(316, 23);
            this.prb_FileProgress.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 405);
            this.Controls.Add(this.prb_FileProgress);
            this.Controls.Add(this.txb_url);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Position);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "File Enigma Encrypter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Position_Rotor1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Position_Rotor2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Position_Rotor3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_Position_Rotor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Codex_Rotor1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_Position_Rotor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Codex_Rotor2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown num_Position_Rotor3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Codex_Rotor3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_Plugboard;
        private System.Windows.Forms.Button btn_Position;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_url;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.ProgressBar prb_FileProgress;
    }
}

