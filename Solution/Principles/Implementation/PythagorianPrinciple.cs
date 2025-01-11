using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public class PythagoreanPrinciple : IPrinciple
    {
        private Dictionary<string, double> numericalFacts;
        private List<PythagoreanRule> rules;

        public string Name => "Pythagorean Theorem Principle";

        public PythagoreanPrinciple()
        {
            numericalFacts = new Dictionary<string, double>();
            rules = new List<PythagoreanRule>();
        }

        public void AddPremise(string premise)
        {
            var parts = premise.Split('=');
            if (parts.Length == 2)
            {
                string key = parts[0].Trim();
                if (double.TryParse(parts[1].Trim(), out double value))
                {
                    numericalFacts[key] = value;
                }
            }
        }

        public void AddRule(string ruleText)
        {
            var parts = ruleText.Split(new[] { "THEN" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2)
            {
                List<string> premises = new List<string>(parts[0].Split(new[] { "AND" }, StringSplitOptions.RemoveEmptyEntries));
                string conclusion = parts[1].Trim();
                rules.Add(new PythagoreanRule(premises.ConvertAll(p => p.Trim()), conclusion));
            }
        }

        public List<string> Infer()
        {
            var results = new List<string>();

            foreach (var rule in rules)
            {
                if (rule.IsSatisfied(numericalFacts.Keys.ToHashSet()))
                {
                    string result = rule.EvaluateConclusion(numericalFacts);
                    results.Add($"{rule.Conclusion.Split('*')[0].Trim()} = {result}");
                }
            }

            return results;
        }
    }

    public class PythagoreanRule
    {
        public List<string> Premises { get; }
        public string Conclusion { get; }

        public PythagoreanRule(List<string> premises, string conclusion)
        {
            Premises = premises;
            Conclusion = conclusion;
        }

        public bool IsSatisfied(HashSet<string> knownFacts)
        {
            return Premises.All(p => knownFacts.Contains(p));
        }

        public string EvaluateConclusion(Dictionary<string, double> facts)
        {
            try
            {
                if (Conclusion.Contains("c") && Premises.Contains("a") && Premises.Contains("b"))
                {
                    double a = facts["a"];
                    double b = facts["b"];
                    double c = Math.Sqrt(a * a + b * b); 
                    return c.ToString("F2");  
                }
               
                else if (Conclusion.Contains("a") && Premises.Contains("b") && Premises.Contains("c"))
                {
                    double b = facts["b"];
                    double c = facts["c"];
                    if (c * c - b * b < 0) throw new ArgumentException("Invalid values for 'c' and 'b'");
                    double a = Math.Sqrt(c * c - b * b); 
                    return a.ToString("F2"); 
                }
               
                else if (Conclusion.Contains("b") && Premises.Contains("a") && Premises.Contains("c"))
                {
                    double a = facts["a"];
                    double c = facts["c"];
                    if (c * c - a * a < 0) throw new ArgumentException("Invalid values for 'c' and 'a'");
                    double b = Math.Sqrt(c * c - a * a);  
                    return b.ToString("F2"); 
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }

            return "Cannot Evaluate";
        }
    }
}
