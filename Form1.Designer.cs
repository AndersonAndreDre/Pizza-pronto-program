
namespace LAB4
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
            this.grpBoxSamTot = new System.Windows.Forms.GroupBox();
            this.lblAccumDiscount = new System.Windows.Forms.Label();
            this.lblAccumVat = new System.Windows.Forms.Label();
            this.lblAccumAmt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtPizzaCode = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radButCash = new System.Windows.Forms.RadioButton();
            this.radButCard = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpBoxSamTot.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxSamTot
            // 
            this.grpBoxSamTot.Controls.Add(this.lblAccumDiscount);
            this.grpBoxSamTot.Controls.Add(this.lblAccumVat);
            this.grpBoxSamTot.Controls.Add(this.lblAccumAmt);
            this.grpBoxSamTot.Controls.Add(this.label10);
            this.grpBoxSamTot.Controls.Add(this.label7);
            this.grpBoxSamTot.Controls.Add(this.label6);
            this.grpBoxSamTot.Location = new System.Drawing.Point(489, 224);
            this.grpBoxSamTot.Name = "grpBoxSamTot";
            this.grpBoxSamTot.Size = new System.Drawing.Size(260, 116);
            this.grpBoxSamTot.TabIndex = 14;
            this.grpBoxSamTot.TabStop = false;
            this.grpBoxSamTot.Text = "Summary Totals";
            this.grpBoxSamTot.Enter += new System.EventHandler(this.grpBoxSamTot_Enter);
            // 
            // lblAccumDiscount
            // 
            this.lblAccumDiscount.AutoSize = true;
            this.lblAccumDiscount.Location = new System.Drawing.Point(180, 87);
            this.lblAccumDiscount.Name = "lblAccumDiscount";
            this.lblAccumDiscount.Size = new System.Drawing.Size(28, 13);
            this.lblAccumDiscount.TabIndex = 5;
            this.lblAccumDiscount.Text = "0.00";
            // 
            // lblAccumVat
            // 
            this.lblAccumVat.AutoSize = true;
            this.lblAccumVat.Location = new System.Drawing.Point(180, 57);
            this.lblAccumVat.Name = "lblAccumVat";
            this.lblAccumVat.Size = new System.Drawing.Size(28, 13);
            this.lblAccumVat.TabIndex = 3;
            this.lblAccumVat.Text = "0.00";
            // 
            // lblAccumAmt
            // 
            this.lblAccumAmt.AutoSize = true;
            this.lblAccumAmt.Location = new System.Drawing.Point(180, 30);
            this.lblAccumAmt.Name = "lblAccumAmt";
            this.lblAccumAmt.Size = new System.Drawing.Size(28, 13);
            this.lblAccumAmt.TabIndex = 1;
            this.lblAccumAmt.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Accumilated discount amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Accumilatd VAT amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Accumilated amount owing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter phone number ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter pizza code ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(361, 58);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNo.TabIndex = 2;
            this.txtPhoneNo.TextChanged += new System.EventHandler(this.txtPhoneNo_TextChanged);
            // 
            // txtPizzaCode
            // 
            this.txtPizzaCode.Location = new System.Drawing.Point(361, 102);
            this.txtPizzaCode.Name = "txtPizzaCode";
            this.txtPizzaCode.Size = new System.Drawing.Size(100, 20);
            this.txtPizzaCode.TabIndex = 4;
            this.txtPizzaCode.TextChanged += new System.EventHandler(this.txtPizzaCode_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(361, 147);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 6;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(180, 241);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(28, 13);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pizza Pronto";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(17, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(326, 395);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(543, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radButCash);
            this.groupBox1.Controls.Add(this.radButCard);
            this.groupBox1.Location = new System.Drawing.Point(498, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 72);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // radButCash
            // 
            this.radButCash.AutoSize = true;
            this.radButCash.Location = new System.Drawing.Point(3, 45);
            this.radButCash.Name = "radButCash";
            this.radButCash.Size = new System.Drawing.Size(49, 17);
            this.radButCash.TabIndex = 1;
            this.radButCash.TabStop = true;
            this.radButCash.Text = "Cash";
            this.radButCash.UseVisualStyleBackColor = true;
            // 
            // radButCard
            // 
            this.radButCard.AutoSize = true;
            this.radButCard.Location = new System.Drawing.Point(3, 16);
            this.radButCard.Name = "radButCard";
            this.radButCard.Size = new System.Drawing.Size(107, 17);
            this.radButCard.TabIndex = 0;
            this.radButCard.TabStop = true;
            this.radButCard.Text = "Debit/Credit Card";
            this.radButCard.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "VAT amount";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(180, 281);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(28, 13);
            this.lblVat.TabIndex = 11;
            this.lblVat.Text = "0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(180, 317);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(28, 13);
            this.lblDiscount.TabIndex = 13;
            this.lblDiscount.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Amount owing";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Discount amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPizzaCode);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBoxSamTot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxSamTot.ResumeLayout(false);
            this.grpBoxSamTot.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSamTot;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtPizzaCode;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radButCash;
        private System.Windows.Forms.RadioButton radButCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAccumDiscount;
        private System.Windows.Forms.Label lblAccumVat;
        private System.Windows.Forms.Label lblAccumAmt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

