namespace AwariaProdukcja
{
    partial class Settings
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPathToMonit = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxPath = new System.Windows.Forms.TextBox();
            this.rbtnXML = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnTXT = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(228, 18);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(210, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ustawienia";
            // 
            // lblPathToMonit
            // 
            this.lblPathToMonit.AutoSize = true;
            this.lblPathToMonit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPathToMonit.Location = new System.Drawing.Point(9, 5);
            this.lblPathToMonit.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblPathToMonit.Name = "lblPathToMonit";
            this.lblPathToMonit.Size = new System.Drawing.Size(80, 13);
            this.lblPathToMonit.TabIndex = 2;
            this.lblPathToMonit.Text = "Folder z logami:";
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.panel1);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 18);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(228, 90);
            this.panelSettings.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rbtnTXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbtnXML);
            this.panel1.Controls.Add(this.tboxPath);
            this.panel1.Controls.Add(this.lblPathToMonit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 91);
            this.panel1.TabIndex = 3;
            // 
            // tboxPath
            // 
            this.tboxPath.Location = new System.Drawing.Point(12, 21);
            this.tboxPath.Name = "tboxPath";
            this.tboxPath.Size = new System.Drawing.Size(204, 20);
            this.tboxPath.TabIndex = 3;
            // 
            // rbtnXML
            // 
            this.rbtnXML.AutoSize = true;
            this.rbtnXML.Checked = true;
            this.rbtnXML.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbtnXML.Location = new System.Drawing.Point(12, 71);
            this.rbtnXML.Name = "rbtnXML";
            this.rbtnXML.Size = new System.Drawing.Size(47, 17);
            this.rbtnXML.TabIndex = 4;
            this.rbtnXML.TabStop = true;
            this.rbtnXML.Text = "XML";
            this.rbtnXML.UseVisualStyleBackColor = true;
            this.rbtnXML.CheckedChanged += new System.EventHandler(this.rbtnXML_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Format logów:";
            // 
            // rbtnTXT
            // 
            this.rbtnTXT.AutoSize = true;
            this.rbtnTXT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbtnTXT.Location = new System.Drawing.Point(65, 71);
            this.rbtnTXT.Name = "rbtnTXT";
            this.rbtnTXT.Size = new System.Drawing.Size(46, 17);
            this.rbtnTXT.TabIndex = 6;
            this.rbtnTXT.Text = "TXT";
            this.rbtnTXT.UseVisualStyleBackColor = true;
            this.rbtnTXT.CheckedChanged += new System.EventHandler(this.rbtnTXT_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(153, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ZAPISZ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(228, 108);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(800, 600);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPathToMonit;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnXML;
        private System.Windows.Forms.TextBox tboxPath;
    }
}