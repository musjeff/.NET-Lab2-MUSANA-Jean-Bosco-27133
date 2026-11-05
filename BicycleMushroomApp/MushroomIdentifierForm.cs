using System;
using System.Drawing;
using System.Windows.Forms;

namespace BicycleMushroomApp;

public partial class MushroomIdentifierForm : Form
{
    // A node is either a question (Yes/No branches) or a result (Result != null).
    private class Node
    {
        public string Question;
        public Node Yes, No;
        public string Result;
        public static Node Leaf(string name) => new Node { Result = name };
        public static Node Ask(string q, Node yes, Node no) => new Node { Question = q, Yes = yes, No = no };
    }

    /*
      Mushroom       Gills  Forest  Ring  Convex cup
      Agaric jaun.   yes    no      yes   yes
      Amanite t-m.   yes    yes     yes   yes
      Cepe bordeaux  no     yes     no    no
      Coprin chev.   yes    no      yes   no
      Girolle        yes    yes     no    no
      Pied bleu      yes    yes     no    yes

      Decision tree: at most 3 questions on any path.
    */
    private static readonly Node Tree =
        Node.Ask("Does your mushroom grow in a forest?",
            yes: Node.Ask("Does your mushroom have a convex cup?",
                    yes: Node.Ask("Does your mushroom have a ring?",
                            yes: Node.Leaf("Amanite tue-mouche"),
                            no: Node.Leaf("Pied bleu")),
                    no: Node.Ask("Does your mushroom have gills?",
                            yes: Node.Leaf("Girolle"),
                            no: Node.Leaf("Cepe de Bordeaux"))),
            no: Node.Ask("Does your mushroom have a convex cup?",
                    yes: Node.Leaf("Agaric jaunissant"),
                    no: Node.Leaf("Coprin chevelu")));

    private Node current = Tree;
    private int asked;

    public MushroomIdentifierForm()
    {
        InitializeComponent();
        Theme.Apply(this);
        lblQuestion.Font = new Font("Segoe UI", 11F);
        Restart();
    }

    private void Restart()
    {
        current = Tree;
        asked = 0;
        ShowNode(current);
    }

    private void Answer(bool yes)
    {
        asked++;
        current = yes ? current.Yes : current.No;
        ShowNode(current);
    }

    private void ShowNode(Node node)
    {
        if (node.Result != null)
        {
            lblQuestion.Text = $"Your mushroom is: {node.Result}";
            lblQuestion.ForeColor = Color.DarkGreen;
            lblCount.Text = $"Identified after {asked} question(s).";
            btnYes.Enabled = false;
            btnNo.Enabled = false;
        }
        else
        {
            lblQuestion.Text = node.Question;
            lblQuestion.ForeColor = SystemColors.ControlText;
            lblCount.Text = $"Question {asked + 1}";
            btnYes.Enabled = true;
            btnNo.Enabled = true;
        }
    }

    private void btnYes_Click(object sender, EventArgs e) => Answer(true);
    private void btnNo_Click(object sender, EventArgs e) => Answer(false);
    private void btnRestart_Click(object sender, EventArgs e) => Restart();

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();   // returns to Menu
    }
}
