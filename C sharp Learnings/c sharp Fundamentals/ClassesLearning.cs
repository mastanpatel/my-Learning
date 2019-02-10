namespace c_sharp_Fundamentals
{
    // Here we will learn about classes

    //What is Class?
    // a Class is Complex Data type with some Behaviours   ex:- Customer class which consist of various Fields and operations to perform
    // fields like name,city,income,number etc.., and behaviours like print name, calcular income,calculate age  etc..,


    //Why we need Classes?
    //We classes to build complex data types as discussed above.  and complex data type are built using simple or elementary datatypes
    //like int,float,string etc...

    //When we use Classes?
    //as discussed above..

    //[Class keyword][ClassName]   --> class declration
    class ClassesLearning
    {
        //class contains fields
        private int _age;
        private string _name;
        //etc...

        //constructure
        // the purpose of constructor is to initialise the class fields
        //class constructor is automatically called when instance of class are created.
        // constructors do not have return value and always have same name as class
        //constructors can be overloaded using number and type of parameter.
        public ClassesLearning(int age,string name)
        {
            //constructor is initialising the class fields
            this._age = age;
            this._name = name;
        }
    }



    
    //Now we learn about static and instance fields and method of class
    //any field or method in a class are made static if it going to raim constance or same for any number of instance
    // so to make program efficient we declare those methods and fields as static

    class circle
    {
        // here we are making PI field as Static Because it does not change for every instance of class
        // so to improve performance and manage memory efficiently we made PI as static variable
        public static float PI;

        //radius is instance field
        float radius;


        // we created static constructor to initialise static fields
        // static constructor is called before instance constructor is called 
        // static constructor is called only once no matter how many instace are created..
        static circle()
        {
            PI = 3.14F;
        }


        // this is parameterised instance constructor
        public circle(float radius)
        {
            this.radius = radius;
        }

        public float Area()
        {
            return PI * radius * radius;
        }
    }

    class programExcutionclass
    {
        // here we create instace of classes and call methods
       public static void MainMethod()
        {
            circle c1 = new circle(3);
            c1.Area();
            circle c2 = new circle(2);
            c2.Area();
        }
        
        
    }
}
