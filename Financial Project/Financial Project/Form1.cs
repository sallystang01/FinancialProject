using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_Project
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        private void btnCompound_Click(object sender, EventArgs e)
        {
            //Hides this form to prevent application from exiting
            //Hides this form, opens Compound form for the compound calculator

            Compound frmComp = new Compound();
            this.Hide();
            frmComp.Show();

        }

        private void btnMortgage_Click(object sender, EventArgs e)
        {
            //Hides this form to prevent application from exiting
            //Hides this form, opens Mortgage form for the mortgage calculator

            Mortgage frmMort = new Mortgage();
            this.Hide();
            frmMort.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            ExitConf frmExit = new ExitConf();
            frmExit.Show();
            
        }
    }
}
