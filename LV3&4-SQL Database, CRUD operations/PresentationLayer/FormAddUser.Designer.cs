namespace PresentationLayer
{
    partial class FormAddUser
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
            this.inptNewUserName = new System.Windows.Forms.TextBox();
            this.inptNewName = new System.Windows.Forms.TextBox();
            this.inptNewPassword = new System.Windows.Forms.TextBox();
            this.inptNewLastName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblNewLastName = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.btnNewCancel = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.lblNewTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inptNewUserName
            // 
            this.inptNewUserName.Location = new System.Drawing.Point(106, 68);
            this.inptNewUserName.Name = "inptNewUserName";
            this.inptNewUserName.Size = new System.Drawing.Size(358, 20);
            this.inptNewUserName.TabIndex = 7;
            // 
            // inptNewName
            // 
            this.inptNewName.Location = new System.Drawing.Point(106, 120);
            this.inptNewName.Name = "inptNewName";
            this.inptNewName.Size = new System.Drawing.Size(358, 20);
            this.inptNewName.TabIndex = 9;
            // 
            // inptNewPassword
            // 
            this.inptNewPassword.Location = new System.Drawing.Point(106, 219);
            this.inptNewPassword.Name = "inptNewPassword";
            this.inptNewPassword.Size = new System.Drawing.Size(358, 20);
            this.inptNewPassword.TabIndex = 10;
            // 
            // inptNewLastName
            // 
            this.inptNewLastName.Location = new System.Drawing.Point(106, 172);
            this.inptNewLastName.Name = "inptNewLastName";
            this.inptNewLastName.Size = new System.Drawing.Size(358, 20);
            this.inptNewLastName.TabIndex = 11;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(63, 123);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(24, 13);
            this.lblNewName.TabIndex = 12;
            this.lblNewName.Text = "Ime";
            // 
            // lblNewLastName
            // 
            this.lblNewLastName.AutoSize = true;
            this.lblNewLastName.Location = new System.Drawing.Point(43, 175);
            this.lblNewLastName.Name = "lblNewLastName";
            this.lblNewLastName.Size = new System.Drawing.Size(44, 13);
            this.lblNewLastName.TabIndex = 13;
            this.lblNewLastName.Text = "Prezime";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(43, 222);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(44, 13);
            this.lblNewPassword.TabIndex = 14;
            this.lblNewPassword.Text = "Lozinka";
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.Location = new System.Drawing.Point(12, 71);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(75, 13);
            this.lblNewUserName.TabIndex = 15;
            this.lblNewUserName.Text = "Korisnicko ime";
            // 
            // btnNewCancel
            // 
            this.btnNewCancel.Location = new System.Drawing.Point(106, 254);
            this.btnNewCancel.Name = "btnNewCancel";
            this.btnNewCancel.Size = new System.Drawing.Size(165, 34);
            this.btnNewCancel.TabIndex = 16;
            this.btnNewCancel.Text = "ZATVORI";
            this.btnNewCancel.UseVisualStyleBackColor = true;
            this.btnNewCancel.Click += new System.EventHandler(this.btnNewCancel_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(299, 254);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(165, 34);
            this.btnNewUser.TabIndex = 17;
            this.btnNewUser.Text = "SPREMI";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // lblNewTitle
            // 
            this.lblNewTitle.AutoSize = true;
            this.lblNewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTitle.Location = new System.Drawing.Point(162, 21);
            this.lblNewTitle.Name = "lblNewTitle";
            this.lblNewTitle.Size = new System.Drawing.Size(145, 25);
            this.lblNewTitle.TabIndex = 18;
            this.lblNewTitle.Text = "Dodaj korisnika";
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 300);
            this.Controls.Add(this.lblNewTitle);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnNewCancel);
            this.Controls.Add(this.lblNewUserName);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblNewLastName);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.inptNewLastName);
            this.Controls.Add(this.inptNewPassword);
            this.Controls.Add(this.inptNewName);
            this.Controls.Add(this.inptNewUserName);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox inptNewUserName;
        public System.Windows.Forms.TextBox inptNewName;
        public System.Windows.Forms.TextBox inptNewPassword;
        public System.Windows.Forms.TextBox inptNewLastName;
        public System.Windows.Forms.Label lblNewName;
        public System.Windows.Forms.Label lblNewLastName;
        public System.Windows.Forms.Label lblNewPassword;
        public System.Windows.Forms.Label lblNewUserName;
        public System.Windows.Forms.Button btnNewCancel;
        public System.Windows.Forms.Button btnNewUser;
        public System.Windows.Forms.Label lblNewTitle;
    }
}