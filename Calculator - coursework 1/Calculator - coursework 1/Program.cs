using System;
using System.ComponentModel.Design.Serialization;
using System.IO.Pipes;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Schema;

namespace Calculator___coursework_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to this scientific calculator Please follow the attached instructions to use!");
            // starting screen for user, will only be printed once as it sits outside of the while loop for operations.

            string userInput = "";
            // string declared for user inut and assigned a null value. To be overwritten with Console.ReadLine (the users input) within the while loop

            float Ans = 0;
            // initial creation of saved answer float is created and default value set to 0.

            bool firstNumberSane = false;
            bool secondNumberSane = false;
            bool operatorSane = false;
            // Sanity bools created for all 3 elements of the users input. Default values set to false, so they have to be called, checked and passed, for the calculations to be done.


            while (userInput != "exit")
            // While loop designed to keep the console open and all operations running for as long as the user input is not the word "exit". This allows for continued use/ operations.
            {
                // userInput string overwritten with the users actual input through COnsole.ReadLine.
                userInput = Console.ReadLine();

                int arrayNumber = 0;
                // integer arrayNumber declared to be used as indices within array. Set to 0 as default, as this is where the array will begin.

                string[] finalArray = new string[3];
                finalArray[0] = "";
                finalArray[1] = "";
                finalArray[2] = "";
                // uses array to store each number and operator as strings because Console.ReadLine geneates string results. Sets default values to null so that they can be used immediately.


                if (userInput == "exit")
                // allows user to exit application. As this is the first if statement, should t prove to be true none of the other code will be compiled and the application is terminated 
                // as per the users wish. 
                {
                    System.Environment.Exit(0);
                }

                else if (userInput == "clr")
                // resets saved answer to 0 from specified uer input. As this is within the while loop the calculator will stay open for the users next instructions.                   
                {
                    Ans = 0;
                }

                else
                // execution  of main calculation features only reached after the above bools are checked.
                {
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

                            case 'S':
                                // sine string added to array for later use
                                // when operation is reached arrayNumber is increased by 1, so we enter the next index of the array - finalArray[]. 
                                // The operator is then stored in that array, before arrayNumber is increased again for the next element to be configured in the next finalArray[] index.
                                // As there is only one input value for sine function the value 0 is assigned to the next index of finalArray[]. This is not used when the function is called.
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

                            case 'A':
                                // If user calls the previous answer the stored variable from the previous calculation. This is converted to a string to satisfy the parameters  of finalArray. It will
                                // converted to a float when it is assigned to InA or InC. arrayNumber is not changed because the input following A should be an operator which already have logic to change
                                // index.
                                finalArray[arrayNumber] = Convert.ToString(Ans);
                                break;

                            default:
                                // default case for assembling numbers. As the userInput string is being read through character by character numbers are broken down. This default simply adds each
                                // new character to the current array, effectively concatenating numbers. For example userInput "322" is read as characters '3', '2', & '2' - this default re-creates "322". 
                                finalArray[arrayNumber] = finalArray[arrayNumber] + userInput[i];
                                break;
                        }

                    }

                    firstNumberSane = Sanitize(finalArray[0]);
                    secondNumberSane = Sanitize(finalArray[2]);
                    // Sanitize function is called first the first and third arrays, which should be numbers. The bool returned by the Sanitize function which operates on the finalArray[] is then assigned to the
                    // santy bools firstNumberSane and SecondNumberSane.

                    switch (finalArray[1])
                    {
                        case "+":
                            operatorSane = true;
                            break;

                        case "M":
                            operatorSane = true;
                            break;

                        case "*":
                            operatorSane = true;
                            break;

                        case "/":
                            operatorSane = true;
                            break;

                        case "^":
                            operatorSane = true;
                            break;

                        case "R":
                            operatorSane = true;
                            break;

                        case "I":
                            operatorSane = true;
                            break;

                        case "!":
                            operatorSane = true;
                            break;

                        case "|":
                            operatorSane = true;
                            break;

                        case "S":
                            operatorSane = true;
                            break;
                    }
                    // operatorSane is defaulted to false. Using the switch statement above if the second final array, which is the operator, matches any of the specified inputs to use as an operator, then 
                    // operatorSane becomes true. if the input was anything other than one of the viable characters listed then operatorSane remains false.

                    if (!firstNumberSane || !secondNumberSane || !operatorSane)
                    // uses or comparison operator to check if any of the sanity checks were failed. If one or more are false then the if statement is executed. This writes a message to the user, and then continue
                    // is used to return to the start of the while loop this statement is encapsulated in.
                    {
                        Console.WriteLine("You have entered an incompatible input, please try again");
                        continue;
                    }

                    float inA = float.Parse(finalArray[0]);
                    // first number will be stored as a string in the first array [0] because of the default case, this is cast to a float to be used in calculations as the first input.
                    string inB = finalArray[1];
                    // the second array is the operator as all specified operators had logic specified to move up an index when reached, and were then saved. These are stored as strings to be used
                    // with comparison operators below and the corresponding function is called.
                    float inC = float.Parse(finalArray[2]);
                    // after all operators the case logic is to move into the next index, and then the default case will collate numbers into the last finalArray, which is the third array [2]. Again
                    // the string is cast to a float so it can be used for calculations below. In some cases the third array was assigned a value of zero for functions where only one input number would 
                    // be acted on by the operator (e.g. the Sine function).

                    // Could have used switch statements below for cleaner code but wanted to show use of both disciplines

                    if (inB == "+")
                    // Calls addition function with 2 inputs. Assigns the result of the calculation to the float Ans which can be called by the user for more calculations.
                    {
                        float AddResult = Addition(inA, inC);
                        Console.WriteLine(AddResult);
                        Ans = AddResult;
                    }

                    else if (inB == "M")
                    // Calls subtraction function with 2 inputs. Assigns the result of the calculation to the float Ans which can be called by the user for more calculations. 
                    {
                        float SubResult = Subtraction(inA, inC);
                        Console.WriteLine(SubResult);
                        Ans = SubResult;
                    }

                    else if (inB == "*")
                    // Calls mutiplication function with 2 inputs. Assigns the result of the calculation to the float Ans which can be called by the user for more calculations.
                    {
                        float MultResult = Multiplication(inA, inC);
                        Console.WriteLine(MultResult);
                        Ans = MultResult;
                    }

                    else if (inB == "/")
                    // Calls addition function with 2 inputs. Assigns the result of the calculation to the float Ans which can be called by the user for more calculations. 
                    {
                        float DivResult = Division(inA, inC);
                        Console.WriteLine(DivResult);
                        Ans = DivResult;
                    }

                    else if (inB == "^")
                    // calls eponential function with 2 inputs. Assigns the result of the calculation to the float Ans which can be called by the user for more calculations.
                    {
                        float ExpResult = Exponent(inA, inC);
                        Console.WriteLine(ExpResult);
                        Ans = ExpResult;
                    }

                    else if (inB == "R")
                    // calls root function with 1 input. Assigns the result of the calculation to the float Ans which can be called by the user for more calculations.
                    {
                        float RootResult = Root(inA);
                        Console.WriteLine(RootResult);
                        Ans = RootResult;
                    }

                    else if (inB == "I")
                    // calls inverse function with 1 input. Assigns the result of the calculation to the float Ans which can be called by the user for more calculations.
                    {
                        float InvResult = Inverse(inA);
                        Console.WriteLine(InvResult);
                        Ans = InvResult;
                    }

                    else if (inB == "!")
                    // calls factorial function with 1 input. Assigns the result of the calculation to the float Ans which can be called by the user for more calculations.
                    {
                        float FactResult = Factorial(inA);
                        Console.WriteLine(FactResult);
                        Ans = FactResult;
                    }

                    else if (inB == "|")
                    // calls absolute function with 1 input. Assigns the result of the calculation to the float Ans which can be called by the user for more calculations.
                    {
                        float AbsResult = Absolute(inA);
                        Console.WriteLine(AbsResult);
                        Ans = AbsResult;
                    }

                    else if (inB == "S")
                    // calls sine function with 1 input. Assigns the result of the calculation to the float Ans which can be called by the user for more calculations.
                    {
                        float SinResult = Sine(inA);
                        Console.WriteLine(SinResult);
                        Ans = SinResult;
                    }

                }
            }
        }

        static float Addition(float a, float b)
        // created addiion function which accepts 2 floats as input parameters
        {
            float result = a + b;
            return result;
        }


        static float Subtraction(float a, float b)
        // created subtraction function which accepts 2 floats as input parameters
        {
            float result = a - b;
            return result;
        }

        static float Multiplication(float a, float b)
        // created multiplication function which accepts 2 floats as input parameters
        {
            float result = a * b;
            return result;
        }

        static float Division(float a, float b)
        // created division function which accepts 2 floats as input parameters
        {
            float result = a / b;
            return result;
        }

        static float Exponent(double a, double b)
        // Math.Pow (Exponent) function only accepts double as an input, however my inputs from Console.ReadLine and within functions are all working with floats. As there is an implicit conversion
        // from float to double this is no issue. The inputs from finalArray will be implicitely converted. The return parameter I've specified here is a float so I have cast the result of the 
        //Math.Pow function to a float.
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
                result *= i;
            }
            return result;
        }

        static float Absolute(float a)
        // Absolute function created through use of in-built C# absolute function, takes one input 
        {
            float result = Math.Abs(a);
            return result;
        }

        static float Sine(float a)
        // Sine funcion taking one input. float a implicitly converted to double for calculation by Math.Sin, result cast to a float and returned. Answer in radians.
        {
            float result = (float)Math.Sin(a);
            return result;
        }

        static bool Sanitize(string Input)
        // function to sanitize user input. 3 checks needed to make sure the input is sane (other than above checks on certain inputs for operators and constants), these are for a decimal place, minus sign, and finally
        // just to ensure that the input is numerical if it doesn't meet the other criteria.
        {
            bool TotalCheck = true;
            bool DecimalCheck = false;
            bool MinusCheck = false;

            foreach (char character in Input)
            // runs through each character within the input and checks them all with the below.
            {
                if (character == '.')
                // if the character is a decimal then DecimalCheck is updated to true. In the case DecimalCheck is already true (i.e there is already a decimal in the input) then TotalCheck is set to false as the input
                // cannot be considered sane if there is already a decimal place.
                {
                    if (DecimalCheck)
                    {
                        TotalCheck = false;
                    }

                    DecimalCheck = true;
                }

                if (character == '-')
                // follows the same logic as the decimal check but for a minus sign. If there is one minus sign then TotalCheck will remain true (as it's default is), but if there is more than one minus sine in the
                // input then the number is ot sane, so TotalCheck is updated to false and Sanitization will be false.
                {
                    if (MinusCheck)
                    {
                        TotalCheck = false;
                    }

                    MinusCheck = true;
                }

                else if (!char.IsDigit(character))
                // the final check checks that any remaining characters are numerical by calling IsDigit. If IsDigit fails then TotalCheck is updated to false.
                {
                    TotalCheck = false;
                }
            }
            // the TotalCheck is returned as per the output parameter (bool) of the function. This will be true if all sanity checks are passed, and false if any fail, as per the above logic.
            return TotalCheck;
        }
    }
}
