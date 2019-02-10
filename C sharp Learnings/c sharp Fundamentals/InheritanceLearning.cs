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


        //we don't have multiple inheritance in c#

        //we have multilavel inheritance
        //ex : Class A : B   ---> class A inherit from class B
        //     Class C : A   ---> Class C inherit from Class A which is inherited from Class B
    }

    public class EmployeeParentClass
    {
        public string name;
        public string adress;
        //etc

        //default constructor
        public EmployeeParentClass()
        {
            Console.Write("parent constructor");
        }

        //parametersed constructor
        public EmployeeParentClass(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
        }

        /// <summary>
        /// this is parent class method which print employeename
        /// </summary>
        public void PrintEMployeeName()
        {
            Console.WriteLine(name);
        }

    }

    // this is child class
    public class ParmanentEmployeeDerived : EmployeeParentClass  //-->syntax of inheritance
    {
        int SalaryMonthly;

        // to decide which constructor to call from base class 
        //we use this "base()" thing in this derived class constructor to initialise value


        public ParmanentEmployeeDerived(int salary) : base("addd","pune")   //--> here base class construct of parameter is initialsed.
        {
            this.SalaryMonthly = salary;
        }


        //this child class printemployeename method
        // this method is already present in parent class so to Hide the parent class method we use "NEW" key word in method declaration
        public new void PrintEMployeeName()
        {
            Console.WriteLine(name);
        }


    }

    public class ProgramEx
    {
        public static void MainMethod()
        {
            //we created derived class cunstructor but first the base class cunstructor is called and created
            //after base class fields are initialised the code comes to derived class
            ParmanentEmployeeDerived p = new ParmanentEmployeeDerived(5000);

            //we we create derived class object all members of base class executed initially so we can access fields and methods of base class.
            //ex :
            //p.adress = "pune";   //--> setting base class field values using derived class instance.
            //p.name = "mastan";   //--> setting base class field values using derived class instance.


            //method hiding
            // method hiding occurs when parent and child class both have same method's and child class instance call the method.
            //then parent class method is hidden and child class method is excuted as shown below
            ParmanentEmployeeDerived p1 = new ParmanentEmployeeDerived(1000);

            p1.PrintEMployeeName();  //--> this method call the child class method

            //To call parent class method we have several other ways

            //1. one way is by casting the parent class on child class intance.

            ((EmployeeParentClass)p1).PrintEMployeeName();   //--> this type casting we make parent class method to be called


            //2. another way is by referenceing parent class to child instace

            EmployeeParentClass p2 = new ParmanentEmployeeDerived(2000);  //--> parent class reference variable can point to child class object.
                                                                          //--> p2 instacne is of type parentclass (EmployeeParentClass)
            p2.PrintEMployeeName();  //--> here PrintEmployeeName() is parent class method

            //similarly we cannot do

            //ParmanentEmployeeDerived p3 = new EmployeeParentClass();     //--> we cannot refercne child reference variable to parent class
            // because child class can perform all thing which parent class can but vice versa is not true.

        }
    }
}
