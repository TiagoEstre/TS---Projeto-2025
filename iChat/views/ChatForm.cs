using iChat.controller;
using iChat.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iChat.views
{
    public partial class ChatForm : Form
    {
        private User selectUser;

        public ChatForm()
        {
            InitializeComponent();
            User();
        }

        private void User()
        {
            
            var currencyManager = sessionManager.CurrentUser;

            b_User.Text = currencyManager.Name;

            using(var db = new iChatContext())
            {
                var listUser = db.Users
                    .Where(l => l.Id != currencyManager.Id)
                    .ToList();



                lb_Users.DataSource = listUser;
                lb_Users.DisplayMember = "Name";
                lb_Users.ValueMember = "Id";
                lb_Users.ClearSelected();
            }
        }

        private void lb_Users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
