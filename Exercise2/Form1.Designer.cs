namespace Exercise2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSecurityCode = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnDel = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnHashTag = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            label2 = new Label();
            lbxAccessLog = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "Security code";
            // 
            // txtSecurityCode
            // 
            txtSecurityCode.Location = new Point(156, 28);
            txtSecurityCode.Name = "txtSecurityCode";
            txtSecurityCode.PasswordChar = '*';
            txtSecurityCode.ReadOnly = true;
            txtSecurityCode.Size = new Size(211, 29);
            txtSecurityCode.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(86, 92);
            btn1.Name = "btn1";
            btn1.Size = new Size(49, 36);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(156, 92);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 36);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(226, 92);
            btn3.Name = "btn3";
            btn3.Size = new Size(49, 36);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn1_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(255, 192, 128);
            btnDel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.Location = new Point(291, 92);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(49, 36);
            btnDel.TabIndex = 5;
            btnDel.Text = "C";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(226, 211);
            btn9.Name = "btn9";
            btn9.Size = new Size(49, 36);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(291, 211);
            btn0.Name = "btn0";
            btn0.Size = new Size(49, 36);
            btn0.TabIndex = 7;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn1_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(156, 211);
            btn8.Name = "btn8";
            btn8.Size = new Size(49, 36);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn1_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(86, 211);
            btn7.Name = "btn7";
            btn7.Size = new Size(49, 36);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn1_Click;
            // 
            // btnHashTag
            // 
            btnHashTag.BackColor = SystemColors.Highlight;
            btnHashTag.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHashTag.Location = new Point(291, 151);
            btnHashTag.Name = "btnHashTag";
            btnHashTag.Size = new Size(49, 36);
            btnHashTag.TabIndex = 10;
            btnHashTag.Text = "#";
            btnHashTag.UseVisualStyleBackColor = false;
            btnHashTag.Click += btnHashTag_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(226, 151);
            btn6.Name = "btn6";
            btn6.Size = new Size(49, 36);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn1_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(156, 151);
            btn5.Name = "btn5";
            btn5.Size = new Size(49, 36);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(86, 151);
            btn4.Name = "btn4";
            btn4.Size = new Size(49, 36);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 288);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 14;
            label2.Text = "Access log:";
            // 
            // lbxAccessLog
            // 
            lbxAccessLog.FormattingEnabled = true;
            lbxAccessLog.ItemHeight = 21;
            lbxAccessLog.Location = new Point(33, 312);
            lbxAccessLog.Name = "lbxAccessLog";
            lbxAccessLog.Size = new Size(334, 130);
            lbxAccessLog.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 472);
            Controls.Add(lbxAccessLog);
            Controls.Add(label2);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnHashTag);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btnDel);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtSecurityCode);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Security Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSecurityCode;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnDel;
        private Button btn9;
        private Button btn0;
        private Button btn8;
        private Button btn7;
        private Button btnHashTag;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Label label2;
        private ListBox lbxAccessLog;
    }
}