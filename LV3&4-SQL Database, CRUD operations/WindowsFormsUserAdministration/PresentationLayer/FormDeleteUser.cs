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
    public partial class FormDeleteUser : Form
    {
        private int UserID;
        private Form mainFormUser = new Form();
        public FormDeleteUser(int uID, Form mFU)
        {
            UserID = uID;
            mainFormUser = mFU as FormUsers;
            InitializeComponent();
        }
        private UserRepository _userRepository = new UserRepository();
        private BindingSource _tableBindingSource = new BindingSource();
        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteYes_Click(object sender, EventArgs e)
        {
            _userRepository.DeleteUser(UserID);
            DataGridView dvg = (DataGridView)this.mainFormUser.Controls[0];
            _tableBindingSource.DataSource = _userRepository.GetUsers();
            dvg.DataSource = _tableBindingSource;
            this.Close();
        }
    }
}
