namespace Shotgun.Classes
{
    public class Player
    {
        public int Bullets { get; set; }
        public Player()
        {
            Bullets = 0;
        }
        public void Charge()
        {
            Bullets++;
        }
        public void Shoot()
        {
            if (Bullets > 0)
            {
                Bullets--;
            }
        }
        public bool CanShoot()
        {
            if (Bullets > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Shotgun()
        {
            if (Bullets > 2)
            {
                Bullets -= 3;
                return true;
            } else
            {
                return false; 
            }    
        }

    }
}