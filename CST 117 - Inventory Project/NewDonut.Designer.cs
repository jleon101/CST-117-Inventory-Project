namespace CST_117___Inventory_Project
{
    partial class NewDonut
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
            this.tboxID = new System.Windows.Forms.TextBox();
            this.tboxDonutName = new System.Windows.Forms.TextBox();
            this.tboxDescription = new System.Windows.Forms.TextBox();
            this.tboxQuantity = new System.Windows.Forms.TextBox();
            this.tboxPrice = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbox__Picture = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbox__Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Image";
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(124, 109);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(100, 20);
            this.tboxID.TabIndex = 6;
            // 
            // tboxDonutName
            // 
            this.tboxDonutName.Location = new System.Drawing.Point(124, 135);
            this.tboxDonutName.Name = "tboxDonutName";
            this.tboxDonutName.Size = new System.Drawing.Size(100, 20);
            this.tboxDonutName.TabIndex = 7;
            // 
            // tboxDescription
            // 
            this.tboxDescription.Location = new System.Drawing.Point(124, 161);
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Size = new System.Drawing.Size(100, 20);
            this.tboxDescription.TabIndex = 8;
            // 
            // tboxQuantity
            // 
            this.tboxQuantity.Location = new System.Drawing.Point(124, 187);
            this.tboxQuantity.Name = "tboxQuantity";
            this.tboxQuantity.Size = new System.Drawing.Size(100, 20);
            this.tboxQuantity.TabIndex = 9;
            // 
            // tboxPrice
            // 
            this.tboxPrice.Location = new System.Drawing.Point(124, 213);
            this.tboxPrice.Name = "tboxPrice";
            this.tboxPrice.Size = new System.Drawing.Size(100, 20);
            this.tboxPrice.TabIndex = 10;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(24, 336);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 12;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(122, 336);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(218, 336);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 42);
            this.label7.TabIndex = 15;
            this.label7.Text = "New Item";
            // 
            // pbox__Picture
            // 
            this.pbox__Picture.Location = new System.Drawing.Point(124, 246);
            this.pbox__Picture.Name = "pbox__Picture";
            this.pbox__Picture.Size = new System.Drawing.Size(100, 79);
            this.pbox__Picture.TabIndex = 16;
            this.pbox__Picture.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 216);
            this.dataGridView1.TabIndex = 17;
            // 
            // NewDonut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbox__Picture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.tboxPrice);
            this.Controls.Add(this.tboxQuantity);
            this.Controls.Add(this.tboxDescription);
            this.Controls.Add(this.tboxDonutName);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDonut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewDonut";
            this.Load += new System.EventHandler(this.NewDonut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox__Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.TextBox tboxDonutName;
        private System.Windows.Forms.TextBox tboxDescription;
        private System.Windows.Forms.TextBox tboxQuantity;
        private System.Windows.Forms.TextBox tboxPrice;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbox__Picture;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}