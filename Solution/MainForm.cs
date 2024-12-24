using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution
{
    public partial class MainForm : Form
    {
        private KnowledgeBase mKnowledgeBase;
        public MainForm()
        {
            InitializeComponent();
            mKnowledgeBase = new KnowledgeBase();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forward Chaining System\nDeveloped for Artificial Intelligence 2024-2025", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadProblemSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature to load predefined problem sets will be implemented here.", "Load Problem Set", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TO DO
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void premisesButton_Click(object sender, EventArgs e)
        {
            string premise = premisesBox.Text.Trim();
            if (!string.IsNullOrEmpty(premise))
            {
                mKnowledgeBase.AddFact(premise);
                premisesListBox.Items.Add(premise);
                premisesBox.Clear();
            }

            // TO DO: Add extended support for numbers, to be able to demonstrate Pythagorean Theorem.
            //      Need to ensure that this won't affect other implementations.
            //      Or if it will, we need to add an extra button on the UI to be able to specify the theorem we want to prove.
        }

        private void ruleButton_Click(object sender, EventArgs e)
        {
            string ruleText = rulesBox.Text.Trim();
            if (!string.IsNullOrEmpty(ruleText))
            {
                string[] parts = ruleText.Split(new[] { "THEN" }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    List<string> premises = new List<string>(parts[0].Split(new[] { "AND" }, StringSplitOptions.RemoveEmptyEntries));
                    string conclusion = parts[1].Trim();
                    Rule rule = new Rule(premises.ConvertAll(p => p.Trim()), conclusion);
                    mKnowledgeBase.AddRule(rule);
                    rulesListBox.Items.Add(ruleText);
                    rulesBox.Clear();
                }
            }

            // TO DO: Add extended support for numbers, to be able to demonstrate Pythagorean Theorem.
            //      Need to ensure that this won't affect other implementations.
            //      Or if it will, we need to add an extra button on the UI to be able to specify the theorem we want to prove.
        }

        private void inferButton_Click(object sender, EventArgs e)
        {
            List<string> newFacts = mKnowledgeBase.PerformInference();
            conclusionsList.Items.Clear();
            foreach (var fact in newFacts)
            {
                conclusionsList.Items.Add(fact);
                MessageBox.Show(fact);
            }

            // TO DO: Add extended support for numbers, to be able to demonstrate Pythagorean Theorem.
            //      Need to ensure that this won't affect other implementations.
            //      Or if it will, we need to add an extra button on the UI to be able to specify the theorem we want to prove.
        }
    }
}
