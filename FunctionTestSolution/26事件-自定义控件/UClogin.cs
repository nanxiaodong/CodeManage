using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26事件_自定义控件
{
    public partial class UClogin : UserControl
    {
        public delegate void LoginDelegate(object sender, MyEventArgs e);
        public delegate void CheckDelegate();
        public UClogin()
        {
            InitializeComponent();
        }
        //定义事件
        public event LoginDelegate MyLoginDelegate;
        //定义委托变量
        public CheckDelegate MyCheckDelegate;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MyEventArgs myEventArgs = new MyEventArgs();
            myEventArgs.LoginName = this.txtLoginName.Text;
            myEventArgs.LoginPwd = this.txtPwd.Text;
            myEventArgs.Result = false;

            //this指的是btnLogin这个控件
            MyLoginDelegate(this, myEventArgs);

            if (myEventArgs.Result)
            {
                this.txtLoginName.BackColor = Color.Green;
                this.txtPwd.BackColor = Color.Green;
            }
            else
            {
                this.txtLoginName.BackColor = Color.Red;
                this.txtPwd.BackColor = Color.Red;
            }
        }
        public class MyEventArgs
        {
            public string LoginName { get; set; }
            public string LoginPwd { get; set; }
            public bool Result { get; set; }
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
           if(MyCheckDelegate!=null)
           {
               MyCheckDelegate();
           }
        }
    }
}
