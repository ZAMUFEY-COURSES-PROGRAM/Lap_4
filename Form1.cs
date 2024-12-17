using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Lap_4.FOL1;

namespace Lap_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KEY CODE = S, B, W,6,9,2,2,12,2,45RFDG,
            // CTRL , ALT
            //switch (e.)
            Char PressedKy = e.KeyChar;
            MessageBox.Show(PressedKy.ToString());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.A:
            //        MessageBox.Show("You Pressed A");
            //        break;
            //    case Keys.B:
            //        MessageBox.Show("You Pressed A");
            //        break;
            //    case Keys.C:
            //        MessageBox.Show("You Pressed A");
            //        break;
            //    case Keys.D:
            //        MessageBox.Show("You Pressed A");
            //        break;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //STEP 1 - FormName + ObjName = new FormName()
            //STEP 2 - ObjName + Show
            Form3 f2 = new Form3();
            f2.Show();
            //this.Hide();
        }
    }
}
