//namespace diclaration
using System;

namespace c_sharp_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading From Console
            string UserName = Console.ReadLine();

            //concatination method to print to console
            Console.WriteLine("Hello "+ UserName);

            //Place holder Syntax --Preferred
            Console.WriteLine("Hello {0}", UserName);

            //Built in Types in c#

            //bool true/fasle

            //---integral data types----

            //sbyte (-128 to 127) it is signed byte -- 8 bits integer
            //byte (0 to 255)  -- 8 bits integer
            //char (unicode) it is -- 16 bit character
            //short (signed) -- 16 bit integer
            //ushort(unsigned) -- 16 bit integer
            //int (signed) -- 32 bit integer (-2,xxx,xxx,xxx to 2,xxx,xxx,xxx)
            //uint (unsigned) -- 32 bit integer (0 to 4,xxxx,xxx,xxx)
            //long (signed) -- 64 bit integer (-9,xxx,xxx,xxx,xxx,xxx,xxx to 9,xxx,xxx,xxx,xxx,xxx,xxx)
            //ulong (unsigned) --64 bit intger (0 to 18,xxx,xxx,xxx,xxx,xxx,xxx)

            //-- Floating data types
            //float --32 bit (7 digits after decimal point)-- precision
            //double --64 bit (15 to 16 digits after decimal points) --precision

            //Decimal --128 bit (28-29 precision)

            // string Types
            //verbatim literal --@  --used mosthly in file names folder names
            //Console.WriteLine(@"a/b/c/d.txt");   --used to remove escape sequence
            //ways to find the int range from code
            Console.WriteLine("max {0}, min {1}",int.MaxValue, int.MinValue);
            Console.WriteLine("max {0}, min {1}", Byte.MaxValue, Byte.MinValue);
            Console.WriteLine("max {0}, min {1}", long.MaxValue, long.MinValue);


            //Common Operators in c#
            //ternary operator
            //----
            //bool isNumber10 = number == 10 ? true : false;
            //----

            // Types in c#
            // 1. value type -- int,float,double,struct,enum etc...  --- intialised as 0
            // 2. reference type -- class, interface, delegates, arrays,string etc.. --- initialised as null

            //------
            //nullable types
            //ex:-  int i = null; --gives error because int cannot be null in intialise state
            //       int? i = null; -- works fine (because now it is nullable type)
            //mostly this scenario occures when we need to store null in database but get the we cannot get null in code
            //ex :- if in user form there is feild to fill are u above 18?
            // the user will enter 'y' or 'n' or he wont enter any thing then the null value is stored in database
            //to handle such scenario c# introduced nullable data types
            //------- 



            //--- Null Coalesing Operator ?? ----
            // int? ticketAvailable = null;
            //int availableTickets = ticketAvailable ?? 0;  --using null coalesing operator to convert nullble to non nullable
            //---------



            //--- type conversion ---
            // 1. implicite conversion
            // this happens automatically id there is no data loss between data type
            //ex : int to flaot conversion

            // 2. explicie conversion
            // this convertion is done using cast () --operator   ex:- int i = (int) b;  b--> is flaot value
            // another method is using Convert.To method  ex: int i = Convert.Toint32(b);

            //imp-- if the data type value is stored as string then use "Parse" or "TryParse" methods
            // ex : string number = "1234";
            //      int numberValue = int.Parse(number);
            //use Try parse if ur not sure the given string is convertable to int or not
            // ex : string number = "12DE";
            //      int numberValue = int.Parse(number);   -- exception is trown so to avoid it use TryParse
            //      int.TryParse(number, out numberValue);  -- it will return bool value
            //-----------------------


            //-----------Arrays in c# -------
            // array are stongly types
            // int[] array = new int[3];
            //-------------------------------

            //------- Comments in c#--------
            //single line comment -- //
            // multiline comment -- /* */
            // very imp --> XML Documentation Comment -- ///
            // XML comments are used to show the documentation comments of any funtion, class etc
            //ex:- 
            //  //<summary> this funtion add two numbers
            //</summary>
            // public void add(int a,int b){};

            //-------------------------------



            //------ Diference between & and &&,  and | and || --------
            // very Imp ---
            // if(number>0 && number<5)   -- here if number>0 is false then it won't check second condition number<5
            // if(number>0 & number<5)    -- here if number>0 is false then also it will check second consition number<5
            // .. similarly for | and || operators
            // so for performance benefit we use && instead of &   and || instead of |
            //----------------------------------------------------------



            //------ goto statement ------
            // start:     -- this is lable where the code shown jump and go
            // goto start;  -- this way we can use to goto perticular Line of Program -- here it will go to(jump to) start: line code
            // it bad practice to use goto statement because it become very difficult (complex) to "debug" the code as program start jumping between lines of code.
            // this also can be achived using loops ex: do-while loop -- prefered way of writing code.
            //----------------------------


            //--- methods in c#------------
            //-----------------------------
            // refer methodLearning.cs class
            //-----------------------------




            //--- namespace in c# ----------
            // namespace help us to orgnise code in large projects
            // namespace is collection of classes
            // we can create namespace in another name space
            // ex : we see in using System; --> is an namespace
            //      we also se using System.IO --> here "System" is namespace and "IO" is also namespace under System.

            // to Learn more about namespaces refer "namespaceLearning.cs" file
            //------------------------------




            //--- classes in c# ------------
            // for classes refer classLeraaning.cs file
            //------------------------------




            //--- Inheretance in c# --------
            // for inheritance refer InheritanceLearning.cs file
            //refer the linq given below
            //https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance
            //------------------------------
            


            //--- Polymorphisn in c# -------
            // for polymorphism refer PlomorphismLearning.cs file
            //------------------------------

            Console.ReadKey();
        }
    }
}
