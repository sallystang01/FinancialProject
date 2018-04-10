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
    public partial class ExitConf : Form
    {
        public ExitConf()
        {
            InitializeComponent();
           
        }

        public void btnYes_Click(object sender, EventArgs e)
        {
            //Exits application
            Application.Exit();
        }

        public void btnNo_Click(object sender, EventArgs e)
        {
            //Closes confirmation and returns to form previously opened
            this.Close();
        }
    }
}
