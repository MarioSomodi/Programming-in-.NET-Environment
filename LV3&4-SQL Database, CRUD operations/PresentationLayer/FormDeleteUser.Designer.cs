namespace PresentationLayer
{
    partial class FormDeleteUser
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
            this.lblObrisiKorisnika = new System.Windows.Forms.Label();
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDeleteYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblObrisiKorisnika
            // 
            this.lblObrisiKorisnika.AutoSize = true;
            this.lblObrisiKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObrisiKorisnika.Location = new System.Drawing.Point(78, 35);
            this.lblObrisiKorisnika.Name = "lblObrisiKorisnika";
            this.lblObrisiKorisnika.Size = new System.Drawing.Size(215, 31);
            this.lblObrisiKorisnika.TabIndex = 0;
            this.lblObrisiKorisnika.Text = "Obrisi korisnika?";
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.Location = new System.Drawing.Point(24, 101);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(131, 44);
            this.btnDeleteCancel.TabIndex = 1;
            this.btnDeleteCancel.Text = "ZATVORI";
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // btnDeleteYes
            // 
            this.btnDeleteYes.Location = new System.Drawing.Point(187, 101);
            this.btnDeleteYes.Name = "btnDeleteYes";
            this.btnDeleteYes.Size = new System.Drawing.Size(137, 44);
            this.btnDeleteYes.TabIndex = 2;
            this.btnDeleteYes.Text = "OBRISI";
            this.btnDeleteYes.UseVisualStyleBackColor = true;
            this.btnDeleteYes.Click += new System.EventHandler(this.btnDeleteYes_Click);
            // 
            // FormDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 190);
            this.Controls.Add(this.btnDeleteYes);
            this.Controls.Add(this.btnDeleteCancel);
            this.Controls.Add(this.lblObrisiKorisnika);
            this.Name = "FormDeleteUser";
            this.Text = "FormDeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObrisiKorisnika;
        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDeleteYes;
    }
}