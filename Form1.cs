using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        private string fileName = string.Empty;
        private bool isChanged = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All files (*.*)|*.*|RichTextFile(*.rtf)|*.rtf";
            var result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = openFile.SafeFileName;
                rtbDocument.LoadFile(fileName);
                ChangeAppName(fileName);
            }
        }

        private void ChangeAppName(string fileName)
        {
            var oldAppName = this.Text.Split('-')[0];
            if (fileName.Split('\\').Count() != 1)
            {
                int count = fileName.Split('\\').Count();
                this.Text = string.Format("{0} - {1}", oldAppName, fileName.Split('\\')[count - 1]);
            }
            else
            {
                this.Text = string.Format("{0} - {1}", oldAppName, fileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                rtbDocument.SaveFile(fileName);
                isChanged = false;
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAsDialog = new SaveFileDialog();
            saveAsDialog.DefaultExt = "rtf";

            if (saveAsDialog.ShowDialog(this) == DialogResult.OK)
            {
                fileName = saveAsDialog.FileName;
                rtbDocument.SaveFile(fileName);
                ChangeAppName(saveAsDialog.FileName);
                isChanged = false;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                rtbDocument.SelectionColor = colorDialog.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog(this) == DialogResult.OK)
            {
                rtbDocument.SelectionFont = fontDialog.Font;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                rtbDocument.SelectionBackColor = colorDialog.Color;
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var findDialog = new Find(rtbDocument);
            findDialog.ShowDialog(this);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbDocument.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbDocument.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbDocument.Paste();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged == true)
            {
                var dialogResult = MessageBox.Show("Do you want to save changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void rtbDocument_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbDocument.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbDocument.Redo();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

        }
    }
}
