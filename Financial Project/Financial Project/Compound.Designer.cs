namespace Financial_Project
{
    partial class Compound
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
            this.lblInitial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInvest = new System.Windows.Forms.TextBox();
            this.tbContribute = new System.Windows.Forms.TextBox();
            this.tbInterest = new System.Windows.Forms.TextBox();
            this.tbYears = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.cbInstance = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitial.Location = new System.Drawing.Point(70, 74);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(75, 15);
            this.lblInitial.TabIndex = 0;
            this.lblInitial.Text = "Base Amount:";
            this.lblInitial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Deposits per Month:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Years:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Compount Interval:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInvest
            // 
            this.tbInvest.Location = new System.Drawing.Point(160, 71);
            this.tbInvest.Name = "tbInvest";
            this.tbInvest.Size = new System.Drawing.Size(100, 20);
            this.tbInvest.TabIndex = 0;
            // 
            // tbContribute
            // 
            this.tbContribute.Location = new System.Drawing.Point(160, 123);
            this.tbContribute.Name = "tbContribute";
            this.tbContribute.Size = new System.Drawing.Size(100, 20);
            this.tbContribute.TabIndex = 2;
            // 
            // tbInterest
            // 
            this.tbInterest.Location = new System.Drawing.Point(160, 97);
            this.tbInterest.Name = "tbInterest";
            this.tbInterest.Size = new System.Drawing.Size(100, 20);
            this.tbInterest.TabIndex = 1;
            // 
            // tbYears
            // 
            this.tbYears.Location = new System.Drawing.Point(160, 149);
            this.tbYears.Name = "tbYears";
            this.tbYears.Size = new System.Drawing.Size(100, 20);
            this.tbYears.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Compound!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOut
            // 
            this.lblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOut.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(22, 205);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(238, 51);
            this.lblOut.TabIndex = 12;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbInstance
            // 
            this.cbInstance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstance.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstance.FormattingEnabled = true;
            this.cbInstance.Items.AddRange(new object[] {
            "Annually",
            "Semiannually",
            "Quarterly",
            "Monthly",
            "Daily"});
            this.cbInstance.Location = new System.Drawing.Point(160, 174);
            this.cbInstance.Name = "cbInstance";
            this.cbInstance.Size = new System.Drawing.Size(100, 23);
            this.cbInstance.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(109, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Compound Interest Calculator";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Compound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 323);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbInstance);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbYears);
            this.Controls.Add(this.tbInterest);
            this.Controls.Add(this.tbContribute);
            this.Controls.Add(this.tbInvest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInitial);
            this.Name = "Compound";
            this.Text = "Compound";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInvest;
        private System.Windows.Forms.TextBox tbContribute;
        private System.Windows.Forms.TextBox tbInterest;
        private System.Windows.Forms.TextBox tbYears;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.ComboBox cbInstance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
    }
}