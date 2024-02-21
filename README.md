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

Here are the solutions for the tasks related to the `Hashtable` data structure in C#:

**Easy:**
1. Write a program to add key-value pairs to a Hashtable and print them.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("A", 1);
        hashtable.Add("B", 2);
        hashtable.Add("C", 3);

        Console.WriteLine("Key-Value pairs in Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
```

2. Write a program to check if a key exists in a Hashtable.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("A", 1);
        hashtable.Add("B", 2);
        hashtable.Add("C", 3);

        string keyToCheck = "B";

        if (hashtable.ContainsKey(keyToCheck))
        {
            Console.WriteLine($"Key {keyToCheck} exists in the Hashtable.");
        }
        else
        {
            Console.WriteLine($"Key {keyToCheck} does not exist in the Hashtable.");
        }
    }
}
```

**Medium:**
3. Write a program to remove a key from a Hashtable.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("A", 1);
        hashtable.Add("B", 2);
        hashtable.Add("C", 3);

        string keyToRemove = "B";

        if (hashtable.ContainsKey(keyToRemove))
        {
            hashtable.Remove(keyToRemove);
            Console.WriteLine($"Key {keyToRemove} removed from the Hashtable.");
        }
        else
        {
            Console.WriteLine($"Key {keyToRemove} does not exist in the Hashtable.");
        }
    }
}
```

4. Write a program to find the most frequent element in a Hashtable.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("A", 1);
        hashtable.Add("B", 2);
        hashtable.Add("C", 1);
        hashtable.Add("D", 3);
        hashtable.Add("E", 2);

        string mostFrequentKey = FindMostFrequentElement(hashtable);

        Console.WriteLine($"Most frequent element in Hashtable: {mostFrequentKey}");
    }

    static string FindMostFrequentElement(Hashtable hashtable)
    {
        Hashtable frequencyMap = new Hashtable();

        foreach (DictionaryEntry entry in hashtable)
        {
            if (!frequencyMap.ContainsKey(entry.Value))
            {
                frequencyMap.Add(entry.Value, 1);
            }
            else
            {
                frequencyMap[entry.Value] = (int)frequencyMap[entry.Value] + 1;
            }
        }

        int maxFrequency = 0;
        string mostFrequentKey = null;

        foreach (DictionaryEntry entry in frequencyMap)
        {
            if ((int)entry.Value > maxFrequency)
            {
                maxFrequency = (int)entry.Value;
                mostFrequentKey = entry.Key.ToString();
            }
        }

        return mostFrequentKey;
    }
}
```

**Hard:**
5. Write a program to implement a Hashtable using open addressing.

```csharp
// Implementation of Hashtable using open addressing is quite complex and requires handling collisions, probing, resizing, etc.
// Here's a basic example of adding elements to Hashtable using open addressing:

using System;

class Program
{
    static void Main()
    {
        OpenAddressingHashtable hashtable = new OpenAddressingHashtable(5);
        hashtable.Add("A", 1);
        hashtable.Add("B", 2);
        hashtable.Add("C", 3);
        hashtable.Add("D", 4);

        Console.WriteLine("Key-Value pairs in Hashtable:");
        hashtable.Print();
    }
}

class OpenAddressingHashtable
{
    private string[] keys;
    private int[] values;
    private int capacity;
    private int size;

    public OpenAddressingHashtable(int capacity)
    {
        this.capacity = capacity;
        keys = new string[capacity];
        values = new int[capacity];
    }

    public void Add(string key, int value)
    {
        int index = GetHash(key);

        while (keys[index] != null)
        {
            index = (index + 1) % capacity;
        }

        keys[index] = key;
        values[index] = value;
        size++;
    }

    public int Get(string key)
    {
        int index = GetHash(key);

        while (keys[index] != key)
        {
            index = (index + 1) % capacity;
        }

        return values[index];
    }

    private int GetHash(string key)
    {
        int hash = 0;
        foreach (char c in key)
        {
            hash += c;
        }
        return hash % capacity;
    }

    public void Print()
    {
        for (int i = 0; i < capacity; i++)
        {
            if (keys[i] != null)
            {
                Console.WriteLine($"Key: {keys[i]}, Value: {values[i]}");
            }
        }
    }
}
```

6. Write a program to implement a Hashtable using separate chaining.

