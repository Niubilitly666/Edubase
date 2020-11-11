using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edubase
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            frm_SignUp a = new frm_SignUp();
            a.Show();
        }
    }
}
