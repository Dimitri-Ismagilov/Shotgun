using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return Bullets > 0;
        }
        public void Shotgung()
        {
            if (Bullets > 2)
            {
                Bullets -= 2;
            }
        }

    }
}