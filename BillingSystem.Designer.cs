namespace SmartHospitalManagementSystem
{
    partial class BillingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtConsultation = new System.Windows.Forms.TextBox();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.txtLabTest = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtFinalAmount = new System.Windows.Forms.TextBox();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnViewBills = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consultation Charges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medicine Charges";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lab Test Charges";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tax Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Final Amount";
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(220, 37);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(100, 26);
            this.txtBillID.TabIndex = 8;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(220, 75);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(100, 26);
            this.txtPatientID.TabIndex = 9;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(220, 110);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(100, 26);
            this.txtPatientName.TabIndex = 10;
            // 
            // txtConsultation
            // 
            this.txtConsultation.Location = new System.Drawing.Point(239, 146);
            this.txtConsultation.Name = "txtConsultation";
            this.txtConsultation.Size = new System.Drawing.Size(100, 26);
            this.txtConsultation.TabIndex = 11;
            // 
            // txtMedicine
            // 
            this.txtMedicine.Location = new System.Drawing.Point(230, 190);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(100, 26);
            this.txtMedicine.TabIndex = 12;
            // 
            // txtLabTest
            // 
            this.txtLabTest.Location = new System.Drawing.Point(230, 222);
            this.txtLabTest.Name = "txtLabTest";
            this.txtLabTest.Size = new System.Drawing.Size(100, 26);
            this.txtLabTest.TabIndex = 13;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(230, 265);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 26);
            this.txtTax.TabIndex = 14;
            // 
            // txtFinalAmount
            // 
            this.txtFinalAmount.Location = new System.Drawing.Point(230, 300);
            this.txtFinalAmount.Name = "txtFinalAmount";
            this.txtFinalAmount.Size = new System.Drawing.Size(100, 26);
            this.txtFinalAmount.TabIndex = 15;
            // 
            // btnAddBill
            // 
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(427, 15);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(67, 39);
            this.btnAddBill.TabIndex = 16;
            this.btnAddBill.Text = "Add";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBill.Location = new System.Drawing.Point(548, 16);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(113, 37);
            this.btnUpdateBill.TabIndex = 17;
            this.btnUpdateBill.Text = "Update";
            this.btnUpdateBill.UseVisualStyleBackColor = true;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBill.Location = new System.Drawing.Point(686, 12);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(113, 41);
            this.btnDeleteBill.TabIndex = 18;
            this.btnDeleteBill.Text = "Delete";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBill.Location = new System.Drawing.Point(427, 72);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(105, 54);
            this.btnSearchBill.TabIndex = 19;
            this.btnSearchBill.Text = "Search";
            this.btnSearchBill.UseVisualStyleBackColor = true;
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(548, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 56);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnViewBills
            // 
            this.btnViewBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBills.Location = new System.Drawing.Point(686, 74);
            this.btnViewBills.Name = "btnViewBills";
            this.btnViewBills.Size = new System.Drawing.Size(91, 37);
            this.btnViewBills.TabIndex = 21;
            this.btnViewBills.Text = "View";
            this.btnViewBills.UseVisualStyleBackColor = true;
            this.btnViewBills.Click += new System.EventHandler(this.btnViewBills_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(427, 138);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 48);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(548, 138);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 48);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate Bill";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(686, 142);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 44);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Location = new System.Drawing.Point(17, 336);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(188, 33);
            this.cmbPaymentStatus.TabIndex = 25;
            this.cmbPaymentStatus.Text = "Payment Status";
            // 
            // dgvBilling
            // 
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling.Location = new System.Drawing.Point(336, 265);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.RowHeadersWidth = 62;
            this.dgvBilling.RowTemplate.Height = 28;
            this.dgvBilling.Size = new System.Drawing.Size(380, 173);
            this.dgvBilling.TabIndex = 26;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBilling);
            this.Controls.Add(this.cmbPaymentStatus);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewBills);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearchBill);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnUpdateBill);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.txtFinalAmount);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtLabTest);
            this.Controls.Add(this.txtMedicine);
            this.Controls.Add(this.txtConsultation);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.txtBillID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BillingForm";
            this.Text = "BillingSystem";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtConsultation;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.TextBox txtLabTest;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtFinalAmount;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnViewBills;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.DataGridView dgvBilling;
    }
}