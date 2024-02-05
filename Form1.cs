using System;
using System.Collections;
using System.Windows.Forms;

namespace MyEnvironmentVariables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";

            IDictionary allVars = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in allVars)
            {
                String[] val = de.Value.ToString().Split(';');

                this.richTextBox1.Text += de.Key + "\r\n";
                foreach(String s in val)
                {
                    this.richTextBox1.Text += "\t" + s + "\r\n";
                }
            }

        }
    }
}
