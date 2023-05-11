using Skyrim_Console_Editon.character;
using Skyrim_Console_Editon.game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Skyrim_Console_Editon
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в пре альфа бета тест Skyrim Console Editon (многие вишки еще пока не реализованны, но если у создателя будет время и желание он допилит)");
            Console.ReadLine();
            Game game = new Game();
            Console.WriteLine("Окно создание рассы\n" +
                "Бретонцы(0) Кровь бретонцев даёт 50 %-е сопротивление магии." +
                "\nИмперцы(1) Везде, где можно найти золото, имперцы как-то умудряются найти чуть больше." +
                "\nНорды(2) Норды имеют 50 %-ю сопротивляемость холоду." +
                "\nРедгарды(3) Редгарды имеют 50%-ю сопротивляемость ядам" +
                "\nАльтмеры(4) Высокие эльфы от рождения имеют 50 дополнительных единиц магии." +
                "\nБосмеры(5) Босмерская кровь даёт вам 50 % сопротивление ядам и болезням." +
                "\nДанмеры(6) Данмерская кровь даёт вам 50 % сопротивление огню." +
                "\nОрки(7) Сильно бьют" +
                "\nАргониане(8) ящерки\n" +
                "Каджиты(9) котики ;3 у них лапки");

            var changeRace = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Выберите свой класс\n" +
                "Воин(0)\n" +
                "Лучник(1)\n" +
                "Магистр анальных искуств(2)\n" +
                "(Из за технологичных ограничений ты не можешь быть войном и анальным исскусителем одновременно по этому выбирай с умом это навсегда)");
            var changClass = int.Parse(Console.ReadLine());
            Console.Clear();

            Character character = game.CreatePerson(changeRace, changClass);

            Console.WriteLine("Введите имя персонажа");
            character.Name= Console.ReadLine();

            game.PlotRails(character);

        }
        
    }
}
