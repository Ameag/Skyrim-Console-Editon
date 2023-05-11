using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Console_Editon.items
{
    public class Items
    {
        public Dictionary<string, int> swords = new Dictionary<string, int>()
        {
            {"Железный меч",5 },
            {"Стальной меч",7 },
            {"Орочий меч",8 },
            {"Стекляный меч",9 },
            {"Эбонитовый меч",10 },
            {"Даэдрический меч",11 },
            {"Костянной меч",12 }
        };
        public Dictionary<string, int> bows = new Dictionary<string, int>()
        {
            {"Деревянный лук",5 },
            {"Стальной лук",7 },
            {"Орочий лук",8 },
            {"Стекляный лук",9 },
            {"Эбонитовый лук",10 },
            {"Даэдрический лук",11 },
            {"Костянной лук",12 }
        };
        public Dictionary<string, int> spells = new Dictionary<string, int>()
        {
            {"Пламя",5 },
            {"Огненная стрела",7 },
            {"Молния",8 },
            {"Ледяная буря",9 },
            {"Цепная молния",10 },
            {"Ледяное копьё",11 },
            {"Гроза с молниями",12 }
        };
        public Dictionary<string, int> armor = new Dictionary<string, int>()
        {
            {"Железная броня",1 },
            {"Стальная броня",3 },
            {"Орочии доспехи",4 },
            {"Стекляная броня",4 },
            {"эбонитовые доспехи",6 },
            {"Даэдрический доспех",7 },
            {"Костянной доспех",8 }
        };

    }
}
