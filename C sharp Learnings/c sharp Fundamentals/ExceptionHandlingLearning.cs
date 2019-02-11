using System;
using System.IO;
using System.Runtime.Serialization;

namespace c_sharp_Fundamentals
{
    //Here we will Learn about Exception Handling
    class ExceptionHandlingLearning
    {

        // What is Exception?
        // an unforseen error Happening at(during) Execution of Program (Applicaiton) is called exception.

        // what is Exception Handling?
        // Handling those unforeseen error is called Exception handling

        // we will learn about Exception Handling
        // we will Learn about Try catch blocks
        // we will Learn about Throw block
        // we will Lern about Finally block
        // we will Learn about InnerExceptions
        // we will Learn about CustomExceptions creating
    }

    //create a class to testException
    class TestException
    {
        static int a, b, c;

        public static void MainMethod()
        {
            try
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());

                    c = a / b;
                }

                // this below method is Bad method of handling Exception.
                //we should Handle exception programmitically not by using series of exceptions.
                catch (FormatException ex)
                {

                    //we usually Log the Exception Messages to Database or to Log Files.
                    //Console.WriteLine(ex.Message);
                    //Console.WriteLine(ex.StackTrace);
                    string FilePath = "Log.txt";

                    if (File.Exists(FilePath))
                    {

                        StreamWriter writer = new StreamWriter(FilePath);

                        writer.WriteLine(ex.Message);
                        writer.WriteLine(ex.StackTrace);

                        //For example while loging message to file some error occures then 

                        // For End User WE mostly Write User Understable Messages like
                        Console.WriteLine("Some thing went Wrong Please Try after Some time.");
                    }
                    else
                    {
                        throw new FileNotFoundException("File missing.", ex);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    //if range of value is outof Range this exception occurs
                }
                catch (DivideByZeroException)
                {
                    // devided by zero exception
                }
                //finally write an generic exception if above exception are not caught this generic exception will execute
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                if (e.InnerException!=null)  //always check wether innerexception is null or not before using it.
                {
                    Console.WriteLine(e.InnerException.Message); //inner exception help in know root cause of exception.
                }
               
            }
            finally
            {
                //Here realease all resouces of class
                // no matter what this block gets exceuted.
            }

        }
    }


    // Implemetation of Custom Exception
    // we use Custom Exception if Normal inbuild Exception are not able to give expected exception Handling
    // For example in asp.net application
    // user is allowed to login one time in one session.
    // if user try to open another browser window and try loging the error message should show User already Logedin.

    //creating CustomExeption Class
    class CustomException
    {
        public static void MainMethod()
        {
            throw new UserAlreadyLoggedInException("User ALready Logged In");
        }
        
    }

    [Serializable]   //we must make class as serialable for seriliasble exception
    class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()   //we overLoad diferent type of constructor from exception class 
        { }                                              //for implemeting custome Exception


        public UserAlreadyLoggedInException(string message): base(message)
        { }

        public UserAlreadyLoggedInException(string message,Exception e): base(message,e)
        { }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext Context) : base(info, Context)
        { }
    }
}
