using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BrainStomerService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCFBrainStormer)))
            {
                host.Open();
                Console.WriteLine("Host is Active");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
