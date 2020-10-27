using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Windows.Controls
{
    /// <summary>
    /// Implements a Win32 progress bar.
    /// </summary>
    [ToolboxBitmap(typeof(System.Windows.Forms.ProgressBar))]
    public class ProgressBar : System.Windows.Forms.ProgressBar
    {
        /// <summary>
        /// Indicates that the progress bar is in the normal state.
        /// </summary>
        protected const int PBST_NORMAL = 1;

        /// <summary>
        /// Indicates the progress bar is in the error state.
        /// </summary>
        protected const int PBST_ERROR = 2;

        /// <summary>
        /// Indicates the progress bars is in the paused state.
        /// </summary>
        protected const int PBST_PAUSED = 3;

        /// <summary>
        /// Message used to set the state of the progress bar.
        /// </summary>
        protected const int PBM_SETSATE = WinApi.WM_USER + 16;

        /// <summary>
        /// Message used to get the state of the progress bar.
        /// </summary>
        protected const int PBM_GETSATE = WinApi.WM_USER + 17;


        /// <summary>
        /// Indicates the state of the progress bar.
        /// </summary>
        public enum States
        {
            /// <summary>
            /// Normal state.
            /// </summary>
            Normal = PBST_NORMAL,

            /// <summary>
            /// Error state.
            /// </summary>
            Error = PBST_ERROR,

            /// <summary>
            /// Paused state.
            /// </summary>
            Paused = PBST_PAUSED
        }

        /// <summary>
        /// Gets/sets the visual state of the progress bar.
        /// </summary>
        [
            Description("Gets/sets the visual state of the progress bar."),
            Category("Apperance")
        ]
        public States State
        {
            get
            {
                return (States)WinApi.SendMessage(this.Handle, PBM_GETSATE, 0, 0);
            }
            set
            {
                WinApi.SendMessage(this.Handle, PBM_SETSATE, (int)value, 0);
            }
        }
    }
}
