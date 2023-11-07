using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] my2DArray = new int[5, 5];
            int numbertoadd = 1;
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    my2DArray[i, j] = numbertoadd;
                    numbertoadd++;
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");        //znak nového řádku
            }
            Console.Write("\n");
            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 0;
            for (int j = 0; j < my2DArray.GetLength(1);  j++)
            {
                Console.Write(my2DArray[nRow, j] + " ");
            }
            Console.Write("\n");
            Console.Write("\n");
            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                Console.Write(my2DArray[i, nColumn] + " ");
            }
            Console.Write("\n");
            Console.Write("\n");
            // bonus TODO: vypiš prvky na hlavní diagonále
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                Console.Write(my2DArray[i, i] + " ");
            }
            Console.Write("\n");
            Console.Write("\n");
            // bonus TODO: vypiš prvky na vedlejší diagonále
            for (int i = 4; i >=0; i--)
            {
                    Console.Write(my2DArray[i,my2DArray.GetLength(0)-i-1] + " ");
            }
            Console.Write("\n");
            Console.Write("\n");

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst = 0, yFirst = 0, xSecond = 1, ySecond = 0;
            int memory;
            /*memory = my2DArray[xFirst,yFirst];
            my2DArray[xFirst,yFirst] = my2DArray[xSecond,ySecond];
            my2DArray[xSecond, ySecond] = memory;
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");*/

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;
            int memory2;
            /*for (int i = 0; i < my2DArray.GetLength(1); i++)
            {
                memory2 = my2DArray[nRowSwap, i];
                my2DArray[nRowSwap, i] = my2DArray[mRowSwap, i];
                my2DArray[mRowSwap, i] = memory2;
            }*/
            //nebo podle něj
            /*int[] temparray = new int[5];
            for (int i = 0; i < my2DArray.GetLength(1); i++)
            {
                temparray[i] = my2DArray[nRowSwap, i];
            }
            for (int i = 0; i < my2DArray.GetLength(1); i++)
            {
                my2DArray[nRowSwap, i] = my2DArray[mRowSwap, i];
            }
            for (int i = 0; i < my2DArray.GetLength(1); i++)
            {
                my2DArray[mRowSwap, i] = temparray[i];
            }

            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");*/

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;
            /*for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                memory = my2DArray[i, nColSwap];
                my2DArray[i, nColSwap] = my2DArray[i, mColSwap];
                my2DArray[i, mColSwap] = memory;
            }*/
            //nebo podle něj
            /*for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                temparray[i] = my2DArray[i, nColSwap];
            }
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                my2DArray[i, nColSwap] = my2DArray[i, mColSwap];
            }
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                my2DArray[i, mColSwap] = temparray[i];
            }

            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");*/

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            /*for (int i = 0;i < my2DArray.GetLength(0)/2; i++)
            {
                int memory3 = my2DArray[i, i];
                int reversedindex = my2DArray.GetLength(0) - 1 - i;
                my2DArray[i, i] = my2DArray[reversedindex, reversedindex];
                my2DArray[reversedindex, reversedindex] = memory3;
            }

            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }*/
            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i = 0; i < my2DArray.GetLength(0) / 2; i++)
            {
                int reversedindex1 = my2DArray.GetLength(1) - 1 - i;
                int reversedindex0 = my2DArray.GetLength(0) - 1 - i;
                int memory3 = my2DArray[i, reversedindex1];
                my2DArray[i, reversedindex1] = my2DArray[reversedindex0, i];
                my2DArray[reversedindex0, i] = memory3;
            }

            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
