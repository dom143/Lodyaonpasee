using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lodyonpasee
{
    public partial class mainmenu1 : Form
    {
        public mainmenu1()
        {
            InitializeComponent();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox1.Text);
            int bonus = int.Parse(textBox2.Text);
            int other = int.Parse(textBox3.Text);
            int outcome;
            {
                outcome = ((month * 12) + bonus + other);
                textBox4.Text = outcome.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Group1 gr1 = new Group1();
            gr1.money1.Text = textBox4.Text;
            gr1.Show();
        }
    }
    
