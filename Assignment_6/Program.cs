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
        public static void PrintWeekDaysEnum()
        {
            foreach (var day in Enum.GetValues(typeof(WeekDays)))
                Console.WriteLine(day.ToString());

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
            //PrintWeekDaysEnum();
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

            #endregion
        }
    }
}