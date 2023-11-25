namespace Task_04
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            Random rand = new Random();
            int size = 10;
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                 array[i] = rand.Next(1, 100001);
            }

            Console.WriteLine("Массив без изменений => ");

            foreach (int number in array)
            {
                Console.WriteLine(number);
            }
            
            for (int i = 0; i < size; i++)
            {
                array[i] = array[size-1-i];
            }
            Console.WriteLine("Массив наоборот => ");

            foreach (int number in array)
            {
                Console.WriteLine(number);
            }

        }
    }
}


