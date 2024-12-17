using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bunifu.UI.WinForms;

namespace Lap_4
{
    public partial class Form2 : Form
    {
        private BunifuSnackbar bunifuSnackbar;
        public Form2()
        {
            InitializeComponent();
            bunifuSnackbar = new BunifuSnackbar();
        }
        private void showSnackbar(string message, BunifuSnackbar.MessageTypes type)
        {
            bunifuSnackbar.Show(this, message, type, 3000);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            showSnackbar("This is a message", BunifuSnackbar.MessageTypes.Success);
        }
    }
}
