using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egednevnick
{
    internal class Program
    {
        static void Main()
        {
            DateTime dataa = new DateTime(2023, 10, 10);

            int minStrelka = 1;
            int maxStrelka = 2;

            int posposition = 1;

            Console.WriteLine("наша дата:" + dataa);
            while (true)
            {
                //это блок кода для стрелочек "вверх-вниз"
                ConsoleKeyInfo klavishka = Console.ReadKey();
                Console.Clear();

                if (klavishka.Key == ConsoleKey.UpArrow && posposition != minStrelka)
                {
                    posposition = posposition - 1;
                }
                if (klavishka.Key == ConsoleKey.DownArrow && posposition != maxStrelka)
                {
                    posposition = posposition + 1;
                }

                //а это для стрелочек "влево-вправо"
                if (klavishka.Key == ConsoleKey.LeftArrow)
                {
                    dataa = dataa.AddDays(-1);
                    Console.WriteLine("наша дата:" + dataa);
                }
                if (klavishka.Key == ConsoleKey.RightArrow)
                {
                    dataa = dataa.AddDays(+1);
                    Console.WriteLine("наша дата:" + dataa);
                }

                //это первая заметка
                if (dataa.Day == 11)
                {
                    Console.WriteLine("наша дата:" + dataa);
                    Console.Clear();
                    Console.WriteLine("наша дата:" + dataa);
                    menushka1();
                    if (klavishka.Key == ConsoleKey.Enter)
                    {
                        if (posposition == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("наша дата:" + dataa);
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("                СДЕЛАТЬ ПРАКТОСЫ                    ");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("описание: надо сделать практос по питону и по шарпам");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("дата, когда надо завершить:");
                            Console.WriteLine("чем раньше тем лучше, но срок сдачи шарпов 15.10.2023");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("личный комментарий: устала");
                        }
                        else if (posposition == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("наша дата:" + dataa);
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("               ПОГУЛЯТЬ С ПИДРУЖКОЙ                 ");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("описание: съездить с пидружкой в музей японских ретро тачек");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("дата, когда надо завершить:");
                            Console.WriteLine("10.10.2023");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("личный комментарий: в итоге поехали пить пиво");
                        }
                    }
                }

                //это вторая заметка
                if (dataa.Day == 13)
                {
                    Console.WriteLine("наша дата:" + dataa);
                    Console.Clear();
                    Console.WriteLine("наша дата:" + dataa);
                    menushka2();
                    if (klavishka.Key == ConsoleKey.Enter)
                    {
                        if (posposition == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("наша дата:" + dataa);
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("                ПАКУШАТЬ ПЕЛЬМЕШИ                   ");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("описание: надо сварить пельмеши и скушать их пока горяченькие");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("дата, когда надо завершить:");
                            Console.WriteLine("СРАЗУ ЖЕ!!!");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("личный комментарий: с кайфом покушала");
                        }
                        else if (posposition == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("наша дата:" + dataa);
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("                 СЕСТЬ ЗА ПРАКТОСЫ                  ");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("описание: теперь надо сделать философию, базу данных и чето еще, но я уже не помню");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("дата, когда надо завершить:");
                            Console.WriteLine("17.10.2023");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("личный комментарий: устала");
                        }
                    }
                }

                //это третья заметка
                if (dataa.Day == 14)
                {
                    Console.WriteLine("наша дата:" + dataa);
                    Console.Clear();
                    Console.WriteLine("наша дата:" + dataa);
                    menushka3();
                    if (klavishka.Key == ConsoleKey.Enter)
                    {
                        if (posposition == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("наша дата:" + dataa);
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("            ПОСМОТРЕТЬ ТУПЫЕ ВИДОСИКИ               ");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("описание: найти видосик на +- 10 минут и сидеть хихикать");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("дата, когда надо завершить:");
                            Console.WriteLine("14.10.2023");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("личный комментарий: люблю смешные видосики с котиками (готова всегда их смотреть)");
                        }
                        else if (posposition == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("наша дата:" + dataa);
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("              ПОКУШАТЬ ЛАПШИЧЫЙ СУПЧИК              ");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("описание: приготовить сперва, а потом с кайом покушать");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("дата, когда надо завершить:");
                            Console.WriteLine("17.10.2023");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("личный комментарий: больше котиков люблю только лапшичку");
                        }
                    }
                }

                //ТУТ БУДЕТ ПОПЫТКА В РЕАЛИЗАЦИЮ ДОП.ЗАДАНИЯ
                if (dataa.Day == 12)
                {
                    Console.WriteLine("наша дата:" + dataa);
                    Console.Clear();
                    Console.WriteLine("наша дата:" + dataa);
                    menushka4();
                    if (klavishka.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("               ВВЕДИТЕ НОВУЮ ЗАМЕТКУ :              ");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.ReadLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("          ТЕПЕРЬ ВВЕДИТЕ ВРЕМЯ ВЫПОЛНЕНИЯ :         ");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.ReadLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("          ТЕПЕРЬ ВВЕДИТЕ ЛИЧНЫЙ КОММЕНТАРИЙ :       ");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.ReadLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    }
                }//вроде получилось реализовать но я хз как это точно должно работать (я ту мач радеюсь на дополнительную пятерочку

                Console.SetCursorPosition(0, posposition);
                Console.WriteLine(">>");
            }
        }

        private static void menushka4()
        {
            Console.WriteLine("   1. ввод новой заметки!");
        }

        private static void menushka1()
        {
            Console.WriteLine("   1. сделать практосы");
            Console.WriteLine("   2. лечь поспать");
        }

        private static void menushka2()
        {
            Console.WriteLine("   1. пакушать пельмеши");
            Console.WriteLine("   2. сесть за практосы");
        }

        private static void menushka3()
        {
            Console.WriteLine("   1. посмотреть тупые видосики");
            Console.WriteLine("   2. покушать лапшичный супчик");
        }
    } 
}

