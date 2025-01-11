using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string EvaluateConclusion(Dictionary<string, double> numericalFacts, IPrinciple activePrinciple)
        {
            string processedConclusion = Conclusion;

            if(activePrinciple.Name == "Pythagorean") 
            {
                string[] equationParts = Conclusion.Split('=');
                if (equationParts.Length != 2)
                    throw new Exception("Invalid conclusion format.");

                string leftHandSide = equationParts[0].Trim();
                string rightHandSide = equationParts[1].Trim();

                bool isAddition = rightHandSide.Contains("+");
                bool isSubtraction = rightHandSide.Contains("-");
                if (!isAddition && !isSubtraction)
                    throw new Exception("The equation must contain either '+' or '-' for Pythagorean-like calculations.");

                string unknownVariable = leftHandSide.Split('*')[0].Trim();

                string[] terms = rightHandSide.Split(new[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
                if (terms.Length != 2)
                    throw new Exception("The equation must involve two terms for Pythagorean-like calculations.");

                string term1 = terms[0].Split('*')[0].Trim();
                string term2 = terms[1].Split('*')[0].Trim();

                if (!numericalFacts.ContainsKey(term1) || !numericalFacts.ContainsKey(term2))
                    throw new Exception("Missing required numerical facts for calculation.");

                double value1 = numericalFacts[term1];
                double value2 = numericalFacts[term2];

                double result;
                if (isAddition)
                {
                    result = Math.Sqrt(value1 * value1 + value2 * value2);
                }
                else
                {
                    if (value1 * value1 - value2 * value2 < 0)
                        throw new Exception("Invalid values: cannot calculate square root of a negative number.");
                    result = Math.Sqrt(value1 * value1 - value2 * value2);
                }
                return $"{result:F2}";
            }
            else if(activePrinciple.Name == "Inclusion-Exclusion")
            {
                foreach (var fact in numericalFacts)
                {
                    processedConclusion = processedConclusion.Replace($"|{fact.Key}|", fact.Value.ToString());
                }
                using (var table = new System.Data.DataTable())
                {
                    return table.Compute(processedConclusion.Split('=')[1], "").ToString();
                }
            }
            // Generic principle
            else
            {
                try
                {
                    foreach (var fact in numericalFacts)
                    {
                        processedConclusion = processedConclusion.Replace(fact.Key, fact.Value.ToString());
                    }

                    // Evaluate the processed conclusion using DataTable
                    using (var table = new System.Data.DataTable())
                    {
                        string result = table.Compute(processedConclusion.Split('=')[1], "").ToString();
                        return $"{processedConclusion.Split('=')[0].Trim()} = {result}";
                    }
                }
                catch (Exception ex)
                {
                    return $"Error evaluating generic principle: {ex.Message}";
                }
            }
        }
    }

}
