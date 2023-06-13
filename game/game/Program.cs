using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;


namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Text text = new Text();
            text.Text1();

            Player pl = new Player("Выживший", 40, 10, 2, 25, 0);
            Monsters mon = new Monsters("Зомби 1 lvl", 30, 6, 3, 50, 15);
            ZombieLVL2 z2 = new ZombieLVL2("Зомби 2 lvl", 60, 15, 5, 90, 20);
            ZombieLVL3 z3 = new ZombieLVL3("Зомби 3 lvl", 150, 30, 10, 150, 30);
            ZombieLVL4 z4 = new ZombieLVL4("Зомби 4 lvl", 210, 50, 20, 200, 35);
           
            if (pl.exp >= 1000)
            {
                Console.WriteLine("ПОЗДРАВЛЯЮ! ТЫ СМОГ! НАДЕЮСЬ В ПУСАНЕ ТЕБЕ ПОМОГУТ. УДАЧИ, ВЫЖИВШИЙ.");

            }
            else
            {
                while (true)
                {

                    Console.WriteLine();
                    Console.WriteLine("Выберите путь:");
                    Console.WriteLine("1. Информация об игроке.");
                    Console.WriteLine("2. Битва с зомби 1 лвл");
                    Console.WriteLine("3. Битва с зомби 2 лвл");
                    Console.WriteLine("4. Битва с зомби 3 лвл");
                    Console.WriteLine("5. Битва с зомби 4 лвл");
                    Console.WriteLine("6. Магазин");
                    Console.WriteLine("7. БЕЖАТЬ НА ПОЕЗД");
                    Console.WriteLine();


                    Console.WriteLine("Введите номер пути");
                    int ex = Convert.ToInt32(Console.ReadLine());
                    switch (ex)
                    {
                        case 1:
                            Info();
                            Console.WriteLine();
                            break;
                        case 2:
                            Way1();
                            Console.WriteLine();
                            break;
                        case 3:
                            Way2();
                            Console.WriteLine();
                            break;
                        case 4:
                            Way3();
                            Console.WriteLine();
                            break;
                        case 5:
                            Way4();
                            Console.WriteLine();
                            break;
                        case 6:
                            Shop();
                            Console.WriteLine();
                            break;
                        case 7:
                            Last();
                            Console.WriteLine();
                            break;


                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Нет такого пути. Введите другое значение.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                    }

                    Console.WriteLine("Продолжить игру? (Y)es/(N)o");
                    Console.WriteLine();

                    string choiseEx = Console.ReadLine();
                    if (choiseEx == "Y" || choiseEx == "y" || choiseEx == "yes" || choiseEx == "Yes" || choiseEx == "YES")
                    {
                        continue;

                    }
                    else if (choiseEx == "N" || choiseEx == "n" || choiseEx == "no" || choiseEx == "No" || choiseEx == "NO")
                    {
                        break;
                    }
                }

                void Info()
                {
                    Console.WriteLine("Уровень здоровья: " + pl.hp);
                    Console.WriteLine("Урон: " + pl.dm);
                    Console.WriteLine("Защита: " + pl.pt);
                    Console.WriteLine("Опыт: " + pl.exp);
                    Console.WriteLine("Монеты: " + pl.coin);
                }



                void Way1()
                {
                    Console.WriteLine("Начать бой с зомби 1 lvl? (yes or no)");
                    if (Console.ReadLine() == "yes" || Console.ReadLine() == "y")
                    {
                        Console.WriteLine("В бой!");
                        while (pl.hp > 0 && mon.hp > 0)
                        {
                            // Рассчитываем урон, который игрок нанесет монстру
                            int dmP2 = pl.dm - mon.pt;
                            if (dmP2 <= 0)
                            {
                                dmP2 = 0;
                            }

                            // Отнимаем здоровье у монстра
                            mon.hp -= dmP2;
                            Console.WriteLine("Выживший нанес {0} урона зомби", dmP2);

                            // Проверяем, умер ли монстр
                            if (mon.hp <= 0)
                            {

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Выживший победил!");
                                Console.WriteLine("Здоровье выжившего: {0}", pl.hp);
                                int hpW1 = pl.hp + 50;
                                int dmW1 = pl.dm + mon.dm;
                                int ptW1 = pl.pt + mon.pt;
                                int expW1 = pl.exp + mon.exp;
                                int coinW1 = pl.coin + mon.coin;
                                pl.exp = expW1; pl.hp = hpW1; pl.dm = dmW1; pl.pt = ptW1; pl.coin = coinW1;
                                mon.hp = 30;
                                Console.WriteLine("hp: " + pl.hp + " ваш опыт: " + pl.exp);
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }

                            // Рассчитываем урон, который монстр нанесет игроку
                            int dmM2 = mon.dm - pl.pt;
                            if (dmM2 <= 0)
                            {
                                dmM2 = 0;
                            }

                            // Отнимаем здоровье у игрока
                            pl.hp -= dmM2;
                            Console.WriteLine("Зомби нанес {0} урона выжившему", dmM2);

                            // Проверяем, умер ли игрок
                            if (pl.hp <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Зомби победил!");
                                Console.WriteLine("Здоровье зомби: {0}", mon.hp);
                                Console.WriteLine("Вы потеряли весь свой наигранный прогресс. Вам придется начать игру заново.");
                                pl.hp = 40; pl.dm = 10; pl.pt = 2; pl.exp = 25; pl.coin = 0;
                                mon.hp = 30;
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }

                            Console.WriteLine("Здоровье выжившего: {0}", pl.hp);
                            Console.WriteLine("Здоровье зомби: {0}", mon.hp);
                            Console.WriteLine("-----");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы сбежали или ввели неверное значение.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            void Way2()
            {
                Console.WriteLine("Начать бой с зомби 2 lvl? (yes or no)");
                if (pl.exp >= 100 && Console.ReadLine() == "yes" || Console.ReadLine() == "y")
                {
                    Console.WriteLine("В бой!");
                    while (pl.hp > 0 && z2.hp > 0)
                    {
                        // Рассчитываем урон, который игрок нанесет монстру
                        int dmP3 = pl.dm - z2.pt;
                        if (dmP3 <= 0)
                        {
                            dmP3 = 0;
                        }

                        // Отнимаем здоровье у монстра
                        z2.hp -= dmP3;
                        Console.WriteLine("Выживший нанес {0} урона зомби", dmP3);

                        // Проверяем, умер ли монстр
                        if (z2.hp <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Выживший победил!");
                            Console.WriteLine("Здоровье выжившего: {0}", pl.hp);
                            int hpW2 = pl.hp + 80;
                            int dmW2 = pl.dm + z2.dm;
                            int ptW2 = pl.pt + z2.pt;
                            int expW2 = pl.exp + z2.exp;
                            int coinW2 = pl.coin + z2.coin;
                            pl.exp = expW2; pl.hp = hpW2; pl.dm = dmW2; pl.pt = ptW2; pl.coin = coinW2;
                            z2.hp = 60;
                            Console.WriteLine("hp: " + pl.hp + ". ваш опыт: " + pl.exp);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }

                        // Рассчитываем урон, который монстр нанесет игроку
                        int dmM3 = z2.dm - pl.pt;
                        if (dmM3 <= 0)
                        {
                            dmM3 = 0;
                        }

                        // Отнимаем здоровье у игрока
                        pl.hp -= dmM3;
                        Console.WriteLine("Зомби нанес {0} урона выжившему", dmM3);

                        // Проверяем, умер ли игрок
                        if (pl.hp <= 0)
                        {
                            Console.WriteLine("Зомби победил!");
                            Console.WriteLine("Здоровье зомби: {0}", z2.hp);
                            Console.WriteLine("Вы потеряли весь свой наигранный прогресс. Вам придется начать игру заново.");
                            pl.hp = 40; pl.dm = 10; pl.pt = 2; pl.exp = 25; pl.coin = 0;
                            z2.hp = 60;
                            break;
                        }

                        Console.WriteLine("Здоровье выжившего: {0}", pl.hp);
                        Console.WriteLine("Здоровье зомби: {0}", z2.hp);
                        Console.WriteLine("-----");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-----");
                    Console.WriteLine("Вы сбежали или у вас недостаточно опыта или ввели неверное значение.");
                    Console.WriteLine("-----");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }


            void Way3()
            {

                Console.WriteLine("Начать бой с зомби 3 lvl? (yes or no)");
                if (pl.exp >= 350 && Console.ReadLine() == "yes" || Console.ReadLine() == "y")
                {
                    Console.WriteLine("В бой!");
                    while (pl.hp > 0 && z3.hp > 0)
                    {
                        // Рассчитываем урон, который игрок нанесет монстру
                        int dmP4 = pl.dm - z3.pt;
                        if (dmP4 <= 0)
                        {
                            dmP4 = 0;
                        }

                        // Отнимаем здоровье у монстра
                        z3.hp -= dmP4;
                        Console.WriteLine("Выживший нанес {0} урона зомби", dmP4);

                        // Проверяем, умер ли монстр
                        if (z3.hp <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Выживший победил!");
                            Console.WriteLine("Здоровье выжившего: {0}", pl.hp);
                            int hpW3 = pl.hp + 100;
                            int dmW3 = pl.dm + z3.dm;
                            int ptW3 = pl.pt + z3.pt;
                            int expW3 = pl.exp + z3.exp;
                            int coinW3 = pl.coin + z3.coin;
                            pl.exp = expW3; pl.hp = hpW3; pl.dm = dmW3; pl.pt = ptW3; pl.coin = coinW3;
                            z2.hp = 150;
                            Console.WriteLine("hp: " + pl.hp + ". ваш опыт: " + pl.exp);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }

                        // Рассчитываем урон, который монстр нанесет игроку
                        int dmM4 = z3.dm - pl.pt;
                        if (dmM4 <= 0)
                        {
                            dmM4 = 0;
                        }

                        // Отнимаем здоровье у игрока
                        pl.hp -= dmM4;
                        Console.WriteLine("Зомби нанес {0} урона выжившему", dmM4);

                        // Проверяем, умер ли игрок
                        if (pl.hp <= 0)
                        {
                            Console.WriteLine("Зомби победил!");
                            Console.WriteLine("Здоровье зомби: {0}", z3.hp);
                            Console.WriteLine("Вы потеряли весь свой наигранный прогресс. Вам придется начать игру заново.");
                            pl.hp = 40; pl.dm = 10; pl.pt = 2; pl.exp = 25; pl.coin = 0;
                            z3.hp = 150;
                            break;
                        }

                        Console.WriteLine("Здоровье выжившего: {0}", pl.hp);
                        Console.WriteLine("Здоровье зомби: {0}", z3.hp);
                        Console.WriteLine("-----");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-----");
                    Console.WriteLine("Вы сбежали или у вас недостаточно опыта или ввели неверное значение.");
                    Console.WriteLine("-----");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }


            void Way4()
            {
                Console.WriteLine("Начать бой с зомби 4 lvl? (yes or no)");
                if (pl.exp >= 600 && Console.ReadLine() == "yes" || Console.ReadLine() == "y")
                {
                    Console.WriteLine("В бой!");
                    while (pl.hp > 0 && z4.hp > 0)
                    {
                        // Рассчитываем урон, который игрок нанесет монстру
                        int dmP5 = pl.dm - z4.pt;
                        if (dmP5 <= 0)
                        {
                            dmP5 = 0;
                        }

                        // Отнимаем здоровье у монстра
                        z4.hp -= dmP5;
                        Console.WriteLine("Выживший нанес {0} урона зомби", dmP5);

                        // Проверяем, умер ли монстр
                        if (z4.hp <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Выживший победил!");
                            Console.WriteLine("Здоровье выжившего: {0}", pl.hp);
                            int hpW4 = pl.hp + 120;
                            int dmW4 = pl.dm + z4.dm;
                            int ptW4 = pl.pt + z4.pt;
                            int expW4 = pl.exp + z4.exp;
                            int coinW4 = pl.coin + z4.coin;
                            pl.exp = expW4; pl.hp = hpW4; pl.dm = dmW4; pl.pt = ptW4; pl.coin = coinW4;
                            z2.hp = 210;
                            Console.WriteLine("hp: " + pl.hp + ". ваш опыт: " + pl.exp);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }

                        // Рассчитываем урон, который монстр нанесет игроку
                        int dmM5 = z4.dm - pl.pt;
                        if (dmM5 <= 0)
                        {
                            dmM5 = 0;
                        }

                        // Отнимаем здоровье у игрока
                        pl.hp -= dmM5;
                        Console.WriteLine("Зомби нанес {0} урона выжившему", dmM5);

                        // Проверяем, умер ли игрок
                        if (pl.hp <= 0)
                        {
                            Console.WriteLine("Зомби победил!");
                            Console.WriteLine("Здоровье зомби: {0}", z4.hp);
                            Console.WriteLine("Вы потеряли весь свой наигранный прогресс. Вам придется начать игру заново.");
                            pl.hp = 40; pl.dm = 10; pl.pt = 2; pl.exp = 25; pl.coin = 0;
                            z4.hp = 210;
                            break;
                        }

                        Console.WriteLine("Здоровье выжившего: {0}", pl.hp);
                        Console.WriteLine("Здоровье зомби: {0}", z4.hp);
                        Console.WriteLine("-----");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-----");
                    Console.WriteLine("Вы сбежали или у вас недостаточно опыта или ввели неверное значение.");
                    Console.WriteLine("-----");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
            void Shop()
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Введите номер покупки");
                    Console.WriteLine("1.  +30 здоровья за 30 монет");
                    Console.WriteLine("2.  +50 здоровья за 50 монет");
                    Console.WriteLine("3.  +70 здоровья за 70 монет");
                    Console.WriteLine("4.  +50 опыта за 50 монет");
                    Console.WriteLine("5.  +100 опыта за 100 монет");
                    Console.WriteLine("-----");
                    int ex1 = Convert.ToInt32(Console.ReadLine());
                    switch (ex1)
                    {
                        case 1:
                            if (pl.coin >= 30)
                            {
                                int shop1 = pl.hp + 30;
                                pl.hp = shop1;
                                int coinS1 = pl.coin - 30;
                                pl.coin = coinS1;
                                Console.WriteLine("Вы купил 30 дополнительных единиц жизни.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("У вас недостаточно монет.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();
                            break;

                        case 2:
                            if (pl.coin >= 50)
                            {
                                int shop2 = pl.hp + 50;
                                pl.hp = shop2;
                                int coinS2 = pl.coin - 50;
                                pl.coin = coinS2;
                                Console.WriteLine("Вы купил 50 дополнительных единиц жизни.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("У вас недостаточно монет.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();
                            break;

                        case 3:
                            if (pl.coin >= 70)
                            {
                                int shop3 = pl.hp + 70;
                                pl.hp = shop3;
                                int coinS3 = pl.coin - 70;
                                pl.coin = coinS3;
                                Console.WriteLine("Вы купил 70 дополнительных единиц жизни.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("У вас недостаточно монет.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();
                            break;

                        case 4:
                            if (pl.coin >= 50)
                            {
                                int shop4 = pl.exp + 50;
                                pl.exp = shop4;
                                int coinS4 = pl.coin - 50;
                                pl.coin = coinS4;
                                Console.WriteLine("Вы купил 50 дополнительных очков опыта.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("У вас недостаточно монет.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();
                            break;

                        case 5:
                            if (pl.coin >= 100)
                            {
                                int shop5 = pl.exp + 100;
                                pl.exp = shop5;
                                int coinS5 = pl.coin - 100;
                                pl.coin = coinS5;
                                Console.WriteLine("Вы купил 100 дополнительных очков опыта.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("У вас недостаточно монет.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();
                            break;


                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Нет такого товара. Введите другое значение.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Продолжить покупки? (Y)es/(N)o");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                    string choiseShop = Console.ReadLine();
                    if (choiseShop == "Y" || choiseShop == "y" || choiseShop == "yes" || choiseShop == "Yes" || choiseShop == "YES")
                    {
                        continue;
                    }
                    else if (choiseShop == "N" || choiseShop == "n" || choiseShop == "no" || choiseShop == "No" || choiseShop == "NO")
                    {
                        break;
                    }


                }
            }

            void Last()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Вы готовы отправиться на поезд? (yes or no)");
                if (Console.ReadLine() == "yes" || Console.ReadLine() == "y")
                {
                    Console.WriteLine("Вперёд!");
                    if (pl.exp >= 1000)
                    {
                        Console.WriteLine("ПОЗДРАВЛЯЮ! ТЫ СМОГ! НАДЕЮСЬ В ПУСАНЕ ТЕБЕ ПОМОГУТ. УДАЧИ, ВЫЖИВШИЙ.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("У тебя недостаточно опыта. Поспеши. Зараженных становится всё больше.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
                else
                {
                    Console.WriteLine("Поспеши! Ты можешь не успеть спастись от зомби!");
                }

                Console.ReadKey();

            }






        }
    }
}
