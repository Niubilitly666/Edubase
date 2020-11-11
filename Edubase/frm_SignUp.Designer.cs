namespace Edubase
{
    partial class frm_SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_UserNo = new System.Windows.Forms.Label();
            this.txb_UserNo = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Hint = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_UserNo
            // 
            this.lbl_UserNo.AutoSize = true;
            this.lbl_UserNo.Location = new System.Drawing.Point(102, 96);
            this.lbl_UserNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserNo.Name = "lbl_UserNo";
            this.lbl_UserNo.Size = new System.Drawing.Size(67, 15);
            this.lbl_UserNo.TabIndex = 3;
            this.lbl_UserNo.Text = "用户号：";
            // 
            // txb_UserNo
            // 
            this.txb_UserNo.Location = new System.Drawing.Point(196, 93);
            this.txb_UserNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_UserNo.Name = "txb_UserNo";
            this.txb_UserNo.Size = new System.Drawing.Size(132, 25);
            this.txb_UserNo.TabIndex = 4;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(102, 165);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(52, 15);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "密码：";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(196, 155);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(132, 25);
            this.txb_Password.TabIndex = 6;
            // 
            // lbl_Hint
            // 
            this.lbl_Hint.AutoSize = true;
            this.lbl_Hint.Location = new System.Drawing.Point(171, 217);
            this.lbl_Hint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Hint.Name = "lbl_Hint";
            this.lbl_Hint.Size = new System.Drawing.Size(157, 15);
            this.lbl_Hint.TabIndex = 7;
            this.lbl_Hint.Text = "请输入新用户号、密码";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(196, 261);
            this.btn_SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(100, 29);
            this.btn_SignUp.TabIndex = 8;
            this.btn_SignUp.Text = " 注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.lbl_Hint);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txb_UserNo);
            this.Controls.Add(this.lbl_UserNo);
            this.Name = "frm_SignUp";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserNo;
        private System.Windows.Forms.TextBox txb_UserNo;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lbl_Hint;
        private System.Windows.Forms.Button btn_SignUp;
    }
}