namespace Exercise3
{
    partial class Lunar
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
            label1 = new Label();
            label2 = new Label();
            calendarYear = new TextBox();
            lunarYear = new TextBox();
            btnViewLunar = new Button();
            btnExitLunar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 144);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 0;
            label1.Text = "Năm dương lịch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 197);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Năm âm lịch";
            // 
            // calendarYear
            // 
            calendarYear.Location = new Point(391, 141);
            calendarYear.Name = "calendarYear";
            calendarYear.Size = new Size(100, 29);
            calendarYear.TabIndex = 2;
            // 
            // lunarYear
            // 
            lunarYear.Location = new Point(391, 197);
            lunarYear.Name = "lunarYear";
            lunarYear.Size = new Size(100, 29);
            lunarYear.TabIndex = 3;
            // 
            // btnViewLunar
            // 
            btnViewLunar.Location = new Point(277, 301);
            btnViewLunar.Name = "btnViewLunar";
            btnViewLunar.Size = new Size(75, 32);
            btnViewLunar.TabIndex = 4;
            btnViewLunar.Text = "View";
            btnViewLunar.UseVisualStyleBackColor = true;
            btnViewLunar.Click += btnViewLunar_Click;
            // 
            // btnExitLunar
            // 
            btnExitLunar.Location = new Point(391, 301);
            btnExitLunar.Name = "btnExitLunar";
            btnExitLunar.Size = new Size(75, 32);
            btnExitLunar.TabIndex = 5;
            btnExitLunar.Text = "Exit";
            btnExitLunar.UseVisualStyleBackColor = true;
            btnExitLunar.Click += btnExitLunar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(183, 46);
            label3.Name = "label3";
            label3.Size = new Size(458, 30);
            label3.TabIndex = 6;
            label3.Text = "Chương trình đổi năm âm lịch sang dương lịch";
            // 
            // Lunar
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnExitLunar);
            Controls.Add(btnViewLunar);
            Controls.Add(lunarYear);
            Controls.Add(calendarYear);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lunar";
            Text = "Lunar";
            FormClosing += Lunar_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox calendarYear;
        private TextBox lunarYear;
        private Button btnViewLunar;
        private Button btnExitLunar;
        private Label label3;
    }
}