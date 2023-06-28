namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, x4, y4;
            Console.WriteLine("Please enter value x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter value y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter value x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter value y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Please enter value x3: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter value y3: ");
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter value x4: ");
            x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter value y4: ");
            y4 = Convert.ToDouble(Console.ReadLine());
            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            Console.WriteLine("The length of line:" + length1);
            Console.WriteLine("The length of line2:" + length2);


            if (length1 == length2)
            {
                Console.WriteLine("The two lines are equal");
            }
            else if (length1 > length2)
            {
                Console.WriteLine("Line 1 is greater than Line 2.");
            }
            else
            {
                Console.WriteLine("The two lines are not equal");
            }



        }
    }
}