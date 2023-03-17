using System;

namespace HelloWorld;

class Program
{
    static void Main()
    { 
    // Задание 1
        
    //     Console.Write("Введите J ");
    //     string J = Console.ReadLine();
    //     Console.Write("Введите S ");
    //     string S = Console.ReadLine();
    //
    //     var jArray = J.ToCharArray();
    //     var sArray = S.ToCharArray();
    //
    //     int count = 0;
    //
    //
    //     for (int i = 0; i < jArray.Length; i++)
    //     {
    //         for (int j = 0; j < sArray.Length; j++)
    //         {
    //             if (sArray[j] == jArray[i])
    //             {
    //                 count++;
    //             }
    //         }
    //     }
    //     Console.WriteLine(count);
    
        // Задание 2

        // List<int> candidates = new List<int>(){2, 5, 2, 1, 2};
        // int target = 5;
        //
        // int total = 0;
        //
        // List<int> answer = new List<int>();
        //
        // for (int i = 0; i < candidates.Count; i++)
        // {
        //     total = 0;
        //     answer.Clear();
        //     for (int j = 0; j < candidates.Count; j++)
        //     {
        //         if (i != j)
        //         {
        //             total += candidates[j];
        //             answer.Add(candidates[j]);
        //         }
        //         if (total > target)
        //         {
        //             break;
        //         }
        //         else if (total == target)
        //         {
        //             for (int k = 0; k < answer.Count; k++)
        //             {
        //                 Console.Write($"{answer[k]} ");
        //             }
        //
        //             Console.WriteLine();
        //         }
        //     }
        // }

        // Задание 3

        List<int> nums = new List<int>() { 1, 2, 3, 4, 4};
        bool haveSame = false;
        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = 0; j < nums.Count; j++)
            {
                if (i != j)
                {
                    if (nums[i] == nums[j])
                    {
                        haveSame = true;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(haveSame);
    }
}