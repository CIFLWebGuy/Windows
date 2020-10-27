using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Controls
{
    /// <summary>
    /// Base class for implementing a Windows command button.
    /// </summary>
    [ToolboxBitmap(typeof(Button))]
    public class CommandButton : Button
    {
        private bool showShield;

        // button notifications

        /// <summary>
        /// Standard notification for extended styles.
        /// </summary>
        protected const int BCN_FIRST = -1250;

        /// <summary>
        /// Standard message for extended styles.
        /// </summary>
        protected const int BCM_FIRST = 0x1600;

        /// <summary>
        /// Message to set the button's style.
        /// </summary>
        protected const int BM_SETSTYLE = 0x00f4;

        /// <summary>
        /// Message to set the sheild icon.
        /// </summary>
        protected const int BCM_SETSHIELD = BCM_FIRST + 0x000C;

        /// <summary>
        /// Message to set the button's image list.
        /// </summary>
        protected const int BCM_SETIMAGELIST = BCM_FIRST + 0x0002;

        /// <summary>
        /// Style to display the button image as an icon.
        /// </summary>
        protected const int BS_ICON = 0x00000040;

        /// <summary>
        /// Style to display the buttion image as a bitmap.
        /// </summary>
        protected const int BS_BITMAP = 0x00000080;

        /// <summary>
        /// Gets/sets a flag that determines if the security icon should be shown.
        /// </summary>
        [
            Description("Gets/sets a flag that determines if the shield icon should be shown."),
            Category("Appearance")
        ]
        public bool ShowShieldIcon
        {
            get
            {
                return showShield;
            }
            set
            {
                showShield = value;

                if(value)
                {
                    int wParam = 0;
                    int lParam = 1;

                    FlatStyle = FlatStyle.System;
                    WinApi.SendMessage(this.Handle, BCM_SETSHIELD, new IntPtr(wParam), new IntPtr(lParam));
                }
                else
                {
                    int wParam = 0;
                    int lParam = 0;

                    WinApi.SendMessage(this.Handle, BCM_SETSHIELD, new IntPtr(wParam), new IntPtr(lParam));
                }
            }
        }
    }
}
