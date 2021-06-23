using DBConnLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScroll = true;

            UserControl1 c = null;
            AppSettings.Instance.Load("DataBase.json");
            for (int i = 0; i < AppSettings.Instance.Config.tests.Count; i++)
            {
                c = new UserControl1();
                c.Location = new Point(0, i * c.Height);
                c.Setup(AppSettings.Instance.Config.tests[i]);
                panel1.Controls.Add(c);
            }

            this.Width = c.Width + 20;
            panel1.Width = c.Width;
        }
    }
}
