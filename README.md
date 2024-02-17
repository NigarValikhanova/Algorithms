# Arrays

Sure, I'll provide solutions for each of the tasks. Let's start with the array-related tasks in C#:

### Arrays:
**Easy:**
1. Write a program to find the sum of all elements in an array.

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Sum of array elements: " + ArraySum(arr));
    }

    static int ArraySum(int[] arr)
    {
        int total = 0;
        foreach (int num in arr)
        {
            total += num;
        }
        return total;
    }
}
```

**2. Write a program to reverse an array.**

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        ReverseArray(arr);
        Console.WriteLine("Reversed array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }

    static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
}
```

**Medium:**
3. Write a program to find the second largest element in an array.

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 5, 30, 15 };
        Console.WriteLine("Second largest element in array: " + SecondLargest(arr));
    }

    static int SecondLargest(int[] arr)
    {
        if (arr.Length < 2)
        {
            throw new ArgumentException("Array should have at least 2 elements");
        }

        int max1 = int.MinValue;
        int max2 = int.MinValue;

        foreach (int num in arr)
        {
            if (num > max1)
            {
                max2 = max1;
                max1 = num;
            }
            else if (num > max2 && num != max1)
            {
                max2 = num;
            }
        }

        return max2;
    }
}
```

**4. Write a program to remove duplicates from an array.**

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 5 };
        int[] uniqueArr = RemoveDuplicates(arr);
        Console.WriteLine("Array after removing duplicates:");
        foreach (int num in uniqueArr)
        {
            Console.Write(num + " ");
        }
    }

    static int[] RemoveDuplicates(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int num in arr)
        {
            set.Add(num);
        }
        int[] uniqueArr = new int[set.Count];
        set.CopyTo(uniqueArr);
        return uniqueArr;
    }
}
```

**Hard:**
5. Write a program to find the "Kth" smallest element in an unsorted array.

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 7, 10, 4, 3, 20, 15 };
        int k = 3;
        Console.WriteLine($"{k}th smallest element in array: " + KthSmallest(arr, k));
    }

    static int KthSmallest(int[] arr, int k)
    {
        Array.Sort(arr);
        return arr[k - 1];
    }
}
```

**6. Write a program to rotate an array by "K" positions to the right.**

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 2;
        RotateArray(arr, k);
        Console.WriteLine($"Array after rotating {k} positions to the right:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }

    static void RotateArray(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n;
        Reverse(arr, 0, n - 1);
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, n - 1);
    }

    static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
}
```

These are the solutions for the array-related tasks in C#. Let me know if you need solutions for tasks from other topics or if you need further explanations!
