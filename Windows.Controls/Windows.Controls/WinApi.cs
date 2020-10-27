using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Controls
{
    /// <summary>
    /// Defines icons used in balloon tips.
    /// </summary>
    public enum EditBallonTipIcons
    {
        /// <summary>
        /// No icon displayed.
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Information icon. 
        /// </summary>
        Info = 1,

        /// <summary>
        /// Warning icon.
        /// </summary>
        Warning = 2,

        /// <summary>
        /// Error icon.
        /// </summary>
        Error = 3
    }

    /// <summary>
    /// Implements a structure that contans the balloon data.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct EDITBALLOONTIP
    {
        public int cbStruct;
        public string pszTitle;
        public string pszText;
        public int ttiIcon;
    }

    /// <summary>
    /// Defines the flags that determine which buttons to show.
    /// </summary>
    [Flags]
    public enum TaskDialogButtons
    {
        /// <summary>
        /// Indicates no buttons were pressed.
        /// </summary>
        None = 0,

        /// <summary>
        /// The task dialog contains the push button: OK.
        /// </summary>
        Ok = 0x0001, // selected control return value IDOK

        /// <summary>
        /// The task dialog contains the push button: Yes.
        /// </summary>
        Yes = 0x0002, // selected control return value IDYES

        /// <summary>
        /// The task dialog contains the push button: No.
        /// </summary>
        No = 0x0004, // selected control return value IDNO

        /// <summary>
        /// The task dialog contains the push button: Cancel. 
        /// </summary>
        /// <remarks>This button must be specified for the dialog box to respond to typical cancel actions (Alt-F4 and Escape).</remarks>
        Cancel = 0x0008, // selected control return value IDCANCEL

        /// <summary>
        /// The task dialog contains the push button: Retry.
        /// </summary>
        Retry = 0x0010, // selected control return value IDRETRY

        /// <summary>
        /// The task dialog contains the push button: Close.
        /// </summary>
        Close = 0x0020  // selected control return value IDCLOSE
    }

    /// <summary>
    /// Defines the standard icons available for a TaskDialog.
    /// </summary>
    public enum TaskDialogIcons : ushort
    {
        /// <summary>
        /// Warning icon.
        /// </summary>
        Warning = ushort.MaxValue,

        /// <summary>
        /// Error icon.
        /// </summary>
        Error = ushort.MaxValue - 1,

        /// <summary>
        /// Information icon.
        /// </summary>
        Information = ushort.MaxValue - 2,

        /// <summary>
        /// Shield icon.
        /// </summary>
        Shield = ushort.MaxValue - 3
    }

    /// <summary>
    /// Defines the results of the task dialog.
    /// </summary>
    public enum TaskDialogResults
    {
        /// <summary>
        /// User clicked the OK button.
        /// </summary>
        Ok = 1,

        /// <summary>
        /// User clicked the Cancel button.
        /// </summary>
        Cancel = 2,

        /// <summary>
        /// User clicked the Abort button.
        /// </summary>
        Abort = 3,

        /// <summary>
        /// User clicked the Retry button.
        /// </summary>
        Retry = 4,

        /// <summary>
        /// User clicked the Ignore button.
        /// </summary>
        Ignore = 5,

        /// <summary>
        /// User clicked the Yes button.
        /// </summary>
        Yes = 6,

        /// <summary>
        /// User clicked the No button.
        /// </summary>
        No = 7,

        /// <summary>
        /// User clicked the Close button.
        /// </summary>
        Close = 8,

        /// <summary>
        /// User clicked the Help button.
        /// </summary>
        Help = 9,

        /// <summary>
        /// User clicked the Try Again button.
        /// </summary>
        TryAgain = 10,

        /// <summary>
        /// User clicked the Continue button.
        /// </summary>
        Continue = 11
    }

    /// <summary>
    /// Provides methods to unmanaged calls to the Win32 API.
    /// </summary>
    public static class WinApi
    {
        /// <summary>
        /// Defines the start of the user-message area.
        /// </summary>
        public const int WM_USER = 1024;

        /// <summary>
        /// Contains members that map to the glyphs in the Segoe UI Symbol font.
        /// </summary>
        public enum UISymbols
        {
            /// <summary>
            /// Close button
            /// </summary>
            Close = 0xe21c,

            /// <summary>
            /// Small close button
            /// </summary>
            CloseSmall = 0xe221,

            /// <summary>
            /// Combo drop-down button
            /// </summary>
            DropDown = 0xe015,

            /// <summary>
            /// Menu button arrow
            /// </summary>
            MenuButton = 0X23f7
        }

        /// <summary>
        /// Represents the OEM images that are built-in to Windows.
        /// </summary>
        public enum OemImages : uint
        {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
            OBM_CLOSE = 32754,
            OBM_UPARROW = 32753,
            OBM_DNARROW = 32752,
            OBM_RGARROW = 32751,
            OBM_LFARROW = 32750,
            OBM_REDUCE = 32749,
            OBM_ZOOM = 32748,
            OBM_RESTORE = 32747,
            OBM_REDUCED = 32746,
            OBM_ZOOMD = 32745,
            OBM_RESTORED = 32744,
            OBM_UPARROWD = 32743,
            OBM_DNARROWD = 32742,
            OBM_RGARROWD = 32741,
            OBM_LFARROWD = 32740,
            OBM_MNARROW = 32739,
            OBM_COMBO = 32738,
            OBM_UPARROWI = 32737,
            OBM_DNARROWI = 32736,
            OBM_RGARROWI = 32735,
            OBM_LFARROWI = 32734,
            OBM_OLD_CLOSE = 32767,
            OBM_SIZE = 32766,
            OBM_OLD_UPARROW = 32765,
            OBM_OLD_DNARROW = 32764,
            OBM_OLD_RGARROW = 32763,
            OBM_OLD_LFARROW = 32762,
            OBM_BTSIZE = 32761,
            OBM_CHECK = 32760,
            OBM_CHECKBOXES = 32759,
            OBM_BTNCORNERS = 32758,
            OBM_OLD_REDUCE = 32757,
            OBM_OLD_ZOOM = 32756,
            OBM_OLD_RESTORE = 32755
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        }

        /// <summary>
        /// Represents the OEM icons that are built-in to Windows.
        /// </summary>
        public enum OemIcons : uint
        {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
            OIC_SAMPLE = 32512,
            OIC_HAND = 32513,
            OIC_QUES = 32514,
            OIC_BANG = 32515,
            OIC_NOTE = 32516,
            OIC_WINLOGO = 32517,
            OIC_WARNING = OIC_BANG,
            OIC_ERROR = OIC_HAND,
            OIC_INFORMATION = OIC_NOTE,
            OIC_SHIELD = 32518
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        }

        /// <summary>
        /// Changes the specified single-selection list box to a drag list box.
        /// </summary>
        /// <param name="handle">The handle o the list box.</param>
        /// <returns>True if successful, False otherwise.</returns>
        [DllImport("Comctl32.dll", CharSet = CharSet.Unicode)]
        internal static extern bool MakeDragList(IntPtr handle);

        /// <summary>
        /// Sends a message to the specified window.
        /// </summary>
        /// <param name="hWnd">The handle of the window recieving the message.</param>
        /// <param name="Msg">The message ID.</param>
        /// <param name="wParam">Message data.</param>
        /// <param name="lParam">Addional message data.</param>
        /// <returns>The result of the message.</returns>
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        internal static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// Sends a message to the specified window.
        /// </summary>
        /// <param name="hWnd">The handle of the window recieving the message.</param>
        /// <param name="Msg">The message ID.</param>
        /// <param name="wParam">Message data.</param>
        /// <param name="lParam">Addional message data.</param>
        /// <returns>The result of the message.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, StringBuilder lParam);

        /// <summary>
        /// Sends a message to the specified window.
        /// </summary>
        /// <param name="hWnd">The handle of the window recieving the message.</param>
        /// <param name="Msg">The message ID.</param>
        /// <param name="wParam">Message data.</param>
        /// <param name="lParam">Addional message data.</param>
        /// <returns>The result of the message.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        /// <summary>
        /// Sends a message to the specified window.
        /// </summary>
        /// <param name="hWnd">The handle of the window recieving the message.</param>
        /// <param name="Msg">The message ID.</param>
        /// <param name="wParam">Message data.</param>
        /// <param name="lParam">Addional message data.</param>
        /// <returns>The result of the message.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        /// <summary>
        /// Sends a message to the specified window.
        /// </summary>
        /// <param name="hWnd">The handle of the window recieving the message.</param>
        /// <param name="Msg">The message ID.</param>
        /// <param name="wParam">Message data.</param>
        /// <param name="lParam">Addional message data.</param>
        /// <returns>The result of the message.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, ref IntPtr lParam);

        /// <summary>
        /// Sends a message to the specified window.
        /// </summary>
        /// <param name="hWnd">The handle of the window recieving the message.</param>
        /// <param name="Msg">The message ID.</param>
        /// <param name="wParam">Message data.</param>
        /// <param name="lParam">Addional message data.</param>
        /// <returns>The result of the message.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        /// <summary>
        /// Sets the theme of the sepecified window.
        /// </summary>
        /// <param name="hWnd">The handle of the window.</param>
        /// <param name="pszSubAppName">The name of the application who owns the style.</param>
        /// <param name="pszSubIdList">The style to set.</param>
        /// <returns></returns>
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        /// <summary>
        /// Loads an image.
        /// </summary>
        /// <param name="hInstance"></param>
        /// <param name="lpszName"></param>
        /// <param name="uType"></param>
        /// <param name="cxDesired"></param>
        /// <param name="cyDesired"></param>
        /// <param name="fuLoad"></param>
        /// <returns></returns>
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private extern static IntPtr LoadImage(IntPtr hInstance, string lpszName, uint uType, int cxDesired, int cyDesired, uint fuLoad);

        /// <summary>
        /// Gets an OEM image.
        /// </summary>
        /// <param name="image">The image to retrieve.</param>
        /// <returns>Bitmap containing the OemImage.</returns>
        public static Bitmap GetOemImage(OemImages image)
        {
            return Bitmap.FromHbitmap(LoadImage(IntPtr.Zero, string.Format("#{0}", (uint)image), 0, 0, 0, LoadResourceFlags.LR_SHARED));
        }

        /// <summary>
        /// Gets an OEM icon.
        /// </summary>
        /// <param name="icon">The icon to retrieve.</param>
        /// <returns>Icon containing the OemIcon</returns>
        public static Icon GetOemIcon(OemIcons icon)
        {
            IntPtr hIcon = LoadImage(IntPtr.Zero, string.Format("#{0}", (uint)icon), 1, 0, 0, LoadResourceFlags.LR_SHARED);

            if(hIcon == IntPtr.Zero)
            {
                int error = Marshal.GetLastWin32Error();
                Debug.WriteLine(error);
            }
            return Icon.FromHandle(hIcon);
        }

        /// <summary>
        /// Retrieves the UAC shield image.
        /// </summary>
        /// <returns></returns>
        public static Bitmap GetSmallShieldImage()
        {
            Bitmap shield = new Bitmap(16, 16);

            using (Graphics g = Graphics.FromImage(shield))
            {
                g.DrawIcon(SystemIcons.Shield, new Rectangle(0, 0, 16, 16));
            }

            return shield;
        }
    }
}
