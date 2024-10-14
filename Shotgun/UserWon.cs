using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class UserWon : Form
    {
        public UserWon()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
