namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            Console.Write("enter Size of the MAtrix: ");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(i == j)
                       matrix[i,j] = 1;
                    else if(j != i)
                        matrix[i,j] = 0;
                    Console.Write($"{matrix[i,j]}  ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
