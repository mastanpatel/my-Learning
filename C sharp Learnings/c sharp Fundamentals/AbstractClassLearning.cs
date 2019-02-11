using System;

namespace c_sharp_Fundamentals
{

    // Here we will Learn About Abstract class
    class AbstractClassLearning
    {
        //what is abstract class?
        //An abstract class in C# language is a class that can't instantiate. We can use an abstract class as a base class.

        //we will learn Diference of Abstract class and normal class
        

        //we wll learn diefrence between Interface and Abstract class
        //------------------------------------------------------------------
        // 1. Abstract classes have implementation for some of it's memebers
        //but interface don't have implementation for any of its member.
        // 2.Interface cannot have fields but abstract class can have fields.
        // 3. An interface can inherit from another interface only but cannot inherit from abstract or other class
        // where as abstract class can inherit from interface and other abstract classes.
        // 4. a class can inherit from multiple interfaces at time but cannot inherit from multiple classes
        // 5. abstract class members have access modifiers but interface member don't they are public by default.
        //------------------------------------------------------------------

    }

    //we need "Abstract" keyword to implement abstract class
    
    public abstract class student
    {
        // an abstract class is incomplete hence we can't have abstract class instance
        // an abstract class cannot be sealed because it is a base class for inheritance
        // an abstract class may contain abstract members like (methods, properties, fields,indexers,events), but not mandatory.
        // an non-abstract class inherited from abstract class must provide implemntaion for inherited Abstract members.

        // if a class is inherited from abstract class there are two options left for it
        // 1. Provide implementation for all abstract members inherited from base abstract class
        //or
        // 2. if inherted class does not wish to proivde implementtion for all abstract method then the class has to be marked as abstract.

        int Id;  // work fine because abstract class can have fields


        // abstract int Name;  //--> erro because abstract is not on Fields
        


        //work fine because it is not mandatory to have all members of abstract class with only declaration , we can have implemetation
        void printID()
        {
            Console.WriteLine(Id);
        }

        //we  have abstract method in class
         public abstract void PrintName();  //abstract method don't have implementation
                                           //virtual or abstract memebers cannot be Private so make them public     
    }

    //inheritance from base abstract class
    public class ClassStudent : student
    {

        //we need to implement all abstract memebers here to make inheritance work form abstract class
        // we have to use "override" key word to implement abstract methods in derived class
        public override void PrintName()
        {
            Console.WriteLine("Implementated Abstract class method");
        }
    }

    class AbstractClassTesting
    {
        public static void MainMethod()
        {
            //we cannot create abstract class instance
            //so create derived class instance

            ClassStudent c1 = new ClassStudent();
            c1.PrintName();

            // but we can can create reference varaiable to child class
            student s1 = new ClassStudent();
            s1.PrintName();

        }
    }
}
