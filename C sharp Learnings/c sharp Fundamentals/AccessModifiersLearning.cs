namespace c_sharp_Fundamentals
{

    //here we will Learn about Access Modifiers

    //Namespace cannot have Modifiers or attribute
    class AccessModifiersLearning
    {
        //before Learning about Access Modifiers
        //Lets Get Clear about Type and Type Members.

        //Type are Nothing But Classes,Strucutres,enums,Delegates,interfaces are called "Types" and it's Members are Called "Type Members".

        //In c# ther are 5 diferent type of access modifiers
        //1. Private
        //2. Public
        //3. Protected
        //4. internal
        //5. internal Protected

        //Important
        //Type Members can Have all the Access Modifiers like fields, Properties, methods.., can have all access modifiers

        //but Type can only Have two access modifiers  types are like classes,interfaces,structs...,etc
        //1. Public
        //2. internal


        // Access Modifiers                        //Accessibility
        // 1. Private             -------> Only within containing Class
        // 2. Public              -------> Any where no restrictions
        // 3. Protected           -------> within containing type and type Derived From Containing Type
                                           // (mean base class and inherited class)
        // 4. Internal            -------> accessible from any where  within the assembly.
        // 5. Internal Protected  -------> can access within containing type and type Derived from containing Type across all assembly.


    }

    //implemtation of Access modifiers
    class sampleParent
    {
        private int salary;

        public string Name;

        protected string CityName;

        internal string InternalName;

        internal protected string InternalProtectedName;

    }

    class sampleChild : sampleParent
    {
        private int childSalary;

        public string Last;

        public void Print()
        {
            base.CityName = "Pune";   //we can access Protected member of base class in derived class
            //or
            sampleChild sam = new sampleChild();
            sam.CityName = "Pune";

            base.InternalName = "internalName";
            sam.InternalName = "internalName";

            base.InternalProtectedName = "internalProtected";
            sam.InternalProtectedName = "internalProtected";

            sampleParent a = new sampleParent();
            a.InternalName = "internal";
            a.InternalProtectedName = "internalProtected";
            
        }
        

    }

    class TestAccessModifiers
    {
        public static void MainMethod()
        {
            //create a instance of sampleParent
            sampleParent s = new sampleParent();

            //we can access Public fields as shown below
            s.Name = "Mastan";
            s.InternalName = "Internal Name";  //can access Internal access modifier field
            s.InternalProtectedName = "internal Protected"; //can access internal Protected Field

            //but we cannot access Private Fields 
            //s.salary = 10000000;  //this will give compilation error as field is Private

            //create child instance
            sampleChild sa = new sampleChild();
            sa.Last = "patel";  //child instance can have parent class public memebers and child class public members.
            sa.InternalName = "";
            sa.InternalProtectedName = "";
        }
    }

}
