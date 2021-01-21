using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Data_Structure_Exercises
{
    class Program
    {
        //#region 1. Pass By Value

        //public static void Increment(int var)
        //{
        //    var++;
        //}
        //static void Main(string[] args)
        //{
        //    int i = 10;
        //    Console.WriteLine("Value of i before increment is: " + i);
        //    Increment(i);
        //    Console.WriteLine("Value of i after increment is: " + i);
        //}
        //#endregion

        //#region 2. Pass By Refrences
        //public class MyInt
        //{
        //    public int value;
        //}

        //public static void Increment(MyInt value)
        //{
        //    (value.value)++;
        //}

        //public static void Main(String[] args)
        //{
        //    MyInt x = new MyInt();
        //    x.value = 10;
        //    Console.WriteLine("Value of i before increment is: " + x.value);
        //    Increment(x);
        //    Console.WriteLine("Value of i after increment is: " + x.value);
        //}
        //#endregion

        //#region 3. Variables Types Via Interface
        //public interface BulbInterface
        //{
        //    void turnOn();
        //    void turnOff();
        //    bool IsOn { get; }
        //}

        //public class Bulb : BulbInterface
        //{
        //    private bool isOn = false;

        //    public virtual void turnOn()
        //    {
        //        isOn = true;
        //    }

        //    public virtual void turnOff()
        //    {
        //        isOn = false;
        //    }

        //    public virtual bool IsOn
        //    {
        //        get
        //        {
        //            return isOn;
        //        }
        //    }

        //    public class BulbDemo
        //    {
        //        public static void Main(string[] args)
        //        {
        //            Bulb b = new Bulb();
        //            Console.WriteLine("Bulb is on return: " + b.isOn);
        //            b.turnOn();
        //            Console.WriteLine("Bulb is on return: " + b.IsOn);
        //        }
        //    }
        //}
        //#endregion

        #region 4. Abstract Class & Methods
        //Abstract Class
        public abstract class Shape
        {
            //Abstract Method
            public abstract double area();

            //Abstract Method
            public abstract double perimeter();
        }

        public class Circle: Shape
        {
            private double radius;

            public Circle(): this(1)
            {

            }

            public Circle(double r)
            {
                radius = r;
            }

            public virtual double Radius
            {
                set
                {
                    radius = value;
                }
            }

            public override double area()
            {
                //Area = 

                return Math.PI * Math.Pow(radius, 2);
            }

            public override double perimeter()
            {
                return 2 * Math.PI * radius;
            }
        }

        public class Rectangle :Shape
        {
            private double width, length;

            public Rectangle(double w, double l)
            {
                width = w;
                length = l;
            }

            public virtual double Width
            {
                set { width = value; }
            }

            public virtual double Length
            {
                set { length = value; }
            }

            public override double area()
            {
                return width * length;
            }

            public override double perimeter()
            {
                return 2 * (width + length);
            }

            public class ShapeDemo
            {
                public static void Main(string[] args)
                {
                    double width = 2, length = 3;
                    Shape rectangle = new Rectangle(width, length);
                    Console.WriteLine("Rectangle: width" + width + "and length " + length + "Area" + rectangle.area() + "Perimeter: " + rectangle.perimeter());
                    double radius = 10;
                    Shape circle = new Circle(radius);
                    Console.WriteLine("Circle radius" + radius + "Area: " + circle.area() + "Perimeter: " + circle.perimeter());
                }
            }
        }
        #endregion

        #region 5. Linked List & ENUM Nested Class
        //public class LinkedList
        //{
        //    public class Node
        //    {
        //        internal int value;
        //        internal Node next;
        //    }

        //    private Node root;
        //    //Order Class Tree other fields and methods
        //}

        //internal class Bulb
        //{
        //    internal enum BulbSize { SMALL, MEDIUM, LARGE} //Enums
        //    internal BulbSize size;
        //}

        //public class BulbDemo
        //{
        //   public static void Main(string[] args)
        //    {
        //        Bulb b = new Bulb();
        //        b.size = Bulb.BulbSize.LARGE;
        //        Console.WriteLine("Bulb Size " + b.size);
        //    }
        //}
        #endregion


        #region 6. Single Array Access
        //public static void arrayExample()
        //{
        //    int[] arr = new int[10];
        //    for(int i = 10; i < 10; i++)
        //    {
        //        arr[i] = i;
        //    }

        //    printArray(arr, 10);            
        //}

        //public static void printArray(int[] arr, int count)
        //{
        //    Console.WriteLine("Values stored in array are: ");
        //    for(int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine("" + arr[i]);
        //    }
        //}
        #endregion


        #region 7. Two dimensional Access
        //public static void twoDArrayExample()
        //{
        //    int[,] arr = new int[4, 2];
        //    int count = 0;
        //    for(int i = 0; i < 4; i++)
        //    {
        //        for(int j=0; j < 2; j++)
        //        {
        //            arr[i, j] = count++;
        //        }
        //    }

        //    print2DArray(arr, 4, 2);
        //}

        //public static void print2DArray(int[,] arr, int row, int col)
        //{
        //    for(int i = 0; i < row; i++)
        //    {
        //        for(int j = 0; j < col; j++)
        //        {
        //            Console.WriteLine(arr[i, j]);
        //        }
        //    }
        //}

        #endregion

        #region 8. SumArray Given Array Size As Arguments
        //public static int SumArray(int[] arr)
        //{
        //    int size = arr.Length;
        //    int total = 0;
        //    int index = 0;

        //    for(index = 0; index < size; index++)
        //    {
        //        total = total + arr[index];
        //    }

        //    return total;
        //}

        //public static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 1, 2, 3, 4 };
        //    Console.WriteLine(SumArray(arr));
        //}
        #endregion

        #region 9. Sequential Search, None Sorted Data
        //public static int SequentialSearch(int[] arr, int size, int value)
        //{
        //    for(int i = 0; i < size; i++)
        //    {
        //        if(value == arr[i])
        //        {
        //            return i;
        //        }
        //    }

        //    return -1;
        //}

        #endregion

        #region 10. Binary Search, Sorted Data
        //public static int BinarySearch(int[] arr, int size, int value)
        //{
        //    int mid;
        //    int low = 0;
        //    int high = size - 1;
        //    while(low <= high)
        //    {
        //        mid = low + (high - low) / 2;
        //        if(arr[mid] == value)
        //        {
        //            return mid;
        //        }

        //        else if(arr[mid] < value)
        //        {
        //            low = mid + 1;
        //        }

        //        else
        //        {
        //            low = mid - 1;
        //        }
        //    }

        //    return -1;
        //}

        #endregion

        #region 11. Rotate Array By K Positions

        //public static void rotateArray(int[] a, int n, int k)
        //{
        //    reverseArray(a, 0, k - 1);

        //}

        //public static void reverseArray(int[] a, int start, int end)
        //{
        //    for(int i = start, j = end; i < j; j++)
        //    {
        //        int temp = a[i];
        //        a[i] = a[j];
        //        a[j] = temp;
        //    }
        //}
        #endregion

        #region 12. Find the largest contigous sub array
        // public static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 1, -2, 3, 4, -4, 6, -14, 8, 2 };
        //    Console.WriteLine("Max sub array sum" + maxSubArraySum(arr, 9));

        //}

        //public static int maxSubArraySum(int[] a, int size)
        //{
        //    int maxSoFar = 0;
        //    int maxEndingHere = 0;

        //    for(int i = 0; i < size; i++)
        //    {
        //        maxEndingHere = maxEndingHere + a[i];
        //        if(maxEndingHere < 0)
        //        {
        //            maxEndingHere = 0;
        //        }

        //        if(maxSoFar < maxEndingHere)
        //        {
        //            maxSoFar = maxEndingHere;
        //        }

        //    }

        //    return maxSoFar;
        //}
        #endregion

        #region 13. Factorial Calculation
        //public static int factorial(int i)
        //{
        //    if(i<=1)
        //    {
        //        return 1;
        //    }

        //    return i * factorial(i - 1);
        //}
        #endregion


        #region 14. Print Base 10
        //public static void printInt(int number)
        //{
        //    char digit = (char)(number % 10 + '0');
        //    number = number / 10;

        //    if(number != 0)
        //    {
        //        printInt(number / 10);
        //    }

        //    Console.WriteLine(digit);
        }
    #endregion

    #region 15. Sorted List Demo

    //public class SortedList
    //{
    //    public static void Main(string[] args)
    //    {
    //        SortedList<string, int> tm = new SortedList<string, int>();

    //        //Put elements into sorted
    //        tm["Masin"] = 55;
    //        tm["Jacob"] = 20;

    //        foreach(string key in tm.Keys)
    //        {
    //            Console.WriteLine(key + "Score Marks" + tm[key]);
    //        }

    //        Console.WriteLine("Emma present in class" + tm.ContainsKey("Masin"));
    //    }
    //}
    #endregion

    #region 16.  Linked List Demo
    //public class LinkedListDemo
    //{
    //    public static void Main(string[] args)
    //    {
    //        LinkedList<int> ln = new LinkedList<int>();
    //        ln.AddFirst(10);
    //        ln.AddLast(20);
    //        ln.AddFirst(9);
    //        ln.AddLast(10);

    //        foreach(int val in ln)
    //        {
    //            Console.WriteLine(val);
    //        }

    //        ln.RemoveFirst();
    //        ln.RemoveLast();
    //    }
    //}
    #endregion

    #region 17. Stack Demo
    //public class StackDemo
    //{
    //    public static void Main(string[] args)
    //    {
    //        Stack<int> stk = new Stack<int>();
    //        stk.Push(1);
    //        stk.Push(2);
    //        stk.Push(3);
    //        int size = stk.Count;
    //        for(int i = 0; i < size; i++)
    //        {
    //            stk.Pop();
    //        }
    //    }
    //}
    #endregion

    #region 18. Queue DE
    //public class QueueDemo
    //{
    //    public static void MAin(string[] args)
    //    {
    //        Queue<int> que = new Queue<int>();
    //        que.Enqueue(1);
    //        que.Enqueue(2);

    //        int size = que.Count;
    //        for(int i = 0; i < size; i++)
    //        {
    //            Console.WriteLine("Dequeue from queue" + que.Dequeue());
    //        }
    //    }
    //}
    #endregion

    #region 19. Sorted Set Demo
    //public class  SortedSetDemo
    //{
    //    public static void Main(string[] args)
    //    {
    //        SortedSet<string> st = new SortedSet<string>();
    //        st.Add("Kenya");
    //        st.Add("Uganda");

    //        foreach(string str in st)
    //        {
    //            Console.WriteLine(str);
    //        }
    //    }
    //}
    #endregion

    #region 20. Sorted Dictionary Demo
    //public class SortedDictionaryDemo
    //{
    //   public static void Main(string[] args)
    //    {
    //        SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
    //        sd["Mason"] = 55;

    //        foreach(string key in sd.Keys)
    //        {
    //            Console.WriteLine(key + "score marks" + sd[key]);
    //            sd.ContainsKey("John");
    //            sd.Remove("Emma");
    //        }
    //    }
    //}

    #endregion

    #region 21. Search & Print Repeating 
    //public class SearchRepeating
    //{
    //    public static void printRepeating(int[] arr, int size)
    //    {
    //        int i;
    //        Array.Sort(arr);
    //        Console.WriteLine("Repeating elements are");
    //        for(i = 1; i < size; i++)
    //        {
    //            if(arr[i] == arr[i-1])
    //            {
    //                Console.WriteLine("" + arr[i]);
    //            }
    //        }
    //    }
    //}

    #endregion

    #region 22. Find Max Appearing Element In Array
    //public class GetMaxAppearing
    //{
    //    public int GetMax(int[] arr, int size)
    //    {
    //        int max = arr[0], maxCount = 1;
    //        int curr = arr[0], currCount = 1;

    //        int i;
    //        Array.Sort(arr);
    //        for(i = 1; i < size; i++)
    //        {
    //            if(arr[i] == arr[i -1])
    //            {
    //                currCount++;
    //            }
    //            else
    //            {
    //                currCount = 1;
    //                curr = arr[i];
    //            }
    //            if(currCount > maxCount)
    //            {
    //                maxCount = currCount;
    //                max = curr;
    //            }

    //        }

    //        return max;
    //    }
    //}
    #endregion

    #region 23. Get Majority
    //public class GetMajority
    //{
    //    public static int getMajority(int[] arr, int size)
    //    {
    //        int majIndex = size / 2, count = 1;
    //        int i;
    //        int candidate;
    //        Array.Sort(arr);
    //        candidate = arr[majIndex];
    //        count = 0;
    //        for(i = 0; i < size; i++)
    //        {
    //            if (arr[i] == candidate)
    //            {
    //                count++;
    //            }
    //        }
    //        if(count > size / 2)
    //        {
    //            return arr[majIndex];
    //        }
    //        else
    //        {
    //            return int.MinValue;
    //        }

    //    }
    //}
    #endregion

    #region 24. FindMissingNumber
    //public class FindMissingNumber
    //{
    //    public int findMissingNumber(int[] arr, int size)
    //    {
    //        int i;
    //        int found = 0;
    //        Array.Sort(arr);
    //        for(i = 0; i < size; i++)
    //        {
    //            if(arr[i] == i)
    //            {
    //                found = 1;                    
    //            }
    //        }

    //        if(found == 0)
    //        {
    //            return i;
    //        }

    //        return int.MaxValue;
    //    }
    //}
    #endregion

    #region 25. Find Pair In An Array Whose Sum Is Equal To Value
    //public class FindPairInArray
    //{
    //    public int FindPair(int[] arr, int size, int value)
    //    {
    //        int first = 0, second = size - 1, curr;
    //        Array.Sort(arr);
    //        while(first < second)
    //        {
    //            curr = arr[first] + arr[second];
    //            if(curr == value)
    //            {
    //                Console.WriteLine("The pair is " + arr[first] + " " + arr[second]);
    //                return 1;
    //            }
    //            else if(curr < value)
    //            {
    //                first++;
    //            }
    //            else
    //            {
    //                second--;
    //            }
    //        }
    //        return 0;
    //    }
    //}
    #endregion

    #region 26. Find Two Elements Whose Sum Is Closest To Zero
    ////public class FindMaxPairCloseToZero
    ////{
    ////    public void minabsSumPair(int[] arr, int size)
    ////    {
    ////        int l, r, minSum, sum, minFirst, minSecond;

    ////        if (size < 2)
    ////        {
    ////            //Invalid Input 
    ////            return;
    ////        }

    ////        Array.Sort(arr);
    ////        minFirst = 0;
    ////        minSecond = size - 1;
    ////        minSum = Math.Abs(arr[minFirst] + arr[minSecond]);

    ////        for(l = 0, r = size -1; l < r;)
    ////        {
    ////            sum = (arr[l] + arr[r]);
    ////            if(Math.Abs(sum) < minSum)
    ////            {
    ////                minSum = sum;
    ////                minFirst = l;
    ////                minSecond = r;
    ////            }

    ////            if(sum < 0)
    ////            {
    ////                l++;
    ////            }
    ////            else if( sum > 0)
    ////            {
    ////                r++;
    ////            }
    ////            else
    ////            {
    ////                break;
    ////            }
    ////        }
    ////    }
    ////}

    #endregion

    #region 27. Find Occurence In Sorted Array
    //public class FinKeyCount
    //{
    //    public int findKeyCount(int[] arr, int size, int key)
    //    {
    //        int firstIndex, lastIndex;
    //        firstIndex = findFirstIndex(arr, 0, size - 1, key);
    //        lastIndex = findLastIndex(arr, 0, size - 1, key);
    //        return (lastIndex - firstIndex + 1);

    //    }

    //    public int findFirstIndex(int[] arr, int start, int end, int key)
    //    {
    //        int mid;
    //        if(end < start)
    //        {
    //            return -1;
    //        }

    //        mid = (start + end) / 2;
    //        if(key == arr[mid] && (mid == start || arr[mid - 1] != key))
    //        {
    //            return mid;
    //        }

    //        if(key <= arr[mid])
    //        {
    //            return findFirstIndex(arr, start, mid - 1, key);
    //        }
    //        else
    //        {
    //            return findFirstIndex(arr, mid + 1, end, key);
    //        }
    //    }

    //    public int findLastIndex(int[] arr, int start, int end, int key)
    //    {
    //        int mid;
    //        if(end < start)
    //        {
    //            return -1;
    //        }

    //        mid = (start + end) / 2;

    //        if(key == arr[mid] && (mid == end || arr[mid + 1] != key))
    //        {
    //            return mid;
    //        }

    //        if(key < arr[mid])
    //        {
    //            return findLastIndex(arr, start, mid - 1, key);
    //        }

    //        else
    //        {
    //            return findLastIndex(arr, mid + 1, end, key);
    //        }
    //    }
    //}
    #endregion

    #region 28. Separate Odd & Even Numbers
    //public class SWap
    //{
    //    public void swap(int[] arr, int first, int second)
    //    {
    //        int temp = arr[first];
    //        arr[first] = arr[second];
    //        arr[second] = temp;
    //    }

    //    public void seperateEvenAndOdd(int[] arr, int size)
    //    {
    //        int left = 0, right = size - 1;
    //        while(left < right)
    //        {
    //            if(arr[left] % 2 == 0)
    //            {
    //                left++;
    //            }

    //            else if(arr[right] % 2 == 1)
    //            {
    //                right--;
    //            }

    //            else
    //            {
    //                swap(arr, left, right);
    //                left++;
    //                right--;

    //            }
    //        }
    //    }
    //}
    #endregion

    #region 29. Get Max Profit
    //public class GetMaxProfit
    //{
    //    public void getMaxProfit(int[] stocks, int size)
    //    {
    //        int buy = 0, sell = 0;
    //        int currMin = 0;
    //        int currProfit = 0;
    //        int maxProfit = 0;
    //        int i;
    //        for (i = 0; i < size; i++)
    //        {
    //            if(stocks[i] < stocks[currMin])
    //            {
    //                currMin = i;
    //            }

    //            currProfit = stocks[i] - stocks[currMin];
    //            if(currProfit > maxProfit)
    //            {
    //                buy = currMin;
    //                sell = i;
    //                maxProfit = currProfit;
    //            }
    //        }

    //    }

    //}
    #endregion

    #region 30. Find Median Of An Array
    //public class GetMedian
    //{
    //    public int getMedian(int[] arr, int size)
    //    {
    //        Array.Sort(arr);
    //        return arr[size / 2];
    //    }
    //}
    #endregion

    #region 31. Find First Repeated Element In Array
    public class FindRepeated
    {

        public int findRepeated(int[] arr, int size)
        {
            int i;
            int max = int.MinValue;
            int[] hash;
            Array.Sort(arr);
            for(i = 0; i < size; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                    return max;
                }

             
            }
       
            return 0;
            
        }
    }
    #endregion






}



