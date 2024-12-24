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
            return Premises.All(premise => knownFacts.Contains(premise));
        }
    }
}
