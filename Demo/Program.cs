namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            #region 1D Array

            #region Example 01
            //int[] numbers;
            ////Console.WriteLine(numbers[0]);
            //// initialize with default value of int [0,0,0]
            //numbers = new int[3];
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //Console.WriteLine($"size of array => {numbers.Length}, dimensions => {numbers.Rank}");

            //for (int i = 0; i < numbers.Length; i++)
            //{ 
            //    Console.WriteLine(numbers[i]);
            //}
            //foreach (int i in numbers)
            //    Console.WriteLine(numbers[i]);

            #endregion

            #region Array Creation Ways
            //int[] numbers01 = new int[3]; // .1
            //int[] numbers02 = new int[3] {1,2,3};  // .2
            //int[] numbers03 = new int[] {1,2,3};  // .3
            //int[] numbers04 = {1,2,3};  // .4
            //int[] numbers05 = [1, 2, 3];  // .5
            #endregion


            #endregion

            #region 2D Array
            //int[,] marks = new int[2, 5];
            //{
            //    {90,80,80,60,70 },
            //    {100, 60, 80, 60, 90 }
            //};

            //marks[0,0] = 1;
            //marks[0,1] = 2;
            //marks[0,2] = 3;
            //marks[0,3] = 4;
            //marks[0,4] = 5;
            //marks[1,0] = 6;
            //marks[1,1] = 7;
            //marks[1,2] = 8;
            //marks[1,3] = 9;
            //marks[1,4] = 10;

            //Console.WriteLine($"size of array => {marks.Length}, dimensions => {marks.Rank}");

            // input from user
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"The grades of student number {i + 1} ");
            //    for(int j = 0; j < marks.GetLength(1);)
            //    {
            //        Console.WriteLine($"The grade of subject number {j + 1} ");
            //        bool isParsed = int.TryParse(Console.ReadLine(), out marks[i, j]);
            //        if (isParsed)
            //        {
            //            ++j;
            //        }
            //    }
            //    Console.WriteLine("==============================");

            //}
            //Console.Clear();
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"The grades of student number {i + 1} ");
            //    for (int j = 0; j < marks.GetLength(1);j++)
            //    {
            //        Console.WriteLine($"The grade of subject number {j + 1} => {marks[i,j]}");

            //    }
            //    Console.WriteLine("==============================");
            //}
            #endregion

            #region Jagged Array
            //int[][] jaggedArray = new int[4][]
            //{
            //    [ 1, 2, 3 ],
            //    [ 4, 5, 6 ],
            //    [ 6, 7 ],
            //    [ 8, 9, 10 ,2,3],
            //};

            //jaggedArray[0] = [1, 4, 5, 6];
            #endregion

            #region Array Methods

            //int[] numbers = { 8, 7, 6, 9, 5, 1, 2, 3, 4 };

            //Array.Sort(numbers); // sort the array
            //Array.Reverse(numbers); // reverse the array
            //Array.Clear(numbers); // put default values of type of array in all elements , can clear specific indices
            //Console.WriteLine(Array.IndexOf(numbers,6)); // get the first index of item with value 6 in numbers array
            //Console.WriteLine(Array.LastIndexOf(numbers, 6)); // get the last index of item with value 6 in numbers array
            //Array.Resize(ref numbers,20); // resize the array to the new size and put default for extra values
            //int[] numbers02 = new int[4];
            //Array.Copy(numbers, numbers02, 4); // copy 4 elements from array numbers into numbers02

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #endregion
        }
    }
}
