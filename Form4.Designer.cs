namespace Venda_Boulevard__VB__Auto_Centre
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.comboBoxPackage = new System.Windows.Forms.ComboBox();
            this.comboBoxAppearance = new System.Windows.Forms.ComboBox();
            this.listBoxDescription = new System.Windows.Forms.ListBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFragance = new System.Windows.Forms.Label();
            this.comboBoxFragrance = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPackage
            // 
            this.comboBoxPackage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPackage.FormattingEnabled = true;
            this.comboBoxPackage.Location = new System.Drawing.Point(12, 139);
            this.comboBoxPackage.Name = "comboBoxPackage";
            this.comboBoxPackage.Size = new System.Drawing.Size(155, 21);
            this.comboBoxPackage.TabIndex = 1;
            this.comboBoxPackage.SelectedIndexChanged += new System.EventHandler(this.comboBoxPackage_SelectedIndexChanged);
            // 
            // comboBoxAppearance
            // 
            this.comboBoxAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppearance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxAppearance.FormattingEnabled = true;
            this.comboBoxAppearance.Location = new System.Drawing.Point(12, 226);
            this.comboBoxAppearance.Name = "comboBoxAppearance";
            this.comboBoxAppearance.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAppearance.TabIndex = 2;
            this.comboBoxAppearance.SelectedIndexChanged += new System.EventHandler(this.comboBoxFragrance_SelectedIndexChanged);
            // 
            // listBoxDescription
            // 
            this.listBoxDescription.BackColor = System.Drawing.Color.White;
            this.listBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDescription.FormattingEnabled = true;
            this.listBoxDescription.Location = new System.Drawing.Point(477, 27);
            this.listBoxDescription.Name = "listBoxDescription";
            this.listBoxDescription.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDescription.Size = new System.Drawing.Size(251, 234);
            this.listBoxDescription.TabIndex = 3;
            this.listBoxDescription.SelectedIndexChanged += new System.EventHandler(this.listBoxDescription_SelectedIndexChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.DarkOrange;
            this.lblWelcome.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(11, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(368, 23);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Venda Boulevard Auto Centre Car Wash";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.BackColor = System.Drawing.Color.Transparent;
            this.lblPackage.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblPackage.Location = new System.Drawing.Point(12, 117);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(190, 19);
            this.lblPackage.TabIndex = 6;
            this.lblPackage.Text = "Choose detailing package:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(11, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Exterior/Interior:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printOrderToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printOrderToolStripMenuItem
            // 
            this.printOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.printOrderToolStripMenuItem.Name = "printOrderToolStripMenuItem";
            this.printOrderToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.printOrderToolStripMenuItem.Text = "Print Order";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearItemsToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // clearItemsToolStripMenuItem
            // 
            this.clearItemsToolStripMenuItem.Name = "clearItemsToolStripMenuItem";
            this.clearItemsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.clearItemsToolStripMenuItem.Text = "Clear Items";
            this.clearItemsToolStripMenuItem.Click += new System.EventHandler(this.clearItemsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblFragance
            // 
            this.lblFragance.AutoSize = true;
            this.lblFragance.BackColor = System.Drawing.Color.Transparent;
            this.lblFragance.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFragance.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblFragance.Location = new System.Drawing.Point(229, 200);
            this.lblFragance.Name = "lblFragance";
            this.lblFragance.Size = new System.Drawing.Size(137, 19);
            this.lblFragance.TabIndex = 9;
            this.lblFragance.Text = "Choose Fragrance:";
            // 
            // comboBoxFragrance
            // 
            this.comboBoxFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFragrance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFragrance.FormattingEnabled = true;
            this.comboBoxFragrance.Location = new System.Drawing.Point(232, 226);
            this.comboBoxFragrance.Name = "comboBoxFragrance";
            this.comboBoxFragrance.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFragrance.TabIndex = 10;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 343);
            this.Controls.Add(this.comboBoxFragrance);
            this.Controls.Add(this.lblFragance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.listBoxDescription);
            this.Controls.Add(this.comboBoxAppearance);
            this.Controls.Add(this.comboBoxPackage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda Boulevard Auto Centre";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPackage;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBoxPackage;
        public System.Windows.Forms.ComboBox comboBoxAppearance;
        public System.Windows.Forms.ListBox listBoxDescription;
        public System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblFragance;
        public System.Windows.Forms.ComboBox comboBoxFragrance;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}