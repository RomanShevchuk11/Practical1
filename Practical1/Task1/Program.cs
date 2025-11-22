namespace Task1
{
    public class Program
    {
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string GetMessage(int number)
        {
            if (number % 2 == 0)
            {
                return "Двері відкриваються!";
            }
            else
            {
                return "Двері зачинені...";
            }
        }
        public static void Main(string[] args)
        {
           
           
            

                Console.Write("Введіть число: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(GetMessage(a));


            
        }
    }
}
