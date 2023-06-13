using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class Text
    {
        public void Text1()
        {


            Console.WriteLine("ПОЕЗД В ПУСАН");
            Console.WriteLine();
            Console.WriteLine("Вы проснулись с головной болью и звоном в ушах в каком-то переулке города.");
            Console.WriteLine("Вы совершенно не помните как сюда попали и что с вами случилось.");
            Console.WriteLine("Вы видите пожар и хаос на основной улице.");
            Console.WriteLine("А также каких-то ходячих мертвецов......");
            Console.WriteLine(".....зомби?");
            Console.WriteLine();

            Console.WriteLine("Здравствуй. Мир поражен неизвестным вирусом, который превращает людей в зомби за считанные минуты.");
            Console.WriteLine("Твоя главная цель - выжить.");
            Console.WriteLine("Назови свое имя.");
            Console.WriteLine();
            string nickname  = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Твоя первая задача - добраться до поезда, который идёт в Пусан.");
            Console.WriteLine("Пусан - единственный город, который не был захвачен зомби и до сих пор держит оборону.");
            Console.WriteLine("По ходу игры ты сможешь выбирать пути по которым идти, собирать ресурсы и получать опыт.");
            Console.WriteLine("Но также тебе придется сражаться с зомби, которые встретятся на пути.");
            Console.WriteLine("Чтобы попасть на поезд тебе нужно заработать не меньше 1000 единиц опыта.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выживи. Удачи, " + nickname);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();


            

        }
    }
}
