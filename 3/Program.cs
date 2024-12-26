using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region related to 1

            //int x = 5;
            //int y = 10;
            ////by value
            //change(x,y);
            //Console.WriteLine($"outside the fun x={x}");
            ////by ref
            //change2(ref x,ref y);
            //Console.WriteLine($"outside the fun x={x}");
            #endregion

            #region related to 2
            //int[] arr = { 1, 2, 3, 4, 5 };

            //change(arr);
            //Console.WriteLine($"outside the fun arr{0}={arr[0]}"); 
            //change2(ref arr);
            //Console.WriteLine($"outside the fun arr{0}={arr[0]}");  
            //change3( arr);
            //Console.WriteLine($"outside the fun arr{0}={arr[0]}"); 
            //change4(ref arr);
            //Console.WriteLine($"outside the fun arr{0}={arr[0]}");

            #endregion

            #region related to 3
            //int sum = 0;
            //int sub = 0;
            //Sumandsub(10, 20, 20, 10, out sum, out sub);
            //Console.WriteLine($"the summitionn is {sum}");
            //Console.WriteLine($"the sub is  {sub}");
            #endregion

            #region related to 4
            //Console.WriteLine("please enter number");
            //int number=int.Parse(Console.ReadLine());
            //sum(number);
            #endregion

            #region related to 5
            //Console.WriteLine("please enter integer number");
            //int num = int.Parse(Console.ReadLine());
            //if (isprime(num))
            //    Console.WriteLine($"{num} is prime");
            //else Console.WriteLine($"{num} is not prime");

            #endregion

            #region related to 6
            //int[] arr = [2, 1, 3, 5, 4, 0];
            //MinMaxArray(ref arr);
            //Console.WriteLine($"the max num is num {arr[arr.Length - 1]}");
            //Console.WriteLine($"the min num is num {arr[0]}");
            #endregion

            #region related to 7
            //Console.WriteLine("enter number");
            //int num=int.Parse(Console.ReadLine());
            //Console.WriteLine(fact(num));

            #endregion
            #region related to 8


            //Console.WriteLine("please enter word");
            //string word = Console.ReadLine();
            //Console.WriteLine("please enter the new char");
            //char charr = char.Parse(Console.ReadLine());
            //changechar(word, charr);

            #endregion



        }


        #region 1

        //1- Explain the difference between passing(Value type
        // parameters) by value and by reference then write a suitable c#
        //value type passing by value we work on copies
        //value type passing by reference we add ref on parameters and on call
        // so we work on the origional values
        //public static void change(int x, int y) 
        //    {

        //    x = y;//x=10
        //    Console.WriteLine($"inside the fun x={x}");
        //    } 

        ///// ////////////////

        //public static void change2(ref int x,ref int y) 
        //    {

        //    x = y;//x=10
        //    Console.WriteLine($"inside the fun x={x}");
        //    }
        #endregion
        #region 2
        // 2- Explain the difference between passing(Reference type
        // parameters) by value and by reference then write a suitable c#
        // example.
        //reference type passing by value and passing by reference
        //both work on  origional values
        //but if we create array inside the the fun
        //it will differ
        //public static void change(int[] arr)
        //{
        //        arr[0] = 100;
        //    Console.WriteLine($"inside the fun arr{0}={arr[0]}");

        //} 
        //public static void change2(ref int[] arr)
        //{
        //        arr[0] = 100;
        //    Console.WriteLine($"inside the fun arr{0}={arr[0]}");

        //} 
        ////////////////////////
        //public static void change3(int[] arr)
        //{
        //    arr = [200,300,400];
        //    Console.WriteLine($"inside the fun arr{0}={arr[0]}");

        //} 
        //public static void change4(ref int[] arr)
        //{
        //    arr = [200, 300, 400];
        //    Console.WriteLine($"inside the fun arr{0}={arr[0]}");

        //}

        ///// ////////////////

        //public static void change2(ref int x,ref int y) 
        //    {

        //    x = y;//x=10
        //    Console.WriteLine($"inside the fun x={x}");
        //    }
        #endregion
        #region 3
        // 3- Write a c# Function that accept 4 parameters from user and
        // return result of summation and subtracting of two numbers
        //public static void Sumandsub(int x,int y,int z,int w,out int sum,out int sub) {

        //    sum= x + y;

        //    sub= z - w;

        //}
        #endregion
        #region 4
        // 4- Write a program in C# Sharp to create a function to calculate
        // the sum of the individual digits of a given number.
        // Output should be like
        // Enter a number: 25
        // The sum of the digits of the number 25 is: 7
        //public static void sum(int x)
        //{
        //    int summ = 0;
        //    string text=x.ToString();

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //       summ += int.Parse(text[i].ToString());
        //    }

        //    Console.WriteLine(summ);
        //}

        #endregion

        #region 5
        // 5- Create a function named "IsPrime",
        // which receives an integer number
        // and retuns true if it is prime, or false if it is not:

        //public static bool isprime(int number)
        //{
        //    if (number < 2)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }

        //    return true;




        //    }


        #endregion
        #region 6
        // 6- Create a function named MinMaxArray, to return the minimum and
        //maximum values stored in an array, using reference parameters
        //public static void MinMaxArray(ref int[] num)
        //{
        //Array.Sort(num);

        //}
        #endregion

        #region 7
        //7- Create an iterative(non-recursive) function to calculate the factorial
        //of the number specified as parameter
        //public static int fact(int num)
        //{
          
        //        int mul = 1;
        //    for(int i = 1; i <= num; i++)
        //    {
        //            mul*= i;
        //    }  
        //        return mul;
            
        //}
        #endregion
        #region 8
        //8- Create a function named "ChangeChar" to modify a letter in a certain
        //position(0 based) of a string, replacing it with a different letter
        //public static void changechar(string word,char newchar)
        //{

        //char[] wordd= word.ToCharArray();
        //    wordd[0]= newchar;
        //    wordd.ToString();
        //    Console.WriteLine(wordd);
        //}
        #endregion


    }

    }