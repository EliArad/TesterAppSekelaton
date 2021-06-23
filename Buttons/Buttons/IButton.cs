using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSkinLib
{
      
    public interface IButtonEx
    {
       
        void NotifyClick(BUTTON_NAME btnName, double value = 0);   
        void NotifyDown(BUTTON_NAME btnName, int value = -1);         
        void NotifyUp(BUTTON_NAME btnName, int value = -1);
       
    }

    public interface IJoystickHandler
    {
        void NotifyJoyHandlerStop();
        void NotifyYawPitch(int yaw, int pitch);
        void NotifyYaw(int yaw);
        void NotifyPitch(int pitch);
        void NotifyFastRate();
        void NotifySlowRate();
    }

    public interface IButton
    {
        void NotifyDown(BUTTON_NAME btnName, string m_btnText = "");
        void NotifyEnter(BUTTON_NAME btnName, string m_btnText = "");
        void NotifyUp(BUTTON_NAME btnName, string m_btnText = "");
        void NotifyDoubleClick(BUTTON_NAME btnName, string m_btnText = "");
    }
}
