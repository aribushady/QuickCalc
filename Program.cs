using System;


namespace QuickCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Year 1 of Payments with $200 extra per month:");
            //ExtraPaymentPrinciple(1, 6, 100, 426);

            //Console.WriteLine($"Year 2 of payements with $250 extra per month:");
            //ExtraPaymentPrinciple(7, 24, 350, 433);

            //Console.WriteLine($"Year 3 of payements with $450 extra per month:");
            //ExtraPaymentPrinciple(19, 54, 500, 439);

            ////Console.WriteLine($"Year 4 of payements with $525 extra per month:");
            ////ExtraPaymentPrinciple(37, 48, 835, 463);

            ////Console.WriteLine($"Year 5 of payements with $1000 extra per month:");
            ////ExtraPaymentPrinciple(49, 60, 1500, 476);
               
            Console.WriteLine(MonthlyMortgagePayment(238000, 0.0275, 30));
            Amortization(238000, 0.0275, 30);
         
        }
        static void ExtraPaymentPrinciple(int paymentTerm, int numPaysments, int extraAmount, int prinicipleStartAmount)
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

        static void Amortization(double loan, double interestRate, int leaseTerm)
        {
            int monthsInYear = 12;
            int monthsInLeaseTerm = monthsInYear * leaseTerm;
            double newLoanAmount = loan;
            

            for (int i = 1; i <= monthsInLeaseTerm; i++)
            {
                double principleAmount = Math.Round(MonthlyMortgagePayment(loan, interestRate, leaseTerm) - (newLoanAmount * interestRate) / 12, 2);
                newLoanAmount -= principleAmount; 
                
                Console.WriteLine($"{i}: Principle Ammount: {principleAmount} Remaing Loan: {Math.Round(newLoanAmount, 2)} ");
            }
           
        }

        static double MonthlyMortgagePayment(double loan, double interestRate, int leaseTerm)
        {
            int monthsInYear = 12;
            int monthsInLeaseTerm = leaseTerm * monthsInYear;
            double interestPerMonth = interestRate / monthsInYear;

            double payment = loan * (interestPerMonth) * Math.Pow(1 + interestPerMonth, monthsInLeaseTerm) / (Math.Pow(1 + interestPerMonth, monthsInLeaseTerm) - 1);

            return Math.Round(payment, 2);
        }
    }
}
