using System;

namespace c_sharp_Fundamentals
{

    //Her we will Learn About Interfaces
    class InterfacesLearning
    {
        // what is interface?
        //An interface in C# contains only the declaration of the methods, properties, and events, but not the implementation.

        //we will Learn about How interface are created
        //naming convention of Interface is "IInterface"  --> recomended
        //
    }

    //interface
    interface ICustomer
    {
        // int id;   ---> this will show error because interface cannot contain Fields

        int Name { get; set; }  //---> interface can have Properties but we cannot explicitly make them public
                                // interface members are by default Public

        // interface methods are only declared they don't have there implemetation

        //public void PrintName();   ---> this is method declaration but still shows error because we made this method explicitly Public

        void PrintName();    //--> this type of method declaration is correct

    }

    //inhertance using Interface
    // if a class or Strucutre inherite from interface it should Provide Implementation For all Members of Interface.
    // other wise we get error message saying this interface member is not implemeted

    //structure for inherting from interface

    struct Customer : ICustomer
    {
        //implemeted the Interface Property
        public int Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //Implemetation of Interface Method
        public void PrintName()
        {
            Console.WriteLine("Interface method Implemted");
        }

        //we must implement all interface member(properties,methods,events) in dervied strucutre or class to avoid error.
    }

    //inhertance of interface in class
    class CustomerClass : ICustomer
    {

        //we have implemeted all members of interface
        public int Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void PrintName()
        {
            throw new NotImplementedException();
        }
    }

    //we can also inherit from one interface to other interface
    //example below
    interface Icustomer2 : ICustomer
    {
        void PrintCustomerName2();
    }

    interface IAinterface
    {
        void printA();
        void PrintName();
    }

    interface IBinterface
    {
        void PrintB();
        void PrintName();
    }


    //to perform multiple inheritance we can make use of interfaces
    class classA : IAinterface, IBinterface
    {
        //here we have implemet all members of both the interfaces
        public void printA()
        {
            throw new NotImplementedException();
        }

        public void PrintB()
        {
            throw new NotImplementedException();
        }

        //now we learn one more concept of Explicite method Implementation
        // example a class inherits from two interfaces and both interface have same method name
        // then How should a class implement methods of both interface
        // there come the concept of Explicite implentation
        // to implement explicitly we only need to use interface.method name and remove the public access modifier
        //as shown below
        void IAinterface.PrintName()
        {
            Console.WriteLine("Implemented Interace A method");
        }

        void IBinterface.PrintName()
        {
            Console.WriteLine("Implemented Interface B method");
        }

    }

    class InterfaceTesting
    {
        public static void MainMethod()
        {
            //we cannot create instance of interface
            // ecause we don't have implementation of interface members in interface
            //so there is no use of instance so c# won't allow to create interface
            // but we can create interface reference variable which point to child class as shown below

            ICustomer custom = new Customer();   //--> interface reference variable(parent) pointing to child class object.

            custom.PrintName();

            //when we have Excplicitly Implemented Interface methods
            //we can only call them using Interface reference variable or by casting the child class Object reference variable
            //as shown below
            //casting as interface

            classA a = new classA();  //--> child class object

            ((IAinterface)a).PrintName();
            ((IBinterface)a).PrintName();

            //or by creating Interface Reference variable to child object
            IAinterface ia = new classA();

            ia.PrintName();

            IBinterface ib = new classA();

            ib.PrintName();

        }
    }
}
