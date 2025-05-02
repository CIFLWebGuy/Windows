using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Controls
{
    public static class FormExtensions
    {
        /// <summary>
        /// Invokes a nonthread-safe method on a form.
        /// </summary>
        /// <param name="form">The form to invoke the method.</param>
        /// <param name="method">The method being invoked. This method must return <see cref="void"/>.</param>
        /// <remarks>This method will invoke the specified method, marshalling the call to the UI thread if that is required. This allows a worker thread to access the properties of controls on a form.</remarks>
        public static void InvokeMethod(this Form form, Action method)
        {
            if(form.InvokeRequired)
            {
                form.Invoke(method);
            }
            else
            {
                form.Invoke(method);
            }
        }
    }
}
