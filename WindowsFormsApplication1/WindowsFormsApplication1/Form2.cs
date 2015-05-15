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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var combo = new Combobox();
            comboBox1.Items.AddRange(combo.Collection);
        }

        public Result Result { get; set; }
        public Result PrevResult { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form3();

            if (Result != null)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        Result.MentalAge += 2;
                        break;
                    case 1:
                        Result.MentalAge -= 2;
                        break;
                    case 2:
                        break;
                }
            }
            f.PrevResult = PrevResult;
            f.Result = Result;
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.Result = PrevResult;
            f.Show();
            Hide();
        }
    }
}
