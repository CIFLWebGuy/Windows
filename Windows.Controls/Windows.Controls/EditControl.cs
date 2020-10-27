using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Controls
{
    /// <summary>
    /// Implements a standard edit control that contains a cue banner and balloon tips.
    /// </summary>
    [ToolboxBitmap(typeof(TextBox))]
    public class EditControl : TextBox
    {
        /// <summary>
        /// Standard message for extended massages.
        /// </summary>
        private const int ECM_FIRST = 0x1500;

        /// <summary>
        /// Message to set the cue banner text.
        /// </summary>
        private const int EM_SETCUEBANNER = ECM_FIRST + 1;

        /// <summary>
        /// Message to show the balloon tip.
        /// </summary>
        private const int EM_SHOWBALLOONTIP = ECM_FIRST + 3;

        /// <summary>
        /// Message to hide the balloon tip.
        /// </summary>
        private const int EM_HIDEBALLOONTIP = ECM_FIRST + 4;
        
        private string cue;
        private bool showCue;

        /// <summary>
        /// Initalizes an instance of the EditControl class.
        /// </summary>
        public EditControl()
        {
            cue = "";
        }

        /// <summary>
        /// Gets/sets a flag the determines if the cue banner is displayed while the control has the focus.
        /// </summary>
        [Description("Gets/sets a flag the determines if the cue banner is displayed while the control has the focus.")]
        public bool ShowCueOnFocus
        {
            get
            {
                return showCue;
            }
            set
            {
                showCue = value;
                UpdateCue();
            }
        }
        /// <summary>
        /// Gets/sets the cue banner text in the edit control.
        /// </summary>
        [Description("Gets/sets the cue banner text in the edit control.")]
        public String CueBanner
        {
            get
            {
                return cue;
            }
            set
            {
                cue = value;
                UpdateCue();
            }
        }

        /// <summary>
        /// Shows a balloon tip on the edit control.
        /// </summary>
        /// <param name="title">The title of ballon tip.</param>
        /// <param name="message">The message displayed in the balloon.</param>
        /// <param name="icon">The icon to show in the balloon.</param>
        public void ShowBalloonTip(string title, string message, EditBallonTipIcons icon)
        {
            EDITBALLOONTIP balloon = new EDITBALLOONTIP();
            IntPtr pBalloon = IntPtr.Zero;

            try
            {
                balloon.cbStruct = Marshal.SizeOf(balloon);
                balloon.pszText = message;
                balloon.pszTitle = title;
                balloon.ttiIcon = (int)icon;

                pBalloon = Marshal.AllocHGlobal(Marshal.SizeOf(balloon));
                Marshal.StructureToPtr(balloon, pBalloon, false);

                WinApi.SendMessage(this.Handle, EM_SHOWBALLOONTIP, IntPtr.Zero, pBalloon);
            }
            finally
            {
                Marshal.DestroyStructure(pBalloon, typeof(EDITBALLOONTIP));
                Marshal.FreeHGlobal(pBalloon);
            }
        }

        /// <summary>
        /// Hides any balloon tip associated with an edit control.
        /// </summary>
        public void HideBalloonTip()
        {
            WinApi.SendMessage(this.Handle, EM_HIDEBALLOONTIP, IntPtr.Zero, IntPtr.Zero);
        }

        private void UpdateCue()
        {
            WinApi.SendMessage(this.Handle, EM_SETCUEBANNER, Convert.ToInt32(showCue), cue);
        }
    }
}
