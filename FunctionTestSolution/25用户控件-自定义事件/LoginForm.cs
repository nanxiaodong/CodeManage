using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25用户控件_自定义事件
{
    public delegate void LoginDelegate(object sender, MyEventArgs e);

    public partial class LoginForm : UserControl
    {
        public event LoginDelegate LoginDelegate;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            MyEventArgs myEventArgs = new MyEventArgs();
            myEventArgs.LoginName = this.txtName.Text;
            myEventArgs.LoginPwd = this.txtPwd.Text;
            myEventArgs.Result = false;

            //this指的是btnLogin这个控件
            LoginDelegate(this, myEventArgs);

            if (myEventArgs.Result)
            {
                this.txtName.BackColor = Color.Green;
                this.txtPwd.BackColor = Color.Green;
            }
            else
            {
                this.txtName.BackColor = Color.Red;
                this.txtPwd.BackColor = Color.Red;
            }
        }
    }
    public class MyEventArgs
    {
        public string LoginName { get; set; }
        public string LoginPwd { get; set; }
        public bool Result { get; set; }
    }
}
