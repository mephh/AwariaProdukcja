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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTester = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelTimers = new System.Windows.Forms.Panel();
            this.panelKPI = new System.Windows.Forms.Panel();
            this.chartPareto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelUser.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTimers.SuspendLayout();
            this.panelKPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPareto)).BeginInit();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(11, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "AWARIA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(11, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 83);
            this.button2.TabIndex = 4;
            this.button2.Text = "ANULUJ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(110, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 83);
            this.button3.TabIndex = 5;
            this.button3.Text = "ROZPOCZNIJ INTERWENCJE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            this.label4.Visible = false;
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 164);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 103);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(11, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 83);
            this.button4.TabIndex = 12;
            this.button4.Text = "ZAKONCZ AWARIE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SOFTWARE",
            "ZASILACZE, MIERNIKI ITP.",
            "POLACZENIE Z SIECIA",
            "MECHANIKA",
            "LOGOWANIE DANYCH",
            "BLAD OPERATORA",
            "BRAK PROBLEMU",
            "USZKODZENIE ELEKTRYCZNE"});
            this.comboBox1.Location = new System.Drawing.Point(11, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Visible = false;
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
            this.panelButtons.Controls.Add(this.button4);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Controls.Add(this.comboBox1);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.label7);
            this.panelButtons.Controls.Add(this.button3);
            this.panelButtons.Controls.Add(this.textBox2);
            this.panelButtons.Controls.Add(this.label2);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 40);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(228, 278);
            this.panelButtons.TabIndex = 17;
            // 
            // panelTimers
            // 
            this.panelTimers.Controls.Add(this.label3);
            this.panelTimers.Controls.Add(this.label4);
            this.panelTimers.Controls.Add(this.label5);
            this.panelTimers.Controls.Add(this.label6);
            this.panelTimers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimers.Location = new System.Drawing.Point(0, 318);
            this.panelTimers.Name = "panelTimers";
            this.panelTimers.Size = new System.Drawing.Size(228, 111);
            this.panelTimers.TabIndex = 18;
            // 
            // panelKPI
            // 
            this.panelKPI.Controls.Add(this.chartPareto);
            this.panelKPI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelKPI.Location = new System.Drawing.Point(0, 431);
            this.panelKPI.Name = "panelKPI";
            this.panelKPI.Size = new System.Drawing.Size(228, 102);
            this.panelKPI.TabIndex = 19;
            // 
            // chartPareto
            // 
            this.chartPareto.BackColor = System.Drawing.Color.Black;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Name = "ChartArea1";
            this.chartPareto.ChartAreas.Add(chartArea1);
            this.chartPareto.Location = new System.Drawing.Point(0, 0);
            this.chartPareto.Margin = new System.Windows.Forms.Padding(0);
            this.chartPareto.Name = "chartPareto";
            this.chartPareto.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Blue;
            series1.Name = "Series1";
            this.chartPareto.Series.Add(series1);
            this.chartPareto.Size = new System.Drawing.Size(219, 102);
            this.chartPareto.TabIndex = 0;
            this.chartPareto.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(228, 533);
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
            this.panelKPI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPareto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTester;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelTimers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelKPI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPareto;
    }
}

