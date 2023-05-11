using Skyrim_Console_Editon.character;
using Skyrim_Console_Editon.character.race;
using Skyrim_Console_Editon.enemies;
using Skyrim_Console_Editon.items;
using Skyrim_Console_Editon.locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim_Console_Editon.game
{
    public class Game
    {
        public Character CreatePerson(int race, int changClass)
        {
            Character character;
            switch(race)
            {
                case 0:
                {
                        character = new Breton();
                        break;
                }
                case 1:
                    {
                        character = new Nord();
                        break;
                    }
                case 2:
                    {
                        character = new Imperials();
                        break;
                    }
                case 3:
                    {
                        character = new Redguards();
                        break;
                    }
                case 4:
                    {
                        character = new Altmer();
                        break;
                    }
                case 5:
                    {
                        character = new Bosmer();
                        break;
                    }
                case 6:
                    {
                        character = new Dunmer();
                        break;
                    }
                case 7:
                    {
                        character = new Orcs();
                        break;
                    }
                case 8:
                    {
                        character = new Argonians();
                        break;
                    }
                case 9:
                    {
                        character = new Khajiit();
                        break;
                    }
                    default: { throw new Exception(); }
            }
            switch (changClass)
            {
                case 0:
                    {
                        character.ClassCharacter = "Воин";
                        break;
                    }
                case 1:
                    {
                        character.ClassCharacter = "Лучник";
                        break;
                    }
                case 2:
                    {
                        character.ClassCharacter = "Маг";
                        break;
                    }
                    default: { throw new Exception(); }
            }
            return character;
        }

        public void PlayerInformation(Character character)
        {
            Console.WriteLine("Это ты \n" + "Имя {0}\n" + "Класс {1}\n" + "Расса {2}\n" + "HP {3}\n" + "Stamina {4}\n" + "Magic {5}\n" + "Damage {6}\n" + "Protection {7}\n" +
                "OP {8}\n" + "Уникальная рассовая способность {9}", character.Name, character.ClassCharacter, character.RaceCharacter, character.HP, character.Stamina,
                character.Magic, character.Damage, character.Protection, character.OP, character.UniqueAttribute);
        }
        public void Fight(Character character, Enemi enemi)
        {
            for (; character.HP > 0;)
            {
                Console.WriteLine("Твоя атака");
                enemi.Hp -= character.Damage;
                Console.WriteLine("Hp противника {0}",enemi.Hp);
                if (enemi.Hp<=0)
                {
                    Console.WriteLine("Враг повержен");
                    break;
                }
                Console.WriteLine("Enter для продолжения");
                Console.ReadLine();
                Console.WriteLine("Атака противника");
                int damage = enemi.Damage-character.Protection;
                if (damage>0)
                {
                    character.HP -= damage;
                }
                Console.WriteLine("Hp твое {0} ", character.HP);
                Console.WriteLine("Enter для продолжения");
                Console.ReadLine();
            }
        }
        public void Starting(Character character)
        {
            if(character.ClassCharacter == "Воин")
            {
                character.Damage += 5;
                character.Protection += 3;
            }
            if (character.ClassCharacter == "Лучник")
            {
                character.Damage += 5;
                character.Protection += 1;
            }
            if (character.ClassCharacter == "Маг")
            {
                character.Damage += 7;
                character.Protection += 3;
            }
        }
        public void PlotRails(Character character)
        {
            StartingLocation startingLocation = new StartingLocation(character);
            Taverna(character);
            Console.Clear();
            Whiterun whiterun = new Whiterun(character);
        }
        public void Taverna(Character character)
        {
            Console.WriteLine("Твое состояние сейчас");
            PlayerInformation(character);
            Console.WriteLine("За Op ты можешь востановить здоровье или купить себе разные бонусы");
            Console.WriteLine("Востановить Hp, цена 3 Op (0),Купить прибавку к урону, цена 5 Op (1),Купить прибавку к броне, цена 4 Op (2), Выход(3)");
            var input = Console.ReadLine();
            while (input!="3")
            {
                if (input=="0" && character.OP>=3)
                {
                    character.HP += 5;
                }
                if (input == "1" && character.OP >= 5)
                {
                    character.Damage += 2;
                }
                if (input == "2" && character.OP >= 4)
                {
                    character.Protection += 1;
                }
            }
            Console.WriteLine("Закончил? Вперед к странствиям");
        }
    }
}
