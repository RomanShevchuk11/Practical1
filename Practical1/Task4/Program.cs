namespace Task4
{
    public class Program
    {
        public static bool IsValidTriangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double GetArea(double a, double b, double c)
        {
            double p = GetPerimeter(a, b, c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }


        public static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "Трикутник рівносторонній.";
            }
            else if (a == b || a == c || b == c)
            {
                return "Трикутник рівнобедрений.";
            }
            else if (Math.Abs(Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) < 0.0001 ||
                 Math.Abs(Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) < 0.0001 ||
                 Math.Abs(Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) < 0.0001)
            {
                return "Трикутник прямокутний.";
            }
            else
            {
                return "Трикутник довільний.";
            }
        }
        public static void Main(string[] args)
        {
            
            
           
            
           
                bool IsTriangleTrue = IsValidTriangle(10, 10, 10);
                Console.WriteLine(IsTriangleTrue);

                double Perimetr = GetPerimeter(10, 10, 10);
                Console.WriteLine(Perimetr);

                double Area = GetArea(10, 10, 10);
                Console.WriteLine(Area);

                string TriangleType = GetTriangleType(10, 10, 10);
                Console.WriteLine(TriangleType);


            
        }
    }
}
