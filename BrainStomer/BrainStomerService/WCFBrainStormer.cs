using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//using BrainStormerWeb.Models;
//using BrainStormerWeb.Controllers;
//using BrainStormerWeb.Models;

namespace BrainStomerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFBrainStormer" in both code and config file together.
    public class WCFBrainStormer : IWCFBrainStormer
    {
        Random rand = new Random();
       public List<string> qID = new List<string>();       
        public ClassQuestions getQuestion(string qid)
        {
            ClassQuestions questions = null;
            using(BrainStormerEntities4 dataset = new BrainStormerEntities4())
            {
                var matchinqQuestions = dataset.Questions.First((p)=>p.QID==qid);
                questions = new ClassQuestions();
                questions.Question = matchinqQuestions.Question1;
                questions.Answer = matchinqQuestions.Answer;
                questions.Option1 = matchinqQuestions.Option1;
                questions.Option2 = matchinqQuestions.Option2;
                questions.Option3 = matchinqQuestions.Option3;
            }
           // qID.RemoveAt(index);
           
            return questions;
        }

        public List<string> ListQuestions()
        {
            using (BrainStormerEntities4 database = new BrainStormerEntities4())
            {
                foreach (var q in database.Questions)
                {
                    qID.Add(q.QID);
                }
            }
            return qID;
        }
        List<string> options = new List<string>();
        string temP = "";
        public List<string> getOptions(string qid)
        {
            ClassQuestions cQ = new ClassQuestions();
            using (BrainStormerEntities4 db = new BrainStormerEntities4())
            {
                var q = db.Questions.First(p => p.QID == qid);
                cQ.Answer = q.Answer;
                cQ.Option1 = q.Option1;
                cQ.Option2 = q.Option2;
                cQ.Option3 = q.Option3;
            }
            List<string> temp = new List<string>();
            temp.Add(cQ.Answer);
            temp.Add(cQ.Option1);
            temp.Add(cQ.Option2);
            temp.Add(cQ.Option3);
            Random r = new Random();
            
            for (int i = 0; i<4;i++)
            {
                int index = r.Next(temp.Count);
                //if (temp.Count>-1)
                {
                    temP = temp.ElementAt(index) ;
                    options.Add(temP);
                   temp.RemoveAt(index);
                }
               
            }
                return options;
        }

        public Dictionary<string, string> loginDb()
        {
            Dictionary<string, string> logindb = new Dictionary<string, string>();

            using (BrainStormerEntities4 br = new BrainStormerEntities4())
            {
                foreach (var i in br.playerLogins)
                {
                    logindb.Add(i.Email, i.PassWord);
                }
            }
            return logindb;
        }
       // public string Success;
   

        //int index;
    }
}
