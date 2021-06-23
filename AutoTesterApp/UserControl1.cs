using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnLib;

namespace WindowsFormsApp4
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            AppSettings.Instance.Load("DataBase.json");
            AppSettings.Instance.Default();


        }
        public void Setup(TESTINFO testInfo)
        {
            label1.Text = testInfo.testName;
            textBox1.Text = testInfo.lowThreshold.ToString();
            textBox2.Text = testInfo.highThreshold.ToString();
            textBox3.Text = string.Empty;

        }
    }
}
