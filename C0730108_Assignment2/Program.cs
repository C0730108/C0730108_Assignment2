﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730108_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Name Jashandeep kaur kingra(co730108)
            //student Name Ramandeep kaur(c0722414)
            //Assignment2
            //March 7,2019
            DelegateExercises a = new DelegateExercises();
            a.Method3();
            Console.WriteLine();
            
        }
    }
    public class DelegateExercises
    {
        public delegate int MyDelegate(int intValue);
        int Method1(int intMethod1)
        {
            return intMethod1 * 4;


        }
        int Method2(int intMethod1)
        {
            return intMethod1 * 20;
        }
        public void Method4(MyDelegate myDelegate)   
        {
            for (int i=1; i<=5; i++)
           System.Console.WriteLine(myDelegate(i) + " ");
        }    


        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            Method4(myDelegate);
            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);





        }
    }
}
