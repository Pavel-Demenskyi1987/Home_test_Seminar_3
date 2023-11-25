namespace Task_03
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            Random random = new Random();
            float arraymin;
            float arraymax;
            float min = 0F;
            float max = 10.0F;
            float randomFloatInRange = min + (max - min) * (float)random.NextDouble();
            float razn;
            int size = 10;
            float[] array = new float[size];
            for (int i = 0; i < size; i++)
            {
                 array[i] = (float)random.NextDouble();
            }

            Console.WriteLine("Случайные вещественные числа:");

            foreach (float number in array)
            {
                Console.WriteLine(number);
            }
            arraymin = array[0];
            for (int i = 0; i < size; i++)
            {
                if(array[i] < arraymin )
                {
                    arraymin = array[i];
                }
            }
            Console.Write($" Минимальное значение массива => {arraymin}");
            arraymax = array[0];
             for (int i = 0; i < size; i++)
            {
                if(array[i] > arraymax )
                {
                    arraymax = array[i];
                }
            }
            Console.Write($" Максимальное значение массива => {arraymax}");
            razn = arraymax-arraymin;
            System.Console.WriteLine($"Разница между максимальным и минимальным значением => {razn}");

        }
    }
}

