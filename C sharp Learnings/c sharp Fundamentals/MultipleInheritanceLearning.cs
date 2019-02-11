using System;

namespace c_sharp_Fundamentals
{

    // Here we Learn why Multilpe inheritance is Problem in C#
    // why Multiple Inheritance is Possible Using Interfaces
    class MultipleInheritanceLearning
    {
        // in the following below Example will see why multiple Inheritance is Problem
    }

    //we create Class A
    class A
    {
        //it has Print Virtual Method
        public virtual void PrintName()
        {
            Console.WriteLine("This is Parent Class method.");
        }
    }

    //we have one more class B inheriting from class A
    class B : A
    {

        //we use ovveride to override parent class method
        public override void PrintName()
        {
            Console.WriteLine("This Implementation in child A Class method.");
        }
    }

    //we have one more class c inheritance from class A
    class C : A
    {
        //we use ovveride to override parent class method
        public override void PrintName()
        {
            Console.WriteLine("This Implementation in child B Class method.");
        }
    }

    //Now we Try to do Multiple Inheritance by inheriting a class from both class B and class C  --> which is not allowed in c#

    //class D : B, C
    //{

        //we cannot Implement Multiple Inheritance using classes becuase it create Diamond Ring Problem.

        //                        A
        //                      /   \ 
        //                     B     C
        //                      \   /
        //                        D


        //                  this is called Diamond Ring Problem.

    //}



    //------------------------------------- similarly we can Implement multiple inhertiance uisng interface------
    
    interface IA
    {
        void PrintName();
    }
    interface IB
    {
        void PrintName();
    }
    class E : IA, IB
    {
        public void PrintName()
        {
            throw new NotImplementedException();
        }
    }

    //--------------------------------------------------------------------------------------------------------------

    // testing Multiple Inheritance
    class TestMultipleInheritance
     {
        public static void MainMethod()
        {
            // lets check multiple inheritance
            // if some one create instance of class D

            // D d = new D();

            //if object of Class D is calling Method of Class A without Overiding that method in class D
            //then there is an ambiguity which implementated method should it call
            // implementaed method in class B or implemented method of Class C

           // d.PrintName();

            //so multiple inheritance is a problem in c# or other languages but it is allowed in cpp with having exception of diamond Problem.
        }
     }

}
