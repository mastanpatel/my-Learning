using System;
using System.Collections.Generic;

namespace c_sharp_Fundamentals
{

    // Here we will Learn what are delegates?
    // multiple Delegates
    // lamda Funtions
    // why delegates are important?
    // Business Implementation using delegates
    class DelegateLearning
    {
        // Learn about Delegate
        // what is delegate?
        // Delegate is Type Safe Funtion pointer. that is, it holds the reference pointer to a Funtion.

        // signature of delegate must match signature of funtion it pointing to. other wise we get compiler error
        // this is reason delegates are called Type safe Funtion Pointers.

        // Delegates are similar to classes , as classes we can create instance of delegates and pass Funtion names as
        // parameter to delegate constructor

        //TIP to Remember Delegate Syntax
        //Delegate syntax is very much similar to of a funtion except with "delegate" KeyWord.
    }


    //lets Create a delegate
    delegate string funtionDelegate(string Message);  //--> here we see delegate return type should match with funtion it pointing to
                                                      //--> and parameters passed should be of same type in pointing funtions also

    class Delegate
    {
        funtionDelegate fd = new funtionDelegate(Print);  //--> delegates constructor take funtion name as parameter  
                                                          //--> Print is an funtion name with string parameter in it.


       // this is funtion to which funtionDelegate is pointing
        public static string Print(string message)
        {
            return message;
        }


        //another method which is pointed by delegate
        public string PrintMessage(string message)
        {
            return message + "thank u";
        }


    }


    // now we will learn use of Delegates
    // delegate are mostly used by FrameWOrk Developers To make FrameWork classes Reusable
    // to avoid Hardcoding values in Framework classes.
    //-------------------- Real time Inplemetation of Delegates------------------------

    //create a Employee Class
    class Employee
    {
        //this class has following property

        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

        // now we want to find wether the employee is Promotable or not.
        // normal implemtation
        //we Pass a list of employees to isPromoted Method

        public void isPromotedEmoplyee(List<Employee> ListEmployee)     //so basically it does work but 
        {
            foreach (Employee employee in ListEmployee)
            {
                if(employee.Age > 25)                         //--> if the business rule changes for Promotion from age> 25 to age > 20
                {                                             //--> then we have again change the class funtion
                                                             //--> the class is not reusable in that condition
                    Console.WriteLine("Promoted");
                }

                //employee.Age > 25  this condition in if statement return true or false so we need delegate to funtion which return true or false.
            }
        }


       

        //now we can make isPromotedEmployee method more reusable using delegate

        public void isPromotedEmployee(List<Employee> ls, isPromotable delegateName)
        {
            foreach (Employee employee in ls)
            {
                if (delegateName(employee))
                {
                    Console.WriteLine("Promoted");
                }
            }
        }

    }


    // so to overcome that situation we use Delegates
    delegate bool isPromotable(Employee ls);

    class TestDelegates
    {
        //we create Funtion to where delegates can point
        static bool isPromoted(Employee LsEmployee)
        {
            if (LsEmployee.Age > 20)
            {
                return true;
            }
            else
                return false;
        }


        public static void MainMethod()
        {
            Delegate d = new Delegate();


            funtionDelegate fn = new funtionDelegate(d.PrintMessage);



            List<Employee> ListEmployee = new List<Employee>();

            ListEmployee.Add(new Employee() { Name = "Mike", Salary = 1000, Age = 20 });
            ListEmployee.Add(new Employee() { Name = "Mina", Salary = 1220, Age = 28 });
            ListEmployee.Add(new Employee() { Name = "Mikel", Salary = 2000, Age = 30 });

            Employee e = new Employee();
            e.isPromotedEmoplyee(ListEmployee);


           

            //initialise delegate and pass funtion name as parameter to delegate
            isPromotable isPromotableDelegate = new isPromotable(isPromoted);

           
            //call the method for chcking employee promotion status of employee class
            e.isPromotedEmployee(ListEmployee, isPromotableDelegate);

            //we have written lot of code to perform simple operation which was done easily using hardcode values
            // but this is better approach
            // we can reduce these steps by using Lamda funtion

            e.isPromotedEmployee(ListEmployee, X => X.Age > 25);  //--> using this lamda funtion we have reduced so much code of creating funtion
                                                                   //--> initialising delegate and passing funtions etc..

        }

       
    }
}
