namespace PresentationLayer
{
    partial class FormUsers
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
            this.components = new System.ComponentModel.Container();
            this.DataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajNovogKorisnika = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuDesnikKlik = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationRightClick = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewUsers
            // 
            this.DataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.Password,
            this.FirstName,
            this.LastName});
            this.DataGridViewUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.DataGridViewUsers.Location = new System.Drawing.Point(12, 27);
            this.DataGridViewUsers.Name = "DataGridViewUsers";
            this.DataGridViewUsers.Size = new System.Drawing.Size(584, 411);
            this.DataGridViewUsers.TabIndex = 0;
            this.DataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsers_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "UserID";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "UserName";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "UserPassword";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "UserFirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "UserLastName";
            this.LastName.HeaderText = "Last name";
            this.LastName.Name = "LastName";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApplication});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Izbornik";
            // 
            // exitApplication
            // 
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Size = new System.Drawing.Size(96, 22);
            this.exitApplication.Text = "Izlaz";
            this.exitApplication.Click += new System.EventHandler(this.exitApplication_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuButton});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramuButton
            // 
            this.oProgramuButton.Name = "oProgramuButton";
            this.oProgramuButton.Size = new System.Drawing.Size(139, 22);
            this.oProgramuButton.Text = "O programu";
            this.oProgramuButton.Click += new System.EventHandler(this.oProgramuButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovogKorisnika,
            this.oProgramuDesnikKlik,
            this.exitApplicationRightClick});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 70);
            // 
            // dodajNovogKorisnika
            // 
            this.dodajNovogKorisnika.Name = "dodajNovogKorisnika";
            this.dodajNovogKorisnika.Size = new System.Drawing.Size(180, 22);
            this.dodajNovogKorisnika.Text = "Novi korisnik";
            this.dodajNovogKorisnika.Click += new System.EventHandler(this.dodajNovogKorisnika_Click);
            // 
            // oProgramuDesnikKlik
            // 
            this.oProgramuDesnikKlik.Name = "oProgramuDesnikKlik";
            this.oProgramuDesnikKlik.Size = new System.Drawing.Size(180, 22);
            this.oProgramuDesnikKlik.Text = "O programu";
            this.oProgramuDesnikKlik.Click += new System.EventHandler(this.oProgramuDesnikKlik_Click);
            // 
            // exitApplicationRightClick
            // 
            this.exitApplicationRightClick.Name = "exitApplicationRightClick";
            this.exitApplicationRightClick.Size = new System.Drawing.Size(180, 22);
            this.exitApplicationRightClick.Text = "Izlaz";
            this.exitApplicationRightClick.Click += new System.EventHandler(this.exitApplicationRightClick_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewUsers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUsers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        public System.Windows.Forms.DataGridView DataGridViewUsers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitApplication;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogKorisnika;
        private System.Windows.Forms.ToolStripMenuItem oProgramuDesnikKlik;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationRightClick;
    }
}

