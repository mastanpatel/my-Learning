using System;
using System.Collections.Generic;

namespace c_sharp_Fundamentals
{

    //Here we Will Learn About Attributes and Why they are Important.
    class AttributesLearning
    {

        //Attriibutes allow you to write Declarative information to the Program which is queried as Runtime using reflection.

        //there are several attribute pre-defined by .Net but we can also create our Custom Attribute.
        //Examples of few Pre-Defined Attribute
        // 1. Obsoete  --> Mark type and Type members outdated   type(class,enum,struct,etc..) and type Members(methods,fields,etc...)
        // 2. WebMethod --> To Expose a Method as an XML web service Method.
        // 3. Serilisable --> Indicates a Class Can be Serialised.

        //an Attribute is Class that inherit from System.Attribute base class.
    }

    //Lets Create demo class for Attribute Implemtation

    class Calculator
    {

        //create a method to add two number
        [Obsolete("Please Use addNumber(List<int> number)")]    //attribute to write Declarative information.
        public int addNumber(int a, int b)
        {
            return a + b;
        }

        //for example according to new requirment a new method to add multiple number should be implemeted
        //then we create new method by overloading previous addNumber method.
        //this new method is more efficient 
        //still if we remove old method then it may cause problem in application because there may be some other part of code might be using 
        //old addNumber method
        //so to Indicate developer to Implement this new method we make use of attribute.

        //new method to add numbers
        public int addNumber(List<int> number)
        {
            int sum = 0;

            foreach (int n in number)
            {
                sum += n;
            }
            return sum;
        }
    }

    class testClassAttribute
    {
        public static void MainMethod()
        {
            Calculator c = new Calculator();

            c.addNumber(4, 3);   //look at swiigly line message we get saying this method is obsolete please use addNumber(list<int> number)

            List<int> numbers = new List<int>()
            {
                1,2,3,4
            };

            c.addNumber(numbers);   // this works Fine
        }
    }


}
