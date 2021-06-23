using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSkinLib
{
    public class ColorCheckBox : Button
    {
        object m_lock = new object();
        
        bool m_isEnter = false;
        bool m_checked = false;
        bool m_checkedState = false;
        bool m_enable = true;
        bool m_disableButtonExists = false;
        public static string BaseDir;
        IButton pButton = null;
        BUTTON_NAME m_btnName = BUTTON_NAME.NONAME;
        Color NormalColor;
        Color EnterColor;
        Color PressColor;
        Color DisableColor;
        public ColorCheckBox()
        {
            InitColors();
        }

        public ColorCheckBox(BUTTON_NAME btnName)
        {
            m_btnName = btnName;
            InitColors();
        }

        void InitColors()
        {
            NormalColor = Color.LightGray;
            EnterColor = Color.FromArgb(255, 238, 179);// Color.LightBlue;
            PressColor = Color.FromArgb(255, 216, 79);// Color.LightSkyBlue;
            DisableColor = Color.Gray;
        }
        public void SetPressColor(Color c)
        {
            PressColor = c;
        }
        public void SetEnterColor(Color c)
        {
            EnterColor = c;
        }
        public void SetNormalColor(Color c)
        {
            NormalColor = c;
        }
        public void InitColors(Color normal, Color enter, Color press, Color disable)
        {
            NormalColor = normal;
            EnterColor = enter;
            PressColor = press;
            DisableColor = disable;
        }

        string m_btnText;
        public void Setup(BUTTON_NAME buttonName , IButton p, string name = "")
        {
            pButton = p;
            m_btnText = name;
            m_btnName = buttonName;
            this.BackColor = NormalColor;
            this.MouseEnter += SkinCheckBox_MouseEnter;
            this.MouseLeave += SkinCheckBox_MouseLeave;
            this.MouseDown += SkinCheckBoxButton_MouseDown;
            this.MouseUp += SkinCheckBoxButton_MouseUp;
        }
        bool m_doubleClick = false;
        public void SetDoubleClickEvent()
        {
            m_doubleClick = true;
        }
        
        private void SkinCheckBoxButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (pButton == null)
                return;
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1)
                    pButton.NotifyDown(m_btnName, m_btnText);
                else if (m_doubleClick == true && e.Clicks == 2)
                {
                    pButton.NotifyDoubleClick(m_btnName, m_btnText);
                }
            }        

        }

        private void SkinCheckBoxButton_MouseUp(object sender, MouseEventArgs e)
        {

            if (pButton == null)
                return;
            if (e.Button == MouseButtons.Left)
            {
                pButton.NotifyUp(m_btnName, m_btnText);
            }

        }
        public void UpdateText(string name)
        {
            this.Text = name;
        }
                  
        private void SkinCheckBox_MouseLeave(object sender, EventArgs e)
        {
            onEnter = false;
  
        }

        public void Toggle(Action<bool> cb)
        {
            if (m_enable == false) return;

            m_checked = !m_checked;            
            Checked(m_checked);
            cb(m_checked);
        }

        public void Toggle()
        {
            if (m_enable == false) return;

            m_checked = !m_checked;
            Checked(m_checked);
        }

        private void SkinCheckBox_MouseEnter(object sender, EventArgs e)
        {
            onEnter = true;
        }

        public bool onEnter
        {
            set
            {
                if (m_enable == false) return;
                m_isEnter = value;   
                if (m_isEnter == true && m_checked == false)
                {                    
                    this.BackColor = EnterColor;
                }
                if (m_isEnter == false && m_checked == false)
                {                    
                    this.BackColor = NormalColor;
                }
            }
        }
        public void Checked(bool c, Action<bool> cb)
        {
            m_checkedState = c;
            if (m_enable == false) return;
            m_checked = c;
            if (m_checked == true)
            {
                this.BackColor = PressColor;
            }
            else
            {
                if (m_isEnter == false)
                {                     
                    this.BackColor = EnterColor;                    
                }
                else
                {
                    this.BackColor = EnterColor;
                }
            }
            if (cb != null)
                cb(m_checked);
             
        }

        public bool GetChecked()
        {
            return m_checked;
        }
      
        public void Checked(bool c)
        {
            m_checkedState = c;
            if (m_enable == false) return;
            m_checked = c;
            if (c)
            {
                 this.BackColor = PressColor;
            }
            else
            {
                if (m_isEnter == false)
                {
                     this.BackColor = NormalColor;
                }
                else
                {
                     this.BackColor = EnterColor;
                }
            }           
        }
        /*
        public void Toggle()
        {

            if (m_enable == false) return;
            m_checked = !m_checked;
            if (m_checked)
            {
                GuiBackground.CreateControlRegion(this, bmp[Common.DOWN], GuiBackground.WITH_AS.IMAGE);
            }
            else
            {
                if (m_isEnter == false)
                    GuiBackground.CreateControlRegion(this, bmp[Common.LEAVE], GuiBackground.WITH_AS.IMAGE);
                else
                    GuiBackground.CreateControlRegion(this, bmp[Common.ENTER], GuiBackground.WITH_AS.IMAGE);
            }
        }
        */
        /*
        public void Toggle(Action<bool> cb)
        {

            if (m_enable == false) return;
            m_checked = !m_checked;
            if (m_checked)
            {
                GuiBackground.CreateControlRegion(this, bmp[Common.DOWN], GuiBackground.WITH_AS.IMAGE);
            }
            else
            {
                if (m_isEnter == false)
                    GuiBackground.CreateControlRegion(this, bmp[Common.LEAVE], GuiBackground.WITH_AS.IMAGE);
                else
                    GuiBackground.CreateControlRegion(this, bmp[Common.ENTER], GuiBackground.WITH_AS.IMAGE);
            }
            cb(m_checked);
        }
        */
        public void Normal()
        {
            if (m_enable == true)
            {
                 this.BackColor = NormalColor;
            }
        }

        public bool IsEnable()
        {
            return m_enable;
        }
        public void Enable(bool b)
        {
            if (m_disableButtonExists == false)
                return;
            m_enable = b;
            if (b == false)
            {
                this.BackColor = DisableColor;
            }
            else
            {
                if (m_checked == false && m_checkedState == true)
                    m_checked = m_checkedState;

                if (m_isEnter == false && m_checked == false)
                    this.BackColor = NormalColor;
                if (m_isEnter == true && m_checked == false)
                    this.BackColor = EnterColor;
                if (m_checked == true)
                {
                    this.BackColor = PressColor;
                }
            }           
        }
        private System.Windows.Forms.Label label;
        public Size m_LabelSizePixel = new Size(40, 20);
        public void AddLabel(Color color, int x, int y, string font, int fontSize, string text)
        {
            label = new Label();
            label.AutoSize = true;
            Font fnt = new Font("Arial", fontSize);
            label.Font = fnt;
            label.BackColor = System.Drawing.Color.Transparent;
            label.ForeColor = color;
            label.Location = new System.Drawing.Point(x, y);
            label.Name = "label1";
            label.Size = m_LabelSizePixel;// new System.Drawing.Size(35, 13);
            label.TabIndex = 10;
            label.Text = text;
            this.Controls.Add(label);
            label.BringToFront();
            //label.MouseDown += Label_MouseDown;
            //label.MouseEnter += Label_MouseEnter;
            //label.MouseLeave += Label_MouseLeave;
            //label.MouseUp += Label_MouseUp;
        }
    }
}
