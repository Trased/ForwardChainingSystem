using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Rule
    {
        public List<string> Premises { get; set; }
        public string Conclusion { get; set; }

        public Rule(List<string> premises, string conclusion)
        {
            Premises = premises;
            Conclusion = conclusion;
        }

        public bool IsSatisfied(HashSet<string> knownFacts)
        {
            return Premises.TrueForAll(knownFacts.Contains);
        }

        public string EvaluateConclusion(Dictionary<string, int> numericalFacts)
        {
            string processedConclusion = Conclusion;

            foreach (var fact in numericalFacts)
            {
                processedConclusion = processedConclusion.Replace($"|{fact.Key}|", fact.Value.ToString());
            }

            using (var table = new System.Data.DataTable())
            {
                return table.Compute(processedConclusion.Split('=')[1], "").ToString();
            }
        }
    }

}
