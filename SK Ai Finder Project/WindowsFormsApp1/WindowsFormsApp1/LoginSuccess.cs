﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginSuccessForm : Form
    {
        public LoginSuccessForm()
        {
            InitializeComponent();
        }

        private void LoginSuccessForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm1 = new LoginForm();
            frm1.ShowDialog();
        }
    }
}
