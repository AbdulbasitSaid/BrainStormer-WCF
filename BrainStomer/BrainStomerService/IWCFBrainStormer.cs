using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//using BrainStormerWeb.Models;
//using BrainStormerWeb.Controllers;
//using BrainStormerWeb;

namespace BrainStomerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFBrainStormer" in both code and config file together.
    [ServiceContract]
    public interface IWCFBrainStormer
    {
        [OperationContract]
        List<string> ListQuestions();
       
        [OperationContract]
        ClassQuestions getQuestion(string qid);
        [OperationContract]
        List<string> getOptions(string qids);
        [OperationContract]
        Dictionary<string,string>loginDb();     
    }
}
