namespace Financial_Project
{
    partial class Default
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
            this.btnCompound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMortgage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompound
            // 
            this.btnCompound.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompound.Location = new System.Drawing.Point(37, 59);
            this.btnCompound.Name = "btnCompound";
            this.btnCompound.Size = new System.Drawing.Size(77, 45);
            this.btnCompound.TabIndex = 0;
            this.btnCompound.Text = "Compound Interest";
            this.btnCompound.UseVisualStyleBackColor = true;
            this.btnCompound.Click += new System.EventHandler(this.btnCompound_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMortgage
            // 
            this.btnMortgage.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMortgage.Location = new System.Drawing.Point(125, 59);
            this.btnMortgage.Name = "btnMortgage";
            this.btnMortgage.Size = new System.Drawing.Size(77, 45);
            this.btnMortgage.TabIndex = 2;
            this.btnMortgage.Text = "Mortgage";
            this.btnMortgage.UseVisualStyleBackColor = true;
            this.btnMortgage.Click += new System.EventHandler(this.btnMortgage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(81, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 145);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMortgage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompound);
            this.Name = "Default";
            this.Text = "Financial Advisor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMortgage;
        private System.Windows.Forms.Button btnExit;
    }
}

