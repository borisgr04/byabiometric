using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FingerprintNetSample
{
    public partial class VerifyDialog : Form
    {
        public VerifyDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex regx = new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (regx.IsMatch(textBox1.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else 
            {
                
            }
        }
        public Int32 VerifyCode 
        {

            get
            {
                try
                {
                    return Convert.ToInt32(textBox1.Text);
                }
                catch { return -1; }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}