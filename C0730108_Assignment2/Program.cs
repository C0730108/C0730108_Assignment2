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
            a.Method2();
            
        }
    }
    public class DelegateExercises
    {
        public delegate void MyDelegate();       
        void Method1()
        {
            Console.WriteLine("Method1");  
            Console.ReadLine();

        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
