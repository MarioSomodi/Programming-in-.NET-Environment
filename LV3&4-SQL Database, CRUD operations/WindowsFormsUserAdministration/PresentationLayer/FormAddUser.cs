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
    public partial class FormAddUser : Form
    {
        private Form mainFormUser = new Form();
        public FormAddUser(Form mFU)
        {
            mainFormUser = mFU as FormUsers;
            InitializeComponent();
        }
        private UserRepository _userRepository = new UserRepository();
        private BindingSource _tableBindingSource = new BindingSource();
        private void btnNewCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            User oUser = new User()
            {
                UserID = 1,
                UserName = inptNewUserName.Text,
                UserPassword = inptNewPassword.Text,
                UserFirstName = inptNewName.Text,
                UserLastName = inptNewLastName.Text
            };
            _userRepository.AddUser(oUser);
            DataGridView dvg = (DataGridView)this.mainFormUser.Controls[0];
            _tableBindingSource.DataSource = _userRepository.GetUsers();
            dvg.DataSource = _tableBindingSource;
            this.Close();
        }
    }
}
