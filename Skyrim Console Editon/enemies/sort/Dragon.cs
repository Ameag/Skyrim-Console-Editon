using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Skyrim_Console_Editon.enemies
{
    public class Dragon : Enemi
    {
        public Dragon()
        {
            Name = "Dragon";
            Hp = 200;
            Damage = 10;
            Xp = 100;
        }
    }
}
