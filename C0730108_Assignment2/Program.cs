using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730108_Assignment2
{

    public class Program
    {



        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
        public delegate int MyDelegate(out int i);
        public class DelegateExercises
        {
            int Method1(out int i)
            {
                System.Console.WriteLine("Method1");
                i = 10;
                return 0;
            }

            public void Method3()

            {


                MyDelegate myDelegate = new MyDelegate(Method1);
                MyDelegate myDelegat1 = new MyDelegate(Method1);
                MyDelegate myDelegate2 = myDelegate + myDelegat1;
                int intValue;
                myDelegate2(out intValue);


            }
        }


    }
}
