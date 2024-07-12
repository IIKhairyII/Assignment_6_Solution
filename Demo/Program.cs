namespace Demo
{
    public class Program
    {
        public enum Weekdays
        {
            Saturday = 1,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
        }
        public static Weekdays Weekday { get; set; }
        public static void PrintArray<T>(ICollection<T> arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
        }
        public static void SumMulti(int x, int y, out int sum, out int multi)
        {
            sum = x + y;
            multi = x * y;
        }
        public static int SumArray(int x, int y, params int[] arr)
        {
            int sum = x + y;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region ArrayMethods
            //int[] nums = { 1, 15, 47, 30, 25, 150, 10 };
            //int[] Arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] Arr2 = { 10, 20, 30, 40, 50, 60 };
            //Array.Sort(nums);
            //PrintArray(nums);
            //Array.Clear(nums);
            //Array.Copy(Arr1, Arr2, 5);
            //Array.ConstrainedCopy(Arr1, 1, Arr2, 0, 5);
            //PrintArray(Arr2);
            //int[,,] Arr3 = (int[,,])Array.CreateInstance(typeof(int), 7, 2, 3);
            #endregion
            #region Passing by out
            int sum, multi;
            SumMulti(5, 10, out sum, out multi);
            Console.WriteLine($"Summation = {sum}, Multiplication = {multi}");
            #endregion
            #region Passing by params
            //int sumArr = SumArray(1, 2, 10, 20, 30, 40, 50);
            //Console.WriteLine($"Array Summation = {sumArr}");  
            #endregion
            #region Protective code
            //try
            //{
            //    int num1, num2;
            //    do
            //    {
            //        Console.WriteLine("Please enter the numerator");
            //    } while (!int.TryParse(Console.ReadLine(), out num1));
            //    do
            //    {
            //        Console.WriteLine("Please enter the denominator");
            //    } while (!(int.TryParse(Console.ReadLine(), out num2)) || num2 == 0);
            //    int result = num1 / num2;
            //    Console.WriteLine($"{num1} / {num2} = {result}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("YOUR CODE WAS EXECUTED");
            //}
            #endregion
            #region Enums
            Weekday = Weekdays.Sunday;
            Console.WriteLine(Weekday);
            Weekday = (Weekdays)7;
            Console.WriteLine(Weekday);
            #endregion
            #region Struct
            Point p1 = new();
            Console.WriteLine($"P1.x = {p1.x}, P1.y = {p1.y}");
            p1 = new(10, 20);
            Console.WriteLine($"P1.x = {p1.x}, P1.y = {p1.y}");
            #endregion
        }
    }
}