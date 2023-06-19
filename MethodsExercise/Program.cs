namespace MethodsExercise
{
    public class Program
    {
        // Exercize#1 with the Bonus Method
        public static void AboutOwner() // Creation of AboutOwner Method
        {
            // to get info about the name
            Console.WriteLine("Hello, What is your name?");
            string userName = Console.ReadLine();

            // to get info about the fav color
            Console.WriteLine("Hello, What is your favorite color");
            string favColor = Console.ReadLine();

            // to get info about the fav animal
            Console.WriteLine("Hello, What is your favorite Animal?");
            string favAnimal = Console.ReadLine();

            // to get info about the fav band
            Console.WriteLine("Hello, What is your favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine(" "); // to add space between the input and output
            Console.WriteLine(" "); // to add space between the input and output
            Console.WriteLine($"Hello my name is {userName} and my favorite color is {favColor}.");
            Console.WriteLine($"My favorite animal to own would be a {favAnimal} and I woould play with it all day.");
            Console.WriteLine($"I love music all types but my favorite band is {favBand}.");
        }

        // Exercize#2 with the 4 Methods
        // This is the addition Method
        public static int Addition(int numa, int numb)
        {
            return numa + numb;
        }

        // This is the Substraction Method
        public static int Substraction(int numc, int numd)
        {
            return numc - numd;
        }

        // This is the Multiplication Method
        public static int Multiplication(int nume, int numf)
        {
            return nume * numf;
        }

        // This is the Division Method
        public static int Division(int numg, int numh)
        {
            return numg / numh;
        }

        // This is the Modulus section Method - Bonus
        // Still thinking about this one


        static void Main(string[] args)
        {
            // Output of Exercize#1 with the Bonus Method
            Console.WriteLine("This is The output of Exercize#1 with the Bonus Method");
            Console.WriteLine(" ");
            Console.WriteLine("This is information about the first person");
            AboutOwner(); // Usage of Method AboutOwner

            Console.WriteLine(" "); // to add space between the running of the method the first time and second time
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("This is information about the second person");
            AboutOwner(); // Usage of Method AboutOwner


            Console.WriteLine(" ");
            Console.WriteLine("Output of Exercize#2 with the 4 Methods for Addition Substraction Multiplication Division");
            // Output of Exercize#2 with the 4 Methods
            // Addtion Method
            int answer1 = Addition(500, 439);
            int answer2 = Addition(2, 6);
            Console.WriteLine(" ");
            Console.WriteLine("This is The output of the addition Method");
            Console.WriteLine($"This is the First result of Addition Number 500 and Number 439 and the answer is {answer1}");
            Console.WriteLine($"This is the Second result of Addition Number 2 and Number 6 and the answer is {answer2}");
            
            // Substration Method
            int answer3 = Substraction(1000, 250);
            int answer4 = Substraction(15, 5);
            Console.WriteLine(" ");
            Console.WriteLine("This is The output of the Substraction Method");
            Console.WriteLine($"This is the First result of Substraction Number 1000 and Number 250 and the asnwer is {answer3}");
            Console.WriteLine($"This is the Second result of Substraction Number 15 and Number 5 and the answer is {answer4}");

            // Multiplication Method
            int answer5 = Multiplication(5, 5);
            int answer6 = Multiplication(9, 3);
            Console.WriteLine(" ");
            Console.WriteLine("This is The output of the Multiplication Method");
            Console.WriteLine($"This is the First result of Multiplication Number 5 and Number 5 and the asnwer is {answer5}");
            Console.WriteLine($"This is the Second result of Multiplication Number 9 and Number 3 and the answer is {answer6}");

            // Division Method
            int answer7 = Division(8, 2);
            int answer8 = Division(12, 3);
            Console.WriteLine(" ");
            Console.WriteLine("This is The output of the Division Method");
            Console.WriteLine($"This is the First result of Division Number 8 and Number 2 and the asnwer is {answer7}");
            Console.WriteLine($"This is the Second result of Division Number 12 and Number 3 and the answer is {answer8}");

            // for the bonus(Modulus Method) - Thinking about this one
            // int Num1 = 2; int Num2 = 4;
            // int Num1 = 2; int Num2 = 4; int Num6 = 1;
            // int Num3 = Num1 + Num2;
            // int Num4 = Num1 + Num2 + Num3;
            // int Num5 = Num6 + Num6 + Num6 + Num6 + Num6;
            // Console.WriteLine(" ");
            // Console.WriteLine("This is The output of the addition");
            // Console.WriteLine("addition results");
            // Console.WriteLine($"The Numbers are as follows {Num1} {Num2} {Num3} {Num4} {Num5} {Num6}.");
                        
            //Code to be resused later
            // Substraction
            //int Num7 = Num2 - Num1;
            //Console.WriteLine(" ");
            //Console.WriteLine("This is The output of the Substraction");
            //Console.WriteLine("Substraction result");
            //Console.WriteLine($"The Substraction of {Num1} and {Num2} results in the following number {Num7}.");
            // Multiplication
            // int Num8 = Num1 * Num2;
            // Console.WriteLine(" ");
            // Console.WriteLine("This is The output of the Multiplication");
            // Console.WriteLine("Multiplication result");
            // Console.WriteLine($"The Multiplication of {Num1} and {Num2} results in the following number {Num8}."); 
            // Division
            // int Num9 = Num2 / Num1;
            // Console.WriteLine(" ");
            // Console.WriteLine("This is The output of the Division");
            // Console.WriteLine("Division results");
            // Console.WriteLine($"The Division of {Num1} and {Num2} results in the following number {Num9}.");


        }

    }
}
