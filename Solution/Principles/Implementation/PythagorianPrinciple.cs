using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Solution
{
    public class PythagoreanPrinciple : IPrinciple
    {
        private Dictionary<string, double> numericalFacts;
        private List<Rule> rules;

        public string Name => "Pythagorean";

        public PythagoreanPrinciple()
        {
            numericalFacts = new Dictionary<string, double>();
            rules = new List<Rule>();
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
                rules.Add(new Rule(premises.ConvertAll(p => p.Trim()), conclusion));
            }
        }

        public List<string> Infer()
        {
            var results = new List<string>();

            foreach (var rule in rules)
            {
                if (rule.IsSatisfied(numericalFacts.Keys.ToHashSet()))
                {
                    string result = rule.EvaluateConclusion(numericalFacts, this);
                    results.Add($"{rule.Conclusion.Split('*')[0].Trim()} = {result}");
                }
            }

            return results;
        }
    }
}
