namespace Task5
{
    public class Program
    {

        public static double GetAverage(int[] marks)
        {
            double sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            double avg = sum / marks.Length;
            return avg;
        }

        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int mark in marks)
            {
                if (min > mark)
                {
                    min = mark;
                }
            }
            return min;
        }

        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (max < mark)
                {
                    max = mark;
                }
            }
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                int[] group = groups[i];
                Console.WriteLine("Група " + (i + 1) + ": " +
                    "Середній = " + GetAverage(group) + ", " +
                    "Мінімальний = " + GetMin(group) + ", " +
                    "Максимальний = " + GetMax(group));
            }
        }

        public static void Main(string[] args)
        {
            
            
           

            
            
                int[][] marks =
                {
                  new int[] { 2, 3, 5 },
                  new int[] { 6, 7, 8 },
                  new int[] { 3, 4, 5 }
            };

                PrintGroupStatistics(marks);

            
        }
    }
}
