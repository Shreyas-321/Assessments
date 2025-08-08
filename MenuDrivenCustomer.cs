namespace Assessment
{

    class Customer
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public double BillAmount { get; set; }
    }
    class Customerrepo
    {
        // static List<Customer> cus = new List<Customer>();

        public static void addcustomer(Customer customer)
        {
            //cus.Add(customer);
            //Console.WriteLine($"The customer {customer.CustomerName} is Added");

            var filePath = "Customer.csv";
            var content = $"{customer.CustomerId}, {customer.CustomerName}, {customer.BillAmount}\n";
            File.AppendAllText(filePath, content);

        }

        public static void deletecustomer(int id)
        {
            var filePath = "Customer.csv";


            var allLines = File.ReadAllLines(filePath).ToList();


            var lineToRemove = allLines.FirstOrDefault(line => line.StartsWith($"{id},"));

            if (lineToRemove != null)
            {

                allLines.Remove(lineToRemove);


                File.WriteAllLines(filePath, allLines);
                Console.WriteLine($"Customer with ID {id} has been deleted.");
            }
            else
            {
                Console.WriteLine($"Customer with ID {id} not found.");
            }
        }

        public static void updatecustomer(Customer customer)
        {
            var filePath = "Customer.csv";

            // Read all lines into memory
            var allLines = File.ReadAllLines(filePath).ToList();

            // Find the line that matches the CustomerId
            for (int i = 0; i < allLines.Count; i++)
            {
                if (allLines[i].StartsWith($"{customer.CustomerId},"))
                {
                    // Replace the line with updated customer info
                    allLines[i] = $"{customer.CustomerId}, {customer.CustomerName}, {customer.BillAmount}";
                    File.WriteAllLines(filePath, allLines);
                    Console.WriteLine($"Customer with ID {customer.CustomerId} has been updated.");
                    return;
                }
            }

            // If no match was found
            Console.WriteLine($"Customer with ID {customer.CustomerId} not found.");
        }

        public static void searchcustomer(int id)
        {
            var filePath = "Customer.csv";
            // Read all lines from the CSV file

            var allLines = File.ReadAllLines(filePath);

            // Search for a line starting with the given ID
            var matchedLine = allLines.FirstOrDefault(line => line.StartsWith($"{id},"));

            if (matchedLine != null)
            {
                var parts = matchedLine.Split(',');
                Console.WriteLine("\nCustomer Found:");
                Console.WriteLine($"ID: {parts[0].Trim()}");
                Console.WriteLine($"Name: {parts[1].Trim()}");
                Console.WriteLine($"Bill Amount: {parts[2].Trim()}");
            }
            else
            {
                Console.WriteLine($"Customer with ID {id} not found.");
            }
        }
    }

    internal class MenuDrivenCustomer
    {

        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~CUSTOMER MANAGEMENT SYSTEM~~~~~~~~~~~~~~~~~");
            bool choice = false;
            do
            {

                int select = ConsoleUtil.GetInputInt("TO ADD CUSTOMER PRESS 1\nTO REMOVE CUSTOMER PREE 2\nTO UPDATE CUSTOMER PRESS 3\nTO SEARCH CUSTOMER PRESS 4\nTO DISPLAY ALL CUSTOMERS PRESS 5\nNOTE: TO EXIT PRESS ANY OTHER KEY");
                choice = Process(select);
            } while (choice);
        }




        public static bool Process(int select)
        {
            switch (select)
            {
                case 1: AddCustomer(); return true;
                case 2: RemoveCustomer(); return true;
                case 3: UpdateCustomer(); return true;
                case 4: SearchCustomer(); return true;
                case 5: DisplayAllCustomer(); return true;
                default:
                    return false;

            }
        }

        private static void DisplayAllCustomer()
        {

            var filePath = "Customer.csv";
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var values = line.Split(',');
                int customerid = int.Parse(values[0]);
                string customername = values[1];
                double billamount = double.Parse(values[2]);
                Console.WriteLine($"CustomerId={customerid}, CustomerName={customername}, CustomerBillAmount={billamount}");
            }
        }
        private static void SearchCustomer()
        {

            int id = ConsoleUtil.GetInputInt("Enter the customer ID to find: ");
            Customerrepo.searchcustomer(id);


        }


        private static void UpdateCustomer()
        {
            Customer customer = new Customer();
            customer.CustomerId = ConsoleUtil.GetInputInt("Enter the customer Id for updation: ");
            customer.CustomerName = ConsoleUtil.GetInputString("Enter the customer name: ");
            customer.BillAmount = ConsoleUtil.GetInputDouble("Enter the Bill Amount: ");
            Customerrepo.updatecustomer(customer);
        }

        private static void RemoveCustomer()
        {
            int id = ConsoleUtil.GetInputInt("Enter the customer ID to delete Customer details: ");
            Customerrepo.deletecustomer(id);
        }

        private static void AddCustomer()
        {
            Customer customer = new Customer();
            customer.CustomerId = ConsoleUtil.GetInputInt("Enter the customer Id: ");
            customer.CustomerName = ConsoleUtil.GetInputString("Enter the customer name: ");
            customer.BillAmount = ConsoleUtil.GetInputDouble("Enter the customer BillAmount: ");
            Customerrepo.addcustomer(customer);
        }
        class ConsoleUtil
        {
            public static int GetInputInt(string question)
            {
                // Console.WriteLine(question);
                return int.Parse(GetInputString(question));
            }
            public static double GetInputDouble(string question)
            {
                //Console.WriteLine(question);
                return double.Parse(GetInputString(question));
            }
            public static string GetInputString(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }
        }
    }
}
