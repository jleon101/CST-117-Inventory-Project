namespace CST_117___Inventory_Project
{
    partial class PayNowUI
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
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalPaymentText = new System.Windows.Forms.Label();
            this.falseButtonApplePay = new System.Windows.Forms.Button();
            this.falseButtonAndroidPay = new System.Windows.Forms.Button();
            this.falseButtonCredit = new System.Windows.Forms.Button();
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(372, 42);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(145, 59);
            this.TotalLabel.TabIndex = 8;
            this.TotalLabel.Text = "Total";
            // 
            // TotalPaymentText
            // 
            this.TotalPaymentText.AutoSize = true;
            this.TotalPaymentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPaymentText.Location = new System.Drawing.Point(324, 120);
            this.TotalPaymentText.Name = "TotalPaymentText";
            this.TotalPaymentText.Size = new System.Drawing.Size(220, 82);
            this.TotalPaymentText.TabIndex = 9;
            this.TotalPaymentText.Text = "$0.00";
            // 
            // falseButtonApplePay
            // 
            this.falseButtonApplePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falseButtonApplePay.Location = new System.Drawing.Point(50, 287);
            this.falseButtonApplePay.Name = "falseButtonApplePay";
            this.falseButtonApplePay.Size = new System.Drawing.Size(346, 91);
            this.falseButtonApplePay.TabIndex = 10;
            this.falseButtonApplePay.Text = "Apple Pay";
            this.falseButtonApplePay.UseVisualStyleBackColor = true;
            // 
            // falseButtonAndroidPay
            // 
            this.falseButtonAndroidPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falseButtonAndroidPay.Location = new System.Drawing.Point(483, 287);
            this.falseButtonAndroidPay.Name = "falseButtonAndroidPay";
            this.falseButtonAndroidPay.Size = new System.Drawing.Size(346, 91);
            this.falseButtonAndroidPay.TabIndex = 11;
            this.falseButtonAndroidPay.Text = "Android Pay";
            this.falseButtonAndroidPay.UseVisualStyleBackColor = true;
            // 
            // falseButtonCredit
            // 
            this.falseButtonCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falseButtonCredit.Location = new System.Drawing.Point(268, 428);
            this.falseButtonCredit.Name = "falseButtonCredit";
            this.falseButtonCredit.Size = new System.Drawing.Size(346, 91);
            this.falseButtonCredit.TabIndex = 12;
            this.falseButtonCredit.Text = "Credit";
            this.falseButtonCredit.UseVisualStyleBackColor = true;
            this.falseButtonCredit.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYouLabel.Location = new System.Drawing.Point(361, 563);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(170, 32);
            this.ThankYouLabel.TabIndex = 13;
            this.ThankYouLabel.Text = "Thank You!";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(35, 565);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(130, 37);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "< Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // PayNowUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ThankYouLabel);
            this.Controls.Add(this.falseButtonCredit);
            this.Controls.Add(this.falseButtonAndroidPay);
            this.Controls.Add(this.falseButtonApplePay);
            this.Controls.Add(this.TotalPaymentText);
            this.Controls.Add(this.TotalLabel);
            this.Name = "PayNowUI";
            this.Text = "PayNowUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalPaymentText;
        private System.Windows.Forms.Button falseButtonApplePay;
        private System.Windows.Forms.Button falseButtonAndroidPay;
        private System.Windows.Forms.Button falseButtonCredit;
        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Button backButton;
    }
}