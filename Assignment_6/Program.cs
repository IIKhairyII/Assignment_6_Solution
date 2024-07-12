using System.Text;

namespace Assignment_6
{
    public class Program
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public enum Seasons
        {
            Summer = 1,
            Winter,
            Spring,
            Autumn
        }
        public enum Permission
        {
            Read,
            Write,
            Delete,
            Execute
        }
        public enum Colors
        {
            Red,
            Green,
            Blue,
        }
        public static string PrintSeasons()
        {
            StringBuilder seasons = new("");
            foreach (var season in Enum.GetValues(typeof(Seasons)))
                seasons.Append($"{season}: {(int)season} \n");
            return seasons.ToString();
        }
        public static string GetMonthRangeThroughSeason(Seasons season)
        {
            StringBuilder range = new("");
            switch (season)
            {
                case Seasons.Summer:
                    range.Append("Hune to August");
                    break;
                case Seasons.Winter:
                    range.Append("December to Feburary");
                    break;
                case Seasons.Spring:
                    range.Append("March to May");
                    break;
                case Seasons.Autumn:
                    range.Append("September to November");
                    break;
                default:
                    range = range;
                    break;
            }
            return range.ToString();
        }
        static void Main(string[] args)
        {
            #region Problem 1
            //foreach (var day in Enum.GetValues(typeof(WeekDays)))
            //    Console.WriteLine(day.ToString());
            #endregion
            #region Problem 2
            //Person[] people =
            //{
            //    new("Karim", 24f),
            //    new("Khalid", 25f),
            //    new("Joe", 27f)
            //};
            //foreach (var person in people)
            //{
            //    Console.WriteLine(person.ToString());
            //}
            #endregion
            #region Problem 3
            //Console.WriteLine($"Enter Season number\n {PrintSeasons()}: ");
            //int input = int.Parse(Console.ReadLine());
            //string monthRange = GetMonthRangeThroughSeason((Seasons)input);
            //Console.WriteLine($"{(Seasons)input} is from {monthRange}");
            #endregion
            #region Problem 4
            //مش فاهم السؤال اصلا 
            #endregion
            #region Problem 5
            //Console.WriteLine("Enter color name: ");
            //string input = Console.ReadLine();
            //if (Enum.TryParse(input, true, out Colors color) && Enum.IsDefined(typeof(Colors), color))
            //{
            //    if (color == Colors.Red || color == Colors.Blue)
            //        Console.WriteLine($"{color} is a primary color.");
            //    else
            //        Console.WriteLine($"{color} is not a primary color.");
            //}
            //else
            //    Console.WriteLine($"{input} is not a defined color.");
            #endregion
            #region Problem 6
            //Point p1 = new();
            //Point p2 = new();
            //Console.WriteLine("Enter x and y for first point");
            //Console.Write("x: ");
            //p1.x = int.Parse(Console.ReadLine());
            //Console.Write("y: ");
            //p1.y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter x and y for second point");
            //Console.Write("x: ");
            //p2.x = int.Parse(Console.ReadLine());
            //Console.Write("y: ");
            //p2.y = int.Parse(Console.ReadLine());
            //double distance = Math.Sqrt(Math.Pow(Math.Abs(p2.x - p1.x), 2) + Math.Pow(Math.Abs(p2.y - p1.y), 2));
            //Console.WriteLine($"Distance between the given pointes is {distance}");
            #endregion
            #region Problem 7
            //List<Person> people = new();
            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine("Enter Pesron name");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter Pesron age");
            //    int age = int.Parse(Console.ReadLine());
            //    people.Add(new(name, age));
            //}
            //var oldest = people.FirstOrDefault(x => x.Age == people.Max(y => y.Age));
            //Console.WriteLine($"{oldest.Name} is the oldest one with age of {oldest.Age}");
            ///*Using arrays*/
            //Person[] peopleArr = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter Pesron name");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter Pesron age");
            //    int age = int.Parse(Console.ReadLine());
            //    peopleArr[i] = new Person(name, age);
            //}
            //int oldestPersonIndex = 0;
            //for (int a = 1; a < peopleArr.Length; a++)
            //{
            //    if (peopleArr[a].Age > peopleArr[oldestPersonIndex].Age)
            //        oldestPersonIndex = a;
            //}
            //Console.WriteLine($"The oldest person is {peopleArr[oldestPersonIndex].Name} with {peopleArr[oldestPersonIndex].Age} years.");
            #endregion
        }
    }
}