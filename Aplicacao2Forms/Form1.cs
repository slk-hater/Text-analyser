using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao2Forms
{
    public partial class Form1 : Form
    {
        char chr;
        char[] delimiters = new char[] { ' ', '\r', '\n' };
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int foundChars=0;
            string[] words = textBox.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            textBox1.Text = words.Length.ToString();
            textBox2.Text = textBox.TextLength.ToString();
            label4.Text = label4.Text.Replace("'"+chr+"'", "'?'");
            if(char.TryParse(charBox.Text, out chr))
            {
                label4.Text = label4.Text.Replace('?', chr);
                for (int i = 0; i <= textBox.TextLength-1; i++) if (textBox.Text[i] == chr) foundChars++;
                textBox3.Text = foundChars.ToString();
            }
            else textBox3.Clear();
        }
    }
}
