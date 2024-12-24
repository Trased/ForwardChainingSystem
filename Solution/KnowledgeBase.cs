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
        public HashSet<string> mFacts { get; private set; }
        public List<Rule> mRules { get; private set; }

        public KnowledgeBase()
        {
            mFacts = new HashSet<string>();
            mRules = new List<Rule>();
        }

        public void AddFact(string fact)
        {
            mFacts.Add(fact);
        }

        public void AddRule(Rule rule)
        {
            mRules.Add(rule);
        }

        public List<string> PerformInference()
        {
            List<string> newFacts = new List<string>();
            bool updated;

            do
            {
                updated = false;
                foreach (var rule in mRules)
                {
                    if (rule.IsSatisfied(mFacts) && !mFacts.Contains(rule.Conclusion))
                    {
                        mFacts.Add(rule.Conclusion);
                        newFacts.Add(rule.Conclusion);
                        updated = true;
                    }
                }
            } while (updated);

            return newFacts;
        }
    }
}
