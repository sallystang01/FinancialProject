namespace Financial_Project
{
    partial class Mortgage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mortgage));
            this.lblInputs = new System.Windows.Forms.Label();
            this.tbDown = new System.Windows.Forms.TextBox();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tbInterest = new System.Windows.Forms.TextBox();
            this.tbTerm = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceDollar = new System.Windows.Forms.Label();
            this.lblPaymentDollar = new System.Windows.Forms.Label();
            this.lblTermYears = new System.Windows.Forms.Label();
            this.lblInterestPerc = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblTotalInt = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblPayoffDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputs
            // 
            this.lblInputs.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblInputs.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInputs.Location = new System.Drawing.Point(25, 49);
            this.lblInputs.Name = "lblInputs";
            this.lblInputs.Size = new System.Drawing.Size(305, 23);
            this.lblInputs.TabIndex = 31;
            this.lblInputs.Text = "INPUTS";
            this.lblInputs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDown
            // 
            this.tbDown.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDown.Location = new System.Drawing.Point(186, 104);
            this.tbDown.Name = "tbDown";
            this.tbDown.Size = new System.Drawing.Size(100, 23);
            this.tbDown.TabIndex = 20;
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.BackColor = System.Drawing.Color.Transparent;
            this.lblDown.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDown.Location = new System.Drawing.Point(80, 107);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(102, 15);
            this.lblDown.TabIndex = 30;
            this.lblDown.Text = "Down Payment:";
            this.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(84, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 22);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Mortgage Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalc.Location = new System.Drawing.Point(98, 221);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(162, 39);
            this.btnCalc.TabIndex = 26;
            this.btnCalc.Text = "Calculate!";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tbInterest
            // 
            this.tbInterest.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInterest.Location = new System.Drawing.Point(186, 156);
            this.tbInterest.Name = "tbInterest";
            this.tbInterest.Size = new System.Drawing.Size(100, 23);
            this.tbInterest.TabIndex = 23;
            // 
            // tbTerm
            // 
            this.tbTerm.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTerm.Location = new System.Drawing.Point(186, 130);
            this.tbTerm.Name = "tbTerm";
            this.tbTerm.Size = new System.Drawing.Size(100, 23);
            this.tbTerm.TabIndex = 21;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(186, 78);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 23);
            this.tbPrice.TabIndex = 18;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.BackColor = System.Drawing.Color.Transparent;
            this.lblInterest.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInterest.Location = new System.Drawing.Point(45, 159);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(137, 15);
            this.lblInterest.TabIndex = 24;
            this.lblInterest.Text = "Annual Interest Rate:";
            this.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.BackColor = System.Drawing.Color.Transparent;
            this.lblTerm.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTerm.Location = new System.Drawing.Point(79, 133);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(103, 15);
            this.lblTerm.TabIndex = 22;
            this.lblTerm.Text = "Mortgage Term:";
            this.lblTerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrice.Location = new System.Drawing.Point(61, 81);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(121, 15);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Amount Borrowed:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriceDollar
            // 
            this.lblPriceDollar.AutoSize = true;
            this.lblPriceDollar.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceDollar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceDollar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPriceDollar.Location = new System.Drawing.Point(292, 81);
            this.lblPriceDollar.Name = "lblPriceDollar";
            this.lblPriceDollar.Size = new System.Drawing.Size(14, 15);
            this.lblPriceDollar.TabIndex = 32;
            this.lblPriceDollar.Text = "$";
            this.lblPriceDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaymentDollar
            // 
            this.lblPaymentDollar.AutoSize = true;
            this.lblPaymentDollar.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentDollar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDollar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPaymentDollar.Location = new System.Drawing.Point(292, 107);
            this.lblPaymentDollar.Name = "lblPaymentDollar";
            this.lblPaymentDollar.Size = new System.Drawing.Size(14, 15);
            this.lblPaymentDollar.TabIndex = 33;
            this.lblPaymentDollar.Text = "$";
            this.lblPaymentDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTermYears
            // 
            this.lblTermYears.AutoSize = true;
            this.lblTermYears.BackColor = System.Drawing.Color.Transparent;
            this.lblTermYears.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermYears.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTermYears.Location = new System.Drawing.Point(292, 133);
            this.lblTermYears.Name = "lblTermYears";
            this.lblTermYears.Size = new System.Drawing.Size(40, 15);
            this.lblTermYears.TabIndex = 34;
            this.lblTermYears.Text = "Years";
            this.lblTermYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterestPerc
            // 
            this.lblInterestPerc.AutoSize = true;
            this.lblInterestPerc.BackColor = System.Drawing.Color.Transparent;
            this.lblInterestPerc.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestPerc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInterestPerc.Location = new System.Drawing.Point(292, 159);
            this.lblInterestPerc.Name = "lblInterestPerc";
            this.lblInterestPerc.Size = new System.Drawing.Size(20, 15);
            this.lblInterestPerc.TabIndex = 35;
            this.lblInterestPerc.Text = "%";
            this.lblInterestPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblResults.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResults.Location = new System.Drawing.Point(378, 49);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(305, 23);
            this.lblResults.TabIndex = 38;
            this.lblResults.Text = "RESULTS";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(500, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 45);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOut
            // 
            this.lblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOut.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(382, 82);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(298, 28);
            this.lblOut.TabIndex = 36;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalInt
            // 
            this.lblTotalInt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalInt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInt.Location = new System.Drawing.Point(382, 110);
            this.lblTotalInt.Name = "lblTotalInt";
            this.lblTotalInt.Size = new System.Drawing.Size(298, 28);
            this.lblTotalInt.TabIndex = 39;
            this.lblTotalInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPayment.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(382, 138);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(298, 28);
            this.lblTotalPayment.TabIndex = 40;
            this.lblTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStart
            // 
            this.tbStart.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStart.Location = new System.Drawing.Point(186, 183);
            this.tbStart.Name = "tbStart";
            this.tbStart.ReadOnly = true;
            this.tbStart.Size = new System.Drawing.Size(100, 23);
            this.tbStart.TabIndex = 42;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(97, 186);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 15);
            this.lblDate.TabIndex = 41;
            this.lblDate.Text = "Date of Loan:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCal
            // 
            this.btnCal.BackgroundImage = global::Financial_Project.Properties.Resources.cal;
            this.btnCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCal.FlatAppearance.BorderSize = 0;
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.Location = new System.Drawing.Point(292, 181);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(32, 25);
            this.btnCal.TabIndex = 43;
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // mCalendar
            // 
            this.mCalendar.Location = new System.Drawing.Point(64, 44);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 44;
            this.mCalendar.Visible = false;
            this.mCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalendar_DateChanged);
            this.mCalendar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mCalendar_MouseUp);
            // 
            // lblPayoffDate
            // 
            this.lblPayoffDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayoffDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayoffDate.Location = new System.Drawing.Point(382, 166);
            this.lblPayoffDate.Name = "lblPayoffDate";
            this.lblPayoffDate.Size = new System.Drawing.Size(298, 28);
            this.lblPayoffDate.TabIndex = 45;
            this.lblPayoffDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mortgage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 272);
            this.Controls.Add(this.lblPayoffDate);
            this.Controls.Add(this.mCalendar);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.lblTotalInt);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblInterestPerc);
            this.Controls.Add(this.lblTermYears);
            this.Controls.Add(this.lblPaymentDollar);
            this.Controls.Add(this.lblPriceDollar);
            this.Controls.Add(this.lblInputs);
            this.Controls.Add(this.tbDown);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbInterest);
            this.Controls.Add(this.tbTerm);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblPrice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mortgage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mortgage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mortgage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputs;
        private System.Windows.Forms.TextBox tbDown;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tbInterest;
        private System.Windows.Forms.TextBox tbTerm;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceDollar;
        private System.Windows.Forms.Label lblPaymentDollar;
        private System.Windows.Forms.Label lblTermYears;
        private System.Windows.Forms.Label lblInterestPerc;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblTotalInt;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.Label lblPayoffDate;
    }
}