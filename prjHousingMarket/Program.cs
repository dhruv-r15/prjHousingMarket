namespace prjHousingMarket
{
    internal class Program
    {
        private static List<Agent> agentList = new List<Agent>();
        static void Main(string[] args)
        {

            

            agentList.Add(new Agent(1, "Bob", "Smith", false, "Black"));
            
            agentList.Add(new Agent(2, "Sand", "Bra", true, "Not from here"));

            agentList.Add(new Agent(3, "Jane", "Bra", false, "Maybe from here"));

            bool bStop = false;

            while (bStop != true)
            {
                Menu();
                Console.WriteLine("Are you finished? Press S to stop");
                String strInput = Console.ReadLine();
                if(strInput.Equals("S"))
                {
                    bStop = true;
                }
            }

            
         
        }

        private static void Menu()
        {
            Console.WriteLine("Welcome to Dhruv's Agents ");
            Console.WriteLine("**************************");
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("Enter 1 to view all agents (1) ");
            Console.WriteLine("Enter 2 to add new agents (2) ");

            String userInput = Console.ReadLine();

            if (userInput == "")
            {
                Console.WriteLine("Can you not type?");
            }
            else if (userInput.Equals("1"))
            {
                PrintAgents();
            }
            else if (userInput.Equals("2"))
            {
                AddAgents();

            }
        }

        private static void PrintAgents()
        {
            foreach (Agent agent in agentList)
            {
                Console.WriteLine(agent.ToString());
            }
        }

        private static void AddAgents()
        {
            Console.WriteLine("Please enter agent number: ");
            String agentNo = Console.ReadLine();
            Console.WriteLine("Please enter agent name: ");
            String agentName = Console.ReadLine();
            Console.WriteLine("Please enter agent surname: ");
            String agentSurname = Console.ReadLine();
            Console.WriteLine("Do they have their license? Yes or No: ");
            String agentLicense = Console.ReadLine();
            Console.WriteLine("Please enter your race: ");
            String agentRace = Console.ReadLine();

            bool license = false;

            if (agentLicense.ToUpper().Equals("YES"))
            {
                license = true;
            }
            agentList.Add(new Agent(Convert.ToInt32(agentNo), agentName, agentSurname, license, agentRace));

            
        }
    }
}
