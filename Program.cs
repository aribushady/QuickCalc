using System;


namespace QuickCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Year 1 of Payments with $200 extra per month:");
            ExtraPaymentPrinciple(1, 72, 200, 426);

            //Console.WriteLine($"Year 2 of payements with $250 extra per month:");
            //ExtraPaymentPrinciple(13, 24, 600, 438);

            //Console.WriteLine($"Year 3 of payements with $450 extra per month:");
            //ExtraPaymentPrinciple(25, 36, 735, 450);

            //Console.WriteLine($"Year 4 of payements with $525 extra per month:");
            //ExtraPaymentPrinciple(37, 48, 835, 463);

            //Console.WriteLine($"Year 5 of payements with $1000 extra per month:");
            //ExtraPaymentPrinciple(49, 60, 1500, 476);


        }

       private static void ExtraPaymentPrinciple(int paymentTerm, int numPaysments, int extraAmount, int prinicipleStartAmount)
        {
            int totalPaid = 0;
            int principlePayment = extraAmount + prinicipleStartAmount;

            for (int i = paymentTerm; i <= numPaysments; i++)
            {
                switch (i)
                {
                    case 32:
                    case 47:
                    case 57:
                    case 66:
                    case 73:
                    case 79:
                    case 85:
                        prinicipleStartAmount += 2;
                        principlePayment++;
                        break;
                }
                
                totalPaid += principlePayment;

                Console.WriteLine($"Principle Paid Per Payment:{i} {principlePayment++}");
                

            }
            Console.WriteLine($"Total paid in year with extra ${extraAmount} month: {totalPaid}");
        }
    }
}
