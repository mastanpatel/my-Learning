using System;

namespace c_sharp_Fundamentals
{

    //Here we are going to Learn about Encaculation and Properties in c#
    class EncapsulationLearning
    {
        // To achieve Encapsulation Ealier we used to use Getter and Setter methods to control
        // inout and Output values of our class Fields
        //ex:

        class Student
        {
            private string _name;    //never ever make this class Fields as Public 
            private int _mark;       //Because we don't get control on what get as input and what is Outputted.
            private int _totalMark = 40;  // this field must be Read Only so we only have getter method for this field

            public int getTotalMark()
            {
                return _totalMark;
            }

            //if any prograaming laguage don't have properties then we used to use getter and setter method tO ACHIEVE Encapculation
            //ex: if name is entered as empty and according to Business rule Name should Not be empty or Mark is Entered -ve Value
            // but it should Be an Positive number so to handle these situation we need to encapsulate fields

            //this is an setter method to set value of fields
            public void setName(string name)
            {
                // we have to put Name contional clause Here to varify the incoming value
                // if value is null and according to business rule it shouldnot be null then we can throw exception to user
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("name cannot b null or empty.");
                }

            }

            public string getName()
            {
                // for reducing code we use ternary operator to check null value
                return (string.IsNullOrEmpty(_name)) ? "no name" : _name;
            }

        }

        public static void MainMethod()
        {
            Student s = new Student();

            s.setName("mastan");   //---> setter method used to set value of field
            s.getName();          //--> getter method to get value of field name
            s.getTotalMark();    //--> geeter method for only readonly fields we dont have setter method for totalMark field
        }



        //-----------------------Properties -----------------------------------

        //as we Implemetation Encapsulation using getter setter method now we nake use of properties in c# to achieve Encapsulcation
        //we have different types of Properties
        //1. Read only proprerty        ---> here we have only "get"  accessor
        //2. Write Only Property        ---> here we have only "set" accessor
        //3. read and write Property    ---> here we have both "get" and "set" accessor
        //4. Auto Implemeted Properties ---> c# implemented Auto Implemented Propery to reduce amount of code


        //IMPORTANT
        //The Advantage of Property over tradition getter and setter method is that we can use properties as Public Fileds of Class.
        //ex: student.Name = "sdv";

        class Car
        {
            private string _name;
            private int _milage;
            private string _brand = "Audi";
            private string _color;
            //properties
            //this is an example of read and write Property
            public string Name
            {
                get
                {
                    return (string.IsNullOrEmpty(_name) ? "no name" : _name);
                }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("null value found");
                    }
                    this._name = value;

                }
            }

            //example of Read only Property
            //it is not better to use Set only Property according to many cases
            // but as one case of setting password we can use set Property to set Password where we cannot read it but can set it.
            //this one real time application i found for Write Only Property
            // othewise it is not common to Only write or set values   ---- need more knowledge on this topic.....
            public string Brand
            {
                get
                {
                    return this._brand;
                }
            }


            //Exmple of Write Only Property
            public string Color
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("no color choosen.");
                    }
                    else
                        this._color = value;
                }
            }

            //Auto Implemeted Property
            //some Fields don't require vaidation so it becomes so much cod eto achive encapsulation
            //so to avoid so many Lines of code
            //c# 3.0 intrudused Auto Implement Property
            //in auto Implement Property we Private Fields are Created Automatically and and anonymous Fields

            //ex: Auto implementated Property
            public String Email
            { get; set; }

        }

        class PropertyTester
        {
            public static void TestProperty()
            {
                Car c1 = new Car();

                //c1.Brand = "Benz";  //--> we cannot assign value because it is read only proprty
                c1.Color = "Red";

                //as we see we can read and write Properties Like as Field values.
            }
        }
        
    }
}
