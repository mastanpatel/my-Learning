using System;

namespace c_sharp_Fundamentals
{
    //Here we will learn about inheritance  (one of pillar of object oriented programming.
    class InheritanceLearning
    {
        //what is inheritance?
        // inheritance is deriving new classes from existing ones and forming them into a hierarchy of classes

        //why we use inheritance?
        // we use inheritance to allow code reusibilty
        //code reusibilty can reduce development time and errors.
        // To implement Inheritance we will specify all the common fields,methods,properties in the Parent class
        // and only have specific fields,method in derived class which are specific to that class

    }

    public class EmployeeParentClass
    {
        string name;
        string adress;
        //etc

        //default constructor
        public EmployeeParentClass()
        {
            Console.Write("parent constructor");
        }

        //parametersed constructor
        public EmployeeParentClass(string name,string adress)
        {
            this.name = name;
            this.adress = adress;
        }

    }

    // this si child class
    public class ParmanentEmployeeDerived : EmployeeParentClass  //-->syntax of inheritance
    {
        int SalaryMonthly;

        // to decide which constructor to call from base class 
        //we use this "base()" thing in this derived class constructor to initialise value

        public ParmanentEmployeeDerived(int salary) : base("addd","pune")   //--> here base class construct of parameter is initialsed.
        {
            this.SalaryMonthly = salary;
        }
    }

    public class ProgramEx
    {
        public static void MainMethod()
        {
            //we created derived class cunstructor but first the base class cunstructor is called and created
            //after base class fields are initialised the code comes to derived class
            ParmanentEmployeeDerived p = new ParmanentEmployeeDerived(5000);
        }
    }
}
