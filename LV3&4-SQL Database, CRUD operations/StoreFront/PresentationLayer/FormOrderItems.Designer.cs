namespace PresentationLayer
{
    partial class FormOrderItems
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
            this.dataGridViewOrderItems = new System.Windows.Forms.DataGridView();
            this.OrderItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemVMProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemVMProductPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemVMUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemVMQuanitity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrderItems
            // 
            this.dataGridViewOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderItemId,
            this.OrderItemVMProductName,
            this.OrderItemVMProductPackage,
            this.OrderItemVMUnitPrice,
            this.OrderItemVMQuanitity});
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(134, 12);
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(544, 426);
            this.dataGridViewOrderItems.TabIndex = 0;
            // 
            // OrderItemId
            // 
            this.OrderItemId.DataPropertyName = "OrderItemVMId";
            this.OrderItemId.HeaderText = "Order item id";
            this.OrderItemId.Name = "OrderItemId";
            // 
            // OrderItemVMProductName
            // 
            this.OrderItemVMProductName.DataPropertyName = "OrderItemVMProductName";
            this.OrderItemVMProductName.HeaderText = "Product name";
            this.OrderItemVMProductName.Name = "OrderItemVMProductName";
            // 
            // OrderItemVMProductPackage
            // 
            this.OrderItemVMProductPackage.DataPropertyName = "OrderItemVMProductPackage";
            this.OrderItemVMProductPackage.HeaderText = "Product package";
            this.OrderItemVMProductPackage.Name = "OrderItemVMProductPackage";
            // 
            // OrderItemVMUnitPrice
            // 
            this.OrderItemVMUnitPrice.DataPropertyName = "OrderItemVMUnitPrice";
            this.OrderItemVMUnitPrice.HeaderText = "Unit price";
            this.OrderItemVMUnitPrice.Name = "OrderItemVMUnitPrice";
            // 
            // OrderItemVMQuanitity
            // 
            this.OrderItemVMQuanitity.DataPropertyName = "OrderItemVMQuantity";
            this.OrderItemVMQuanitity.HeaderText = "Quantity";
            this.OrderItemVMQuanitity.Name = "OrderItemVMQuanitity";
            // 
            // FormOrderItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewOrderItems);
            this.Name = "FormOrderItems";
            this.Text = "FormOrderItems";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemVMProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemVMProductPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemVMUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemVMQuanitity;
    }
}