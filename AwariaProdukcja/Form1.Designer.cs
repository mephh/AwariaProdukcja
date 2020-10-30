namespace AwariaProdukcja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTester = new System.Windows.Forms.Label();
            this.buttonRegisterIssue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonIntervention = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStartInterv = new System.Windows.Forms.Label();
            this.tboxDescr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCloseInterv = new System.Windows.Forms.Button();
            this.cboxProblemType = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelTimers = new System.Windows.Forms.Panel();
            this.panelKPI = new System.Windows.Forms.Panel();
            this.panelUser.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTimers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTester
            // 
            this.lblTester.AutoSize = true;
            this.lblTester.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTester.Location = new System.Drawing.Point(5, 9);
            this.lblTester.Name = "lblTester";
            this.lblTester.Size = new System.Drawing.Size(78, 13);
            this.lblTester.TabIndex = 1;
            this.lblTester.Text = "Nazwa testera:";
            // 
            // buttonRegisterIssue
            // 
            this.buttonRegisterIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonRegisterIssue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonRegisterIssue.Location = new System.Drawing.Point(11, 6);
            this.buttonRegisterIssue.Name = "buttonRegisterIssue";
            this.buttonRegisterIssue.Size = new System.Drawing.Size(192, 83);
            this.buttonRegisterIssue.TabIndex = 2;
            this.buttonRegisterIssue.Text = "ZGŁOŚ AWARIĘ";
            this.buttonRegisterIssue.UseVisualStyleBackColor = false;
            this.buttonRegisterIssue.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rodzaj problemu";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(11, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 83);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "ANULUJ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonIntervention
            // 
            this.buttonIntervention.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonIntervention.Location = new System.Drawing.Point(110, 6);
            this.buttonIntervention.Name = "buttonIntervention";
            this.buttonIntervention.Size = new System.Drawing.Size(93, 83);
            this.buttonIntervention.TabIndex = 5;
            this.buttonIntervention.Text = "ROZPOCZNIJ INTERWENCJE";
            this.buttonIntervention.UseVisualStyleBackColor = true;
            this.buttonIntervention.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Czas rozpoczecia awarii:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStartTime.Location = new System.Drawing.Point(12, 27);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(35, 13);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "label4";
            this.lblStartTime.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(10, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Czas rozpoczecia interwencji:";
            // 
            // lblStartInterv
            // 
            this.lblStartInterv.AutoSize = true;
            this.lblStartInterv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStartInterv.Location = new System.Drawing.Point(12, 87);
            this.lblStartInterv.Name = "lblStartInterv";
            this.lblStartInterv.Size = new System.Drawing.Size(35, 13);
            this.lblStartInterv.TabIndex = 9;
            this.lblStartInterv.Text = "label6";
            this.lblStartInterv.Visible = false;
            // 
            // tboxDescr
            // 
            this.tboxDescr.Location = new System.Drawing.Point(11, 164);
            this.tboxDescr.Multiline = true;
            this.tboxDescr.Name = "tboxDescr";
            this.tboxDescr.Size = new System.Drawing.Size(189, 103);
            this.tboxDescr.TabIndex = 10;
            this.tboxDescr.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(12, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Opis problemu";
            // 
            // buttonCloseInterv
            // 
            this.buttonCloseInterv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonCloseInterv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCloseInterv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCloseInterv.Location = new System.Drawing.Point(11, 5);
            this.buttonCloseInterv.Name = "buttonCloseInterv";
            this.buttonCloseInterv.Size = new System.Drawing.Size(192, 83);
            this.buttonCloseInterv.TabIndex = 12;
            this.buttonCloseInterv.Text = "ZAKONCZ AWARIE";
            this.buttonCloseInterv.UseVisualStyleBackColor = false;
            this.buttonCloseInterv.Visible = false;
            this.buttonCloseInterv.Click += new System.EventHandler(this.button4_Click);
            // 
            // cboxProblemType
            // 
            this.cboxProblemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProblemType.FormattingEnabled = true;
            this.cboxProblemType.Items.AddRange(new object[] {
            "SOFTWARE",
            "ZASILACZE, MIERNIKI ITP.",
            "POLACZENIE Z SIECIA",
            "MECHANIKA",
            "LOGOWANIE DANYCH",
            "BLAD OPERATORA",
            "BRAK PROBLEMU",
            "USZKODZENIE ELEKTRYCZNE"});
            this.cboxProblemType.Location = new System.Drawing.Point(11, 109);
            this.cboxProblemType.Name = "cboxProblemType";
            this.cboxProblemType.Size = new System.Drawing.Size(189, 21);
            this.cboxProblemType.TabIndex = 13;
            this.cboxProblemType.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUser.Location = new System.Drawing.Point(5, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(113, 13);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "Zalogowany operator: ";
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.btnSettings);
            this.panelUser.Controls.Add(this.label1);
            this.panelUser.Controls.Add(this.lblTester);
            this.panelUser.Controls.Add(this.lblUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(228, 40);
            this.panelUser.TabIndex = 16;
            this.panelUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUser_MouseDown);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(215, 27);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(13, 13);
            this.btnSettings.TabIndex = 16;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(215, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.cboxProblemType);
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Controls.Add(this.label7);
            this.panelButtons.Controls.Add(this.buttonIntervention);
            this.panelButtons.Controls.Add(this.tboxDescr);
            this.panelButtons.Controls.Add(this.label2);
            this.panelButtons.Controls.Add(this.buttonRegisterIssue);
            this.panelButtons.Controls.Add(this.buttonCloseInterv);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 40);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(228, 278);
            this.panelButtons.TabIndex = 17;
            // 
            // panelTimers
            // 
            this.panelTimers.Controls.Add(this.label3);
            this.panelTimers.Controls.Add(this.lblStartTime);
            this.panelTimers.Controls.Add(this.label5);
            this.panelTimers.Controls.Add(this.lblStartInterv);
            this.panelTimers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimers.Location = new System.Drawing.Point(0, 318);
            this.panelTimers.Name = "panelTimers";
            this.panelTimers.Size = new System.Drawing.Size(228, 111);
            this.panelTimers.TabIndex = 18;
            // 
            // panelKPI
            // 
            this.panelKPI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelKPI.Location = new System.Drawing.Point(0, 430);
            this.panelKPI.Name = "panelKPI";
            this.panelKPI.Size = new System.Drawing.Size(228, 102);
            this.panelKPI.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(228, 532);
            this.ControlBox = false;
            this.Controls.Add(this.panelKPI);
            this.Controls.Add(this.panelTimers);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelUser);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(228, 1527);
            this.MinimumSize = new System.Drawing.Size(228, 527);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Awaria Produkcja";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelTimers.ResumeLayout(false);
            this.panelTimers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTester;
        private System.Windows.Forms.Button buttonRegisterIssue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonIntervention;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStartInterv;
        private System.Windows.Forms.TextBox tboxDescr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCloseInterv;
        private System.Windows.Forms.ComboBox cboxProblemType;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelTimers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelKPI;
        private System.Windows.Forms.Button btnSettings;
    }
}

