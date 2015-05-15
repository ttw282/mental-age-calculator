using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6(Result result, Result prevresult)
        {
            InitializeComponent();
            Result = result;
            PrevResult = prevresult;
            if(Result != null)
                label1.Text = string.Format("Your mental age is {0}.", Result.MentalAge);
            else if (PrevResult != null)
            {
                label1.Text = string.Format("Your mental age is {0}.", PrevResult.MentalAge);
            }
            else
            {
                label1.Text = "Please start over.";
            }
        }

        public Result Result { get; set; }
        public Result PrevResult { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new Form5();
            f.Result = PrevResult;
            f.Show();
            Hide();
        }
    }
}
