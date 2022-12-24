using System;

namespace CodeWithMosh1
{
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

        }
    }
}
