using Skyrim_Console_Editon.character;
using Skyrim_Console_Editon.enemies;
using Skyrim_Console_Editon.game;
using Skyrim_Console_Editon.items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Console_Editon.locations
{
    public class StartingLocation
    {
        public StartingLocation(Character character) 
        {
            Game game = new Game();
            Enemi enemi = new Wolf();
            Console.WriteLine("ВНИМАНИЕ ЕСЛИ ВЫ УМРЕТЕ ВО ВРЕМЯ ПРИКЛЮЧЕНИЯ ВЫ НАЧНЕТЕ ИГРУ ЗАНОВО");
            Console.WriteLine("Дракон улетел. Вы только что сбежали из крпости Хелген, вам нужно в Ривервуд может там ва помогут (для продолжения нажмите Enter)");
            Console.ReadLine();
            game.Starting(character);
            Console.WriteLine("Вы получили прибавку к статам в зависимости от вашего класса");
            Console.WriteLine("По дороге в Ривервуд на вас напал волк");
            game.Fight(character, enemi);
            character.OP += enemi.Xp;            
            Console.WriteLine("Убив волка ты доходишь без проблем");
        }
        
    }
}
