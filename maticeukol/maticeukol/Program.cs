using System.Data;

namespace maticeukol
{
    internal class Program
    {
        //naplní pole od 1 dál
        static void FillArray(int[,] array)
        {
            int numbertoadd = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = numbertoadd;
                    numbertoadd++;
                }
            }
        }
        //naplní pole náhodně
        static void FillArrayRandom(int[,] array)
        {
            Random rng = new Random();
            for (int i = 0;i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rng.Next(1,10);
                }
            }
        }
        //vypíše pole
        static void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        //vynásobí pole číslem
        static void MultiplyArray(int[,] array, int constant)
        {
            for(int i = 0;i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = constant * array[i,j];
                }
            }
        }
        //vynásobí řádek číslem
        static void MultiplyRow(int[,] array, int constant, int row)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                array[row, i] = constant * array[row, i];
            }
        }
        //vynásobí sloupec číslem
        static void MultiplyColumn(int[,] array, int constant, int column)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, column] = constant * array[i, column];
            }
        }
        //jistota zadání správného čísla; nápověda z chatgpt
        static int NumberInRange(int input, int min, int max)
        {
            bool InRange = false;

            while (InRange == false)
            {
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input >= min && input < max)
                    {
                        InRange = true;
                        return input;
                    }
                    else
                    {
                        Console.WriteLine($"můžeš jen mezi {min} a {max-1}");
                    }
                }
                else
                {
                    Console.WriteLine("napiš platné číslo");
                }
            }
            return -1;
        }
        //odečtení původního pole od nového
        static void Subtract(int[,] array, int rows, int columns)
        {
            int[,] Sum2DArray = new int[rows, columns];
            //FillArray(Sum2DArray);
            FillArrayRandom(Sum2DArray);
            Console.WriteLine("odčítám od pole");
            WriteArray(Sum2DArray);
            Console.Write("\n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Sum2DArray[i, j] - array[i, j];
                }
            }
        }
        //sečtení s novým polem
        static void Add(int[,] array, int rows, int columns)
        {
            int[,] Sum2DArray = new int[rows, columns];
            //FillArray(Sum2DArray);
            FillArrayRandom(Sum2DArray);
            Console.WriteLine("sčítám s polem");
            WriteArray(Sum2DArray);
            Console.Write("\n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Sum2DArray[i, j] + array[i, j];
                }
            }
        }
        //vynásobí pole s druhou maticí stejných rozměrů; nápověda z photomath a chatgpt
        static void MultiplyWithArray(int[,] array, int rows, int columns, int[,] ResultArray)
        {
            if (rows != columns)
            {
                Console.WriteLine("tyto matice nejde násobit (počet řádků u 1. není stejný jako počet sloupců u 2.)");
                return;
            }
            int[,] Multiply2DArray = new int[rows, columns];
            //FillArray(Multiply2DArray);
            FillArrayRandom(Multiply2DArray);
            Console.WriteLine("násobím s polem");
            WriteArray(Multiply2DArray);
            Console.Write("\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        ResultArray[i, j] += array[i, k] * Multiply2DArray[k, j];
                    }
                }
            }
        }
        //sečte všechny čísla v matici
        static int SumOfArray(int[,] array, int Sum)
        {
            for (int i = 0;i < array.GetLength(0); i++)
            {
                for (int j =0; j < array.GetLength(1); j++)
                {
                    Sum += array[i, j];
                }
            }
            return Sum;
        }
        static int MaxOfArray(int[,] array, int Max)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   if (array[i, j] > Max)
                    {
                        Max = array[i, j];
                    }
                }
            }
            return Max;
        }
        static int MinOfArray(int[,] array, int Min)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < Min)
                    {
                        Min = array[i, j];
                    }
                }
            }
            return Min;
        }
        //body 12 + 5 + 7,5 (nebo 10) + 8 + (12,5) + 15
        static void Main(string[] args)
        {
            int rows = 0, columns = 0;
            Console.WriteLine("Zadej počet řádků");
            rows = NumberInRange(rows, 1, 20);
            Console.WriteLine("Zadej počet sloupců");
            columns = NumberInRange(columns, 1, 20);
            int[,] my2DArray = new int[rows, columns];
            //FillArray(my2DArray);
            FillArrayRandom(my2DArray);
            WriteArray(my2DArray);
            Console.WriteLine("Co chceš dělat?");
            string operation = Console.ReadLine();
            while (operation != "multiply" && operation != "subtract" && operation != "add" && operation != "multiplywitharray" && operation != "sum" && operation != "max" && operation != "min")
            {
                Console.WriteLine("napiš možnou operaci");
                operation = Console.ReadLine();
            }
            switch (operation)
            {
                case "multiply":
                    int multiplyer;
                    Console.WriteLine("čím chceš násobit?");
                    while (!int.TryParse(Console.ReadLine(), out multiplyer))
                    {
                        Console.WriteLine("Zadej platné celé číslo");
                    }
                    Console.WriteLine("chceš násobit all, row nebo column?");
                    string option = Console.ReadLine();
                    while (option != "all" && option != "row" && option != "column")                //násobení řádku, sloupce nebo všeho
                    {
                        Console.WriteLine("Zadej možnou možnost");
                        option = Console.ReadLine();
                    }
                    if (option == "all")
                    {
                        MultiplyArray(my2DArray, multiplyer);
                        WriteArray(my2DArray);
                    }
                    else if (option == "row")
                    {
                        int row = 0;
                        Console.WriteLine("jaký řádek chceš násobit?");
                        row = NumberInRange(row, 0, my2DArray.GetLength(0));
                        MultiplyRow(my2DArray, multiplyer, row);
                        WriteArray(my2DArray);
                    }
                    else
                    {
                        int column = 0;
                        Console.WriteLine("jaký sloupec chceš násobit?");
                        column = NumberInRange(column, 0, my2DArray.GetLength(0));
                        MultiplyColumn(my2DArray, multiplyer, column);
                        WriteArray(my2DArray);
                    }
                    break;
                case "subtract":                                                                    //odčítání
                    Subtract(my2DArray, rows, columns);
                    WriteArray(my2DArray);
                    break;
                case "add":                                                                         //sčítání
                    Add(my2DArray, rows, columns);
                    WriteArray(my2DArray);
                    break;
                case "multiplywitharray":                                                           //násobení s maticí
                    int[,] ResultArray = new int[rows, columns];
                    MultiplyWithArray(my2DArray, rows, columns, ResultArray);
                    WriteArray(ResultArray);
                    break;
                case "sum":
                    int Sum = 0;
                    Sum = SumOfArray(my2DArray, Sum);
                    Console.WriteLine($"součet všech polí v matici je {Sum}");
                    break;
                case "max":
                    int Max = int.MinValue;
                    Max = MaxOfArray(my2DArray, Max);
                    Console.WriteLine($"největší číslo v matici je {Max}");
                    break;
                case "min":
                    int Min = int.MaxValue;
                    Min = MinOfArray(my2DArray, Min);
                    Console.WriteLine($"nejmenší číslo v matici je {Min}");
                    break;
            }




            
            Console.ReadKey();
        }
    }
}