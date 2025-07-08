namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Console.Write("enter Size of the MAtrix: ");
            //int size = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[size,size];
            //for (int i = 0; i < size; i++)
            //{
            //    for(int j = 0; j < size; j++)
            //    {
            //        if(i == j)
            //           matrix[i,j] = 1;
            //        else if(j != i)
            //            matrix[i,j] = 0;
            //        Console.Write($"{matrix[i,j]}  ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Question 2
            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //int sum = 0;
            //for(int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter item number {i + 1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}
            //Console.Write($"Sum of Array items = {sum}");
            #endregion

            #region Question 3
            //// this answer is based on assumption that the two arrays are sorted in ascending order
            //// and the resulted array will be sorted also in ascending order
            //int[] arr1 = { 1, 2, 4, 6, 8 };
            //int[] arr2 = { 0, 3, 4, 9, 10 };
            //int[] arrResult = new int[arr1.Length + arr2.Length];
            //int pointer1 = 0;
            //int pointer2 = 0;
            //int resIndex = 0;
            //while (pointer1 < arr1.Length && pointer2 < arr2.Length)
            //{
            //    if (arr1[pointer1] <= arr2[pointer2])
            //    {
            //        arrResult[resIndex] = arr1[pointer1];
            //        pointer1++;
            //    }
            //    else
            //    {
            //        arrResult[resIndex] = arr2[pointer2];
            //        pointer2++;
            //    }
            //    resIndex++; 
            //}
            //// handling the rest of values from arr1 if exsisted
            //while(pointer1 < arr1.Length)
            //{
            //    arrResult[resIndex++] = arr1[pointer1++];
            //}
            //// handling the rest of values from arr2 if exsisted
            //while (pointer2 < arr2.Length)
            //{
            //    arrResult[resIndex++] = arr2[pointer2++];
            //}
            //Console.WriteLine("The Resulting Array: ");
            //foreach (int i in arrResult)
            //{
            //    Console.Write($"{i} ");
            //}

            #endregion

            #region Question 4
            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //int minVal = int.MaxValue;
            //int maxVal = int.MinValue;
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter item number {i + 1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());

            //    if(arr[i] <= minVal)
            //    {
            //        minVal = arr[i];
            //    }
            //    if (arr[i] >= maxVal)
            //    {
            //        maxVal = arr[i];
            //    }
            //}
            //Console.WriteLine($"Max value is {maxVal}");
            //Console.WriteLine($"Min value is {minVal}");

            #endregion

            #region Question 5
            //Console.WriteLine("Enter Array Size:");
            //int arrSize = int.Parse(Console.ReadLine());
            //int[] numbers = new int[arrSize];
            //int secondMax = int.MinValue;
            //int maxNum = int.MinValue;
            //for (int i = 0; i < arrSize;)
            //{
            //    Console.Write($"enter element number {i + 1} ");
            //    bool isParsed = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    if (numbers[i] >= maxNum)
            //    {
            //        secondMax = maxNum;
            //        maxNum = numbers[i];
            //    }
            //    else if (numbers[i] < maxNum && numbers[i] >= secondMax)
            //    {
            //        secondMax = numbers[i];
            //    }
            //    if (isParsed)
            //        ++i;
            //}
            //Console.WriteLine($"The second Largest Number is {secondMax}");
            #endregion

            #region Question 6
            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter item number {i + 1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int leftPointer = 0;
            //int rightPointer = arr.Length - 1;
            //int maxDistance = int.MinValue;
            //int firstId = 0;
            //int lastId = 0;
            //while (leftPointer < arr.Length)
            //{
            //    rightPointer = arr.Length - 1;
            //    while (arr[rightPointer] != arr[leftPointer])
            //    {
            //        rightPointer--;
            //    }
            //    if (rightPointer - leftPointer > maxDistance)
            //    {
            //        maxDistance = rightPointer - leftPointer -1;
            //        firstId = leftPointer;
            //        lastId = rightPointer;
            //    }
            //    leftPointer++;
            //}
            //Console.WriteLine($"max distance is {maxDistance} cells between {arr[firstId]} at {firstId} and at {lastId}");
            #endregion

            #region Question 7
            //Console.Write("Enter your words: ");
            //string input = Console.ReadLine();
            //string[] words = input.Trim().Split(' ');
            //string[] wordsReversed = new string[words.Length];  
            //int wordsPointer = words.Length - 1;
            //int reversedPointer = 0;
            //while (reversedPointer < words.Length)
            //{
            //    wordsReversed[reversedPointer] = words[wordsPointer];
            //    reversedPointer++;
            //    wordsPointer--;
            //}
            //string output = string.Join(' ', wordsReversed);
            //Console.WriteLine($"Reversed Words => {output}");
            #endregion

            #region Question 8
            //Console.Write("Enter first dimension of array: ");
            //int firstDim = int.Parse(Console.ReadLine());
            //Console.Write("Enter second dimension of array: ");
            //int secondDim = int.Parse(Console.ReadLine());
            //int[,] arr1 = new int[firstDim,secondDim];
            //int[,] arr2 = new int[firstDim, secondDim];
            //// taking items from user in arr1
            //for (int i = 0; i < firstDim; i++)
            //{
            //    for (int j = 0;j < secondDim; j++)
            //    {
            //        Console.Write($"Enter item at {i},{j} : ");
            //        arr1[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //// copying items in arr1 to arr2 without using Array.Copy() and print it
            //Console.WriteLine("Items in Second array");
            //for (int i = 0; i < firstDim; i++)
            //{
            //    for (int j = 0; j < secondDim; j++)
            //    {
            //        arr2[i, j] = arr1[i,j];
            //        Console.Write($"{arr2[i, j]} ");
            //    }
            //    Console.WriteLine();    
            //}

            #endregion

            #region Question 9
            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter item number {i + 1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //for(int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{arr[i]} ");
            //}
            #endregion


        }
    }
}
