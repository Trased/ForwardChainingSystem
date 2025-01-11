using Solution.Principles.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            mKnowledgeBase.SetActivePrinciple(new GenericPrinciple());   
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forward Chaining System\nDeveloped for Artificial Intelligence 2024-2025", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void genericProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Generic Problem was set as the active principle", "Load Problem Set", MessageBoxButtons.OK, MessageBoxIcon.Information);

            rulesBox.Clear();
            rulesListBox.Items.Clear();
            premisesBox.Clear();
            premisesListBox.Items.Clear();
            conclusionsList.Items.Clear();
            ruleButton.Enabled = true;

            mKnowledgeBase.SetActivePrinciple(new GenericPrinciple());
        }
        private void pythagoreanTheoremToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pythagorean Theorem was set as the active principle!", "Load Problem Set", MessageBoxButtons.OK, MessageBoxIcon.Information);

            rulesBox.Clear();
            rulesListBox.Items.Clear();
            premisesBox.Clear();
            premisesListBox.Items.Clear();
            conclusionsList.Items.Clear();
            ruleButton.Enabled = false;

            mKnowledgeBase.SetActivePrinciple(new PythagoreanPrinciple());

            mKnowledgeBase.AddRule("A AND B THEN H * H = A * A + B * B");
            mKnowledgeBase.AddRule("A AND C THEN L * L = C * C - A * A");
            mKnowledgeBase.AddRule("B AND C THEN L * L = C * C - B * B");

            rulesListBox.Items.Add("A AND B THEN H * H = A * A + B * B");
            rulesListBox.Items.Add("A AND C THEN L * L = C * C - A * A");
            rulesListBox.Items.Add("B AND C THEN L * L = C * C - B * B");
            
        }

        private void inclusionExclusionPrincipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inclusion-Exclusion Principle was set as the active principle!", "Load Problem Set", MessageBoxButtons.OK, MessageBoxIcon.Information);

            rulesBox.Clear();
            rulesListBox.Items.Clear();
            premisesBox.Clear();
            premisesListBox.Items.Clear();
            conclusionsList.Items.Clear();
            ruleButton.Enabled = false;

            mKnowledgeBase.SetActivePrinciple(new InclusionExclusionPrinciple());

            mKnowledgeBase.AddRule("|A| AND |B| AND |A n B| THEN |A u B| = |A| + |B| - |A n B|");

            rulesListBox.Items.Add("|A| AND |B| AND |A n B| THEN |A u B| = |A| + |B| - |A n B|");
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
                try
                {
                    mKnowledgeBase.AddFact(premise);
                    premisesListBox.Items.Add(premise);
                    premisesBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding premise: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ruleButton_Click(object sender, EventArgs e)
        {
            string ruleText = rulesBox.Text.Trim();
            if (!string.IsNullOrEmpty(ruleText))
            {
                try
                {
                    mKnowledgeBase.AddRule(ruleText);
                    rulesListBox.Items.Add(ruleText);
                    rulesBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding rule: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void inferButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> newFacts = mKnowledgeBase.Infer();
                conclusionsList.Items.Clear();
                foreach (var fact in newFacts)
                {
                    conclusionsList.Items.Add(fact);
                }

                if (newFacts.Count == 0)
                {
                    MessageBox.Show("No new conclusions could be inferred.", "Inference Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during inference: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
