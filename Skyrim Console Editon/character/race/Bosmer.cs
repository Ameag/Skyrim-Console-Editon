using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Console_Editon.character.race
{
    public class Bosmer : Character
    {
        public Bosmer() 
        {
            RaceCharacter = "Босмер";
            HP = 100;
            Stamina = 100;
            Magic = 100;
            OP = 0;
            Damage = 1;
            Protection = 0;
            UniqueAttribute = "50 % сопротивление ядам и болезням";
        }
    }
}
