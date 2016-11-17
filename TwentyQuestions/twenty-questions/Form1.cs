using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twenty_questions
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        Question root;
        Question current;

        private void Form1_Load(object sender, EventArgs e)
        {
            root = new Question();
            root.question = "Is it hot?";
            root.yes = new Question();
            root.yes.question = "Is it black coffee?";
            root.no = new Question();
            root.no.question = "Is it 2% milk";

            root.no.parent = root;
            root.yes.parent = root;

            current = root;
            questionLabel.Text = current.question;
            
        }

        private void yesButton_Click(object sender, EventArgs e)
        {

            // am I at a leaf?
            // yes: I rock!
            //      Do you want to play again?
            // no: ask the next question

            if (current.isLeaf())
            {
                if (MessageBox.Show("DOPE. Do you want to play again?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    current = root;
                    questionLabel.Text = current.question;
                }
                else
                {
                    AddNewItem addNew = new AddNewItem();
                    addNew.ShowDialog();
                }     
            }
            else
            {
                current = current.yes;
                questionLabel.Text = current.question;
            }
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            // am I at a leaf?
            // no: ask the next question
            // yes: Oh, then it's new. Go learn stuff.
            //      Do you want to play again?

            if (current.isLeaf())
            {
                AddNewItem add = new AddNewItem();
                if (add.ShowDialog() == DialogResult.OK)
                {
                    
                }
                current = root;
                questionLabel.Text = current.question;
            }
            else
            {
                current = current.no;
                questionLabel.Text = current.question;
            }
        }

        public void addQuestion(string newQ, string newA)
        {

            // Moving the Question not the Node
            /*
            string oldQ = current.question;
            current.question = newQ;
            current.no = new Question();
            current.no.question = oldQ;
            current.yes = new Question();
            current.yes.question = newA;
            questionLabel.Text = current.question;

            */

            // Moving the Node not the Question

            Question newNode = new Question();
            newNode.question = newQ;
            newNode.yes.question = newA;

            Question temp = current;

            newNode.parent = current.no.parent;
            current.parent.no = newNode;

            newNode.no = current;
            newNode.yes.question = newA;
             

            newNode.



            
        } 
        
        // NEEDS TO BE REMOVED
        private void questionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
