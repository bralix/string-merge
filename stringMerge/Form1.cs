using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stringMerge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            String defaultText = null;
            String addedItem = "";
            String[] wordDefault = new string[0];
            String[] wordAdded = new string[0];
            String result = "";

            try
            {
                defaultText = richTextBox1.Text.Trim();
                char[] charArrayDefault = defaultText.ToCharArray();
                Array.Reverse(charArrayDefault);
                defaultText = new string(charArrayDefault);

                addedItem = richTextBox2.Text.Trim();
                char[] charArrayAdd = addedItem.ToCharArray();
                Array.Reverse(charArrayAdd);
                addedItem = new string(charArrayAdd);

                if (!String.IsNullOrEmpty(defaultText) && !String.IsNullOrEmpty(addedItem))
                {


                    if (!String.IsNullOrEmpty(defaultText))
                    {
                        wordDefault = defaultText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (!String.IsNullOrEmpty(addedItem))
                        {
                            wordAdded = addedItem.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            success = true;
                        }
                        else
                        {
                            richTextBox4.Text = "Incorrect input of the second field! Try again...";
                            richTextBox4.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        richTextBox4.Text = "Incorrect entry of the first field! Try again...";
                        richTextBox4.BackColor = Color.Red;
                    }
                }
                else
                {
                    richTextBox4.Text = "Invalid input! Try again...";
                    richTextBox4.BackColor = Color.Red;
                }

                while ((wordDefault.Length > 0) && (wordAdded.Length > 0))
                {
                    result += wordDefault[0] + " ";
                    result += wordAdded[0] + " ";

                    wordDefault = wordDefault.Skip(1).ToArray();
                    wordAdded = wordAdded.Skip(1).ToArray();
                }

                while (wordDefault.Length > 0)
                {
                    result += wordDefault[0] + " ";
                    wordDefault = wordDefault.Skip(1).ToArray();
                }

                while (wordAdded.Length > 0)
                {
                    result += wordAdded[0] + " ";
                    wordAdded = wordAdded.Skip(1).ToArray();
                }

                if (success)
                {
                    richTextBox3.Text = result.ToString();
                    richTextBox4.BackColor = Color.Green;
                    richTextBox4.Text = "Everything went well!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox4.BackColor = Color.RoyalBlue;
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox4.Text = "Waiting for input ...";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
