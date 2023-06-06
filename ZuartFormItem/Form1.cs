using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZuartControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZuartFormItem
{
    public partial class Form1 : Form
    {
        ZuartControl.ZuartControl zuartControl1 = null;
        public Form1()
        {
            zuartControl1 = new ZuartControl.ZuartControl();
            //zuartControl1.Show();
            Form form = new Form();
            form.Size = zuartControl1.Size;
            form.Width = form.Width * 2;
            form.Text = "串口设置";
            form.Controls.Add(zuartControl1);
            zuartControl1.Location = new Point(0, 0);
            zuartControl1.Dock = DockStyle.Left;
            form.Show();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            form.Left = 0;
            this.Left = form.Size.Width + 100;
            if (zuartControl1 != null)
                zuartControl1.ComDataReceivedProperties += new System.EventHandler<ZuartControl.ZuartControl.ComData_EventArgs>(this.zuartControl1_ComDataReceived);


        }

        public Form1(ZuartControl.ZuartControl _zuartControl)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            zuartControl1 = _zuartControl;
            if (zuartControl1 != null)
                zuartControl1.ComDataReceivedProperties += new System.EventHandler<ZuartControl.ZuartControl.ComData_EventArgs>(this.zuartControl1_ComDataReceived);


        }
        private void zuartControl1_ComDataReceived(object sender, ZuartControl.ZuartControl.ComData_EventArgs e)
        {
            byte[] data = e.data;
            string str = e.recived_string;

        }
    }
}
