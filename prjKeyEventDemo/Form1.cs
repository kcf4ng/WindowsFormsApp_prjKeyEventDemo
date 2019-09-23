using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjKeyEventDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // lbl.Text += "\nForm1_KeyDown Event Execute";
             lbl.Text += e.KeyValue.ToString() ;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // lbl.Text += "\nForm1_KeyPress Event Execute";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
          //  lbl.Text += "\nForm1_KeyUp Event Execute";
        }
    }
}
