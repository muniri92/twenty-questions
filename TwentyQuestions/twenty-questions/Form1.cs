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
            root.yes.question = "Is it black coffe?";
            root.no = new Question();
            root.no.question = "Is it 2% milk";

            current = root;
            questionLabel.Text = current.question;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            // am I at a leaf?
            // yes: I rock!
            //      Do you want to play again?
            // no: ask the next question

            if (MessageBox.Show("Do you want to play again?", "Twenty Questions",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();
            }

        }

        private void noButton_Click(object sender, EventArgs e)
        {
            // am I at a leaf?
            // no: ask the next question
            // yes: Oh, then it's new. Go learn stuff.
            //      Do you want to play again?

            AddNewItem add = new AddNewItem();
            if (add.ShowDialog() == DialogResult.OK)
            {

            }

        }
    }
}
