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
    public class ColorButton : ButtonEx
    {
        bool m_enable = true;
        Bitmap[] bmp = new Bitmap[4];
        bool m_enableButtonExists = false;
        ACTIONS m_state;
        bool m_forePress = false;
        BUTTON_NAME m_btnName;
        private static string m_dir;
        IButton pButton = null;

        Color DisableColor;
        Color NormalColor;
        Color EnterColor;
        Color PressColor;
        public ColorButton(BUTTON_NAME name)
        {
            m_btnName = name;
            InitColors();
        }
        public ColorButton()
        {
            InitColors();
        }
        public void InitColors()
        {
            NormalColor = Color.LightGray;
            EnterColor = Color.FromArgb(255, 238, 179);// Color.LightBlue;
            PressColor = Color.FromArgb(255, 216 , 79);// Color.LightSkyBlue;
            DisableColor = Color.Gray;
        }

        public void InitColors(Color normal , Color enter, Color press , Color disable)
        {
            NormalColor = normal;
            EnterColor = enter;
            PressColor = press;
            DisableColor = disable;
        }

        public static void BaseDir(string b)
        {
            m_dir = b;
        }
        bool m_doubleClick = false;
        public void SetDoubleClickEvent()
        {
            m_doubleClick = true;
        }

        public void Setup(BUTTON_NAME buttonName, IButton p,string name = "")
        {
            pButton = p;
            if (name != string.Empty)
                this.Text = name;
            this.BackColor = NormalColor;
            m_state = ACTIONS.LEAVE;
            m_btnName = buttonName;
            this.MouseDown += SkinButton_MouseDown;
            this.MouseEnter += SkinButton_MouseEnter;
            this.MouseLeave += SkinButton_MouseLeave;
            this.MouseUp += SkinButton_MouseUp;

        }
        
        public void UpdateText(string name)
        {
            this.Text = name;
        }
        public void SetForeColor(Color color)
        {
            this.ForeColor = color;
        }
       
        private void SkinButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (m_enable == false) return;
             
            this.BackColor = EnterColor;             

            m_state = ACTIONS.UP;
            if (pButton != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pButton.NotifyUp(m_btnName);
                }
            }

        }

        private void SkinButton_MouseLeave(object sender, EventArgs e)
        {
            if (m_enable == false) return;
            if (m_forePress == true) return;
             
            this.BackColor = NormalColor;
             
            m_state = ACTIONS.LEAVE;
        }

        private void SkinButton_MouseEnter(object sender, EventArgs e)
        {
            if (m_enable == false) return;
            if (m_forePress == true) return;             
            this.BackColor = EnterColor;             
            m_state = ACTIONS.ENTER;
        }

        private void SkinButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (m_enable == false) return;
            if (m_forePress == true) return;            
            this.BackColor = PressColor;
            
            m_state = ACTIONS.DOWN;
            
            if (pButton != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (e.Clicks == 1)
                    {
                        pButton.NotifyDown(m_btnName);
                    }
                    else if (m_doubleClick == true && e.Clicks == 2)
                    {
                        pButton.NotifyDoubleClick(m_btnName);
                    }
                }
            }            
        }

        public bool IsEnable()
        {
            return m_enable;
        } 
        public void Enable(bool b)
        {
            m_enable = b;
            this.Enabled = b;
            if (b == false)
            {                
                this.BackColor = DisableColor;
                m_state = ACTIONS.DISABLE;
            }
            else
            {
                if (m_state == ACTIONS.LEAVE)
                {                     
                    this.BackColor = NormalColor;
                }
                else
                if (m_state == ACTIONS.ENTER)
                { 
                   this.BackColor = EnterColor;
                }
                else
                {
                    
                   this.BackColor = NormalColor;
                }
                 
            }
        }

        public void PressState()
        {
            this.BackColor = PressColor;
            m_state = ACTIONS.DOWN;
        }

        public void EnterState()
        {

            this.BackColor = EnterColor;
            m_state = ACTIONS.ENTER;
        }
        public void NormalState()
        {
            
            this.BackColor = NormalColor;            
            m_state = ACTIONS.LEAVE;
        }

        public void UpdateSate()
        {
            switch (m_state)
            {
                case ACTIONS.LEAVE:
                {
                    this.BackColor = NormalColor;
                }
                break;
                case ACTIONS.ENTER:
                    this.BackColor = EnterColor;
                    break;
                case ACTIONS.DOWN:
                    this.BackColor = PressColor;
                    break;
                case ACTIONS.DISABLE:
                    this.BackColor = DisableColor;
                    break;

            }
        }

        public void ForcePress(bool value)
        {
            m_forePress = value;
            if (value == true) PressState();
            else NormalState();
            
        }
       
    }
}
