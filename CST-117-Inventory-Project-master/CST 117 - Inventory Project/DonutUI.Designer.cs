namespace CST_117___Inventory_Project
{
    partial class DonutUI
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
            this.DonutMenuLabel = new System.Windows.Forms.Label();
            this.DonutList1 = new System.Windows.Forms.ListBox();
            this.RemoveDonutButton = new System.Windows.Forms.Button();
            this.AddDonutButton = new System.Windows.Forms.Button();
            this.AvailableDonutsLabel = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Button();
            this.MyBoxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DonutMenuLabel
            // 
            this.DonutMenuLabel.AutoSize = true;
            this.DonutMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonutMenuLabel.Location = new System.Drawing.Point(201, 6);
            this.DonutMenuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DonutMenuLabel.Name = "DonutMenuLabel";
            this.DonutMenuLabel.Size = new System.Drawing.Size(183, 55);
            this.DonutMenuLabel.TabIndex = 18;
            this.DonutMenuLabel.Text = "Donuts";
            // 
            // DonutList1
            // 
            this.DonutList1.FormattingEnabled = true;
            this.DonutList1.Items.AddRange(new object[] {
            "Glazed",
            "Strawberry",
            "Cholocate",
            "Jelly",
            "Cinnamon",
            "Old Fashioned"});
            this.DonutList1.Location = new System.Drawing.Point(24, 85);
            this.DonutList1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DonutList1.Name = "DonutList1";
            this.DonutList1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.DonutList1.Size = new System.Drawing.Size(357, 238);
            this.DonutList1.TabIndex = 19;
            // 
            // RemoveDonutButton
            // 
            this.RemoveDonutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveDonutButton.Location = new System.Drawing.Point(392, 216);
            this.RemoveDonutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveDonutButton.Name = "RemoveDonutButton";
            this.RemoveDonutButton.Size = new System.Drawing.Size(185, 105);
            this.RemoveDonutButton.TabIndex = 20;
            this.RemoveDonutButton.Text = "Remove Donut";
            this.RemoveDonutButton.UseVisualStyleBackColor = true;
            // 
            // AddDonutButton
            // 
            this.AddDonutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDonutButton.Location = new System.Drawing.Point(392, 85);
            this.AddDonutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddDonutButton.Name = "AddDonutButton";
            this.AddDonutButton.Size = new System.Drawing.Size(185, 110);
            this.AddDonutButton.TabIndex = 21;
            this.AddDonutButton.Text = "Add Donut";
            this.AddDonutButton.UseVisualStyleBackColor = true;
            this.AddDonutButton.Click += new System.EventHandler(this.AddDonutButton_Click);
            // 
            // AvailableDonutsLabel
            // 
            this.AvailableDonutsLabel.AutoSize = true;
            this.AvailableDonutsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvailableDonutsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableDonutsLabel.Location = new System.Drawing.Point(24, 68);
            this.AvailableDonutsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AvailableDonutsLabel.Name = "AvailableDonutsLabel";
            this.AvailableDonutsLabel.Size = new System.Drawing.Size(116, 17);
            this.AvailableDonutsLabel.TabIndex = 22;
            this.AvailableDonutsLabel.Text = "Available Donuts";
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.Location = new System.Drawing.Point(24, 355);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(268, 36);
            this.MenuButton.TabIndex = 23;
            this.MenuButton.Text = "Main Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // MyBoxButton
            // 
            this.MyBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyBoxButton.Location = new System.Drawing.Point(309, 355);
            this.MyBoxButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyBoxButton.Name = "MyBoxButton";
            this.MyBoxButton.Size = new System.Drawing.Size(269, 36);
            this.MyBoxButton.TabIndex = 24;
            this.MyBoxButton.Text = "Your Box";
            this.MyBoxButton.UseVisualStyleBackColor = true;
            this.MyBoxButton.Click += new System.EventHandler(this.MyBoxButton_Click);
            // 
            // DonutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 419);
            this.Controls.Add(this.MyBoxButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.AvailableDonutsLabel);
            this.Controls.Add(this.AddDonutButton);
            this.Controls.Add(this.RemoveDonutButton);
            this.Controls.Add(this.DonutList1);
            this.Controls.Add(this.DonutMenuLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DonutUI";
            this.Text = "Donut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DonutMenuLabel;
        private System.Windows.Forms.ListBox DonutList1;
        private System.Windows.Forms.Button RemoveDonutButton;
        private System.Windows.Forms.Button AddDonutButton;
        private System.Windows.Forms.Label AvailableDonutsLabel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button MyBoxButton;
    }
}