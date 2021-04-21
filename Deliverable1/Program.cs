// Deliverable 1 is a program that prompts for a measurement value and a unit, it then converts it from Imperial over to MilliHips or from Millihips to Imperial. It then asks the user if it would like 
// to do another convsersion. If user responds with anything but no, the program will prompt for another input to continue doing conversions.
// using this


using System;

namespace Deliverable1
{
	class Mainclass
	{


		public static void Main(string[] args)

		{
			{

				//initialize the variables as a decimal for conversions
				decimal inchtospin = (decimal)(7.0/2.0);

				decimal foottomeme = 5;

				decimal spintoinch = (decimal)(2.0 / 7.0);

				decimal memetofoot = (decimal)(1.0 / 5.0);

				string response = "yes";

				while (response == "yes")
				{


					Console.WriteLine("Input measurement Value ");
					// Asks for input and stores this value as a string


					string InputValue = Console.ReadLine();


                    //Initializes the Variable Measured value and parses the string into a decimal value


                    Console.WriteLine("Input measurement units type");
                    // Asks for input 


                    string MeasurementType = Console.ReadLine();
					// stores input as a string


					decimal MeasuredValue = decimal.Parse(InputValue);
					//changes the variable type 

					Decimal.Round(MeasuredValue, 2);

                    if (MeasurementType == "inch")
                    {
                        decimal NewValue = MeasuredValue * inchtospin;

                        Console.WriteLine(("The result is " + NewValue + " fidget spinners"));
                    }
                    // This checks the string Measurement type for the inch input and outputs  converted value and the new unit

                    if (MeasurementType == "foot")
					{
						decimal NewValue = MeasuredValue * foottomeme;

						Console.WriteLine(("The result is " + NewValue + " memes"));
					}
					// This checks the string Measurement type for the foot input and outputs  converted value and the new unit 

					if (MeasurementType == "fidget spinners")
					{
						decimal NewValue = MeasuredValue * spintoinch;

						Console.WriteLine(("The result is " + NewValue + " inches"));

					}
					// This checks the string Measurement type for the fidget spinners input and outputs  converted value and the new unit 

					if (MeasurementType == "memes")
					{
						decimal NewValue = MeasuredValue * memetofoot;

						Console.WriteLine(("The result is " + NewValue + " feet"));

					}
					// This checks the string Measurement type for the memes input and outputs  converted value and the new unit 


					Console.WriteLine(("Do you need to do another conversion Yes or No? "));

					//prompts the user if they need to do more conversions

					response = Console.ReadLine();

					// sets the boolean condition to the user input to check to see if another iteration is required.


					
				}

			}
		}

       
    }

}