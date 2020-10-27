using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Controls
{
    /// <summary>
    /// Implements a command link button.
    /// </summary>
    [ToolboxBitmap(typeof(CommandLink), "LinkButton_16x.png")]
    public class CommandLink : CommandButton
    {
        private string description;

        /// <summary>
        /// Message to set the command link's note text.
        /// </summary>
        protected const int BCM_SETNOTE = BCM_FIRST + 0x0009;

        /// <summary>
        /// Style to display the button as a command link.
        /// </summary>
        protected const int BS_COMMANDLINK = 0x0000000E;

        /// <summary>
        /// Style to display the button as the default command link.
        /// </summary>
        protected const int BS_DEFCOMMANDLINK = 0x0000000F;

        /// <summary>
        /// Initalizes a command link.
        /// </summary>
        public CommandLink()
        {
            this.FlatStyle = FlatStyle.System;
        }

        /// <summary>
        /// Gets the default size of the command link.
        /// </summary>
        protected override Size DefaultSize => new Size(152,42);

        /// <summary>
        /// Adds the necessary window style to the control.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();

                CreateParams p = base.CreateParams;

                if (IsDefault)
                    p.Style |= BS_DEFCOMMANDLINK;
                else
                    p.Style |= BS_COMMANDLINK;

                return p;
            }
        }

        /// <summary>
        /// Gets/sets the description text.
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;

                WinApi.SendMessage(this.Handle, BCM_SETNOTE, 0, description);
            }
        }
    }
}
