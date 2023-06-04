using System.Xml.Linq;

namespace Exercise1
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
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            chkClean = new CheckBox();
            chkWhitening = new CheckBox();
            chkXRay = new CheckBox();
            lblCleanCost = new Label();
            lblWhiteningCost = new Label();
            lblXRayCost = new Label();
            numFilling = new NumericUpDown();
            lblFilling = new Label();
            lblFillCost = new Label();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnExit = new Button();
            btnCalc = new Button();
            ((System.ComponentModel.ISupportInitialize)numFilling).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Impact", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(178, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(212, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dental Payment Form";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(56, 120);
            lblName.Name = "lblName";
            lblName.Size = new Size(117, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            txtName.Location = new Point(210, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 29);
            txtName.TabIndex = 2;
            // 
            // chkClean
            // 
            chkClean.AutoSize = true;
            chkClean.Location = new Point(56, 168);
            chkClean.Name = "chkClean";
            chkClean.Size = new Size(81, 25);
            chkClean.TabIndex = 3;
            chkClean.Text = "Cạo vôi";
            chkClean.UseVisualStyleBackColor = true;
            // 
            // chkWhitening
            // 
            chkWhitening.AutoSize = true;
            chkWhitening.Location = new Point(56, 211);
            chkWhitening.Name = "chkWhitening";
            chkWhitening.Size = new Size(94, 25);
            chkWhitening.TabIndex = 4;
            chkWhitening.Text = "Tẩy trắng";
            chkWhitening.UseVisualStyleBackColor = true;
            // 
            // chkXRay
            // 
            chkXRay.AutoSize = true;
            chkXRay.Location = new Point(56, 257);
            chkXRay.Name = "chkXRay";
            chkXRay.Size = new Size(137, 25);
            chkXRay.TabIndex = 5;
            chkXRay.Text = "Chụp hình răng";
            chkXRay.UseVisualStyleBackColor = true;
            // 
            // lblCleanCost
            // 
            lblCleanCost.AutoSize = true;
            lblCleanCost.Location = new Point(389, 172);
            lblCleanCost.Name = "lblCleanCost";
            lblCleanCost.Size = new Size(73, 21);
            lblCleanCost.TabIndex = 6;
            lblCleanCost.Text = "$100000";
            // 
            // lblWhiteningCost
            // 
            lblWhiteningCost.AutoSize = true;
            lblWhiteningCost.Location = new Point(380, 215);
            lblWhiteningCost.Name = "lblWhiteningCost";
            lblWhiteningCost.Size = new Size(82, 21);
            lblWhiteningCost.TabIndex = 7;
            lblWhiteningCost.Text = "$1200000";
            // 
            // lblXRayCost
            // 
            lblXRayCost.AutoSize = true;
            lblXRayCost.Location = new Point(389, 261);
            lblXRayCost.Name = "lblXRayCost";
            lblXRayCost.Size = new Size(73, 21);
            lblXRayCost.TabIndex = 8;
            lblXRayCost.Text = "$200000";
            // 
            // numFilling
            // 
            numFilling.Location = new Point(155, 314);
            numFilling.Name = "numFilling";
            numFilling.Size = new Size(120, 29);
            numFilling.TabIndex = 9;
            // 
            // lblFilling
            // 
            lblFilling.AutoSize = true;
            lblFilling.Location = new Point(56, 316);
            lblFilling.Name = "lblFilling";
            lblFilling.Size = new Size(81, 21);
            lblFilling.TabIndex = 10;
            lblFilling.Text = "Trám răng";
            // 
            // lblFillCost
            // 
            lblFillCost.AutoSize = true;
            lblFillCost.Location = new Point(373, 316);
            lblFillCost.Name = "lblFillCost";
            lblFillCost.Size = new Size(89, 21);
            lblFillCost.TabIndex = 11;
            lblFillCost.Text = "$80000/cái";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(251, 373);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 21);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Tổng";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(319, 370);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(143, 29);
            txtTotal.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(141, 421);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 30);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = SystemColors.ActiveCaption;
            btnCalc.Location = new Point(364, 421);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(107, 30);
            btnCalc.TabIndex = 15;
            btnCalc.Text = "Tính tiền";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 487);
            Controls.Add(btnCalc);
            Controls.Add(btnExit);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblFillCost);
            Controls.Add(lblFilling);
            Controls.Add(numFilling);
            Controls.Add(lblXRayCost);
            Controls.Add(lblWhiteningCost);
            Controls.Add(lblCleanCost);
            Controls.Add(chkXRay);
            Controls.Add(chkWhitening);
            Controls.Add(chkClean);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Dental Payment Application";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numFilling).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private CheckBox chkClean;
        private CheckBox chkWhitening;
        private CheckBox chkXRay;
        private Label lblCleanCost;
        private Label lblWhiteningCost;
        private Label lblXRayCost;
        private NumericUpDown numFilling;
        private Label lblFilling;
        private Label lblFillCost;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnExit;
        private Button btnCalc;
    }
}