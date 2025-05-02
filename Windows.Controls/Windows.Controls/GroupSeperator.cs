using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Windows.Controls
{
    [ToolboxBitmap(typeof(GroupSeperator), "GroupSeperator.png")]
    public partial class GroupSeperator : Control
    {
        /*private string text;

        /// <summary>
        /// Gets/sets the text of the control.
        /// </summary>
        public override string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                Refresh();
            }
        }*/

        /// <summary>
        /// Constructs a GroupSeperator object.
        /// </summary>
        public GroupSeperator()
        {
            InitializeComponent();
            this.Text = Name;
            this.Width = 200;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        /// <inheritdoc/>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
            PointF point = new PointF(this.Padding.Left, this.Padding.Top);
            Rectangle edgeRect = new Rectangle(textSize.Width + this.Padding.Left, this.Padding.Top + 3 + textSize.Height / 2, this.Width, 1);

            VisualStyleRenderer edgeRenderer = new VisualStyleRenderer(VisualStyleElement.Window.SmallFrameBottom.Active);

            using (SolidBrush brush = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(this.Text, this.Font, brush, point);
                edgeRenderer.DrawEdge(e.Graphics, edgeRect, Edges.Bottom, EdgeStyle.Etched, EdgeEffects.None);
            }
        }
    }
}