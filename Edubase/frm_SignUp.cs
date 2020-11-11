using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace Edubase
{
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            #region 验证输入
            if (this.txb_UserNo.Text.Trim() == "")
            {
                MessageBox.Show("用户号不能为空！");
                this.txb_UserNo.Focus();
                return;
            }
            if (this.txb_Password.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空！");
                this.txb_Password.Focus();
                return;
            }
            #endregion
            string commandText =
                $@"INSERT tb_User(No,Password)
					VALUES
					('{this.txb_UserNo.Text.Trim()}','{this.txb_Password.Text.Trim()}');";
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected = sqlHelper.QuickSubmit(commandText);
            if (rowAffected == 1)
            {
                MessageBox.Show("注册成功。");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
        }
    }
}
