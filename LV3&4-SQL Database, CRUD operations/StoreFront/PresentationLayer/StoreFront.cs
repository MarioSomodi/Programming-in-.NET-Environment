using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;

namespace PresentationLayer
{
    public partial class StoreFront : Form
    {
        private BindingSource _tableBindingSourceCustomers = new BindingSource();
        private BindingSource _tableBindingSourceOrders = new BindingSource();
        private BindingSource _tableBindingSourceOrderItems = new BindingSource();
        private BindingSource _tableBindingSourceProducts = new BindingSource();
        private BindingSource _tableBindingSourceSuppliers = new BindingSource();
        private DBRepository _DBRepository = new DBRepository();
        public StoreFront()
        {
            InitializeComponent();
            _tableBindingSourceCustomers.DataSource = _DBRepository.GetCustomers();
            _tableBindingSourceOrders.DataSource = _DBRepository.GetOrdersToDisplay();
            _tableBindingSourceProducts.DataSource = _DBRepository.GetProductsToDisplay();
            _tableBindingSourceSuppliers.DataSource = _DBRepository.GetSuppliers();
        }

        private void StoreFront_Load(object sender, EventArgs e)
        {
            dataGridViewCustomers.DataSource = _tableBindingSourceCustomers;
            dataGridViewOrders.DataSource = _tableBindingSourceOrders;
            dataGridViewProducts.DataSource = _tableBindingSourceProducts;
            dataGridViewSuppliers.DataSource = _tableBindingSourceSuppliers;
            DataGridViewImageColumn oInspectButton = new DataGridViewImageColumn();
            oInspectButton.Image = Image.FromFile("D:/Faks/Programiranje_u_NET_okolini/Laboratorijske_Vjezbe/LV3-4/StoreFront/icons/inspect.png");
            oInspectButton.Width = 20;
            oInspectButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrders.Columns.Add(oInspectButton);
            dataGridViewOrders.Columns[5].Name = "View Items";
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewOrders.Rows[e.RowIndex].Selected = true;
            if (dataGridViewOrders.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                int orderId = Convert.ToInt32(dataGridViewOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
                _tableBindingSourceOrderItems.DataSource = _DBRepository.GetOrderItemsOfOrder(orderId);
                FormOrderItems formOrderItems = new FormOrderItems(_tableBindingSourceOrderItems);
                formOrderItems.Show();
            }
        }
    }
}
