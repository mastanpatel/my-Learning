using System;

namespace c_sharp_Fundamentals
{
    // Here we will Learn about Polymorphism
    class PolymorphismLearning
    {
        //what is polymorphism?
        //polymorphism allow invoking derived class methods using parent class referecence during runtime.

        //why we use polymorphism?
        // as stated above do call derived class methods which are same in parent and child class.

        //benifits of polymorphism?
        // it gives flexibility to organise code
    }

    //Implementation of polymorphism

    class EmployeeParent
    {
        //to make derived class methods to callable we have to make this parent class method virtual method by using "Virtual" keyword
        // the virtual ketword indicates that this method can be ovverriden in any derived classes.
        public virtual void PrintEmployeeName()     //--> this is an virtual method
        {
            Console.WriteLine("Employee Name is XYZ");
        }
    }

    class PartTimeEmployee : EmployeeParent
    {
        //to make this method accesible from parent class reference variable we have to override this method using "overide" keyword
        public override void PrintEmployeeName()
        {
            Console.WriteLine("Employee Name is XYZ");
        }
    }

    class FullTimeEmployee : EmployeeParent
    {
        //to make this method accesible from parent class reference variable we have to override this method using "overide" keyword
        public override void PrintEmployeeName()
        {
            Console.WriteLine("Employee Name is XYZ");
        }
    }

    class TemporaryEmployee : EmployeeParent
    {
       //method hiding in parent class
        public new void PrintEmployeeName()
        {
            Console.WriteLine("Employee Name is XYZ");
        }

        public void PrintCity()
        { }
    }

    class PramEX
    {
        public static void MainMethod()
        {
            // create an array of Employee Type objects
            EmployeeParent[] Employee = new EmployeeParent[4];   //--> created four Employee Type Objects

            Employee[0] = new EmployeeParent();
            Employee[1] = new PartTimeEmployee();
            Employee[2] = new FullTimeEmployee();
            Employee[3] = new TemporaryEmployee();

           
            foreach (EmployeeParent e in Employee)
            {
                //e.PrintEmployeeName();    //--> this line of code will always call parent class method even if object is of derived class type

                //TO call derived class methods at runtime using Parent class reference varible we have to make 
                //parent class methods which are same in derived class as virtual methods
                //and overide the parent class method in derived classes to call them.

                //we perform above operations in code
                //now if we run below line of code it will call each derived class methods using parent class referece variable.
                e.PrintEmployeeName();
                
            }


            //Now we will Learn above diference between method Hiding and methodoverriding //
            //in method ovveriding the child class methods is called by overriding base class method
            //so
            Employee[1].PrintEmployeeName();   //---> this is overiden method so PrintEmployeeName() is an Derived class method
                                               // because we are calling Using Parent class Referece variable
                                               // this method overiding

            //similarly we have used method hinding for TemporaryEmployee class method
            // where we used "new" keyword to hide the parent class method PrintEmployeeName()
            // usually method hiding is done to call parent class method using child class object.
            // but here we have parent class reference variable so basically
            Employee[3].PrintEmployeeName();  //---> this will call parent class methods only.
        }
    }
}
