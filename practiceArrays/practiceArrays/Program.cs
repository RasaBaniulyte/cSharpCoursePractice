using System;
using System.Linq;

class Program
{
    static void Main()
    {
        findMagicNumber();
        //printMineSweeperNumbers();
    }

    private static void findMagicNumber()
    {

        int multiplier = 1;

        while (multiplier < 6)
        {

            multiplier++;
            int magicNumber = 99999;
            bool IsMagicNumber = false;
            bool NoMagicNumber = false;

            do
            {
                magicNumber++;

                if (magicNumber < 1000000)
                {

                    int multipliedMagicNumber = magicNumber * multiplier;

                    int[] magicArr = NumbersToArrays(magicNumber);
                    int[] multipliedMagicArr = NumbersToArrays(multipliedMagicNumber);


                    if (AllElementsDifferent(magicArr) && AllElementsDifferent(multipliedMagicArr))
                    {
                        IsMagicNumber = CompareArrays(magicArr, multipliedMagicArr);
                    }
                    else
                    {
                        IsMagicNumber = false;
                    }
                }
                else
                {
                    NoMagicNumber = true;
                }

            } while (IsMagicNumber == false && NoMagicNumber == false);

            if (NoMagicNumber == true)
            {
                Console.WriteLine($"There is no magic number for multiplier {multiplier}");
            }
            else
            {
                Console.WriteLine($"Magic number with multiplier {multiplier} is {magicNumber}");
            }
        }

        Console.ReadKey();

    }

    static int[] NumbersToArrays(int number)
    {
        return number.ToString().Select(x => int.Parse(x.ToString())).ToArray();
    }

    static bool AllElementsDifferent(int[] arr)
    {
        return arr.Distinct().Count() == arr.Length;
    }

    static bool CompareArrays(int[] arr1, int[] arr2)
    {

        int count = (arr1.Intersect(arr2)).Count();
        bool valuesNotEqual = false;

        if (count != arr1.Length)
        {
            return false;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                valuesNotEqual = (arr1[i] != arr2[j]);
            }
        }
        return valuesNotEqual;
    }

    private static void printMineSweeperNumbers()
    {
        throw new NotImplementedException("TODO: Sukurkite programą kuri liepia vartotojui įvesti MineSweeper žaidimo lauko duomenis. " +
            "Tada paskaičiuoja ir išspausdina lentelę su skaičiais kiek aplinkui(8 kryptyse įskaitant įstrižai) yra minų.");
    }
}


