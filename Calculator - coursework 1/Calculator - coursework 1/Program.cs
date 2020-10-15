using System;
using System.ComponentModel.Design.Serialization;
using System.IO.Pipes;
using System.Runtime.InteropServices.ComTypes;

namespace Calculator___coursework_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to this scientific calculator Please follow the attached instructions to use!");
            // starting screen for user

            string userInput = Console.ReadLine();

            int arrayNumber = 0;
            string[] finalArray = new string[3];
            // uses array to store each number and operator as strings because Console.ReadLine geneates string results.

            for (int i = 0; i < userInput.Length; i++)
            {
                switch (userInput[i])
                {
                    case '+':
                        // addition string added to array for later use
                        // when operation is reached arrayNumber is increased by 1, so we enter the next index of the array - finalArray[]. 
                        // The operator is then stored in that array, before arrayNumber is increased again for the next element to be configured in the next finalArray[] index.
                        arrayNumber++;
                        finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                        arrayNumber++;
                        break;

                    case 'M':
                        // subtraction string added to array for later use
                        // letter M used to denote minus, as minus sign can represent a negative number or an operator
                        // when operation is reached arrayNumber is increased by 1, so we enter the next index of the array - finalArray[]. 
                        // The operator is then stored in that array, before arrayNumber is increased again for the next element to be configured in the next finalArray[] index.
                        arrayNumber++;
                        finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                        arrayNumber++;
                        break;

                    case '*':
                        // multiplication string added to array for later use
                        // when operation is reached arrayNumber is increased by 1, so we enter the next index of the array - finalArray[]. 
                        // The operator is then stored in that array, before arrayNumber is increased again for the next element to be configured in the next finalArray[] index.
                        arrayNumber++;
                        finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                        arrayNumber++;
                        break;

                    case '/':
                        // division string added to array for later use
                        // when operation is reached arrayNumber is increased by 1, so we enter the next index of the array - finalArray[]. 
                        // The operator is then stored in that array, before arrayNumber is increased again for the next element to be configured in the next finalArray[] index.
                        arrayNumber++;
                        finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                        arrayNumber++;
                        break;

                    case '^':
                        // exponent string added to array for later use
                        // when operation is reached arrayNumber is increased by 1, so we enter the next index of the array - finalArray[]. 
                        // The operator is then stored in that array, before arrayNumber is increased again for the next element to be configured in the next finalArray[] index.
                        arrayNumber++;
                        finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                        arrayNumber++;
                        break;

                    case 'R':
                        // root string added to array for later use
                        // when operation is reached arrayNumber is increased by 1, so we enter the next index of the array - finalArray[]. 
                        // The operator is then stored in that array, before arrayNumber is increased again for the next element to be configured in the next finalArray[] index.
                        // As there is only one input value for root function the value 0 is assigned to the next index of finalArray[]. This is not used wen the function is called.
                        arrayNumber++;
                        finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                        arrayNumber++;
                        finalArray[arrayNumber] = "0";
                        break;

                    case 'I':
                        // inverse string added to array for later use
                        // when operation is reached arrayNumber is increased by 1, so we enter the next index of the array - finalArray[]. 
                        // The operator is then stored in that array, before arrayNumber is increased again for the next element to be configured in the next finalArray[] index.
                        // As there is only one input value for inverse function the value 0 is assigned to the next index of finalArray[]. This is not used wen the function is called.
                        arrayNumber++;
                        finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                        arrayNumber++;
                        finalArray[arrayNumber] = "0";
                        break;

                    case '!':
                        // factorial string added to array for later use
                        // when operation is reached arrayNumber is increased by 1, so we enter the next index of the array - finalArray[]. 
                        // The operator is then stored in that array, before arrayNumber is increased again for the next element to be configured in the next finalArray[] index.
                        // As there is only one input value for factorial function the value 0 is assigned to the next index of finalArray[]. This is not used wen the function is called.
                        arrayNumber++;
                        finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                        arrayNumber++;
                        finalArray[arrayNumber] = "0";
                        break;

                    case '|':
                        // absolute string added to array for later use
                        // when operation is reached arrayNumber is increased by 1, so we enter the next index of the array - finalArray[]. 
                        // The operator is then stored in that array, before arrayNumber is increased again for the next element to be configured in the next finalArray[] index.
                        // As there is only one input value for absolute function the value 0 is assigned to the next index of finalArray[]. This is not used wen the function is called.
                        arrayNumber++;
                        finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                        arrayNumber++;
                        finalArray[arrayNumber] = "0";
                        break;

                    case 'P':
                        // allows user to call Pi, had to convert to string as finalArray[] is an array of strings. Will be stored as string and converted to float when inA or inC is assigned.
                        finalArray[arrayNumber] = Convert.ToString(Math.PI);
                        break;

                    case 'E':
                        // allows user to call e, had to convert to string as finalArray[] is an array of strings. Will be stored as string and converted to float when inA or inC is assigned.
                        finalArray[arrayNumber] = Convert.ToString(Math.E);
                        break;

                    case 'S':
                        // sine string added to array for later use
                        // when operation is reached arrayNumber is increased by 1, so we enter the next index of the array - finalArray[]. 
                        // The operator is then stored in that array, before arrayNumber is increased again for the next element to be configured in the next finalArray[] index.
                        // As there is only one input value for sine function the value 0 is assigned to the next index of finalArray[]. This is not used wen the function is called.
                        arrayNumber++;
                        finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                        arrayNumber++;
                        finalArray[arrayNumber] = "0";
                        break;

                    case ' ':
                        // does nothing. Put in place in case user inputs spaces, this will have no effect on the arrays and the loop will continue to work.
                        break;

                    default:
                        // default case for assembling numbers. As the userInput string is being read through character by character numbers are broken down. This default simply adds each
                        // new character to the current array, effectively concatenating numbers. For exaple userInput "322" is read as characters '3', '2', & '2' - this default re-creates "322". 
                        finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                        break;
                }

            }

            float inA = float.Parse(finalArray[0]);
            string inB = finalArray[1];
            float inC = float.Parse(finalArray[2]);

            // Could have used switch statements for cleaner code but wanted to show use of both disciplines
            if (inB == "+")
            {
                float AddResult = Addition(inA, inC);
                Console.WriteLine(AddResult);
            }

            else if (inB == "M")
            {
                float SubResult = Subtraction(inA, inC);
                Console.WriteLine(SubResult);
            }

            else if (inB == "*")
            {
                float MultResult = Multiplication(inA, inC);
                Console.WriteLine(MultResult);
            }

            else if (inB == "/")
            {
                float DivResult = Division(inA, inC);
                Console.WriteLine(DivResult);
            }

            else if (inB == "^")
            {
                float ExpResult = Exponent(inA, inC);
                Console.WriteLine(ExpResult);
            }

            else if (inB == "R")
            {
                float RootResult = Root(inA);
                Console.WriteLine(RootResult);
            }

            else if (inB == "I")
            {
                float InvResult = Inverse(inA);
                Console.WriteLine(InvResult);
            }

            else if (inB == "!")
            {
                float FactResult = Factorial(inA);
                Console.WriteLine(FactResult);
            }

            else if (inB == "|")
            {
                float AbsResult = Absolute(inA);
                Console.WriteLine(AbsResult);
            }

            else if (inB == "S")
            {
                float SinResult = Sine(inA);
                Console.WriteLine(SinResult);
            }

        }

        static float Addition(float a, float b)
        {
            float result = a + b;
            return result;
        }


        static float Subtraction(float a, float b)
        {
            float result = a - b;
            return result;
        }

        static float Multiplication(float a, float b)
        {
            float result = a * b;
            return result;
        }

        static float Division(float a, float b)
        {
            float result = a / b;
            return result;
        }

        static float Exponent(double a, double b)
            // Math.Sqrt function only accepts double as an input, however my inputs from Console.ReadLine and within functions are all working with floats.
        {
            float result = (float)Math.Pow(a, b);
            return result;
        }

        static float Root(float a)
            // Math.Sqrt function only accepts double as an input, however my inputs from Console.ReadLine and within functions are all working with floats. As there exists an implicit 
            // conversion from float to double this could have been handled in the same way as the Exponent function above, but I wanted to show a different technique. To get around this I created
            // a new variable b, which was just the input a converted to a double. I then cast the result of Math.Sqrt on the double b to a float and returned that float as the funtions result.
        {
            double b = Convert.ToDouble(a);
            float result = (float)Math.Sqrt(b);
            return result;
        }

        static float Inverse(float a)
            // Simple inverse function, takes a float a as input parameter and divides one by this input to calculate inverse.
        {
            float result = 1 / a;
            return result;
        }

        static float Factorial(float a)
            // Factoial function. Takes user input as float a. Two floats declared. For loop begins with stipulation that i is one less than the input number for multiplication use.
            // The for loop will continue to execute as long as i is more than or equal to 1 (multiplication by one has no effect so just as easily could have been >1 with same result)
            // i decreases by one through each iteration of the for loop. The float result begins as the input a, but through the for loop is multiplied by i, which is one less than a initially
            // and is then every integer counting down from then, thus acheiving the factorial calculation.
        {
            float result, i;
            result = a;
            for (i = a - 1; i >= 1; i--)
            {
                result = result * i;
            }
            return result;
        }

        static float Absolute(float a)
        {
            float result = Math.Abs(a);
            return result;
        }

        static float Sine(float a)
        {
            float result = (float)Math.Sin(a);
            return result;
        }
    }
}
