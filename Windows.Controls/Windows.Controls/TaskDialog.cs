using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Controls
{
    /// <summary>
    /// Implements a Windows Task Dialog
    /// </summary>
    public class TaskDialog
    {
        /// <summary>
        /// Creates and operates a task dialog box.
        /// </summary>
        /// <param name="hWnd">The handle of owning window.</param>
        /// <param name="hInstance">The handle of the instance containing the icon to display.</param>
        /// <param name="title">The title of the task dialog.</param>
        /// <param name="instruction">The main instruction text.</param>
        /// <param name="content">The additional text that appears below the main instruction.</param>
        /// <param name="buttons">The butons to display in the task dialog.</param>
        /// <param name="icon">The id of icon to display.</param>
        /// <param name="buttonSelected">The id of the button pressed.</param>
        /// <returns>The result of the call.</returns>
        [DllImport(dllName: "Comctl32.dll", EntryPoint = "TaskDialog", SetLastError = true, BestFitMapping = true, CharSet = CharSet.Unicode)]
        private static extern int TaskDlog(IntPtr hWnd, IntPtr hInstance, string title, string instruction, string content, int buttons, ushort icon, out int buttonSelected);

        /// <summary>
        /// Creates and operates a task dialog box.
        /// </summary>
        /// <param name="hWnd">The handle of owning window.</param>
        /// <param name="hInstance">The handle of the instance containing the icon to display.</param>
        /// <param name="title">The title of the task dialog.</param>
        /// <param name="instruction">The main instruction text.</param>
        /// <param name="content">The additional text that appears below the main instruction.</param>
        /// <param name="buttons">The butons to display in the task dialog.</param>
        /// <param name="icon">The name of icon to display.</param>
        /// <param name="buttonSelected">The id of the button pressed.</param>
        /// <returns>The result of the call.</returns>
        [DllImport(dllName: "Comctl32.dll", EntryPoint = "TaskDialog", SetLastError = true, BestFitMapping = true, CharSet = CharSet.Unicode)]
        private static extern int TaskDlog(IntPtr hWnd, IntPtr hInstance, string title, string instruction, string content, int buttons, string icon, out int buttonSelected);

        /// <summary>
        /// Display a standard message box.
        /// </summary>
        /// <param name="handle">The handle of the owning window.</param>
        /// <param name="title">The title of the dialog box.</param>
        /// <param name="instruction">The main instruction text.</param>
        /// <param name="content">Text content text displayed uner the main instruction.</param>
        /// <param name="buttons">The buttons to display in the dialog.</param>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static TaskDialogResults ShowMessage(IntPtr handle, string title, string instruction, string content, TaskDialogButtons buttons, TaskDialogIcons icon)
        {
            int iconID = (int)icon;
            int result;
            int hresult = TaskDlog(handle, IntPtr.Zero, title, instruction, content, (int)buttons, (ushort)iconID, out result);

            if (hresult != 0)
            {
                throw new Win32Exception(hresult);
            }

            return (TaskDialogResults)result;
        }
    }
}
