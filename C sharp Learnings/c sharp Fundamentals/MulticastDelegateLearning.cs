namespace c_sharp_Fundamentals
{
    /// <summary>
    /// Here we will Learn about multicast delegates
    /// </summary>
    class MulticastDelegateLearning
    {
        //what is multicast delegate?
        // multicast delegate is a delegate which points to more than one method
        //when we invoke multicast delegate all methods pointed by delegate are invoked.

        //there are 2 approaches to implement multicast delegate
        // + or += method
        // - or -= method

        //delegate invoke funtion in same order as they are added.

        //Note : if a delegate has return type other than void than the return value will the returned value of Last called Funtion.

        //Interview Question?
        //Where do we Use MultiCast Delegates?
        //Multicast Delegate make implemetation of Observer Design Pattern implemtation very simple.
        //Observer Pattern is also called as Publisher/Subscribe pattern.
    }

    // create Delegate 
    delegate void simpleDelegate();

    //create delegate to return value
    delegate int valueDelegate(int number);

    //delegate test class
    class TestMultiCastDelegate
    {

        public static void MainMethod()
        {
            //initialise delegate
            //multicast delegate
            simpleDelegate s1, s2, s3, s4;

            s1 = new simpleDelegate(Print1);
            s2 = new simpleDelegate(Print2);
            s3 = new simpleDelegate(Print3);
            s4 = s1 + s2 + s3;   //one way of calling delegates

            s4 = s1 + s2 + s3 - s2; //this method remove s2 delegate from pointing to funtion
        }
       
        static void Print1()
        { }

        static void Print2()
        { }

        static void Print3()
        { }
       
        
    }
}
