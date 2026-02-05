using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1


            double d = 9.99;
            int x = (int)d;
            Console.WriteLine(x);

            Console.WriteLine("the variable d is a double with value 9.99 " +
                "in C#, casting from double to int truncates the decimal part " +
                "So 9.99 becomes 9, not 10.");
            #endregion

            #region Question 2
            int n = 5;
            double d2 = (double)n / 2;
            Console.WriteLine(d2);

            #endregion

            #region Question 3
            Console.Write("Enter  your age: ");
            int age;
            if (int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine($"You entered: {age}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for age.");
            }
            #endregion
            #region Question 4
            //string s = "12a";
            //int l = int.Parse( s);
            //Console.WriteLine(x);

            Console.WriteLine("This case throws a FormatException because the character cannot be directly converted, although Convert.ToInt32 converts a char to its Unicode value.");
            #endregion
            
            #region Question 5
            //string s = "12a";
            //int l = int.Parse(s);
            //Console.WriteLine(x);


            Console.Write("Enter a  number: ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {

                Console.WriteLine(number);
            }


            else
            {
                Console.WriteLine("Invalid");

            }
            #endregion

            #region Question 6
            object o = 10;
            int a = (int)o;
            Console.WriteLine(a + 1);
            // a=11  
            Console.WriteLine("The integer 10 is stored in an object variable." +
                "This is called boxing that converts value type into a referecne type " +
                " Unboxing: converting  the object back  so a equals 11 after adding 1");

            #endregion

            #region Question 7
            //object o = 10;
            //long x = (long)o;
            Console.WriteLine(" o contains an integer (boxed), so unboxing must match the original type (int). Then it can be safely converted to long.");

            #endregion
            #region Question 8

            object z = 10;
            long p;

            if (z is int i)
                p = i;
            else if (z is long l)
                p = l;
            else
                x = -1;

            Console.WriteLine(x);
            #endregion
            #region Question 9

            string? name = null;
            Console.WriteLine(name?.Length);
            Console.WriteLine("name is a nullable reference type and currently null.   " +
                "The ?. is the null-conditional operator." +
                "If name is not null, return name.Length." +
                "If name is null, return null without throwing an exception." +
                "Since name is null, name?.Length is null.");

            #endregion
            #region Question 10

            string? name2 = null;
            int length = name2?.Length ?? 0;
            Console.WriteLine("name2 is a nullable reference type with value null.   " +
                "The ?. is the null-conditional operator." +
                "Returns name2.Length if name2 is not null; otherwise returns null.." +
                "If the left-hand side (name2?.Length) is null, it returns the right-hand side (0).." 
                );

            #endregion
            #region Question 11
            //string? s = null;
            //int x = int.Parse(s ?? "0");
            // Console.WriteLine(x);

            Console.WriteLine("s ?? \"0\"  only handles null." +
                "If s contains \"abc\" or \"12a\", int.Parse throws FormatException." +
                "So this is not completely safe." +
                "Safe from null and invalid numeric input. No exception will occur.");



            #endregion

            #region Question 12


            //string? s = null; 
            //Console.WriteLine(s!.Length);
            Console.WriteLine(" s is a nullable string (null)." +
                "s! is the null-forgiving operator, which tells the compiler \"trust me, this is not null.\"." +
                "So this is not completely safe." +
                "Problem: At runtime, s is actually null. Accessing s.Length causes a NullReferenceException..");



            string? s = null;
            Console.WriteLine(s!?.Length ?? 0);



            #endregion


            #region Question 13
            //string? s = null;
            //int x = Convert.ToInt32(s);
            //Console.WriteLine(x );

            //null
            #endregion

            #region Question 14

            //string? s = null;

            // A
            // int a = int.Parse(s);  
            Console.WriteLine("A: int.Parse(s) will throw a FormatException because s is null and Parse cannot convert null to int.");

            // B
            // int b = Convert.ToInt32(s);  
            Console.WriteLine("B: Convert.ToInt32(s) returns 0 if s is null. No exception occurs.");

            // Demo of B
            string? sB = null;
            int b = Convert.ToInt32(sB);
            Console.WriteLine(b); // prints 0

            #endregion
            #region Question 15

            string? user = null;

            // Use null-coalescing operator with ToUpper
            Console.WriteLine((user?.ToUpper()) ?? "Guest");

            // If user = "Hossam" → prints "HOSSAM"
            // If user = null → prints "Guest"

            #endregion
              


           

        }
    }
}
