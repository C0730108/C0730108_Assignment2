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
            DelegateExercises a = new DelegateExercises();
            a.Method3();
            
        }
    }
    public class DelegateExercises
    {
        public delegate int MyDelegate(int intValue);
        public int Method1(int intMethod1)
        {
            return intMethod1 * 2;

        }
        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;     
        } 
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);    
            System.Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);
        }
    }
}
