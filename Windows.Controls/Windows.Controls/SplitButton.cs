using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Controls
{
    /// <summary>
    /// Implements a Windows command button with a drop-down menu.
    /// </summary>
    [ToolboxBitmap(typeof(SplitButton), "SplitButton.png")]
    public class SplitButton : CommandButton
    {
        /// <summary>
        /// Message to set the drop-down state.
        /// </summary>
        protected const int BCM_SETDROPDOWNSTATE = BCM_FIRST + 0x0006;
        
        /// <summary>
        /// Window style to display the button as a split button.
        /// </summary>
        protected const int BS_SPLITBUTTON = 0x0000000C;

        /// <summary>
        /// Window style to display the button as a default split-button.
        /// </summary>
        protected const int BS_DEFSPLITBUTTON = 0x0000000D;

        /// <summary>
        /// Indicates the drop-down has been pressed.
        /// </summary>
        protected const int BST_DROPDOWNPUSHED = 0x0400;

        // Split button info mask flags

        /// <summary>
        /// Indicates the image list handle is valid. 
        /// </summary>
        protected const int BCSIF_GLYPH = 0x0001;

        /// <summary>
        /// Indicates the image list handle is valid. Used when uSplitStyle is set to <code>BCSS_IMAGE</code>.
        /// </summary>
        protected const int BCSIF_IMAGE = 0x0002;

        /// <summary>
        /// Indicates the style structure is valid.
        /// </summary>
        protected const int BCSIF_STYLE = 0x0004;

        /// <summary>
        /// Indicates the size structure is valid.
        /// </summary>
        protected const int BCSIF_SIZE = 0x0008;

        /// <summary>
        /// Gets/sets the context menu for the split button.
        /// </summary>
        [
            Description("Gets/sets the context menu for the split button."),
            Category("Behavior")
        ]
        public ContextMenuStrip SplitMenu { get; set; }

        /// <summary>
        /// Occurs when the drop-down button is clicked.
        /// </summary>
        [
            Description("Occurs when the drop-down button is clicked."),
            Category("Action")
        ]
        public event EventHandler DropDownClick;

        /// <summary>
        /// Occurs when the drop-down menu is about to be displayed.
        /// </summary>
        [
        Description("Occurs when the drop-down menu is opened."),
            Category("Action")
        ]
        public event EventHandler<DropDownMenuEventArgs> DropDownOpening;

        /// <summary>
        /// Initalizes a new instance of the SplitButton class.
        /// </summary>
        public SplitButton()
        {
            this.FlatStyle = FlatStyle.System;
        }

        /// <summary>
        /// Raises the SplitClick event.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        protected virtual void OnSplitClick(DropDownMenuEventArgs e)
        {
            DropDownClick?.Invoke(this, new EventArgs());

            if (SplitMenu == null)
                return;

            DropDownOpening?.Invoke(this, e);

            if (e.CancelDropdown)
                return;

            Point bottomLeft = new Point(e.DrawArea.Left, e.DrawArea.Bottom);

            SplitMenu.Width = e.DrawArea.Width;
            SplitMenu.Show(this, bottomLeft);
        }

        /// <summary>
        /// Applies the button styles to the button.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();

                CreateParams p = base.CreateParams;

                if (IsDefault)
                    p.Style |= BS_DEFSPLITBUTTON;
                else
                    p.Style |= BS_SPLITBUTTON;

                return p;
            }
        }

        /// <summary>
        /// The callback provided to Windows to recieve window messages.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if(m.Msg == (int)BCM_SETDROPDOWNSTATE)
            {
                if(m.WParam.ToInt32() == 1)
                {
                    OnSplitClick(new DropDownMenuEventArgs(ClientRectangle));
                }
            }

            base.WndProc(ref m);

        }
    }
}
