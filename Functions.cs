using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathin
{
    internal class Functions
    {
        public static Random random = new Random();
        public static void LineFunc()
        {
            Console.WriteLine("Введите функцию вида y=kx+b");

            string funcRaw = Console.ReadLine();

            string[] funcHandledX = funcRaw.Split("=");

            string[] funcHandledY = funcHandledX[1].Split("+");

            string[] funcHandledZ = funcHandledX[1].Split("x");

            Console.WriteLine("Табличный вид? yes/no");

            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("Введите начальное и конечное число через x (пример: 2x5)");

                string cycleRaw = Console.ReadLine();

                string[] cycle = cycleRaw.Split("x");

                int i = Int32.Parse(cycle[0]);

                while (i < Int32.Parse(cycle[1]))
                {
                    Console.WriteLine($"x - {i} y - {Int32.Parse(funcHandledZ[0]) * i + Int32.Parse(funcHandledZ[1])}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Введите x:");
                int x = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"x - {x} y - {Int32.Parse(funcHandledZ[0]) * x + Int32.Parse(funcHandledZ[1])}");
            }

            int u = random.Next(1, 10);
            if (u == 1) Console.WriteLine("1 из 6 \\ 1 - M");
            else if (u == 2) Console.WriteLine("2 из 6 \\ 2 - E");
            else if (u == 3) Console.WriteLine("3 из 6 \\ 3 - M");
            else if (u == 4) Console.WriteLine("4 из 6 \\ 4 - O");
            else if (u == 5) Console.WriteLine("5 из 6 \\ 5 - R");
            else if (u == 6) Console.WriteLine("5 из 6 \\ 6 - Y");
            else Console.WriteLine("...ты близок?");
        }

        public static void ParabolaFunc()
        {
            Console.WriteLine("Введите функцию вида y=ax^2");

            string funcRaw = Console.ReadLine();

            string[] funcHandledX = funcRaw.Split("=");

            string[] funcHandledY = funcHandledX[1].Split("^");

            string[] funcHandledZ = funcHandledX[1].Split("x");

            Console.WriteLine("Табличный вид? yes/no");

            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("Введите начальное и конечное число через x (пример: 2x5)");

                string cycleRaw = Console.ReadLine();

                string[] cycle = cycleRaw.Split("x");

                int i = Int32.Parse(cycle[0]);

                while (i < Int32.Parse(cycle[1]))
                {
                    Console.WriteLine($"x - {i} y - {Int32.Parse(funcHandledZ[0]) * i * i}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Введите x:");
                int x = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"x - {x} y - {Int32.Parse(funcHandledZ[0]) * x * x}");
            }
        
        
        }

        public static void SumSquare()
        {
            Console.WriteLine("Введите выражения типа (a+b)^2");

            string SumSquareRaw = Console.ReadLine();

            SumSquareRaw = SumSquareRaw.Remove(0, 1);
            SumSquareRaw = SumSquareRaw.Remove(SumSquareRaw.Length - 3);

            string[] SumSquareValues = SumSquareRaw.Split("+");

            Console.WriteLine($"{Int32.Parse(SumSquareValues[0]) * Int32.Parse(SumSquareValues[0])} + {2 * Int32.Parse(SumSquareValues[0]) * Int32.Parse(SumSquareValues[1])} + {Int32.Parse(SumSquareValues[1]) * Int32.Parse(SumSquareValues[1])}");

            int u = random.Next(1, 10);
            if (u == 1) Console.WriteLine("1 из 6 \\ 1 - M");
            else if (u == 2) Console.WriteLine("2 из 6 \\ 2 - E");
            else if (u == 3) Console.WriteLine("3 из 6 \\ 3 - M");
            else if (u == 4) Console.WriteLine("4 из 6 \\ 4 - O");
            else if (u == 5) Console.WriteLine("5 из 6 \\ 5 - R");
            else if (u == 6) Console.WriteLine("5 из 6 \\ 6 - Y");
            else Console.WriteLine("...ты близок?");
        }

        public static void SubSquare()
        {
            Console.WriteLine("Введите выражения типа (a-b)^2");

            string SubSquareRaw = Console.ReadLine();

            SubSquareRaw = SubSquareRaw.Remove(0, 1);
            SubSquareRaw = SubSquareRaw.Remove(SubSquareRaw.Length - 3);

            string[] SubSquareValues = SubSquareRaw.Split("-");

            Console.WriteLine($"{Int32.Parse(SubSquareValues[0]) * Int32.Parse(SubSquareValues[0])} - {2 * Int32.Parse(SubSquareValues[0]) * Int32.Parse(SubSquareValues[1])} + {Int32.Parse(SubSquareValues[1]) * Int32.Parse(SubSquareValues[1])}");

            int u = random.Next(1, 12);
            if (u == 1) Console.WriteLine("1 из 6 \\ 1 - M");
            else if (u == 2) Console.WriteLine("2 из 6 \\ 2 - E");
            else if (u == 3) Console.WriteLine("3 из 6 \\ 3 - M");
            else if (u == 4) Console.WriteLine("4 из 6 \\ 4 - O");
            else if (u == 5) Console.WriteLine("5 из 6 \\ 5 - R");
            else if (u == 6) Console.WriteLine("5 из 6 \\ 6 - Y");
            else Console.WriteLine("...ты близок?");
        }

        public static void NegevIsMyLv()
        {
            Console.WindowHeight = 35;
            Console.WindowWidth = 120;

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("v1.1 ВЫ НАШЛИ ПАСХАЛКУ!!!! ПИШИТЕ МНЕ ОБ ЭТОМ В ЛС В ТЕЛЕГЕ!!! @saltcult ГДЕ НАПИСАНА ТОЧКА ЭТО ЗНАЧИТ ЧТО ЭТО НОВОЕ");

            Console.WriteLine("Я не забуду это время... Лето 2023... а еще Негев моя нящааа(она успокаивает лучше всего на свете, она психику мне починила, спс саше за то что отправил стикер с ей и я ее вспомнил))))) да я вас уже задолбал с ней, но *Я АХЕРЕТЬ ЛЮБЛЮ ЭТОГО ПЕРСОНАЖА Я СОШЕЛ С УМА:)");
            Console.WriteLine("ниже текста одной моей любимой песни sugarcult - memory(бурнаут 3 саундтрек))) слушаю 24/7(shotdown и BaH тоже)");
            Console.WriteLine("отдельное спасибо за все челам из пацанов burunduk229, илья, nikody, санчосу, smoothycat,khaniks, элмир");
            Console.WriteLine("я понял что я часто в 7 классе был дебилом, спасибо всем за все.");
            Console.WriteLine("*Здравствуйте, и я уже делаю обновление и вижу эту пасхалку и понимаю что я какой то слишком странный когда такие вещи пишу.");
            Console.WriteLine("*ребят, я немного конченный, поэтому строго не судите МАЙ ИНДЕПЕНДАНС ДЭЭЭЭЭЙЙЙЙ");
            Console.WriteLine("*вот что я здесь делаю, надо все переосмыслить");
            Console.WriteLine("*рано или поздно мы все сдохнем\n*и насколько наша жизнь была осмысленной мы пока не знаем\n*ИДИ РАБОТАЙ\n*когда человек умирает он осознает насколько его жизнь была со смыслом\n*я не хочу просрать жизнь" +
                "\n*надо быть лучшей версией себя\nдля чего мы вообще живем\nя не хочу когда я сдох все осталось как прежде\nя не хочу просрать жизнь");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("This may never start\nWe could fall apart.\nAnd I’d be your memory.\nLost your sense of fear.\nFeelings insincere.\nCan I be your memory?");
            Console.WriteLine("и последний вопрос... я чмо тупое которое только умничает? аххахаха уже 0:33 23.06.23, а я придумываю послание :)");
            
            switch (Console.ReadLine().ToLower())
            {
                case "да":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();

                    while (true)
                    {
                        Console.WriteLine("SHOT DOWN, SPUN ROUND, STRONG OUT... STILL, AROUND, SOMEHOW...(тоже отрывок из одной любимой песни nine black alps)");
                    }
                case "нет":
                    Console.WriteLine("спасибо. можешь закрывать прогу, напиши мне чето хорошее, пожалуйста :)");
                    break;
                default:
                    Console.WriteLine("выбери из этих 2 вариков выше, а не придумывай тут свое :D");
                    break;
            }
        }

        public static void SumCube()
        {
            Console.WriteLine("Введите выражения типа (a+b)^3");

            string SumCubeRaw = Console.ReadLine();

            SumCubeRaw = SumCubeRaw.Remove(0, 1);
            SumCubeRaw = SumCubeRaw.Remove(SumCubeRaw.Length - 3);

            string[] SumCubeValues = SumCubeRaw.Split("+");

            Console.WriteLine($"{Int32.Parse(SumCubeValues[0]) * Int32.Parse(SumCubeValues[0]) * Int32.Parse(SumCubeValues[0])} + {3 * Int32.Parse(SumCubeValues[0]) * Int32.Parse(SumCubeValues[0]) * Int32.Parse(SumCubeValues[1])} + {3 * Int32.Parse(SumCubeValues[0]) * Int32.Parse(SumCubeValues[1]) * Int32.Parse(SumCubeValues[1])} + {Int32.Parse(SumCubeValues[1]) * Int32.Parse(SumCubeValues[1]) * Int32.Parse(SumCubeValues[1])}");
        }

        public static void SubCube()
        {
            Console.WriteLine("Введите выражения типа (a-b)^3");

            string SubCubeRaw = Console.ReadLine();

            SubCubeRaw = SubCubeRaw.Remove(0, 1);
            SubCubeRaw = SubCubeRaw.Remove(SubCubeRaw.Length - 3);

            string[] SubCubeValues = SubCubeRaw.Split("-");

            Console.WriteLine($"{Int32.Parse(SubCubeValues[0]) * Int32.Parse(SubCubeValues[0]) * Int32.Parse(SubCubeValues[0])} + {3 * Int32.Parse(SubCubeValues[0]) * Int32.Parse(SubCubeValues[0]) * Int32.Parse(SubCubeValues[1])} + {3 * Int32.Parse(SubCubeValues[0]) * Int32.Parse(SubCubeValues[1]) * Int32.Parse(SubCubeValues[1])} + {Int32.Parse(SubCubeValues[1]) * Int32.Parse(SubCubeValues[1]) * Int32.Parse(SubCubeValues[1])}");

        }

        public static void SquareSub()
        {
            Console.WriteLine("a^2-b^2 / Введите выражения типа a и b через x(пример 4x2)");

            string valuesRaw = Console.ReadLine();
            string[] values = valuesRaw.Split("x");

            Console.WriteLine($"({float.Parse(values[0])}+{float.Parse(values[1])})({float.Parse(values[0])}-{float.Parse(values[1])})");
        }

        public static void HyperbolaFunc()
        {
            Console.WriteLine("Введите функцию вида y=k/x");

            string funcRaw = Console.ReadLine();

            string[] funcHandledX = funcRaw.Split("=");

            string[] funcHandledY = funcHandledX[1].Split("/");

            Console.WriteLine("Табличный вид? yes/no");

            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("Введите начальное и конечное число через x (пример: 2x5)");

                string cycleRaw = Console.ReadLine();

                string[] cycle = cycleRaw.Split("x");

                int i = Int32.Parse(cycle[0]);

                while (i < Int32.Parse(cycle[1]))
                {
                    Console.WriteLine($"x - {i} y - {float.Parse(funcHandledY[0]) / i}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Введите x:");
                float x = float.Parse(Console.ReadLine());
                Console.WriteLine($"x - {x} y - {float.Parse(funcHandledY[0]) / x}");
            }
        }
    }
}
