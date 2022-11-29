

namespace InstallmentPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Principal = 0;
            int ActivityOption;
        debt:
            Console.WriteLine("enter the amount you are owing");

            try
            {
                Principal = int.Parse(Console.ReadLine());
                if (Principal <= 0)
                {
                    Console.WriteLine("invalid input");
                    goto debt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                goto debt;

            }

            Console.WriteLine("\n enter your period of payment");


            bool session = true;
            while (session)
            {
            plan:
                Console.WriteLine("select 1: for daily, 2: for weekly, 3: for bi-weekly, 4: for monthly, 5: for half-year, 6: for Yearly\n");
                Console.WriteLine("******* select either 1, 2, 4, or 6 for now *******");
                Plan plan = new Plan();
                try
                {
                    ActivityOption = int.Parse(Console.ReadLine());


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    goto plan;
                };

                switch (ActivityOption)
                {
                    case 1:
                        plan.Daily(Principal);
                        break;
                    case 2:
                        plan.Weekly(Principal);
                        break;
                    case 3:
                        plan.BiWeekly(Principal);
                        break;
                    case 4:
                        plan.Monthly(Principal);
                        break;
                    case 5:
                        plan.HalfYear(Principal);
                        break;
                    case 6:
                        plan.Annualy(Principal);
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;

                }
               Console.WriteLine("press \"Y\" to continue with another plan");
                string? input2 = Console.ReadLine();
                if (input2.ToUpper() != "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for banking with us");
                    session = false;

                }
            }

        }


    }

    public class Plan
    {
        public void Daily(int Principal)
        {
       
            Console.Clear();
            Console.WriteLine("how many days will it take you to complete your payment");
        Period:
            double input;
            try
            {
                input = int.Parse(Console.ReadLine());
                if (input <= 0)
                {
                    Console.WriteLine("invalid input");
                    goto Period;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Period;

            }

            if (input != 0)
            {
                double rate = 0.05;
                double output = input / 365;
                Console.WriteLine(output);
                double interest = (Principal * rate * output);
                Console.WriteLine("you have interest of {0}", interest);

                double result = Principal + interest;
                double installment = result / input;
                Console.WriteLine("Total payable amount is {0}", result);
                Console.WriteLine("Monthly installmental Payment is {0}: ", installment);
            }
            payment(input);
        }
        public void Weekly(int Principal)
        {
     
        Period:
            Console.WriteLine("how many weeks will it take you to complete your payment");
            double input;
            try
            {
                input = int.Parse(Console.ReadLine());
                if (input <= 0)
                {
                    Console.WriteLine("invalid input");
                    goto Period;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Period;

            }
            if (input != 0)
            {
                double rate = 0.05;
                double output = input / 52;
                Console.WriteLine(output);
                double interest = (Principal * rate * output);
                Console.WriteLine("you have interest of {0}", interest);

                double result = Principal + interest;
                double installment = result / input;
                Console.WriteLine("Total payable amount is {0}", result);
                Console.WriteLine("Weekly installmental Payment is {0}: ", installment);



            }
            payment(input);

        }
        public void BiWeekly(int Principal)
        {
        Period:
            Console.WriteLine("how many weeks  will it take you to complete your payment");
            double input;
            try
            {
                input = int.Parse(Console.ReadLine());
                if (input <= 0)
                {
                    Console.WriteLine("invalid input");
                    goto Period;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Period;

            }
            if (input != 0)
            {
                double result = Principal / (input);


                Console.WriteLine("it will take you {0} weeks to complete your payment", result);
            }
            payment(input);
        }
        public void Monthly(int Principal)
        {

            Console.WriteLine("how many Months will it take you to complete your payment");
        Period:
            double input;
            try
            {
                input = int.Parse(Console.ReadLine());
                if (input <= 0)
                {
                    Console.WriteLine("invalid input");
                    goto Period;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Period;

            }

            if (input != 0)
            {
                double rate = 0.05;
                double output = input / 12;
                Console.WriteLine(output);
                double interest = (Principal * rate * output);
                Console.WriteLine("you have interest of {0}", interest);

                double result = Principal + interest;
                double installment = result / input;
                Console.WriteLine("Total payable amount is {0}", result);
                Console.WriteLine("Monthly installmental Payment is {0}: ", installment);
            }
            payment(input);
        }
        public void HalfYear(int Principal)
        {
        Period:
            Console.WriteLine("how long will it take you to complete your payment");
            double input;
            try
            {
                input = int.Parse(Console.ReadLine());
                if (input <= 0)
                {
                    Console.WriteLine("invalid input");
                    goto Period;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Period;

            }
            if (input != 0)
            {
                double result = Principal / (input);

                Console.WriteLine("it will take you {0} weeks to complete your payment", result);
            }
            payment(input);
        }
        public void Annualy(int Principal)
        {
            Console.WriteLine("how many years will it take you to complete your payment");
        Period:
            double input;
            try
            {
                input = int.Parse(Console.ReadLine());
                if (input <= 0)
                {
                    Console.WriteLine("invalid input");
                    goto Period;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Period;

            }

            if (input != 0)
            {
                double rate = 0.05;


                double interest = (Principal * rate * input);
                Console.WriteLine("\n you have interest of      {0}", interest);

                double result = Principal + interest;
                double installment = result / input;

                Console.WriteLine("\n Total payable amount is      {0}", result);
                Console.WriteLine("\n yearly installmental Payment is      {0}: ", installment);
            }
            payment(input);
        }
        public void payment(double input)
        {
            Period1:
            Console.WriteLine("press 1 to initialize the payment or 2 to exit");
            try
            {
                int confirm = int.Parse(Console.ReadLine());

                if (confirm == 2 || confirm != 1)
                {
                    Console.WriteLine("logout successful");
                    Environment.Exit(0);
                }
                DayOfWeek day = DateTime.Today.DayOfWeek;
                DateTime today = DateTime.Now;
                DateTime newDate2 = today.AddDays(input);
                Console.WriteLine("\n\n Your Payment starts today:  {0} being  {1} \n\n \t\t  to be completed on {2} \n", today, day, newDate2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Period1;
            }

                      /*Console.WriteLine("press \"Y\" to continue or exit with any key");
                        string? input2 = Console.ReadLine();
                        if (input2.ToUpper() != "Y")
                        {
                            Console.Clear();
                            Console.WriteLine("Thanks for banking with us");
                            //session = false;


                        }*/
        }
    }
}