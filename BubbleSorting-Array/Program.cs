namespace BubbleSort
{
    class Mohamed
    {
        static void Main(string[] args)
        {
            Random num= new Random();
            int[] numbers = new int[10];
            Console.WriteLine("Enter the values of the array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array before sorting: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            BubbleSort(numbers);
        }
        private static void BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - (1 + i); j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int example = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = example;
                    }
                }
            }
            Console.WriteLine("The array after sorting: ");
            foreach(int number in numbers) 
            {
              Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}