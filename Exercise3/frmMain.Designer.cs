namespace Exercise3
{
    partial class frmMain
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
            lion = new RadioButton();
            fullham = new RadioButton();
            arsenal = new RadioButton();
            tottenham = new RadioButton();
            aletico = new RadioButton();
            real = new RadioButton();
            barcelona = new RadioButton();
            milan = new RadioButton();
            mu = new RadioButton();
            pic = new PictureBox();
            btnExit = new Button();
            btnLunar = new Button();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // lion
            // 
            lion.AutoSize = true;
            lion.BackColor = SystemColors.ActiveCaption;
            lion.Checked = true;
            lion.Location = new Point(52, 46);
            lion.Name = "lion";
            lion.Size = new Size(58, 25);
            lion.TabIndex = 0;
            lion.TabStop = true;
            lion.Text = "Lion";
            lion.UseVisualStyleBackColor = false;
            lion.CheckedChanged += lion_CheckedChanged;
            // 
            // fullham
            // 
            fullham.AutoSize = true;
            fullham.BackColor = SystemColors.ActiveCaption;
            fullham.Location = new Point(52, 90);
            fullham.Name = "fullham";
            fullham.Size = new Size(84, 25);
            fullham.TabIndex = 1;
            fullham.Text = "Fullham";
            fullham.UseVisualStyleBackColor = false;
            fullham.CheckedChanged += lion_CheckedChanged;
            // 
            // arsenal
            // 
            arsenal.AutoSize = true;
            arsenal.BackColor = SystemColors.ActiveCaption;
            arsenal.Location = new Point(52, 138);
            arsenal.Name = "arsenal";
            arsenal.Size = new Size(80, 25);
            arsenal.TabIndex = 2;
            arsenal.Text = "Arsenal";
            arsenal.UseVisualStyleBackColor = false;
            arsenal.CheckedChanged += lion_CheckedChanged;
            // 
            // tottenham
            // 
            tottenham.AutoSize = true;
            tottenham.BackColor = SystemColors.ActiveCaption;
            tottenham.Location = new Point(52, 187);
            tottenham.Name = "tottenham";
            tottenham.Size = new Size(101, 25);
            tottenham.TabIndex = 3;
            tottenham.Text = "Tottenham";
            tottenham.UseVisualStyleBackColor = false;
            tottenham.CheckedChanged += lion_CheckedChanged;
            // 
            // aletico
            // 
            aletico.AutoSize = true;
            aletico.BackColor = SystemColors.ActiveCaption;
            aletico.Location = new Point(404, 232);
            aletico.Name = "aletico";
            aletico.Size = new Size(129, 25);
            aletico.TabIndex = 4;
            aletico.Text = "Aletico Madrid";
            aletico.UseVisualStyleBackColor = false;
            aletico.CheckedChanged += lion_CheckedChanged;
            // 
            // real
            // 
            real.AutoSize = true;
            real.BackColor = SystemColors.ActiveCaption;
            real.Location = new Point(404, 279);
            real.Name = "real";
            real.Size = new Size(112, 25);
            real.TabIndex = 5;
            real.Text = "Real Madrid";
            real.UseVisualStyleBackColor = false;
            real.CheckedChanged += lion_CheckedChanged;
            // 
            // barcelona
            // 
            barcelona.AutoSize = true;
            barcelona.BackColor = SystemColors.ActiveCaption;
            barcelona.Location = new Point(404, 329);
            barcelona.Name = "barcelona";
            barcelona.Size = new Size(96, 25);
            barcelona.TabIndex = 6;
            barcelona.Text = "Barcelona";
            barcelona.UseVisualStyleBackColor = false;
            barcelona.CheckedChanged += lion_CheckedChanged;
            // 
            // milan
            // 
            milan.AutoSize = true;
            milan.BackColor = SystemColors.ActiveCaption;
            milan.Location = new Point(404, 371);
            milan.Name = "milan";
            milan.Size = new Size(103, 25);
            milan.TabIndex = 7;
            milan.Text = "Inter Milan";
            milan.UseVisualStyleBackColor = false;
            milan.CheckedChanged += lion_CheckedChanged;
            // 
            // mu
            // 
            mu.AutoSize = true;
            mu.BackColor = SystemColors.ActiveCaption;
            mu.Location = new Point(52, 237);
            mu.Name = "mu";
            mu.Size = new Size(159, 25);
            mu.TabIndex = 8;
            mu.Text = "Manchester United";
            mu.UseVisualStyleBackColor = false;
            mu.CheckedChanged += lion_CheckedChanged;
            // 
            // pic
            // 
            pic.Image = Properties.Resources.lion;
            pic.Location = new Point(334, 21);
            pic.Name = "pic";
            pic.Size = new Size(182, 190);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.TabIndex = 9;
            pic.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Blue;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(116, 341);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 32);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnLunar
            // 
            btnLunar.BackColor = Color.Blue;
            btnLunar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLunar.ForeColor = SystemColors.ButtonHighlight;
            btnLunar.Location = new Point(116, 379);
            btnLunar.Name = "btnLunar";
            btnLunar.Size = new Size(127, 32);
            btnLunar.TabIndex = 11;
            btnLunar.Text = "Xem lịch âm";
            btnLunar.UseVisualStyleBackColor = false;
            btnLunar.Click += btnLunar_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.fpt;
            ClientSize = new Size(630, 448);
            Controls.Add(btnLunar);
            Controls.Add(btnExit);
            Controls.Add(pic);
            Controls.Add(mu);
            Controls.Add(milan);
            Controls.Add(barcelona);
            Controls.Add(real);
            Controls.Add(aletico);
            Controls.Add(tottenham);
            Controls.Add(arsenal);
            Controls.Add(fullham);
            Controls.Add(lion);
            Name = "frmMain";
            Text = "frmMain";
            FormClosing += frmMain_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton lion;
        private RadioButton fullham;
        private RadioButton arsenal;
        private RadioButton tottenham;
        private RadioButton aletico;
        private RadioButton real;
        private RadioButton barcelona;
        private RadioButton milan;
        private RadioButton mu;
        private PictureBox pictureBox1;
        private PictureBox pic;
        private Button btnExit;
        private Button btnLunar;
    }
}