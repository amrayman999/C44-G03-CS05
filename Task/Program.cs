namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1Enhanced();
            //Q2();
        }

        /// <summary>
        /// problem 1 get the 2nd largest element in an array
        /// </summary>
        static void Q1()
        {
            Console.WriteLine("Enter Array Size:");
            int arrSize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrSize];
            int max_idx = 0;
            int maxNum = int.MinValue;
            for (int i = 0; i < arrSize;)
            {
                Console.Write($"enter element number {i + 1} ");
                bool isParsed = int.TryParse(Console.ReadLine(), out numbers[i]);
                if(numbers[i] >= maxNum)
                {
                    maxNum = numbers[i];
                    max_idx = i;
                }
                if (isParsed)
                    ++i;
            }
            maxNum = int.MinValue;
            for (int i = 0; i < arrSize;i++)
            {
                if (numbers[i] >= maxNum && i != max_idx)
                {
                    maxNum = numbers[i];

                }
            }
            Console.WriteLine($"The second Largest Number is {maxNum}");

        }
        static void Q1Enhanced()
        {
            Console.WriteLine("Enter Array Size:");
            int arrSize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrSize];
            int secondMax = int.MinValue;
            int maxNum = int.MinValue;
            for (int i = 0; i < arrSize;)
            {
                Console.Write($"enter element number {i + 1} ");
                bool isParsed = int.TryParse(Console.ReadLine(), out numbers[i]);
                if (numbers[i] >= maxNum)
                {
                    secondMax = maxNum;
                    maxNum = numbers[i];
                }
                else if (numbers[i] < maxNum && numbers[i] >=  secondMax)
                {
                    secondMax = numbers[i];
                }
                if (isParsed)
                    ++i;
            }
            Console.WriteLine($"The second Largest Number is {secondMax}");
        }
        /// <summary>
        /// problem 2 : make user enter values of 3x3 matrix and then print the transpose of that matrix
        /// </summary>
        static void Q2()
        {
            int[,] arr3d = new int[3, 3];
            for(int i = 0;i < arr3d.GetLength(0); i++)
            {
                for(int j = 0; j < arr3d.GetLength(1);j++)
                {
                    Console.WriteLine($"enter element {i}{j} : ");
                    arr3d[i,j] = int.Parse(Console.ReadLine());    
                }
            }
            Console.WriteLine("simple matrix ");
            for (int i = 0; i < arr3d.GetLength(0); i++)
            {
                for (int j = 0; j < arr3d.GetLength(1); j++)
                {
                    Console.WriteLine($"{arr3d[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("transpose matrix ");
            for (int i = 0; i < arr3d.GetLength(0); i++)
            {
                for (int j = 0; j < arr3d.GetLength(1); j++)
                {
                    Console.WriteLine($"{arr3d[j,i]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
