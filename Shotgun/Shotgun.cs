using Shotgun.Classes;

namespace Shotgun
{
    public partial class Shotgun : Form
    {
        private GameMode move;
        public Shotgun()
        {
            InitializeComponent();
            move = new GameMode();

        }
        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (radioButtonCharge.Checked)
            {
                move.GamePlay("Ladda");
                UpdateShoots();

            }
            else if (radioButtonBlock.Checked)
            {
                move.GamePlay("Blocka");
                UpdateShoots();
            }
            else if (radioButtonShoot.Checked)
            {
                move.GamePlay("Sjut");
                UpdateShoots();
            }
            else if (radioButtonShotgun.Checked)
            {
                
            }
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        private void UpdateShoots()
        {
            listBoxUser.Text = $"Skott:{move.User.Bullets}";
            listBoxComputer.Text = $"Skott: {move.Computer.Bullets}";
        }
    }
}
