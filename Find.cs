using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Find : Form
    {
        public RichTextBox rtbFind;
        private int _searchedPositionUp = 0;
        private int _searchedPositionDown;
        private Dictionary<int, int> _positions;

        public Find(RichTextBox rtb)
        {
            InitializeComponent();
            rtbFind = rtb;
            _positions = new Dictionary<int, int>();
            _searchedPositionDown = rtb.Text.Length - 1;
            button1.Click += delegate (object sender, EventArgs e) { button1_Click(sender, e, rtb.Text.Length); };
        }

        private void button1_Click(object sender, EventArgs e, int textLength)
        {
            if (searchDown_radioBtn.Checked)
            {
                _searchedPositionUp = rtbFind.Find(txtFind.Text, _searchedPositionUp + txtFind.Text.Length, RichTextBoxFinds.None);
            }
            if (searchUp_radioBtn.Checked)
            {
                _searchedPositionDown = rtbFind.Find(txtFind.Text, _searchedPositionDown - txtFind.Text.Length, RichTextBoxFinds.None);
                if (!_positions.ContainsKey(_searchedPositionDown))
                {
                    _positions.Add(_searchedPositionDown, _searchedPositionDown);
                    _searchedPositionDown = _searchedPositionDown - txtFind.Text.Length;
                }
                else
                {
                    _searchedPositionDown = textLength - 1;
                    _positions.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
