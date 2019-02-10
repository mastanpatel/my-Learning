using System;
namespace c_sharp_Fundamentals
{

    //Here we will be Learn about Similaries Between Classes and Structures
    //Diference Between Classes ans Strucutres
    //Stack and Heap
    //Value Type and Refence Type diference

    class StructureLearning
    {
        //What is Strucuture?
        //a structure is a value type data type. It helps you to make a single variable hold related data of various data types.

        //why and when we need use strucuture?
        //answer needed

        //Similarieties between class ans strucuture
        //Just like Classes Strucutures Have 
        //1. Private Fields
        //2. Public Properties
        //3. Constructors
        //4. Methods


        //Diference Between Structure and Class
        // 1. strucutre is Value type and Class is Refernce Type
        // 2. all diference applicable to value type and reference type are applicable to strucutre and classes
        // 3. strucutres are stored on stack where as values are stored on Heap
        // 4. Value types Hold there value in Memory where they are declared. where as Reference type hold reference of object in memory.
        // 5.Value types are Destroyed as soon as scope is Lost.  but reference type Variable are destroyed when scope is lost but
        // object are later destroyed by Garbage collector.
        // 6. when u copy one strucutre to other strucutre value get copies
        // where both are independent if change one other won't get affected
        // where as in classes if we copy one referece variable to other then both referece variable point to same object
        // hence change in one varible casuses the object to change

        // 7. structure's can't have distrcutors but classes have.
        // (we don't need distructor because object are destroyed after scope is lost in strucutre)
        // 8. strucutres cannot have Explicite ParameterLess Construcutre where as classes have
        // because strucutre don't have concept of Onject reference variable so it don't require Explicity parameterless construcutor and destructor.

        //8. Strucutre can't inherite from other classes but can inherit from interfaces , where as classes can inherite from othe classes and interfaces
        //  strucutres are basically of Sealed Type 
        // if we want to make any class not inheritable we have to make it as Sealed class
        // sealed class dont have inheritance
        // we can't inherite from strucutre (making strucutre as base type is not possible).

        // Please Referer Following Image for More clarity
        // stack and Heap for classes and strucutres.... in this Reposotry..
        //-----------------------------------
    }

    //Creating Strucutre we Need "Struct" Keyword

    public struct Student
    {
        //we can have Private Fileds in strucutre
        private string _name;       //--> as we hover mouse on "string" we see it is an refrence type (Class) from (Syste.String)
        private int _marks;         //--> where as if we hover mouse on "int" we see it as strucutre type (strucutre) as (System.Int32)



        //-->so basically int is an example of strucuture type data type.

        // we can create Public Properties in strucutre same as in class
        public string Name { get => _name; set => _name = value; }
        public int Marks { get => _marks; set => _marks = value; }
        

        //we can also Create Constructor as in classes
        public Student(string name,int mark)
        {
            _name = name;
            _marks = mark;
        }

        //similarly we can create methods in strucutre as in classes
        public void PrintStudentName()
        {
            Console.WriteLine(Name);
        }

    }
    class StrucutureTesting
    {
        public static void MainMethod()
        {
            // we can create instance of strucutre same like of classes
            Student s1 = new Student("Mastan", 100);   //--> this is instance of strucuture

            s1.PrintStudentName();   //--> calling strucutre methods

            //we can also initialise strucuture fields like this
            s1.Name = "Baba";
            s1.Marks = 99;


            //C3 has introduced Object Initialiser Syntax in 3.0 for initialising Objects for both Structure and classes

            //below code is of Object Initialiser syntax Type

            Student s2 = new Student
            {                                      //--> this syntax simplifies object initialisation of sturcuture and classes
                Name = "m1",
                Marks = 98

            };



        }
    }
}
