using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Controls
{
    /// <summary>
    /// Implements an edit control with a search button.
    /// </summary>
    [ToolboxBitmap(typeof(SearchBox), "Search_16x.png")]
    public partial class SearchBox : UserControl
    {
        /// <summary>
        /// Occurs when the search button is clicked.
        /// </summary>
        public event EventHandler SearchClicked;

        /// <summary>
        /// Occurs when the text changes.
        /// </summary>
        [Browsable(true)]
        public new event EventHandler TextChanged
        {
            add { base.TextChanged += value; }
            remove { base.TextChanged -= value; }
        }

        /// <summary>
        /// Initalizes a SearchBox control.
        /// </summary>
        public SearchBox()
        {
            InitializeComponent();

            editControlSearch.Width = this.Width - pictureBoxSearchButton.Width - 3;

            editControlSearch.TextChanged += EditControlSearch_TextChanged;
            editControlSearch.Click += EditControlSearch_Click;
            editControlSearch.DoubleClick += EditControlSearch_DoubleClick;
            editControlSearch.KeyDown += EditControlSearch_KeyDown;
        }

        /// <summary>
        /// Gets/sets the text selected in the text box.
        /// </summary>
        [Browsable(false)]
        public string SelectedText
        {
            get
            {
                return editControlSearch.SelectedText;
            }
            set
            {
                editControlSearch.SelectedText = value;
            }
        }

        /// <summary>
        /// Gets or sets the starting point of text selected in the text box.
        /// </summary>
        [Browsable(false)]
        public int SelectionStart
        {
            get
            {
                return editControlSearch.SelectionStart;
            }
            set
            {
                editControlSearch.SelectionStart = value;
            }
        }

        /// <summary>
        /// Gets or sets the number of characters selected in the text box.
        /// </summary>
        [Browsable(false)]
        public int SelectionLength
        {
            get
            {
                return editControlSearch.SelectionLength;
            }
            set
            {
                editControlSearch.SelectionLength = value;
            }
        }

        /// <summary>
        /// Gets or sets how text is aligned in a System.Windows.Forms.TextBox control.
        /// </summary>
        public HorizontalAlignment TextAlign
        {
            get
            {
                return editControlSearch.TextAlign;
            }
            set
            {
                editControlSearch.TextAlign = value;
            }
        }

        /// <summary>
        /// Gets the length of text in the control.
        /// </summary>
        [Browsable(false)]
        public int TextLength
        {
            get
            {
                return editControlSearch.TextLength;
            }
        }
        /// <summary>
        /// Gets or sets a value specifying the source of complete strings used for automatic completion.
        /// </summary>
        public AutoCompleteSource AutoCompleteSource
        {
            get
            {
                return editControlSearch.AutoCompleteSource;
            }
            set
            {
                editControlSearch.AutoCompleteSource = value;
            }
        }

        /// <summary>
        /// Gets or sets a custom <see cref="System.Collections.Specialized.StringCollection">StringCollection</see> to use when the <see cref="AutoCompleteSource">AutoCompleteSource</see> property is set to <c>CustomSource</c>.
        /// </summary>
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return editControlSearch.AutoCompleteCustomSource;
            }
            set
            {
                editControlSearch.AutoCompleteCustomSource = value;
            }
        }

        /// <summary>
        /// Gets or sets an option that controls how automatic completion works for the <see cref="SearchBox">SearchBox</see>.
        /// </summary>
        public AutoCompleteMode AutoCompleteMode
        {
            get
            {
                return editControlSearch.AutoCompleteMode;
            }
            set
            {
                editControlSearch.AutoCompleteMode = value;
            }
        }

        /// <summary>
        /// Gets/sets the cue banner forthe edit control.
        /// </summary>
        public string CueBanner
        {
            get
            {
                return editControlSearch.CueBanner;
            }
            set
            {
                editControlSearch.CueBanner = value;
            }
        }
        /// <summary>
        /// Gets the default size of the control.
        /// </summary>
        protected override Size DefaultSize
        {
            get
            {
                return new Size(150, 20);
            }
        }

        /// <summary>
        /// Gets/sets the text in the text box.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return editControlSearch.Text;
            }
            set
            {
                editControlSearch.Text = value;
            }
        }

        private void EditControlSearch_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void EditControlSearch_DoubleClick(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }

        private void EditControlSearch_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void EditControlSearch_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged(e);
        }

        /// <summary>
        /// Raises the SearchClicked event.
        /// </summary>
        protected void OnSearchClicked()
        {
            SearchClicked?.Invoke(this, new EventArgs());
        }

        private void pictureBoxSearchButton_Click(object sender, EventArgs e)
        {
            OnSearchClicked();
        }

        private void SearchBox_FontChanged(object sender, EventArgs e)
        {
            editControlSearch.Width = this.Width - pictureBoxSearchButton.Width - 3;
        }
    }
}
