using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Controls
{
    /// <summary>
    /// Specifies flags for the LoadResource and LoadImage functions.
    /// </summary>
    public static class LoadResourceFlags
    {
        /// <summary>
        /// Causes the function to return a DIB section bitmap rather than a compatible bitmap.
        /// </summary>
        public const uint LR_CREATEDIBSECTION = 0x00002000;

        /// <summary>
        /// The default flag; it does nothing.
        /// </summary>
        public const uint LR_DEFAULTCOLOR = 0x00000000;

        /// <summary>
        /// Uses the width or height specified by the system metric values for cursors or icons, if the cxDesired or cyDesired values are set to zero. 
        /// </summary>
        /// <remarks>
        /// If this flag is not specified and cxDesired and cyDesired are set to zero, the function uses the actual resource size. 
        /// If the resource contains multiple images, the function uses the size of the first image.
        /// </remarks>
        public const uint LR_DEFAULTSIZE = 0x00000040;

        /// <summary>
        /// Loads the stand-alone image from the file specified by lpszName (icon, cursor, or bitmap file).
        /// </summary>
        public const uint LR_LOADFROMFILE = 0x00000010;

        /// <summary>
        /// <para>Searches the color table for the image and replaces the following shades of gray with the corresponding 3-D color.</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Dk Gray, RGB(128,128,128) with COLOR_3DSHADOW</description>
        /// </item>
        /// <item>
        /// <description>Gray, RGB(192,192,192) with COLOR_3DFACE</description>
        /// </item>
        /// <item>
        /// <description>Lt Gray, RGB(223,223,223) with COLOR_3DLIGHT</description>
        /// </item>
        /// </list>
        /// </summary>
        public const uint LR_LOADMAP3DCOLORS = 0x00001000;

        /// <summary>
        /// Retrieves the color value of the first pixel in the image and replaces the corresponding entry in the color table with the default window color (COLOR_WINDOW). 
        /// </summary>
        /// <remarks>
        /// All pixels in the image that use that entry become the default window color. 
        /// This value applies only to images that have corresponding color tables.
        /// </remarks>
        public const uint LR_LOADTRANSPARENT = 0x00000020;

        /// <summary>
        /// Loads the image in black and white.
        /// </summary>
        public const uint LR_MONOCHROME = 0x00000001;

        /// <summary>
        /// Shares the image handle if the image is loaded multiple times.
        /// </summary>
        /// <remarks>
        /// <para>If LR_SHARED is not set, a second call for the same resource will load the image again and return a different handle.</para>
        /// <para>When you use this flag, the system will destroy the resource when it is no longer needed.</para>
        /// <para>Do not use LR_SHARED for images that have non-standard sizes, that may change after loading, or that are loaded from a file.</para>
        /// <para>This function finds the first image in the cache with the requested resource name, regardless of the size requested.</para>
        /// </remarks>
        public const uint LR_SHARED = 0x00008000;

        /// <summary>
        /// Uses true VGA colors.
        /// </summary>
        public const uint LR_VGACOLOR = 0x00000080;
    }
}
