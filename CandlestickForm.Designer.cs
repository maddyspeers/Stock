namespace Project_3
{
    partial class CandlestickForm
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
            this.stockcombo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.loadbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMonth = new System.Windows.Forms.RadioButton();
            this.buttonWeek = new System.Windows.Forms.RadioButton();
            this.buttonDay = new System.Windows.Forms.RadioButton();
            this.startDate = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.stocklabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockcombo
            // 
            this.stockcombo.FormattingEnabled = true;
            this.stockcombo.Location = new System.Drawing.Point(32, 106);
            this.stockcombo.Name = "stockcombo";
            this.stockcombo.Size = new System.Drawing.Size(179, 24);
            this.stockcombo.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 13, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(252, 62);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(167, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2022, 12, 29, 0, 0, 0, 0);
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(33, 319);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(178, 90);
            this.loadbutton.TabIndex = 3;
            this.loadbutton.Text = "LOAD";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMonth);
            this.groupBox1.Controls.Add(this.buttonWeek);
            this.groupBox1.Controls.Add(this.buttonDay);
            this.groupBox1.Location = new System.Drawing.Point(37, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Period";
            // 
            // buttonMonth
            // 
            this.buttonMonth.AutoSize = true;
            this.buttonMonth.Location = new System.Drawing.Point(6, 119);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(64, 20);
            this.buttonMonth.TabIndex = 2;
            this.buttonMonth.TabStop = true;
            this.buttonMonth.Text = "Month";
            this.buttonMonth.UseVisualStyleBackColor = true;
            this.buttonMonth.CheckedChanged += new System.EventHandler(this.buttonMonth_CheckedChanged);
            // 
            // buttonWeek
            // 
            this.buttonWeek.AutoSize = true;
            this.buttonWeek.Location = new System.Drawing.Point(6, 71);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Size = new System.Drawing.Size(64, 20);
            this.buttonWeek.TabIndex = 1;
            this.buttonWeek.TabStop = true;
            this.buttonWeek.Text = "Week";
            this.buttonWeek.UseVisualStyleBackColor = true;
            this.buttonWeek.CheckedChanged += new System.EventHandler(this.buttonWeek_CheckedChanged);
            // 
            // buttonDay
            // 
            this.buttonDay.AutoSize = true;
            this.buttonDay.Location = new System.Drawing.Point(6, 31);
            this.buttonDay.Name = "buttonDay";
            this.buttonDay.Size = new System.Drawing.Size(53, 20);
            this.buttonDay.TabIndex = 0;
            this.buttonDay.TabStop = true;
            this.buttonDay.Text = "Day";
            this.buttonDay.UseVisualStyleBackColor = true;
            this.buttonDay.CheckedChanged += new System.EventHandler(this.buttonDay_CheckedChanged);
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(426, 27);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(34, 16);
            this.startDate.TabIndex = 5;
            this.startDate.Text = "Start";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(429, 67);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(31, 16);
            this.endDate.TabIndex = 6;
            this.endDate.Text = "End";
            // 
            // stocklabel
            // 
            this.stocklabel.AutoSize = true;
            this.stocklabel.Location = new System.Drawing.Point(36, 67);
            this.stocklabel.Name = "stocklabel";
            this.stocklabel.Size = new System.Drawing.Size(44, 16);
            this.stocklabel.TabIndex = 7;
            this.stocklabel.Text = "Stock:";
            // 
            // CandlestickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stocklabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.stockcombo);
            this.Name = "CandlestickForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox stockcombo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton buttonMonth;
        private System.Windows.Forms.RadioButton buttonWeek;
        private System.Windows.Forms.RadioButton buttonDay;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label stocklabel;
    }
}

