namespace tipCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkRound = new System.Windows.Forms.CheckBox();
            this.txtBillAmt = new System.Windows.Forms.TextBox();
            this.txtNumPeople = new System.Windows.Forms.TextBox();
            this.txtTipPercent = new System.Windows.Forms.TextBox();
            this.txtTotalNoTip = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.txtTotalWithTip = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of people";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip percent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total each, before tip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tip";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total each, with tip";
            // 
            // checkRound
            // 
            this.checkRound.AutoSize = true;
            this.checkRound.Location = new System.Drawing.Point(70, 235);
            this.checkRound.Name = "checkRound";
            this.checkRound.Size = new System.Drawing.Size(171, 17);
            this.checkRound.TabIndex = 7;
            this.checkRound.Text = "Round tip up to nearest dollar?";
            this.checkRound.UseVisualStyleBackColor = true;
            // 
            // txtBillAmt
            // 
            this.txtBillAmt.Location = new System.Drawing.Point(187, 57);
            this.txtBillAmt.Name = "txtBillAmt";
            this.txtBillAmt.Size = new System.Drawing.Size(100, 20);
            this.txtBillAmt.TabIndex = 9;
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.Location = new System.Drawing.Point(187, 102);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(100, 20);
            this.txtNumPeople.TabIndex = 10;
            // 
            // txtTipPercent
            // 
            this.txtTipPercent.Location = new System.Drawing.Point(187, 153);
            this.txtTipPercent.Name = "txtTipPercent";
            this.txtTipPercent.Size = new System.Drawing.Size(100, 20);
            this.txtTipPercent.TabIndex = 11;
            this.txtTipPercent.Text = "20\r\n";
            // 
            // txtTotalNoTip
            // 
            this.txtTotalNoTip.Location = new System.Drawing.Point(484, 53);
            this.txtTotalNoTip.Name = "txtTotalNoTip";
            this.txtTotalNoTip.ReadOnly = true;
            this.txtTotalNoTip.Size = new System.Drawing.Size(100, 20);
            this.txtTotalNoTip.TabIndex = 12;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(484, 119);
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.Size = new System.Drawing.Size(100, 20);
            this.txtTip.TabIndex = 13;
            // 
            // txtTotalWithTip
            // 
            this.txtTotalWithTip.Location = new System.Drawing.Point(484, 170);
            this.txtTotalWithTip.Name = "txtTotalWithTip";
            this.txtTotalWithTip.ReadOnly = true;
            this.txtTotalWithTip.Size = new System.Drawing.Size(100, 20);
            this.txtTotalWithTip.TabIndex = 14;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(290, 235);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 298);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalWithTip);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtTotalNoTip);
            this.Controls.Add(this.txtTipPercent);
            this.Controls.Add(this.txtNumPeople);
            this.Controls.Add(this.txtBillAmt);
            this.Controls.Add(this.checkRound);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkRound;
        private System.Windows.Forms.TextBox txtBillAmt;
        private System.Windows.Forms.TextBox txtNumPeople;
        private System.Windows.Forms.TextBox txtTipPercent;
        private System.Windows.Forms.TextBox txtTotalNoTip;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.TextBox txtTotalWithTip;
        private System.Windows.Forms.Button btnCalculate;
    }
}

