using System;

namespace c_sharp_Fundamentals
{

    //Here we will Learn about Enums
    class EnumLearning
    {
        // what is enum?
        //Enums are stongly type constant

        //if Program uses set of integral numbers, consider replacing them with enums.
        //otherwise program becomes less readble and maintainable.


        //Enums are Strongly Type Constant so we cannnot implicitly convert enum type to integer type
        //we need explicite Convertion to convert from enum type to integer type
        //  Gender.Male = (Enum)1;   //explicite convertion
        //similary
        // int i = (int)Gender.Female

        //the default underlieng value of enum is Integer
        //the value of First Element of Enum is Zero and Increamented By 1

        //enums are value type
        //it is Possible to change underlieng type and Values of Enum as Shown Below
        //public Enum Gender : short      //change Int to Short
        // {
        //    Male = 3,                    //changed Default value 0 to 3
        //    Female = 34,
        //    Unkown
        //}

    }

    //first we create case where we will implement without using enums
    class Teacher
    {
        public string Name { get; set; }
        public int gender { get; set; }
    }



    //Testing Enum implemetation with enums and without enums
    class WithoutenumTesting
    {
        public static void MainMethod()
        {
            //create array of Teacher objects
            Teacher [] t = new Teacher[3];   

            //Implementing without enums
             t[0] = new Teacher()
            {
                Name = "Mastan",
                gender = 0                          //Male = 0
            };

            t[1] = new Teacher()
            {
                Name = "baba",
                gender = 1                         //Female = 1
            };

            t[2] = new Teacher()
            {
                Name = "mas",
                gender = 2                         //Unknown = 2
            };

            foreach (Teacher teacher in t)
            {
                //we are printing name and Geneger, for converting numeric Geneder to meaningfull name we wrote one more funtion.
                Console.WriteLine("Name : {0} and Gender : {1}", teacher.Name, GetGender(teacher.gender));
            }
        }


        //Methos to Convert integer gender value to Meaningfull name
        // but here we need to Refer what is 0 stand for 1 stand for and 2 stand for.
        // so it is hard to read and maintain so here come enums for resue. from this situation.
        public static string GetGender(int i)
        {
            switch(i)
            {
                case 0:
                    return "Male";
                case 1:
                    return "female";
                case 2:
                    return "Unkown";
                default:
                    return "Invalid Gender";

            }
        }
    }



    //Implemetation of Enums

   //Writeing Enum is similar to of class but with Enum keyword
    public enum Gender
    {
        Male,
        Female,
        Unknown
    }

    //create a class for Workers
    class Worker
    {
        public string Name { get; set; }
        public Gender gender { get; set; }   //we Create gender Property of Gender (Enum Type)
    }

    //Testing Enum
    class EnumTesting
    {
        public static void MainMethod()
        {

            //Example of Enums in Real Implemtation are
           // System.IO.FileShare.Read;   // same Like this FileShare is Enum and Read  = 1 similarly we have Write,share etc Enums 

            //create array of Worker objects
            Worker[] work = new Worker[3];

            //Implementing without enums
            work[0] = new Worker()
            {
                Name = "Mastan",
                gender = Gender.Male                         //Male = Gender.Male
            };

            work[1] = new Worker()
            {
                Name = "baba",
                gender = Gender.Female                        //Female = Gender.Female
            };

            work[2] = new Worker()
            {
                Name = "mas",
                gender = Gender.Unknown                         //Unknown = Gender.Unkown
            };

            foreach (Worker Work in work)
            {
                //we are printing name and Geneger, for converting numeric Geneder to meaningfull name we wrote one more funtion.
                Console.WriteLine("Name : {0} and Gender : {1}", Work.Name, GetGender(Work.gender));
            }




            //let us Learn More about Enums funtionality
            //get enum values, it will return array of values like 0,1,2 for genders

            int[] genderValues = (int[])Enum.GetValues(typeof(Gender));


        }


        public static string GetGender(Gender gen)   //pass Gender Enum as Parameter
        {
            switch (gen)
            {
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "female";
                case Gender.Unknown:
                    return "Unkown";
                default:
                    return "Invalid Gender";

            }
        }

    }
}


