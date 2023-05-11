using Skyrim_Console_Editon.character.race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Console_Editon.character
{
    public class Character 
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Stamina { get; set; }
        public int Magic { get; set; }
        public int Damage { get; set; }
        public int Protection { get; set; }
        public int OP { get; set; }
        public string UniqueAttribute { get; set; }
        public string ClassCharacter { get; set; }
        public string RaceCharacter { get; set; }

    }
}
