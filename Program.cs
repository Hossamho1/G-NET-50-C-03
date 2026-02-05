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


        }
    }
}
