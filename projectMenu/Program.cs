using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectMenu
{
    internal class Program
    {
        static string[] stringArray;
        static int[] intArray;

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
                    ShowSeries(intArray);
                    break;
                case "c":
                    ReversSeries(intArray);
                    break;
                case "d":
                    SortedSeries(intArray);
                    break;
                case "e":
                    HighestNumber(intArray);
                    break;
                case "f":
                    LowestNumber(intArray);
                    break;
                case "g":
                    AverageNumber(intArray);
                    break;
                case "h":
                    Console.WriteLine(ElementsNumber(intArray));
                    break;
                case "i":
                    Console.WriteLine(SumNumber(intArray));
                    break;
                case "j":
                    Exit();
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again:");
                    Menu();
                    break;

            }

        }
        static void InputSeries()            // בקש מהמשתמש סדרה שתדרוס את הסדרה הקיימת ותחזיר את הסדרה שהוא הכניס למשתנה הסטרינג
        {
            Console.WriteLine("enter some numbers");
            string myString = Console.ReadLine();
            string[] myStrArray = myString.Split(' ');
            if (IsNumbers(myStrArray))
            {
               stringArray = myStrArray;
            }
            else
            {
                Menu();
            }
        }
        static void ShowSeries(int[] intArr)            //מדפיס את הסדרה לפי הסדר המקורי
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i]);
            }
        }
        static void ReversSeries(int[] intArr)            //מדפיס את הסדרה בסדר ההפוך
        {
            for (int i = intArr.Length-1; i >= 0; i--)
            {
                Console.Write(intArr[i]);
            }
        }
        static void SortedSeries(int[] intArr)            //מדפיס את הסדרה בסדר מהקטן לגדול
        {
            Array.Sort(intArr);
            foreach (int i in intArr)
            {
                Console.WriteLine(i);
            }
        }
        static void HighestNumber(int[] intArr)            //מדפיס את המספר הגבוה ביותר
        {
            SortedSeries(intArr);
            Console.WriteLine(intArr[intArr.Length-1]);
        }
        static void LowestNumber(int[] intArr)            //מדפיס את המספר הנמוך ביותר
        {
            SortedSeries(intArr);
            Console.WriteLine(intArr[0]);
        }
        static void AverageNumber(int[] intArr)            //מדפיס את הממוצע של כל המספרים
        {
            Console.WriteLine((SumNumber(intArr)) / Convert.ToDouble(intArr.Length));
        }
        static int ElementsNumber(int[] intArr)            //מחזיר את מספר האלמנטים הקיימים ברשימה
        {
            return intArr.Length;
        }
        static int SumNumber(int[] intArr)            //מחזיר את הסכום של כל המספרים שברשימה
        {
            int count = 0;
            foreach (int i in intArr)
            {
                count += i;
            }
            return count;
        }
        static void Exit()            //מדפיס כיתוב יצאת בהצלחה
        {
            Console.WriteLine("You left successfully!");
        }
        static void Main(string[] args)
        {
        }
    }
}
