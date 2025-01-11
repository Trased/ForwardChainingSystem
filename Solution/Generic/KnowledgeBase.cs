using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution
{
    public class KnowledgeBase
    {
        private IPrinciple ActivePrinciple;

        public void SetActivePrinciple(IPrinciple principle)
        {
            ActivePrinciple = principle;
        }

        public IPrinciple GetActivePrinciple()
        { 
            return ActivePrinciple;
        }

        public void AddFact(string premise)
        {
            if (ActivePrinciple == null)
            {
                throw new InvalidOperationException("No active principle selected.");
            }
            ActivePrinciple.AddPremise(premise);
        }

        public void AddRule(string rule)
        {
            if (ActivePrinciple == null)
            {
                throw new InvalidOperationException("No active principle selected.");
            }
            ActivePrinciple.AddRule(rule);
        }

        public List<string> Infer()
        {
            if (ActivePrinciple == null)
            {
                throw new InvalidOperationException("No active principle selected.");
            }
            return ActivePrinciple.Infer();
        }
    }
}
