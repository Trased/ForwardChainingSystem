using System.Collections.Generic;

namespace Solution
{
    public interface IPrinciple
    {
        string Name { get; }
        void AddPremise(string premise);
        void AddRule(string rule);
        List<string> Infer();
    }
}
