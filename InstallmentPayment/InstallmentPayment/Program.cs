namespace InstallmentPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amount you are owing");
            int Principal = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your period of payment");


            bool session = true;
            while (session)
            {
                Console.WriteLine("select 1: for daily, 2: for weekly, 3: for bi-weekly, 4: for monthly, 5: for half-year, 6: for Yearly");
                Console.WriteLine("select either 1, 2, 4, or 6 for now");
                Plan plan = new Plan();
                int ActivityOption = int.Parse(Console.ReadLine());
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
                        Console.WriteLine("invalid");
                        break;

                }
                Console.WriteLine("press \"Y\" to continue");
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

        /*        public double Principal { get; set; }
                public string Name { get; set; }
                public DateTime Period { get; set; }
                public double rate { get; }
                public double Interest { get; }
                public decimal Instalment { get; }
                public decimal Total { get; }*/

        public Plan()
        {
            //double principal, string name, DateTime period

            /*Principal = principal;
            Name = name;
            Period = period;*/
        }

        public void Daily(int Principal)
        {
            Console.WriteLine("how many days will it take you to complete your payment");
            double input = int.Parse(Console.ReadLine());//use generics to take effect on date 

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
                Console.WriteLine("Daily installmental Payment is {0}: ", installment);
            }
            Console.WriteLine("enter yes to initialize the payment or no to quit");
            string confirm = Console.ReadLine();
            DayOfWeek day = DateTime.Today.DayOfWeek;
            DateTime today = DateTime.Now;
            DateTime newDate2 = today.AddDays(input);
            Console.WriteLine("Your Payment starts today  {0} being {1} to end on{2} ", today, day, newDate2);//

        }
        public void Weekly(int Principal)
        {
            Console.WriteLine("how many week will it take you to complete your payment");
            double input = int.Parse(Console.ReadLine());
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

        }
        public void BiWeekly(int Principal)
        {
            Console.WriteLine("How much can you pay BiWeekly");
            int input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                double result = Principal / (input);


                Console.WriteLine("it will take you {0} weeks to complete your payment", result);
            }
        }
        public void Monthly(int Principal)
        {

            Console.WriteLine("how many Months will it take you to complete your payment");
            double input = int.Parse(Console.ReadLine());
          
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

        }
        public void HalfYear(int Principal)
        {
            Console.WriteLine("How much can you pay BiWeekly");
            int input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                double result = Principal / (input);

                Console.WriteLine("it will take you {0} weeks to complete your payment", result);
            }
        }
        public void Annualy(int Principal)
        {
            Console.WriteLine("how many years will it take you to complete your payment");
            double input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                double rate = 0.05;


                double interest = (Principal * rate * input);
                Console.WriteLine("you have interest of {0}", interest);

                double result = Principal + interest;
                double installment = result / input;

                Console.WriteLine("Total payable amount is {0}", result);
                Console.WriteLine("yearly installmental Payment is {0}: ", installment);
            }
        }
    }
}