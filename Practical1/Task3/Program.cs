namespace Task3
{
    public class Program
    {
        public static string ClassifyAge(int age)
            {

                if (age < 12 && age > 0)
                {
                    return "Ви дитина";
                }
                else if (age >= 12 && age <= 17)
                {
                    return "Підліток";
                }
                else if (age >= 18 && age <= 59)
                {
                    return "Дорослий";
                }
                else if (age >= 60 && age <= 120)
                {
                    return "Пенсіонер";
                }
                else
                {
                    return "Нереальний вік";
                }
            }
        public static void Main(string[] args)
        {
            
            
                Console.WriteLine("Ваш вік: ");
                int age = Convert.ToInt32(Console.ReadLine());
                string q = ClassifyAge(age);
                Console.WriteLine(q);
            
        }
    }
}
