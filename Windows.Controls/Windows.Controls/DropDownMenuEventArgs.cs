using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Controls
{
    /// <summary>
    /// Provides data for drop-down menus.
    /// </summary>
    public class DropDownMenuEventArgs
    {
        /// <summary>
        /// Initalizes a DropDownMenuEventArgs object.
        /// </summary>
        public DropDownMenuEventArgs()
        {
            CancelDropdown = false;
        }

        /// <summary>
        /// Initalizes a DropDownMenuEventArgs object with the specified draw area.
        /// </summary>
        /// <param name="drawArea">The drop-down menu area.</param>
        public DropDownMenuEventArgs(Rectangle drawArea)
        {
            DrawArea = drawArea;
            CancelDropdown = false;
        }

        /// <summary>
        /// Determines if the drop-down menu should be opened. 
        /// </summary>
        public bool CancelDropdown { get; set; }

        /// <summary>
        /// Represents the bounding box of the clicked button.
        /// </summary>
        /// <remarks>
        /// A menu should be opened, with top-left coordinates in the left-bottom
        /// point of the rectangle and with width equal (or greater) than the width
        /// of the rectangle.
        /// </remarks>
        public Rectangle DrawArea { get; set; }

    }
}
