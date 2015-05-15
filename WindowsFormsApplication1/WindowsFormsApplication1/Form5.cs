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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            var coll = new Combobox();
            comboBox1.Items.AddRange(coll.Collection);
        }

        public Result Result { get; set; }
        public Result PrevResult { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Result != null)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        Result.MentalAge -= 3;
                        break;
                    case 1:
                        Result.MentalAge += 3;
                        break;
                    case 2:
                        Result.MentalAge -= 1;
                        break;
                }
            }

            var f = new Form6(Result, PrevResult);
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new Form4();
            f.Result = PrevResult;
            f.Show();
            Hide();
        }
    }
}
