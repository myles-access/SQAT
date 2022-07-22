using System;
using System.Windows.Forms;

namespace SQAT
{
    public partial class passwordGate : Form
    {
        #region VARS
        private readonly string password = "LiftFix";
        private readonly bool bypass = true;
        #endregion

        public passwordGate()
        {
            InitializeComponent();

            //set to true to bypass password gate 
            if (bypass)
            {
                AdminPanel aP = new AdminPanel();
              //  aP.Show();
                tbPass.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == password || bypass)
            {
                AdminPanel aP = new AdminPanel();
                this.Hide();
                aP.Show();
            }
            else
            {
                MessageBox.Show("Password is incorrect");
                tbPass.Text = "";
            }
        }

        public void CloseFormMethod()
        {
            this.Close();
        }
    }
}