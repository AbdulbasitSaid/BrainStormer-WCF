using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainStormerClient.ServiceReference2;
namespace BrainStormerClient
{
    class Program
    {
        ServiceReference2.WCFBrainStormerClient proxy = new ServiceReference2.WCFBrainStormerClient();
        void test()
        {
            Random rand = new Random();
            proxy.ListQuestionsAsync();
            List<string> IDs = proxy.ListQuestions();
            Console.WriteLine("Hit any key");
            Console.ReadKey();
            foreach(var id in IDs)
            {
              //var b = proxy.ListQuestions();
              // var a= proxy.randomizeQuestions();
                Console.WriteLine(id);
              //  Console.WriteLine(a.Answer);
                Console.WriteLine("---------------");
            }
            int index = rand.Next(IDs.Count);
            string value = IDs.ElementAt(index);
            var dis = proxy.getQuestion(value);
            List<string> disp = proxy.getOptions(value);
                Console.WriteLine(dis.Question + "the Options ");
            foreach(var d in disp)
            {
                Console.WriteLine(d);
            }
                IDs.RemoveAt(index);
            //for(int i = 0;i<IDs.Count;i++)
            //{
            //   var dis = proxy.getQuestion(value);
            //    Console.WriteLine(dis.Question + "the answer is "+ dis.Answer);
            //    IDs.RemoveAt(index);
            //}
            Console.ReadKey();
          //  this.test();
        }
      //  void display(int i) { Console.WriteLine(dis.Question + "the answer is " + dis.Answer); }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.test();
        }
    }
}
