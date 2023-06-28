using Mathin;

Random rand = new Random();

Console.WindowHeight = 20;
Console.WindowWidth = 81;

Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.White;   

Console.WriteLine("Latesoft Mathin v1.1 - математическая программа / author Saltcult");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("команды:\n1. линейная функция\n2. парабола\n3. квадрат суммы\n4. квадрат разности\n5.[новое] гипербола\n6.[новое] куб суммы\n7.[новое] куб разности\nComing soon...");

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("Введите функцию/фсу:");

switch (Console.ReadLine().ToLower())
{
    case "линейная функция":
        Functions.LineFunc();
        break;
    case "парабола":
        Functions.ParabolaFunc();
        break;
    case "гипербола":
        Functions.HyperbolaFunc();
        break;
    case "квадрат суммы":
        Functions.SumSquare();
        break;
    case "квадрат разности":
        Functions.SubSquare();
        break;
    case "разность квадратов":
        Functions.SquareSub();
        break;
    case "куб суммы":
        Functions.SumCube();
        break;
    case "куб разности":
        Functions.SubCube();
        break;
    case "memory":
        Functions.NegevIsMyLv();
        break;
    default:
        int u = rand.Next(1, 7);
        if (u == 1) Console.WriteLine("1 из 6 \\ 1 - M");
        else if (u == 2) Console.WriteLine("2 из 6 \\ 2 - E");
        else if (u == 3) Console.WriteLine("3 из 6 \\ 3 - M");
        else if (u == 4) Console.WriteLine("4 из 6 \\ 4 - O");
        else if (u == 5) Console.WriteLine("5 из 6 \\ 5 - R");
        else if (u == 6) Console.WriteLine("5 из 6 \\ 6 - Y");
        else Console.WriteLine("...ты близок?");
        break;
}

Console.WriteLine("Нажмите любою клавишу чтобы закрыть программу");
Console.ReadKey();