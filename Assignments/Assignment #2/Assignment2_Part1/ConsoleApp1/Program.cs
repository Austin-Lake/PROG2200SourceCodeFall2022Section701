using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.
            // Initialization of Low Risk Shipping Fees delegate
            ShippingLowRiskFeesDelegate theLow = delegate (ref decimal itemFee) { };
            ShippingFeesDelegate theDel;
            ShippingDestination theDest;
            

            string theZone;
            do
            {
                // get the destination zone
                Console.WriteLine("What is the destination zone?");
                theZone = Console.ReadLine();

                // if the user wrote "exit" then terminate the program,
                // otherwise continue 
                if (!theZone.Equals("exit"))
                {
                    // given the zone, retrieve the associated shipping info
                    theDest = ShippingDestination.getDestinationInfo(theZone);

                    // if there's no associated info, then the user entered
                    // an invalid zone, otherwise continue
                    if (theDest != null)
                    {
                        // 1.
                        // Keeps asking for price until a value greater than zero is entered
                        decimal itemPrice = 0;
                        while (true)
                        {
                            try
                            {
                                // ask for the price and convert the string to a decimal number
                                Console.WriteLine("What is the item price?");
                                string thePriceStr = Console.ReadLine();
                                itemPrice = decimal.Parse(thePriceStr);

                                if (itemPrice > 0)
                                    break;
                                else
                                    Console.WriteLine("Value must be greater than zero");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Value is not a number");
                            }
                            catch (OverflowException) 
                            {
                                Console.WriteLine("Value is too big");
                            }
                        }
                        // Each ShippingDestination object has a function called calcFees,
                        // use that as the delegate for calculating the fee
                        theDel = theDest.calcFees;

                        // For high-risk zones, we tack on the delegate that adds more
                        if (theDest.m_isHighRisk)
                        {
                            theDel += delegate (decimal thePrice, ref decimal itemFee)
                            {
                                itemFee += 25.0m;
                            };
                        }
                        else 
                        {
                            // 2.
                            // Subscribes anonymous delegate method to Low Risk Shipping Fees delegate
                            theLow = delegate (ref decimal itemFee)
                            {
                                //2. 
                                // Subtracts 10 if the fee is over 100
                                if (itemFee > 100.0m)
                                    itemFee -= 10.0m;
                            };
                        }
                      

                        // now all that is left to do is call the delegate and output
                        // the shipping fee to the Console
                        decimal theFee = 0.0m;
                        theDel(itemPrice, ref theFee);
                        // 2.
                        // Calls Low Risk Shipping Fees delegate on the fee as a reference to modify the external value
                        theLow(ref theFee);
                        Console.WriteLine("The shipping fees are: {0}", theFee);
                    }
                    else
                    {
                        Console.WriteLine("Hmm, you seem to have entered an uknown destination. Try again or 'exit'");
                    }
                }
            } while (theZone != "exit");
        }
    }
}
