namespace HotelVanier
{
    partial class SearchDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDatabase));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emplyeeButton = new System.Windows.Forms.Button();
            this.customerAndBillButton = new System.Windows.Forms.Button();
            this.bilButton = new System.Windows.Forms.Button();
            this.roomStatusButton = new System.Windows.Forms.Button();
            this.hotelRoomButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.emplyeeButton);
            this.groupBox1.Controls.Add(this.customerAndBillButton);
            this.groupBox1.Controls.Add(this.bilButton);
            this.groupBox1.Controls.Add(this.roomStatusButton);
            this.groupBox1.Controls.Add(this.hotelRoomButton);
            this.groupBox1.Controls.Add(this.customerButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // emplyeeButton
            // 
            resources.ApplyResources(this.emplyeeButton, "emplyeeButton");
            this.emplyeeButton.BackColor = System.Drawing.Color.OldLace;
            this.emplyeeButton.Name = "emplyeeButton";
            this.emplyeeButton.UseVisualStyleBackColor = false;
            this.emplyeeButton.Click += new System.EventHandler(this.emplyeeButton_Click);
            // 
            // customerAndBillButton
            // 
            resources.ApplyResources(this.customerAndBillButton, "customerAndBillButton");
            this.customerAndBillButton.BackColor = System.Drawing.Color.OldLace;
            this.customerAndBillButton.Name = "customerAndBillButton";
            this.customerAndBillButton.UseVisualStyleBackColor = false;
            this.customerAndBillButton.Click += new System.EventHandler(this.customerAndBillButton_Click);
            // 
            // bilButton
            // 
            resources.ApplyResources(this.bilButton, "bilButton");
            this.bilButton.BackColor = System.Drawing.Color.OldLace;
            this.bilButton.Name = "bilButton";
            this.bilButton.UseVisualStyleBackColor = false;
            this.bilButton.Click += new System.EventHandler(this.bilButton_Click);
            // 
            // roomStatusButton
            // 
            resources.ApplyResources(this.roomStatusButton, "roomStatusButton");
            this.roomStatusButton.BackColor = System.Drawing.Color.OldLace;
            this.roomStatusButton.Name = "roomStatusButton";
            this.roomStatusButton.UseVisualStyleBackColor = false;
            this.roomStatusButton.Click += new System.EventHandler(this.roomStatusButton_Click);
            // 
            // hotelRoomButton
            // 
            resources.ApplyResources(this.hotelRoomButton, "hotelRoomButton");
            this.hotelRoomButton.BackColor = System.Drawing.Color.OldLace;
            this.hotelRoomButton.Name = "hotelRoomButton";
            this.hotelRoomButton.UseVisualStyleBackColor = false;
            this.hotelRoomButton.Click += new System.EventHandler(this.hotelRoomButton_Click);
            // 
            // customerButton
            // 
            resources.ApplyResources(this.customerButton, "customerButton");
            this.customerButton.BackColor = System.Drawing.Color.OldLace;
            this.customerButton.Name = "customerButton";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.signoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            resources.ApplyResources(this.homeToolStripMenuItem, "homeToolStripMenuItem");
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // signoutToolStripMenuItem
            // 
            resources.ApplyResources(this.signoutToolStripMenuItem, "signoutToolStripMenuItem");
            this.signoutToolStripMenuItem.Name = "signoutToolStripMenuItem";
            this.signoutToolStripMenuItem.Click += new System.EventHandler(this.signoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SearchDatabase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SearchDatabase";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button emplyeeButton;
        private System.Windows.Forms.Button customerAndBillButton;
        private System.Windows.Forms.Button bilButton;
        private System.Windows.Forms.Button roomStatusButton;
        private System.Windows.Forms.Button hotelRoomButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}