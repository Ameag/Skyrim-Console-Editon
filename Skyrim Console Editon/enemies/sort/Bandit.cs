using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Skyrim_Console_Editon.enemies
{
    public class Bandit : Enemi
    {
        public Bandit()
        {
            Name =  "Bandit";
            Hp = 30;
            Damage = 4;
            Xp = 10;
        }
    }
}
