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
