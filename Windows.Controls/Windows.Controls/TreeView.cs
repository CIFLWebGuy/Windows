using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Controls
{
    /// <summary>
    /// Implements an Explorer-styled TreeView
    /// </summary>
    [ToolboxBitmap(typeof(System.Windows.Forms.TreeView))]
    public class TreeView : System.Windows.Forms.TreeView
    {        /// <summary>
             /// Raises the <see cref="System.Windows.Forms.Control.HandleCreated"/> event.
             /// </summary>
             /// <param name="e">The event arguments.</param> 
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (Environment.OSVersion.Version.Major >= 6)
            {
                WinApi.SetWindowTheme(this.Handle, "Explorer", null);
                ShowLines = false;
            }
        }
    }
}
