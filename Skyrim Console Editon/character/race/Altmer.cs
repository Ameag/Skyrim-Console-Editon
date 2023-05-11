using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Console_Editon.character.race
{
    public class Altmer : Character
    {
        public Altmer() 
        {
            RaceCharacter = "Альтмер";
            HP = 100;
            Stamina = 100;
            Magic = 150;
            OP = 0;
            Damage = 1;
            Protection = 0;
            UniqueAttribute = "Нету";
        }
    }
}
