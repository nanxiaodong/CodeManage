using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26事件_自定义控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uClogin1.MyLoginDelegate += uClogin1_MyLoginDelegate;
            uClogin1.MyCheckDelegate = uClogin1_MyCheckDelegate;
        }
        private void uClogin1_MyCheckDelegate()
        {
            MessageBox.Show("这是委托调用方法！");
        }

        void uClogin1_MyLoginDelegate(object sender, UClogin.MyEventArgs e)
        {
            if (e.LoginName == "admin" && e.LoginPwd == "123456")
            {
                e.Result = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uClogin1.MyLoginDelegate += uClogin1_MyLoginDelegate;
            uClogin1.MyCheckDelegate();
        }
    }
}
