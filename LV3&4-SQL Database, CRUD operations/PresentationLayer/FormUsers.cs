using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
            _tableBindingSource.DataSource = _userRepository.GetUsers();
        }
        private BindingSource _tableBindingSource = new BindingSource();
        private UserRepository _userRepository = new UserRepository();

        private void FormUsers_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();
            oEditButton.Image = Image.FromFile("D:/Faks/Programiranje_u_NET_okolini/Laboratorijske_Vjezbe/LV3-4/WindowsFormsUserAdministration/icons/update.png");
            oEditButton.Width = 20;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewUsers.Columns.Add(oEditButton);
            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("D:/Faks/Programiranje_u_NET_okolini/Laboratorijske_Vjezbe/LV3-4/WindowsFormsUserAdministration/icons/delete.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewUsers.Columns.Add(oDeleteButton);
            DataGridViewUsers.AutoGenerateColumns = false;
            DataGridViewUsers.DataSource = _tableBindingSource;
        }
        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewUsers.Rows[e.RowIndex].Selected = true;
            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                int userId = Convert.ToInt32(DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormEditUser FormEditUser = new FormEditUser(userId, this);
                FormEditUser.lblEditUserID.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormEditUser.lblEditUserName.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditUser.inptEditPassword.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditUser.inptEditName.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormEditUser.inptEditSurname.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                FormEditUser.Show();
            }
            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                int userId = Convert.ToInt32(DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormDeleteUser FormDeleteUser = new FormDeleteUser(userId, this);
                FormDeleteUser.Show();
            }
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oProgramu() 
        {
            MessageBox.Show("Created by Mario Somodi \nVersion 1.0 \nYear : 2020");
        }

        private void oProgramuButton_Click(object sender, EventArgs e)
        {
            oProgramu();
        }

        private void dodajNovogKorisnika_Click(object sender, EventArgs e)
        {
            FormAddUser FormAddUser = new FormAddUser(this);
            FormAddUser.Show();
        }

        private void oProgramuDesnikKlik_Click(object sender, EventArgs e)
        {
            oProgramu();
        }

        private void exitApplicationRightClick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
