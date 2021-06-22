using System;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        private string text;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                text = textBox1.Text;

                if (radioButton1.Checked)
                {
                    text = ReverseText.functionText(text);
                }
                else if (radioButton2.Checked)
                {
                    text = CapitalLetters.functionText(text);
                }

                MessageBox.Show(
                    text,
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);


            }
        }
    }
}
