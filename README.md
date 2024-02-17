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


Apologies for the oversight. Let's focus on providing solutions for the array-related tasks in C# as requested. Here are the solutions for the remaining array tasks:

**ArrayList:**

**Easy:**
1. Write a program to add elements to an ArrayList and print them.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);

        Console.WriteLine("Elements in ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}
```

**Medium:**
3. Write a program to find the frequency of occurrence of an element in an ArrayList.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList() { 1, 2, 3, 2, 2, 4, 5, 2 };
        int elementToFind = 2;

        int frequency = FindFrequency(arrayList, elementToFind);

        Console.WriteLine($"Frequency of {elementToFind}: {frequency}");
    }

    static int FindFrequency(ArrayList arrayList, int element)
    {
        int frequency = 0;
        foreach (var item in arrayList)
        {
            if (item.Equals(element))
            {
                frequency++;
            }
        }
        return frequency;
    }
}
```

**Hard:**
6. Write a program to implement a binary search on an ArrayList.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList() { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int elementToFind = 12;

        int index = BinarySearch(arrayList, elementToFind);

        if (index != -1)
        {
            Console.WriteLine($"{elementToFind} found at index {index}");
        }
        else
        {
            Console.WriteLine($"{elementToFind} not found in the ArrayList");
        }
    }

    static int BinarySearch(ArrayList arrayList, int element)
    {
        int left = 0;
        int right = arrayList.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if ((int)arrayList[mid] == element)
            {
                return mid;
            }
            else if ((int)arrayList[mid] < element)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}
```

These are the solutions for the ArrayList-related tasks in C#. Let me know if you need solutions for tasks from other topics or if you need further explanations!


Here are the solutions for the tasks related to the `SortedList` data structure in C#:

**Easy:**
1. Write a program to add elements to a SortedList and print them.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        SortedList sortedList = new SortedList();
        sortedList.Add(3, "Banana");
        sortedList.Add(1, "Apple");
        sortedList.Add(2, "Orange");

        Console.WriteLine("Elements in SortedList:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
```

2. Write a program to remove the smallest element from a SortedList.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        SortedList sortedList = new SortedList();
        sortedList.Add(3, "Banana");
        sortedList.Add(1, "Apple");
        sortedList.Add(2, "Orange");

        if (sortedList.Count > 0)
        {
            sortedList.RemoveAt(0);
            Console.WriteLine("Smallest element removed successfully.");
        }
        else
        {
            Console.WriteLine("SortedList is empty.");
        }
    }
}
```

**Medium:**
3. Write a program to check if a SortedList is in ascending order.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        SortedList sortedList = new SortedList();
        sortedList.Add(3, "Banana");
        sortedList.Add(1, "Apple");
        sortedList.Add(2, "Orange");

        bool isAscending = IsAscending(sortedList);

        if (isAscending)
        {
            Console.WriteLine("The SortedList is in ascending order.");
        }
        else
        {
            Console.WriteLine("The SortedList is not in ascending order.");
        }
    }

    static bool IsAscending(SortedList sortedList)
    {
        for (int i = 1; i < sortedList.Count; i++)
        {
            if ((int)sortedList.GetKey(i) < (int)sortedList.GetKey(i - 1))
            {
                return false;
            }
        }
        return true;
    }
}
```

4. Write a program to merge two SortedLists into a single SortedList.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        SortedList sortedList1 = new SortedList();
        sortedList1.Add(1, "Apple");
        sortedList1.Add(3, "Banana");

        SortedList sortedList2 = new SortedList();
        sortedList2.Add(2, "Orange");
        sortedList2.Add(4, "Grapes");

        SortedList mergedList = MergeSortedLists(sortedList1, sortedList2);

        Console.WriteLine("Merged SortedList:");
        foreach (DictionaryEntry entry in mergedList)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }

    static SortedList MergeSortedLists(SortedList sortedList1, SortedList sortedList2)
    {
        SortedList mergedList = new SortedList();

        foreach (DictionaryEntry entry in sortedList1)
        {
            mergedList.Add(entry.Key, entry.Value);
        }

        foreach (DictionaryEntry entry in sortedList2)
        {
            mergedList.Add(entry.Key, entry.Value);
        }

        return mergedList;
    }
}
```

**Hard:**
5. Write a program to perform a binary search on a SortedList.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        SortedList sortedList = new SortedList();
        sortedList.Add(1, "Apple");
        sortedList.Add(2, "Banana");
        sortedList.Add(3, "Orange");

        int keyToFind = 2;
        int index = BinarySearch(sortedList, keyToFind);

        if (index != -1)
        {
            Console.WriteLine($"Key {keyToFind} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Key {keyToFind} not found in the SortedList.");
        }
    }

    static int BinarySearch(SortedList sortedList, int key)
    {
        int left = 0;
        int right = sortedList.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midKey = (int)sortedList.GetKey(mid);

            if (midKey == key)
            {
                return mid;
            }
            else if (midKey < key)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}
```

6. Write a program to find the intersection of two SortedLists.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        SortedList sortedList1 = new SortedList();
        sortedList1.Add(1, "Apple");
        sortedList1.Add(2, "Banana");
        sortedList1.Add(3, "Orange");

        SortedList sortedList2 = new SortedList();
        sortedList2.Add(2, "Banana");
        sortedList2.Add(4, "Grapes");

        SortedList intersectionList = FindIntersection(sortedList1, sortedList2);

        Console.WriteLine("Intersection of SortedLists:");
        foreach (DictionaryEntry entry in intersectionList)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }

    static SortedList FindIntersection(SortedList sortedList1, SortedList sortedList2)
    {
        SortedList intersectionList = new SortedList();

        foreach (DictionaryEntry entry in sortedList1)
        {
            if (sortedList2.ContainsKey(entry.Key))
            {
                intersectionList.Add(entry.Key, entry.Value);
            }
        }

        return intersectionList;
    }
}
```

These are the solutions for the tasks related to the `SortedList` data structure in C#. Let me know if you need further explanations or assistance!
