using System;
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
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();   
            Console.ReadLine();
        }

    } 

    
    public delegate void MyDelegate();
    public class DelegateExercises   
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
            System.Console.WriteLine(myDelegate.ToString());
        }
    }
}
        
    

