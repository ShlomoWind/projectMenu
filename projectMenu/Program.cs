using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectMenu
{
    internal class Program
    {
        static string String = "1 2 3 4 5 6";
        static string[] stringArray;
        static int[] intArray;
        static string[] CangeToStrArray(string strInput)             //ממיר את הסטרינג שקיבל למערך מסוג סטרינג
        {
            string[] output = strInput.Split(' ');
            return output;
        }
        static bool IsNumbers(string[] series)            //מחזיר האם כל האלמנטים הם מספרים
        {
            bool IsNum = true;
            foreach (string word in series)
            {
                try
                    {
                    Convert.ToInt32(word); 
                    }
                catch
                {
                    IsNum = false;
                    break;
                }
            }
            return IsNum;
        }
        static int[] CangeToIntArray(string[] strings)          //ממיר מערך מסוג סטרינג למערך מסוג אינט
        {
            int[] output = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                output[i] = Convert.ToInt32(strings[i]);
            }
            return output;
        }
        static bool ThreePositive(int[] series)            //מחזיר האם יש לפחות שלושה מספרים חיוביים
        {
            int cunt = 0;
            foreach(int number in series)
            {
                if (cunt == 3)
                {
                    return true;
                    break;
                }
                else if (number > 0)
                {
                    cunt++;
                }
            }
            return false;
        }
        static void Menu()                 //מציג את התפריט
        {
            Console.WriteLine("enter your choose: \na. to input a series \nb. to display the series \nc. to display the series in revers \nd. to display sorted seriec \ne. to display the max number \nf. to display the min number \ng. to display the average \nh. to display the number of elements \ni. to display the sum of the numbers \nj. to exit");
            switch (Console.ReadLine())
            {
                case "a":
                    InputSeries();
                    break;
                case "b":
                    ShowSeries(String);
                    break;
                case "c":
                    ReversSeries();
                    break;
                case "d":
                    SortedSeries();
                    break;
                case "e":
                    HighestNumber();
                    break;
                case "f":
                    LowestNumber();
                    break;
                case "g":
                    AverageNumber();
                    break;
                case "h":
                    ElementsNumber();
                    break;
                case "i":
                    SumNumber();
                    break;
                case "j":
                    Exit();
                    break;
                default:
                    Menu();
                    break;

            }

        }
        static string InputSeries()            //בקש מהמשתמש סדרה שתדרוס את הסדרה הקיימת ותחזיר את הסדרה שהוא הכניס
        {
            Console.WriteLine("enter some numbers");
            String = Console.ReadLine();
            return String;
        }
        static void ShowSeries(string stringToShow)            //מחזיר את הסדרה בסדר הנכון
        {
            Console.WriteLine(stringToShow);
        }
        static void ReversSeries()            //מחזיר את הסדרה בסדר ההפוך
        {
            Console.WriteLine("c");
        }
        static void SortedSeries()            //מחזיר את הסדרה בסדר מהקטן לגדול
        {
            Console.WriteLine("d");
        }
        static void HighestNumber()            //מחזיר את המספר הגבוה ביותר
        {
            Console.WriteLine("e");
        }
        static void LowestNumber()            //מחזיר את המספר הנמוך ביותר
        {
            Console.WriteLine("f");
        }
        static void AverageNumber()            //מחזיר את הממוצע של כל המספרים
        {
            Console.WriteLine("g");
        }
        static void ElementsNumber()            //מחזיר את מספר האלמנטים הקיימים ברשימה
        {
            Console.WriteLine("h");
        }
        static void SumNumber()            //מחזיר את הסכום של כל המספרים שברשימה
        {
            Console.WriteLine("i");
        }
        static void Exit()            //מחזיר כיתוב יצאת בהצלחה
        {
            Console.WriteLine("j");
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
