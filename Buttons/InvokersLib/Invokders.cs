using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvokersLib
{
    public class INVOKERS
    {

        public static void InvokeControlVisible(Control control, bool e)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Visible = e;
                });
            }
            else
            {
                control.Visible = e;
            }
        }

        public static void InvokeTrackerValue(TrackBar control, int value)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Value = value;
                });
            }
            else
            {
                control.Value = value;
            }
        }

        public static void InvokeTrackerMaximum(TrackBar control, int value)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Maximum = value;
                });
            }
            else
            {
                control.Maximum = value;
            }
        }

        public static void InvokeTrackerMinimum(TrackBar control, int value)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Minimum = value;
                });
            }
            else
            {
                control.Minimum = value;
            }
        }

        public static void InvokeControlEnable(Control control, bool e)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Enabled = e;
                });
            }
            else
            {
                control.Enabled = e;
            }
        }


        public static void InvokeControlForeColor(Control control, Color color)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.ForeColor = color;
                });
            }
            else
            {
                control.ForeColor = color;
            }
        }

        public static void InvokeControlBackColor(Control control, Color color)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.BackColor = color;
                });
            }
            else
            {
                control.BackColor = color;
            }
        }

        public static void InvokeControlText<T>(Control control, T e)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Text = e.ToString();
                });
            }
            else
            {
                control.Text = e.ToString();
            }
        }

        public static void InvokeControlAddListItem<T>(ListBox control, T e)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Items.Add(e.ToString());
                });
            }
            else
            {
                control.Items.Add(e.ToString());
            }
        }

        
        public static void InvokeControlAddListBoxClear(ListBox control)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Items.Clear();
                });
            }
            else
            {
                control.Items.Clear();
            }
        }

        public static void InvokeControlRemoveAtListItem(ListBox control, int e)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Items.RemoveAt(e);
                });
            }
            else
            {
                control.Items.RemoveAt(e);
            }
        }


        public static void InvokeTextboxScrollToCaret(TextBox control)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.ScrollToCaret();
                });
            }
            else
            {
                control.ScrollToCaret();
            }
        }


        public static void InvokeControlSelectionStart(TextBox control, int length)
        {

            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.SelectionStart = length;
                });
            }
            else
            {
                control.SelectionStart = length;
            }
        }

        public static void InvokeControlAppendText(Control control, string e)
        {

            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Text += e;
                });
            }
            else
            {
                control.Text += e;
            }
        }
        public static void InvokeControlText(Control control, string e)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Text = e;
                });
            }
            else
            {
                control.Text = e;
            }
        }

        public static void InvokeControlSelectedIndex(ComboBox control, int index)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    control.BeginInvoke((MethodInvoker)delegate ()
                    {
                        control.SelectedIndex = index;
                    });
                }
                else
                {
                    control.SelectedIndex = index;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                    
            }

        }

    }
}
