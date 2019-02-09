using System;

namespace c_sharp_Fundamentals
{
    /// <summary>
    /// this Class is Used for Learning about Methods in c#
    /// </summary>
    class methodsLearning
    {
        /// <summary>
        /// this is an static method
        /// </summary>
        /// [accessModifiers][modifier][returnType][methodName]()   -->this method signature
        public static void MainMethod()
        {
            //we cannot call directly other non static methods in this method
            //ex : printInstanceMethod();  --> this method will show swilly error line as we can't call non static members in static method.

            // we can call other static method in static method as below printStaticMethod(); is called successfully.
            printStaticMethod();

            //--- calling non static methods ---//
            //to call non static method we need to create instace of class
            methodsLearning methods = new methodsLearning();

            //now using instance we can call non static methods
            methods.printInstanceMethod();

        }

        /// <summary>
        /// this is an instace method we are called by creating instance of the class.
        /// </summary>
        public void printInstanceMethod()
        {
            Console.WriteLine("My name is instance method");
        }

        /// <summary>
        /// this is an static method called directly without creating instance of class.
        /// </summary>
        public static void printStaticMethod()
        {
            Console.WriteLine("my name is Static method");
        }


        // Method Parameter Types
        // 1. Value Parameters
        // 2. Reference Parameters
        // 3. Out Parameters
        // 4. Parameter Arrays

        public void TestMethod()
        {
            //calling value parameter method
            int a = ValaueParameterMethod(1);


            //calling reference parameter method
            //here the actual value of "a" get updated as we are passing adress of a as parameter.
            int b = ReferenceParameterMethod(ref a);

            int sum = 0;
            int product = 0;
            // calling output parameter type method to return multiple values from single method
            OutputParameterMethod(a, b,out sum,out product);


            // calling as parameter array to pass as array
            ParamParameterMethod(1, 2, 3, 4, 5);

        }

        /// <summary>
        /// this is an value Parameter method where value is passed as parameter to this method
        /// </summary>
        /// <param name="a"></param>
        /// <returns>return the intiger</returns>
        public int ValaueParameterMethod(int a)
        {
            return a;
        }


        /// <summary>
        /// this is an reference parameter method where the parameter is passed as an refrence key word "ref" is essential
        /// </summary>
        /// <param name="a"></param>
        /// <returns>return the updated value of a</returns>
        public int ReferenceParameterMethod(ref int a)
        {
            return a + 2;
        }



        /// <summary>
        /// this method is of output parameter type where we pass output parameter to return multiple values in from single method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="sum"></param>
        /// <param name="product"></param>
        public void OutputParameterMethod(int a,int b,out int sum,out int product)
        {
            sum = a + b;
            product = a * b;
        }


        public void ParamParameterMethod(params int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
