using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25用户控件_自定义事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginForm1.LoginDelegate += loginForm1_LoginDelegate;
        }

        void loginForm1_LoginDelegate(object sender, MyEventArgs e)
        {
            if (e.LoginName == "admin" && e.LoginPwd == "123456")
            {
                e.Result = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm1.LoginDelegate+=loginForm1_LoginDelegate;
        }
    }
}
