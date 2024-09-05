using System.Runtime.CompilerServices;

namespace C__basics_1
{
    internal class Program
    {
        // This is a class wide variable and it can be used by any fuction inside of the Program class
        static int variable1;

        //This is an examle of a function with a return of a string. When you are making a function you have to write static first in order to make it work inside of the Program class
        //If you dont put static first the function wont be aviable inside of the Program class. Next up is the return value type in this case a string after that is the name
        static string Function1()
        {
            return "Meow";
        }

        //This function takes in a variable as a parametar in a way that it can`t edit the original variable
        static int Function2(int variable2)
        {
            //This is a function vide variable and can only be used inside Function 2. You dont have to put static before it
            int variable3;

            variable3 = variable2 + variable1;

            return variable3;
        }

        //This function takes in a variable by referance meaning that it can change the value of the original value
        //Note: Arrays are always passed by reference
        static void Function3(ref int variable2)
        {
            variable2 = variable2 + variable1;
        }

        static void Main(string[] args) //This is your main method, it functions like in c++ but it is a bit diferent in that it is a void instead of an int and you can`t return
                                        //exit values from it. It also provides you with a string that contains the parameters that the program has been launched with 
                                        //In order to get the lenght of the string you will have to do args.Lenght as a separate variable for the lenght is not provided
                                        //The args string does not contain the program path as it does in c++
        {
            //This is the way you print data to the console. I will use this as an example of how to use fuctions and variables form another class(object)
            //the Console part is refering to an object with that name and .WriteLine part is a function insside that class that you are calling
            Console.WriteLine(Function1());

            //You can also change variables from the class like the color variable
            //The console part functions the same as when you are using it to call a function but after the .ForegroundColor comes a = operator and the value that you are giving to
            //the variable in this case the value is a constant with the name Green from the class called ConsoleColor
            Console.ForegroundColor = ConsoleColor.Green;

            //Keep in mind that the Console part is given to you and you cant change its name but with custom classes (i will cover them in another program) you can pick a name
            //for your object. And to clear up some confusion, an object is a class that has been created using a constuctor. They are not the same thing and i will explain more in
            //the later programs that talk about how object oriented programing works

            //I dont think i need to explain this.
            variable1 = 24;

            //This is how you add a intiger value to a string when you want to print it out to the console
            Console.WriteLine("This is the value of the variable1: {0}", variable1);

            //This is how you add more than 1 variable to the string that is printed to the console
            Console.WriteLine("This is the value of the variable1 and the return value of the function2: {0} & {1}", variable1, Function2(24));

            //Again i think i dont need to explain how this works
            int variable4 = 24;

            //This is how you call and pass in a value by reference(meaning that the program can edit the original value)
            //The ref keyword is not needed when passing in arrays and when the function doesnt ask for a variable by reference
            Function3(ref variable4);
            Console.WriteLine("This is the value of the variable4 after the function3 has been called: {0}", variable4);

            int variable5;
            //The write function prints stuff to the console but it doesnt start a new line (line cout << "meow";)
            Console.Write("Enter an intiger: ");

            //This is how you read data from the console
            //the variable5 is an int but the text on the console is a string so we need to convert it
            //and for that we call the Parse function from the int class and we pass in the string we want it to convert (in this case it is the return value of the ReadLine function
            //from the Console class) and in turn it will return us an int value that we can use for math
            //Note1: This is not idiot proof and someone can enter a non number character and this will give an error and stop execution but i will demostrate a solution later on
            //Note2: The Parse function has to be called for every type exept for string
            variable5 = int.Parse(Console.ReadLine());

            //The writeline function prints stuff to the console but it does start a new line (line cout << "meow" <<endl;)
            Console.WriteLine("The number you put in was {0}", variable5);

            float variable6;

            //This is the same so i wont spend time explaining it
            variable6 = (float)variable5 / variable1;

            //This will print an unformated float that may have a lot of useless decimals
            Console.WriteLine("This is the number you entered devided by {0}: {1}", variable1, variable6);

            //This will print out a float formated with the template that you put into the function .ToString that is contained in the float calss
            //(here being called from an object called variable6)
            Console.WriteLine("This is the number you entered devided by {0}: {1} but with 2 decimals", variable1, variable6.ToString("0.00"));

        }
    }
}
