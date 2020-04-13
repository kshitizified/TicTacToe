using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm(p1.Text, p2.Text);
            this.Hide();
            
            frm.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
