namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // string firstName; //declration
            //firstName = "Rhea"; //  initilization
            string firstName = "Rhea";// declaration and initilization
            // forumla is (datatype, varialbe name, put equal symbol, add variable value, if it's a string put variable value in qoute marks, finish with ;

            // int myAge; // declaration
            // myAge = 99; // initilization
            int myAge = 99; // declare and init

            // char firstInitial; // declaration syntax
            // firstInitial = 'R'; // initilization
            char firstInitial = 'R'; // declared and initiliazed

            //bool isMarried; // declaration
            //isMarried = false;  initilize
            bool isMarried = false;

            double height = 99.9;

            decimal weight = 129.9m;

            Console.WriteLine($"My name  is {firstName}. I am {myAge} years old (obviously I am super young). " +
                $"My first initial is {firstInitial}. It is {isMarried} that I am married."); 
        }
    }
}





