using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQAT
{
    public partial class passwordGate : Form
    {
        //VARS
        private readonly string password = "LiftFix";

        public passwordGate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == password)
            {
                this.Hide();
                AdminPanel aP = new AdminPanel();
                aP.Show();
            }
            else
            {
                MessageBox.Show("Password is incorrect");
            }
        }

        public void CloseFormMethod()
        {
            this.Close();
        }

    }
}
