namespace Reservation_seat_in_cinema
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashierDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.detailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCashierToolStripMenuItem,
            this.removeCashierToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovieToolStripMenuItem,
            this.removeMovieToolStripMenuItem,
            this.sessionToolStripMenuItem});
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.moviesToolStripMenuItem.Text = "Movies";
            // 
            // addCashierToolStripMenuItem
            // 
            this.addCashierToolStripMenuItem.Name = "addCashierToolStripMenuItem";
            this.addCashierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCashierToolStripMenuItem.Text = "Add Cashier";
            this.addCashierToolStripMenuItem.Click += new System.EventHandler(this.addCashierToolStripMenuItem_Click);
            // 
            // removeCashierToolStripMenuItem
            // 
            this.removeCashierToolStripMenuItem.Name = "removeCashierToolStripMenuItem";
            this.removeCashierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeCashierToolStripMenuItem.Text = "Remove Cashier";
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addMovieToolStripMenuItem.Text = "Add Movie";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // removeMovieToolStripMenuItem
            // 
            this.removeMovieToolStripMenuItem.Name = "removeMovieToolStripMenuItem";
            this.removeMovieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeMovieToolStripMenuItem.Text = "Remove Movie";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesDetailToolStripMenuItem,
            this.cashierDetailToolStripMenuItem});
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.detailToolStripMenuItem.Text = "Detail";
            // 
            // moviesDetailToolStripMenuItem
            // 
            this.moviesDetailToolStripMenuItem.Name = "moviesDetailToolStripMenuItem";
            this.moviesDetailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moviesDetailToolStripMenuItem.Text = "Movies Detail";
            // 
            // cashierDetailToolStripMenuItem
            // 
            this.cashierDetailToolStripMenuItem.Name = "cashierDetailToolStripMenuItem";
            this.cashierDetailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cashierDetailToolStripMenuItem.Text = "Cashier Detail";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Customer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashierDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
    }
}