```csharp
// Implementation of Hashtable using separate chaining is also quite complex as it involves maintaining a list of elements at each index of the table.
// Here's a basic example of adding elements to Hashtable using separate chaining:

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SeparateChainingHashtable hashtable = new SeparateChainingHashtable(5);
        hashtable.Add("A", 1);
        hashtable.Add("B", 2);
        hashtable.Add("C", 3);
        hashtable.Add("D", 4);

        Console.WriteLine("Key-Value pairs in Hashtable:");
        hashtable.Print();
    }
}

class SeparateChainingHashtable
{
    private List<KeyValuePair<string, int>>[] items;
    private int capacity;

    public SeparateChainingHashtable(int capacity)
    {
        this.capacity = capacity;
        items = new List<KeyValuePair<string, int>>[capacity];
    }

    public void Add(string key, int value)
    {
        int index = GetHash(key);

        if (items[index] == null)
        {
            items[index] = new List<KeyValuePair<string, int>>();
        }

        items[index].Add(new KeyValuePair<string, int>(key, value));
    }

    public int Get(string key)
    {
        int index = GetHash(key);

        if (items[index] != null)
        {
            foreach (var pair in items[index])
            {
                if (pair.Key == key)
                {
                    return pair.Value;
                }
            }
        }

        throw new KeyNotFoundException("Key not found in Hashtable.");
    }

    private int GetHash(string key)
    {
        int hash = 0;
        foreach (char c in key)
        {
            hash += c;
        }
        return hash % capacity;
    }

    public void Print()
    {
        for (int i = 0; i < capacity; i++)
        {
            if (items[i

] != null)
            {
                foreach (var pair in items[i])
                {
                    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
                }
            }
        }
    }
}
```

These are the solutions for the tasks related to the `Hashtable` data structure in C#. Let me know if you need further explanations or assistance!

Here are the solutions for the tasks related to the `Stack` data structure in C#:

**Easy:**
1. Write a program to push elements onto a stack and print them.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Elements pushed onto the stack:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}
```

2. Write a program to pop elements from a stack.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Popping elements from the stack:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
```

**Medium:**
3. Write a program to reverse a string using a stack.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        string input = "Hello";
        string reversed = ReverseString(input);
        Console.WriteLine($"Original string: {input}");
        Console.WriteLine($"Reversed string: {reversed}");
    }

    static string ReverseString(string input)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in input)
        {
            stack.Push(c);
        }

        char[] reversedChars = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            reversedChars[i] = stack.Pop();
        }

        return new string(reversedChars);
    }
}
```

4. Write a program to evaluate a postfix expression using a stack.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        string postfixExpression = "23*5+";
        int result = EvaluatePostfixExpression(postfixExpression);
        Console.WriteLine($"Result of the postfix expression \"{postfixExpression}\": {result}");
    }

    static int EvaluatePostfixExpression(string expression)
    {
        Stack<int> stack = new Stack<int>();

        foreach (char c in expression)
        {
            if (char.IsDigit(c))
            {
                stack.Push(c - '0');
            }
            else
            {
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();

                switch (c)
                {
                    case '+':
                        stack.Push(operand1 + operand2);
                        break;
                    case '-':
                        stack.Push(operand1 - operand2);
                        break;
                    case '*':
                        stack.Push(operand1 * operand2);
                        break;
                    case '/':
                        stack.Push(operand1 / operand2);
                        break;
                }
            }
        }

        return stack.Pop();
    }
}
```

**Hard:**
5. Write a program to implement a stack using two queues.

```csharp
using System;
using System.Collections;
using System.Collections.Generic;

class StackUsingQueues
{
    Queue<int> queue1;
    Queue<int> queue2;

    public StackUsingQueues()
    {
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();
    }

    public void Push(int value)
    {
        // Enqueue the new element to queue1
        queue1.Enqueue(value);
    }

    public int Pop()
    {
        if (queue1.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        // Move all elements from queue1 to queue2 except the last one
        while (queue1.Count > 1)
        {
            queue2.Enqueue(queue1.Dequeue());
        }

        // Dequeue the last element from queue1, which is the top element of the stack
        int topElement = queue1.Dequeue();

        // Swap queue1 and queue2
        Queue<int> temp = queue1;
        queue1 = queue2;
        queue2 = temp;

        return topElement;
    }

    public int Peek()
    {
        if (queue1.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        // Move all elements from queue1 to queue2 except the last one
        while (queue1.Count > 1)
        {
            queue2.Enqueue(queue1.Dequeue());
        }

        // Peek at the last element from queue1, which is the top element of the stack
        int topElement = queue1.Peek();

        // Enqueue the top element back to queue1
        queue2.Enqueue(queue1.Dequeue());

        // Swap queue1 and queue2
        Queue<int> temp = queue1;
        queue1 = queue2;
        queue2 = temp;

        return topElement;
    }

    public bool IsEmpty()
    {
        return queue1.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        StackUsingQueues stack = new StackUsingQueues();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Popping elements from the stack:");
        while (!stack.IsEmpty())
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
```

