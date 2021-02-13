namespace PresentationLayer
{
    partial class StoreFront
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageNarudzbe = new System.Windows.Forms.TabPage();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.tabPageKupci = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageProizvodi = new System.Windows.Forms.TabPage();
            this.tabPageDobavljaci = new System.Windows.Forms.TabPage();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.ProductVMId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNamesd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductVMUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIsDiscountinued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierComapnyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTabControl.SuspendLayout();
            this.tabPageNarudzbe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPageKupci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabPageProizvodi.SuspendLayout();
            this.tabPageDobavljaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPageNarudzbe);
            this.mainTabControl.Controls.Add(this.tabPageKupci);
            this.mainTabControl.Controls.Add(this.tabPageProizvodi);
            this.mainTabControl.Controls.Add(this.tabPageDobavljaci);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(857, 455);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPageNarudzbe
            // 
            this.tabPageNarudzbe.Controls.Add(this.dataGridViewOrders);
            this.tabPageNarudzbe.Location = new System.Drawing.Point(4, 22);
            this.tabPageNarudzbe.Name = "tabPageNarudzbe";
            this.tabPageNarudzbe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNarudzbe.Size = new System.Drawing.Size(849, 429);
            this.tabPageNarudzbe.TabIndex = 0;
            this.tabPageNarudzbe.Text = "Narudzbe";
            this.tabPageNarudzbe.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderDate,
            this.OrderNumber,
            this.OrderCustomerId,
            this.OrderTotalAmount});
            this.dataGridViewOrders.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(598, 423);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // tabPageKupci
            // 
            this.tabPageKupci.Controls.Add(this.dataGridViewCustomers);
            this.tabPageKupci.Location = new System.Drawing.Point(4, 22);
            this.tabPageKupci.Name = "tabPageKupci";
            this.tabPageKupci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKupci.Size = new System.Drawing.Size(849, 429);
            this.tabPageKupci.TabIndex = 1;
            this.tabPageKupci.Text = "Kupci";
            this.tabPageKupci.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.City,
            this.Country,
            this.Phone});
            this.dataGridViewCustomers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(643, 423);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "CustomerId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "CustomerFirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "CustomerLastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // City
            // 
            this.City.DataPropertyName = "CustomerCity";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Country
            // 
            this.Country.DataPropertyName = "CustomerCountry";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "CustomerPhone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // tabPageProizvodi
            // 
            this.tabPageProizvodi.Controls.Add(this.dataGridViewProducts);
            this.tabPageProizvodi.Location = new System.Drawing.Point(4, 22);
            this.tabPageProizvodi.Name = "tabPageProizvodi";
            this.tabPageProizvodi.Size = new System.Drawing.Size(849, 429);
            this.tabPageProizvodi.TabIndex = 2;
            this.tabPageProizvodi.Text = "Proizvodi";
            this.tabPageProizvodi.UseVisualStyleBackColor = true;
            // 
            // tabPageDobavljaci
            // 
            this.tabPageDobavljaci.Controls.Add(this.dataGridViewSuppliers);
            this.tabPageDobavljaci.Location = new System.Drawing.Point(4, 22);
            this.tabPageDobavljaci.Name = "tabPageDobavljaci";
            this.tabPageDobavljaci.Size = new System.Drawing.Size(849, 429);
            this.tabPageDobavljaci.TabIndex = 3;
            this.tabPageDobavljaci.Text = "Dobavljaci";
            this.tabPageDobavljaci.UseVisualStyleBackColor = true;
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderVMId";
            this.OrderId.HeaderText = "Id";
            this.OrderId.Name = "OrderId";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderVMDate";
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderVMNumber";
            this.OrderNumber.HeaderText = "Order Number";
            this.OrderNumber.Name = "OrderNumber";
            // 
            // OrderCustomerId
            // 
            this.OrderCustomerId.DataPropertyName = "OrderVMCustomerFullName";
            this.OrderCustomerId.HeaderText = "Customer Full Name";
            this.OrderCustomerId.Name = "OrderCustomerId";
            // 
            // OrderTotalAmount
            // 
            this.OrderTotalAmount.DataPropertyName = "OrderVMTotalAmount";
            this.OrderTotalAmount.HeaderText = "Total Amount";
            this.OrderTotalAmount.Name = "OrderTotalAmount";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductVMId,
            this.ProductNamesd,
            this.ProductSupplier,
            this.ProductVMUnitPrice,
            this.ProductPackage,
            this.ProductIsDiscountinued});
            this.dataGridViewProducts.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(645, 423);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // ProductVMId
            // 
            this.ProductVMId.DataPropertyName = "ProductVMId";
            this.ProductVMId.HeaderText = "Id";
            this.ProductVMId.Name = "ProductVMId";
            // 
            // ProductNamesd
            // 
            this.ProductNamesd.DataPropertyName = "ProductVMName";
            this.ProductNamesd.HeaderText = "Name";
            this.ProductNamesd.Name = "ProductNamesd";
            // 
            // ProductSupplier
            // 
            this.ProductSupplier.DataPropertyName = "ProductVMSupplierName";
            this.ProductSupplier.HeaderText = "Supplier name";
            this.ProductSupplier.Name = "ProductSupplier";
            // 
            // ProductVMUnitPrice
            // 
            this.ProductVMUnitPrice.DataPropertyName = "ProductVMUnitPrice";
            this.ProductVMUnitPrice.HeaderText = "Unit price";
            this.ProductVMUnitPrice.Name = "ProductVMUnitPrice";
            // 
            // ProductPackage
            // 
            this.ProductPackage.DataPropertyName = "ProductVMPackage";
            this.ProductPackage.HeaderText = "Package";
            this.ProductPackage.Name = "ProductPackage";
            // 
            // ProductIsDiscountinued
            // 
            this.ProductIsDiscountinued.DataPropertyName = "ProductVMIsDiscontinued";
            this.ProductIsDiscountinued.HeaderText = "Is Discontinued";
            this.ProductIsDiscountinued.Name = "ProductIsDiscountinued";
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierID,
            this.SupplierComapnyName,
            this.ContactName,
            this.ContactTitle,
            this.SupplierCity,
            this.SupplierCountry,
            this.SupplierPhone,
            this.SupplierFax});
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(843, 423);
            this.dataGridViewSuppliers.TabIndex = 0;
            // 
            // SupplierID
            // 
            this.SupplierID.DataPropertyName = "SupplierId";
            this.SupplierID.HeaderText = "Id";
            this.SupplierID.Name = "SupplierID";
            // 
            // SupplierComapnyName
            // 
            this.SupplierComapnyName.DataPropertyName = "SupplierCompanyName";
            this.SupplierComapnyName.HeaderText = "Company name";
            this.SupplierComapnyName.Name = "SupplierComapnyName";
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "SupplierContactName";
            this.ContactName.HeaderText = "Contact name";
            this.ContactName.Name = "ContactName";
            // 
            // ContactTitle
            // 
            this.ContactTitle.DataPropertyName = "SupplierContactTitle";
            this.ContactTitle.HeaderText = "Contact title";
            this.ContactTitle.Name = "ContactTitle";
            // 
            // SupplierCity
            // 
            this.SupplierCity.DataPropertyName = "SupplierCity";
            this.SupplierCity.HeaderText = "City";
            this.SupplierCity.Name = "SupplierCity";
            // 
            // SupplierCountry
            // 
            this.SupplierCountry.DataPropertyName = "SupplierCountry";
            this.SupplierCountry.HeaderText = "Country";
            this.SupplierCountry.Name = "SupplierCountry";
            // 
            // SupplierPhone
            // 
            this.SupplierPhone.DataPropertyName = "SupplierPhone";
            this.SupplierPhone.HeaderText = "Phone";
            this.SupplierPhone.Name = "SupplierPhone";
            // 
            // SupplierFax
            // 
            this.SupplierFax.DataPropertyName = "SupplierFax";
            this.SupplierFax.HeaderText = "Fax";
            this.SupplierFax.Name = "SupplierFax";
            // 
            // StoreFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 458);
            this.Controls.Add(this.mainTabControl);
            this.Name = "StoreFront";
            this.Text = "StoreFront";
            this.Load += new System.EventHandler(this.StoreFront_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabPageNarudzbe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabPageKupci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabPageProizvodi.ResumeLayout(false);
            this.tabPageDobavljaci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPageNarudzbe;
        private System.Windows.Forms.TabPage tabPageKupci;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.TabPage tabPageProizvodi;
        private System.Windows.Forms.TabPage tabPageDobavljaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTotalAmount;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductVMId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNamesd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductVMUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIsDiscountinued;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierComapnyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierFax;
    }
}

