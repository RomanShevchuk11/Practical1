namespace Task2
{
    public class Program
    {
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max);
            }
            return array;
        }

        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static double GetAverage(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double avg = sum / numbers.Length;
            return avg;
        }
        
        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public static
            int GetMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        public static void Main(string[] args)
        {
            
            
            
            
            

                int[] array = GenerateRandomArray(10, 1, 100);

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(" " + array[i]);
                }
                Console.WriteLine();
                int sum = GetSum(array);
                Console.WriteLine("Сума масиву: " + sum);

                double avg = GetAverage(array);
                Console.WriteLine("Середнє значення: " + avg);

                int max = GetMax(array);
                Console.WriteLine("Максимальне число: " + max);

                int min = GetMin(array);
                Console.WriteLine("Мінімальне число: " + min);
            
        }
    }
}
