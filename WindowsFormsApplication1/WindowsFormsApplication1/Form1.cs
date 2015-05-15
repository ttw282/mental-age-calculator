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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Result Result { get; set; }
        public Result PrevResult { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            //f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            //Controls.Add(f);
            //f.Visible = true;
            Result = new Result();
            PrevResult = new Result();
            //Result.MentalAge = int.Parse(textBox1.Text);
            int num1;
            bool res = int.TryParse(textBox1.Text, out num1);
            if (!res)
            {
                label2.Text = "Please enter a valid age.";
                return;
            }
            Result.MentalAge = num1;
            PrevResult.MentalAge = num1;
            f.PrevResult = PrevResult;
            f.Result = Result;
            f.Show();
            Hide();
        }
    }
}
