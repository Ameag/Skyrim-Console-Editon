using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Skyrim_Console_Editon.enemies
{
    public class FlameAtronach : Enemi
    {
        public FlameAtronach()
        {
            Name = "Flame Atronach";
            Hp = 50;
            Damage = 15;
            Xp = 15;
        }
    }
}