6. Write a program to sort elements in a stack.

```csharp


using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push(3);
        stack.Push(1);
        stack.Push(2);

        Console.WriteLine("Original stack:");
        PrintStack(stack);

        Stack sortedStack = SortStack(stack);

        Console.WriteLine("Sorted stack:");
        PrintStack(sortedStack);
    }

    static void PrintStack(Stack stack)
    {
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }

    static Stack SortStack(Stack stack)
    {
        Stack tempStack = new Stack();

        while (stack.Count > 0)
        {
            int temp = (int)stack.Pop();

            while (tempStack.Count > 0 && (int)tempStack.Peek() > temp)
            {
                stack.Push(tempStack.Pop());
            }

            tempStack.Push(temp);
        }

        return tempStack;
    }
}
```

These are the solutions for the tasks related to the `Stack` data structure in C#. Let me know if you need further explanations or assistance!

Here are the solutions for the tasks related to the `Queue` data structure in C#:

**Easy:**
1. Write a program to add elements to a queue and print them.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("Elements added to the queue:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
```

2. Write a program to remove elements from a queue.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("Elements removed from the queue:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
```

**Medium:**
3. Write a program to implement a circular queue.

```csharp
using System;

class CircularQueue
{
    private int[] array;
    private int front;
    private int rear;
    private int capacity;
    private int count;

    public CircularQueue(int size)
    {
        capacity = size;
        array = new int[capacity];
        front = 0;
        rear = -1;
        count = 0;
    }

    public void Enqueue(int item)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("Queue is full");
        }

        rear = (rear + 1) % capacity;
        array[rear] = item;
        count++;
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        int dequeuedItem = array[front];
        front = (front + 1) % capacity;
        count--;
        return dequeuedItem;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return array[front];
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public bool IsFull()
    {
        return count == capacity;
    }
}

class Program
{
    static void Main()
    {
        CircularQueue queue = new CircularQueue(5);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Console.WriteLine("Elements in the circular queue:");
        while (!queue.IsEmpty())
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
```

4. Write a program to reverse the first "K" elements of a queue.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        int k = 3;
        ReverseFirstKElements(queue, k);

        Console.WriteLine("Reversed first " + k + " elements of the queue:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }

    static void ReverseFirstKElements(Queue queue, int k)
    {
        if (queue.Count < k)
        {
            throw new InvalidOperationException("Queue size is less than k");
        }

        Stack tempStack = new Stack();

        for (int i = 0; i < k; i++)
        {
            tempStack.Push(queue.Dequeue());
        }

        while (tempStack.Count > 0)
        {
            queue.Enqueue(tempStack.Pop());
        }

        for (int i = 0; i < queue.Count - k; i++)
        {
            queue.Enqueue(queue.Dequeue());
        }
    }
}
```

**Hard:**
5. Write a program to implement a queue using two stacks.

```csharp
using System;
using System.Collections;

class QueueUsingStacks
{
    private Stack stack1;
    private Stack stack2;

    public QueueUsingStacks()
    {
        stack1 = new Stack();
        stack2 = new Stack();
    }

    public void Enqueue(int item)
    {
        stack1.Push(item);
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        return (int)stack2.Pop();
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        return (int)stack2.Peek();
    }

    public bool IsEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("Dequeued elements from the queue:");
        while (!queue.IsEmpty())
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
```

6. Write a program to find the maximum element in each sliding window of size "K" in a given queue.

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue

.Enqueue(3);
        queue.Enqueue(5);
        queue.Enqueue(7);
        queue.Enqueue(9);

        int k = 3;
        FindMaximumInSlidingWindow(queue, k);
    }

    static void FindMaximumInSlidingWindow(Queue queue, int k)
    {
        Stack maxStack = new Stack();

        for (int i = 0; i < k; i++)
        {
            while (maxStack.Count > 0 && (int)queue.Peek() >= (int)maxStack.Peek())
            {
                maxStack.Pop();
            }
            maxStack.Push(queue.Dequeue());
        }

        Console.WriteLine("Maximum elements in sliding windows of size " + k + ":");
        Console.WriteLine(maxStack.Peek());

        while (queue.Count > 0)
        {
            int removedItem = (int)maxStack.Pop();
            if (removedItem == (int)queue.Peek())
            {
                queue.Dequeue();
            }

            while (maxStack.Count > 0 && (int)queue.Peek() >= (int)maxStack.Peek())
            {
                maxStack.Pop();
            }

            maxStack.Push(queue.Dequeue());
            Console.WriteLine(maxStack.Peek());
        }
    }
}
```

--!>
