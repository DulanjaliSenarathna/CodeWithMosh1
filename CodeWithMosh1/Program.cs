using System;
using CodeWithMosh1.Math;

namespace CodeWithMosh1

{  //Demo- Enums
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    
    class Person1
    {
        public int Age;
    }
    class Person
    {
        public string firstName;
        public string lastName; 

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Demo Variables and Constants
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Dulanjali";
            var isWorking = true;

            const float PI = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(PI);

            Console.WriteLine("{0} {1}", byte.MaxValue , byte.MinValue);
            Console.WriteLine("{0} {1}", float.MaxValue , float.MinValue);

            //Demo Type Conversion
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int x = 2000;
            byte y = (byte)x;
            Console.WriteLine(y);

            try
            {
            
                var numberc = "1235";
                int z = Convert.ToInt32(numberc);
                Console.WriteLine(z);
                byte by = Convert.ToByte(numberc);
                Console.WriteLine(numberc);
            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be coverted to the byte");
            }

            string str = "true";
            bool boo = Convert.ToBoolean(str);
            Console.WriteLine(boo);

            //Demo- Operators

            int q = 10;
            int w = 3;
            int r = 11;

            Console.WriteLine(q+w);
            Console.WriteLine(q/w);//reslut int
            Console.WriteLine((float)q/ (float)w);
            Console.WriteLine(q+w*r);//operator precedence
            Console.WriteLine(w>q);
            Console.WriteLine(w==q);
            Console.WriteLine(w!=q);
            Console.WriteLine(!(w!=q)); // ugly, so => put (w==q)
            Console.WriteLine(r>q && r>w);
            Console.WriteLine(r > q && r == w);
            Console.WriteLine(r > q || r == w);
            Console.WriteLine(!(r > q || r == w));

            Person person = new Person();
            person.firstName = "Dulanjali";
            person.lastName = "Dilshani";
            person.Introduce();

            Calculator cal = new Calculator();
            int res =cal.Add(1, 5);
            Console.WriteLine(res);

            //Demo- Arrays

            var numbers = new int[30];  //same to int[] numbers = new int[30]; because compiler identifies type of var as an array
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);//output 1
            Console.WriteLine(numbers[1]);//output 0 default
            Console.WriteLine(numbers[2]);//output 0

            var flags = new bool[3];

            flags[0] = true;

            Console.WriteLine(flags[0]); //output true
            Console.WriteLine(flags[1]);//output false default
            Console.WriteLine(flags[2]);

            var names = new string[3] {"Dul","Dil","Sena" };

            //Demo Strings
            var firstName1 = "Dul";
            String secName = "Dil";
            string thName = "Sena"; //same declaration

            var name = firstName1 + " "+ secName ;
            var newname = string.Format("My name is {0} {1}", firstName1, thName);

            string[] names1 = new string[3] { "Ayesh","Nish","chathu"};
            var resl = string.Join(",", names1);
            Console.WriteLine(resl);

            //Verbatim character
            var verb = @"Hi John
                        Look in to the following paths 
                        c:\ folder1\images\new";
            Console.WriteLine(verb);


            Int32 ix = 1;
            int ixx = 2;//these 2 same

            //Demo- Enums
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //when the number is come from another system and, based on that number we can detremine shiipping method
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());//don't need to add ToString.

            //parse a string in to enum
            var methName = "Express";
            var shippingMe =  (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methName); //type of the var is ShippingMethod

            // Demo- Reference Types and Value Types
            //value type
            var g = 10;
            var p = g;
            p++;
            Console.WriteLine(string.Format("g: {0} p:{1}", g,p));

            //reference type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine(string.Format("array1[0] : {0} , array2[0] : {1}", array1[0], array2[0]));

            //Reference Types 2
            //Value type
            var num = 1;
            Increment(num);
            Console.WriteLine(num);//output 1, num not affected by increment

            //reference type
            Person1 person1 = new Person1() {Age =20 };
            MakeOld(person1);
            Console.WriteLine(person1.Age);//output 30 

            //Demo- Conditional Statements

            int hour = 10;

            if(hour>0 && hour<12)
                Console.WriteLine("It's morning");
            else if(hour>=12 && hour<18)
                Console.WriteLine("It's afternoon");
            else
                Console.WriteLine("It's evening");

            //conditional operators
            bool isGoldCustomer = true;

            //float pricee;
            //if (isGoldCustomer)
            //    pricee = 19.95f;
            //else
            //    pricee = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            //switch
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");//if we want to case Autumn , and Summer , both print statement similar, remove this line and break statement below this
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer");
                    break;
                default:
                    Console.WriteLine("I don't knwo");
                    break;
            }

            //forloop
            var name1 = "Dulanjali";
            int ik;
            for ( ik = 0; ik<name1.Length; ik++)
            {
                Console.WriteLine(name1[ik]);
            }

            //display even numbers 1-10

            for(var l=1; l<=10; l++)
            {
                if(l%2 == 0)
                {
                    Console.WriteLine(l);
                }
            }

            //reverse order even numbers 1-10
            for (var l = 10; l >= 1; l--)
            {
                if (l % 2 == 0)
                {
                    Console.WriteLine(l);
                }
            }

            foreach (var letter in name1)
            {
                Console.WriteLine(letter);
            }

            //iterate over array
            int[] numm = new int[3] { 5, 8, 6 };

            foreach (var f in numm)
            {
                Console.WriteLine(f);
            }

            //while
            var fs = 0;
            while (fs <= 10)
            {
                if(fs%2 == 0)
                {
                    Console.WriteLine(fs);
                }
                fs++;
            }

            //

            while (true)
            {
                Console.Write("Enter your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine("@Echo:" + input);
            }




        }
        //Reference Types 2
        //value type
        public static void Increment(int number)
        {
            number+=10;
        }

        public static void MakeOld(Person1 person1)//parameter is person object
        {
            person1.Age += 10;
        }


    }
}
