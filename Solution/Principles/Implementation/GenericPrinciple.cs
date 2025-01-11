using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Principles.Implementation
{
    public class GenericPrinciple : IPrinciple
    {
        private HashSet<string> logicalFacts;
        private Dictionary<string, double> numericalFacts;
        private List<Rule> rules;

        public string Name => "Generic";

        public GenericPrinciple()
        {
            logicalFacts = new HashSet<string>();
            numericalFacts = new Dictionary<string, double>();
            rules = new List<Rule>();
        }

        public void AddPremise(string premise)
        {
            if (premise.Contains("="))
            {
                var parts = premise.Split('=');
                if (parts.Length == 2)
                {
                    string key = parts[0].Replace("|", "").Trim();
                    if (double.TryParse(parts[1].Trim(), out double value))
                    {
                        numericalFacts[key] = value;
                    }
                }
            }
            else
            {
                logicalFacts.Add(premise.Trim());
            }
        }

        public void AddRule(string ruleText)
        {
            var parts = ruleText.Split(new[] { "THEN" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2)
            {
                List<string> premises = parts[0].Split(new[] { "AND" }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToList();
                string conclusion = parts[1].Trim();
                rules.Add(new Rule(premises, conclusion));
            }
        }

        public List<string> Infer()
        {
            var results = new List<string>();

            foreach (var rule in rules)
            {
                bool isLogical = rule.Premises.All(p => logicalFacts.Contains(p));
                bool isNumerical = rule.Premises.All(p => numericalFacts.ContainsKey(p.Replace("|", "").Trim()));

                if (isLogical || isNumerical)
                {
                    if (rule.Conclusion.Contains("="))
                    {
                        string result = rule.EvaluateConclusion(numericalFacts, this);
                        results.Add($"{rule.Conclusion.Split('=')[0].Trim()} = {result}");
                    }
                    else
                    {
                        if (!logicalFacts.Contains(rule.Conclusion))
                        {
                            logicalFacts.Add(rule.Conclusion);
                            results.Add(rule.Conclusion);
                        }
                    }
                }
            }

            return results;
        }
    }

}
