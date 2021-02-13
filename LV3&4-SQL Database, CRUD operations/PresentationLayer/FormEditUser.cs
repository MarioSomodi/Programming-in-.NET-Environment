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
    public partial class FormEditUser : Form
    {
        private Form mainFormUser = new Form();
        public FormEditUser(int userId, Form mFU)
        {
            mainFormUser = mFU as FormUsers;
            InitializeComponent();
        }

        private UserRepository _userRepository = new UserRepository();
        private BindingSource _tableBindingSource = new BindingSource();
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User oUser = new User()
            {
                UserID = Convert.ToInt32(lblEditUserID.Text),
                UserName = lblEditUserName.Text,
                UserPassword = inptEditPassword.Text,
                UserFirstName = inptEditName.Text,
                UserLastName = inptEditSurname.Text
            };
            _userRepository.UpdateUsers(oUser);
            DataGridView dvg = (DataGridView)this.mainFormUser.Controls[0];
            _tableBindingSource.DataSource = _userRepository.GetUsers();
            dvg.DataSource = _tableBindingSource;
            this.Close();
        }
    }
}
