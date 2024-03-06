namespace prjHousingMarket
{
    internal class Program
    {

        //public static List<Agent> agentList = new List<Agent>();

        static void Main(string[] args)
        {

            

            //agentList.Add(new Agent(1, "Bob", "Smith", false, "Black"));
            
            //agentList.Add(new Agent(2, "Sand", "Bra", true, "Not from here"));

            //agentList.Add(new Agent(3, "Jane", "Bra", false, "Maybe from here"));

            bool bStop = false;
            
            
            

            while (bStop != true)
            {
                
                AgentDB.Menu();
                Console.WriteLine("Are you finished? Press S to stop or any other key to continue ");
                String strInput = Console.ReadLine();
                if(strInput.Equals("S"))
                {
                    bStop = true;
                }
            }

            AgentDB.PrintAgents();
            AgentDB.AddAgents();   


            
         
        }

    }
}
