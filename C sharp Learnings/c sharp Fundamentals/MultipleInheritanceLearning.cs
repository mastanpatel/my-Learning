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
        void PrintNameA();
    }

    //class nA inheriting from Interface IA
    class nA : IA
    {
        public void PrintNameA()
        {
            Console.WriteLine("Implemetation of IA interface Method.");
        }
    }

    interface IB
    {
        void PrintNameB();
    }

    class nB : IB
    {
        public void PrintNameB()
        {
            Console.WriteLine("Implemetation of IB interface Method.");
        }
    }

    // now we try to inherit from Above two interfaces to achieve mutiple inheritance
    // multiple inheritance mean having capapbilties of both Base classes which are Class nA and class nB here
    class E //: IA, IB
    {
        //now we create objects of nA and nB
        nA newA = new nA();
        nB newB = new nB();

        // now we implement below method of interface IA by just calling implemented Method in Class nA
        public void PrintNameA()
        {
            //calling implemeted method in class nA
            newA.PrintNameA();
        }

        // now we implement below method of interface IB by just calling implemented Method in Class nB
        public void PrintNameB()
        {
            //calling implemeted method in class nB
            newB.PrintNameB();
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



            //-------------Multiple inheritance using interfaces--------

            E e = new E();
            e.PrintNameA();   //we can call method of class nA
            e.PrintNameB();   // we can call method of class nB

            //----------------------------------------------------------
        }
     }

}
