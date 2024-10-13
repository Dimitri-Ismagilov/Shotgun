using Shotgun.Classes;

namespace Shotgun
{
    public partial class Shotgun : Form
    {
        private GameMode move = new GameMode();
        private User playerMove = new User();
        public Shotgun()
        {
            InitializeComponent();
        }
        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (radioButtonCharge.Checked)
            {
                move.GamePlay("Ladda");

            }
            else if (radioButtonBlock.Checked)
            {
                move.GamePlay("Blocka");

            }
            else if (radioButtonShoot.Checked)
            {
                move.GamePlay("Sjut");

            }
            else if (radioButtonShotgun.Checked)
            {
                playerMove = new Move();
                playerMove.Shotgun = playerMove.Shotgun + 1;
            }
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
