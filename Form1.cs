using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_6_T_1_Text_editor
{
    public partial class Form1 : Form
    {
        static int number = 1;
        Dictionary<string, Action> menu;
        public Form1()
        {            
            InitializeComponent();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStrip1.ImageList = imageList1;
            newFile_toolStripButton.ImageIndex = 2;
            openFile_toolStripButton.ImageIndex = 3;
            save_toolStripButton.ImageIndex = 5;
            saveAs_toolStripButton.ImageIndex = 6;
            copy_toolStripButton.ImageIndex = 0;
            past_toolStripButton.ImageIndex = 4;
            undo_toolStripButton.ImageIndex = 7;
            cut_toolStripButton.ImageIndex = 1;
            textEditor_Box.Visible = false;
        }

        private void openAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All file|*.*|Text file|*.txt||";
            openFile.FilterIndex = 1;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textEditor_Box.Visible = true;
                textEditor_Box.Clear();
                StreamReader sr = File.OpenText(openFile.FileName);
                textEditor_Box.Text = sr.ReadToEnd();
                this.Text = openFile.FileName;
                sr.Close();
            }            
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor_Box.Visible = true;
            StreamWriter sw = new StreamWriter($"D:\\Programing\\TextEditor\\Unname{number}.txt");
            this.Text = $"D:\\Programing\\TextEditor\\Unname{number}.txt";
            number++;
            sw.WriteLine(textEditor_Box.Text);            
            sw.Close();            
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();          
            StreamWriter sw = new StreamWriter(this.Text);
            sw.WriteLine(textEditor_Box.Text);
            sw.Close();            
        }

        private void CopyTxt(TextBox txt)
        {
            txt.Copy();
        }

        private void PastTxt(TextBox txt)
        {
            txt.Paste();
        }

        private void UndoTxt(TextBox txt)
        {
            txt.Undo();
        }

        private void CutTxt(TextBox txt)
        {
            txt.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyTxt(textEditor_Box);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PastTxt(textEditor_Box);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoTxt(textEditor_Box);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();            
            if (font.ShowDialog() == DialogResult.OK)
            {
                textEditor_Box.Font = font.Font;                
            }
        }

        private void colorTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog font = new ColorDialog();            
            if (font.ShowDialog() == DialogResult.OK)
            {                
                textEditor_Box.ForeColor = font.Color;
            }
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog font = new ColorDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                textEditor_Box.BackColor = font.Color;
            }
        }

        private void newFile_toolStripButton_Click(object sender, EventArgs e)
        {
            textEditor_Box.Visible = true;
            StreamWriter sw = new StreamWriter($"D:\\Programing\\TextEditor\\Unname{number}.txt");
            this.Text = $"D:\\Programing\\TextEditor\\Unname{number}.txt";
            number++;
            sw.WriteLine(textEditor_Box.Text);
            sw.Close();
        }

        private void openFile_toolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All file|*.*|Text file|*.txt||";
            openFile.FilterIndex = 1;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textEditor_Box.Visible = true;
                textEditor_Box.Clear();
                StreamReader sr = File.OpenText(openFile.FileName);
                textEditor_Box.Text = sr.ReadToEnd();
                this.Text = openFile.FileName;
                sr.Close();
            }
        }

        private void save_toolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();            
            StreamWriter sw = new StreamWriter(this.Text);
            sw.WriteLine(textEditor_Box.Text);
            sw.Close();            
        }

        private void saveAs_toolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "All file|*.*|Text file|*.txt||";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFile.FileName);
                sw.WriteLine(textEditor_Box.Text);
                sw.Close();
            }
            this.Close();
        }

        private void copy_toolStripButton_Click(object sender, EventArgs e)
        {
            CopyTxt(textEditor_Box);
        }

        private void past_toolStripButton_Click(object sender, EventArgs e)
        {
            PastTxt(textEditor_Box);
        }

        private void undo_toolStripButton_Click(object sender, EventArgs e)
        {
            UndoTxt(textEditor_Box);
        }

        private void cut_toolStripButton_Click(object sender, EventArgs e)
        {
            CutTxt(textEditor_Box);
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CopyTxt(textEditor_Box);
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CutTxt(textEditor_Box);
        }

        private void pastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PastTxt(textEditor_Box);
        }

        private void undoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UndoTxt(textEditor_Box);
        }
    }
}
