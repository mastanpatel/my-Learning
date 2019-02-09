using System;
//using ProjectA.TeamA;  --> namespace without alias
//using ProjectA.TeamB;  --> namespace without alias create ambuigiuty during using classes of samename
// to Avoid ambuigity we use namespace alias
using PATA = ProjectA.TeamA;   // --> alias name for namespace
using PATB = ProjectA.TeamB;   //  --> alias names are frefered if namespace are to long

class namspaceLearning
    {
        // here we will learn how name space help in oragnise the large chunk of code or classes
        // learn about how namespace remove the naming ambiguity problems
        // learn about namespace alias --> very important topic
    }
    class SampleClass
    {
        public static void Mainmethod()
        {
        //calling ClassA.PrintMethod() method will create ambiguty 
        //between above two namespaces ProjectA.TeamA and ProjectA.TeamB because both namespace have classA in them.

        //   ClassA.printMethod();  --> this method will show error

        // To avoid ambuigity we can use either full names like
        // ProjectA.TeamA.ClassA.printMethod();   --> valid approach
        // ProjectA.TeamB.ClassA.printMethod();   --> valid approach

        // Or we can use Namespace alias which prefered way to reduce line of code.
        // as we know from above PATA is alias name for ProjectA.TeamA;
        // PATB is alias name for  ProjectA.TeamB   we can use
        PATA.ClassA.printMethod();   //--> no error or ambuigity is shown
        PATB.ClassA.printMethod();   //--> no error or ambuigity is shown  this prefered way.
    }
}

    namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
            {
                public static void printMethod()
                {
                    Console.Write("Hello ClassA");
                }
            }
        }
    }

    namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
            {
                public static void printMethod()
                {
                    Console.Write("Hello ClassA");
                }
            }
        }
    }

