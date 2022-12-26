using System;
using CodeWithMosh1.Math;
using System.Collections.Generic;
using System.Text;
using System.IO;

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

            //Random
            var random = new Random();
            for (var nn = 0; nn < 10; nn++)
                Console.WriteLine(random.Next(1,10));//min = 1 max=10

            //

            Console.WriteLine((int)'a');
            //random pw generation and display string in console.but string is immutable, which means cannot be change after they create. to avoid this, we can store individul characters in an array and convert itto string and display
            const int passwordLength = 10;
            for(var pw=0; pw <passwordLength; pw++)
            {
                Console.Write((char)random.Next(97,122)); //another way -> Console.Write((char)('a'+ random.Next(0,26)));
            }
            Console.WriteLine();
            //store char in array
            char[] buffer = new char[passwordLength];
            for (var pw = 0; pw <passwordLength; pw++)
            {
                buffer[pw] =((char)random.Next(97, 122)); //another way -> Console.Write((char)('a'+ random.Next(0,26)));
            }

            //Demo Arrays
            int[] numbersw = new[] { 3, 7, 9, 45, 78,8,9 }; //we can use var instead of int[]
           
            //Length
            var lengthofAttay = numbersw.Length;
            Console.WriteLine(lengthofAttay);

            //IndexOf
            int index =Array.IndexOf(numbersw, 9);
            Console.WriteLine(index);

            //Clear method (cleared members set to 0) because default value of int is 0. if boolean , default is false. is strings default is null
            Array.Clear(numbersw, 0, 3);
                   
            Console.WriteLine("Affect of clear method");
            foreach (var o in numbersw)
            {
                Console.WriteLine(o);
            }

            //Copy() method
            int[] another = new int[3];
            //copy 1st 3 numbers from numbersw array to another array
            Array.Copy(numbersw, another, 3);

            foreach (var t in another)
            {
                Console.WriteLine(t);
            }

            //Sort ()method
            Array.Sort(numbersw);

            Console.WriteLine("Effect after sort");
            foreach(var n in numbersw)
            {
                Console.WriteLine(n);
            }

            //Reverse ()method
            Array.Reverse(numbersw);

            Console.WriteLine("Effect after Reverse");
            foreach (var n in numbersw)
            {
                Console.WriteLine(n);
            }

            // Demo- Lists

            var numbersList = new List<int>() {1,2,3,4,6};
            numbersList.Add(1);
            numbersList.AddRange(new int[3] { 5,6,7});

            foreach(var e in numbersList)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Index of 1 : " + numbersList.IndexOf(2));
            Console.WriteLine("Last Index of 6 : " + numbersList.LastIndexOf(6));//search from last

            Console.WriteLine("Count of list: "+ numbersList.Count);

            numbersList.Remove(1);//remove the first 1 you meet from the begining
            foreach(var z in numbersList)
            {
                Console.WriteLine(z);
            }

            //remove all the 6s from the lsit
            for (int bs=0; bs< numbersList.Count; bs++)
            {
                if (numbersList[bs] == 6)
                {
                    numbersList.Remove(numbersList[bs]);
                }
            }
           
            foreach(var c in numbersList)
            {
                Console.WriteLine(c);
            }

            //clear method
            numbersList.Clear();
            Console.WriteLine("Afetr clear Count of list: " + numbersList.Count);

            //DateTime
            var dateTime = new DateTime(2015, 12, 31);
            var now = DateTime.Now;//now is a static property
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Hour: " + now.Minute);

            //DateTime is immutable. So we need to specific way to modify it
            //add 1 day to now
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yy MM dd HH mm"));

            //TimeSpan

            //creating
            var timespan = new TimeSpan(1, 2, 0);

            var timespan1 = new TimeSpan(1, 2, 0);
            var timespan2 = TimeSpan.FromHours(1);

            var noww = DateTime.Now;
            var after = DateTime.Now.AddMinutes(2);
            var duration = after - noww;
            Console.WriteLine("Duration"+duration);

            //Properties
            Console.WriteLine("Minutes: "+timespan.Minutes);
            Console.WriteLine("Total Minutes"+timespan.TotalMinutes);

            //Timespan is immutable. So we need to specific way to modify it
            //Add
            Console.WriteLine(timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timespan.Subtract(TimeSpan.FromMinutes(5)));

            //ToString
            Console.WriteLine("ToString : "+ timespan.ToString());

            //Parse string to timespan.
            Console.WriteLine("Parse : "+ TimeSpan.Parse("01:02:03"));

            //Demo Strings
            var lastName = "Dulanjali Senarathna ";
            Console.WriteLine("Trim '{0}'",lastName.Trim());//remove the whitespace at end
            Console.WriteLine("ToUpper '{0}'", lastName.ToUpper());

            //trim based on white space (using Substring())
            var index1 = lastName.IndexOf(' ');
            var firstname = lastName.Substring(0, index1);//0= starting index, index1=ending index (2nd overloading of substring method)
            var secname = lastName.Substring(index1 + 1);//first overloading of substring method(use only starting index)
            Console.WriteLine("First name:"+ firstname);
            Console.WriteLine("Second name :"+secname);

            //trim based on white space (using Split())

            var names2 = lastName.Split(' ');//return string array and one name is a one element
            Console.WriteLine("First name:"+ names2[0] );
            Console.WriteLine("Second name:" + names2[1]);

            //Replace()
            //replace string
            lastName.Replace('u', 'U');//all these methods returns new string. original string does not affected
            Console.WriteLine(lastName.Replace("Dulanjali", "Dilshani"));

            //IsNullOrEmpty()
            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }else if(String.IsNullOrEmpty(""))
            {
                Console.WriteLine("Also invalid");
            }else if(String.IsNullOrEmpty(" ".Trim()))//without .Trim() " " not considered as a invalid.but this is ugly. then miscrosoft introduce new method called, IsNullOrWitespace()
            {
                    Console.WriteLine("Also invalid");
                }
            else if(String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Also invalid");
            }

            //convert string to number
            var inputz = "1234";
            Console.WriteLine(Convert.ToInt32(inputz));

            //convert number to string
            var inputInt = 29.5f;
            Console.WriteLine(inputInt.ToString("C"));//C = currency
            Console.WriteLine(inputInt.ToString("C0"));//remove decimal and roundup

            //Summarizing Text
            var sentence = "This is goin to be really really really really really long text...";
            Console.WriteLine(StringUtility.SummerizeText(sentence, 30));

            //Demo- StringBuilder
            var stringBuilder = new StringBuilder("hello world");//parameter is starting string
            //Append
            stringBuilder
                .Append('-', 10)//output -> ----------(10 dashes) , Append method returns StringBilder. It means Append method is not a void. So we can chain our Append methods all together
                .AppendLine()//line break
                .Append("Header")
                .AppendLine()//line break
                .Append('-', 10)//output -> ----------(10 dashes)
                .Replace('-', '+')// Replace method also returns StringBilder, so it also can chain to append method
                .Remove(0, 10)//remove starting 0 from index 10 -> first line removed. // Remove method also returns StringBilder, so it also can chain to replace method
                .Insert(0, new string('-', 10));// insert new string with 10 dashes (-) to index 0 , // Insert method also returns StringBilder, so it also can chain to remove method
            Console.WriteLine(stringBuilder);

            //get char at given index
            Console.WriteLine("First Char: "+stringBuilder[0]);

            // Exercice , get input name from user and reverse name
            Console.Write("What is your name? ");
            var nameUSer = Console.ReadLine();
            var reversed = ReverseName(nameUSer);//ReverseName() method is in outside of the main method

            Console.WriteLine("Reveresd : "+reversed);

            //get user input as numbers continously until user input quit, and display unique numbers to console

            var numbers2 = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number :");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;
                numbers2.Add(Convert.ToInt32(input));
            }

            var uniques = GetUniqueNumbers(numbers2);
           
            Console.WriteLine("Unique numbers: ");
            foreach(var j in uniques)
            {
                Console.WriteLine(j);
            }

            // File and FileInfo

            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\mydoc.jpg", true); //parameter 1 = copy from , parameter 2 = copy to, parameter 3 optional - if true = overwrite file
            File.Delete(path);
            if (File.Exists(path))
            {
                //do somthing
            }

            var content = File.ReadAllText(path);//return string

            //FileInfo class's methods
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("path", true); //parameter 2 = copy to, parameter 3 optional - if true = overwrite file
            fileInfo.Delete();
            if (fileInfo.Exists) //in here , Exists is a property, not a method
            {
                //do somthing
            }

            //Directory and DirectoryInfo

            Directory.CreateDirectory(@"c\temp\folder");
          var files =  Directory.GetFiles(@"C:\Users\Dulanjali\Desktop\Code with Mosh", "*.", SearchOption.AllDirectories);//* = all files extension. this returns a string array
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\Users\Dulanjali\Desktop\Code with Mosh","*.",SearchOption.AllDirectories); //this returns a string array
            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists(@"C:\Users\Dulanjali\Desktop\Code with Mosh");

            //FileInfo class's methods
            var directoryInfo = new DirectoryInfo(@"C:\Users\Dulanjali\Desktop\Code with Mosh");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories("*.",SearchOption.AllDirectories);

            

            //create string based on buffer array

            var password = new string(buffer);
            Console.WriteLine(password);
            

            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine("@Echo:" + input);

                //if (!String.IsNullOrWhiteSpace(input)) //if not this, loop will iterating as previous.but after iterate 1 time it will terminate because of the break.
                //{
                //Console.WriteLine("@Echo:" + input);
                //  continue; //but using continue, our loop not going to out of this block , it will go to line 291 again and continue loop
                //}
                //    break;

                
            }

        }

        public static List<int> GetUniqueNumbers(List <int> numbers2) //return type is List<int> and parameter is List<int>
        {
            var uniques = new List<int>();
            foreach (var d in numbers2)
            {
                if (!uniques.Contains(d))
                {
                    uniques.Add(d);
                }
            }
            return uniques;
        }

        public static string ReverseName(string nameUSer)
        {
            var array3 = new char[nameUSer.Length];
            for (var gl = nameUSer.Length; gl > 0; gl--)
            {
                array3[nameUSer.Length - gl] = nameUSer[gl - 1];
            }
            return new string(array3);//store array in string
            
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
