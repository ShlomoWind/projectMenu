using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectMenu
{
    internal class Program
    {
        static bool IsNumbers()            //מחזיר האם כל האלמנטים הם מספרים
        {

        }
        static void ThreePositive()            //מחזיר האם יש לפחות שלושה מספרים חיוביים
        {
        }
        static void InputSeries()            //בקשה מהמשתמש לסדרה שתדרוס את הסדרה הקיימת והמחזיר את הסדרה שהוא הכניס
        {
            Console.WriteLine("a");
        }
        static void ShowSeries()            //מחזיר את הסדרה בסדר הנכון
        {
            Console.WriteLine("b");
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
            void Menu()            //מציג את התפריט
            {
                Console.WriteLine("enter your choose: \na. to input a series \nb. to display the series \nc. to display the series in revers \nd. to display sorted seriec \ne. to display the max number \nf. to display the min number \ng. to display the average \nh. to display the number of elements \ni. to display the sum of the numbers \nj. to exit");
                switch (Console.ReadLine())
                {
                    case "a":
                        InputSeries();
                        break;
                    case "b":
                        ShowSeries();
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
        }
    }
}
