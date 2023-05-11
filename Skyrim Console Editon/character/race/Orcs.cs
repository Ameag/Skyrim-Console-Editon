using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Console_Editon.character.race
{
    public class Orcs : Character
    {
        public Orcs() 
        {
            RaceCharacter = "Орк";
            HP = 100;
            Stamina = 100;
            Magic = 100;
            OP = 0;
            Damage = 5;
            Protection = 0;
            UniqueAttribute = "Нет";
        }
    }
}
