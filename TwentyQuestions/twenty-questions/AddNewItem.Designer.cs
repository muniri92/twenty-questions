namespace twenty_questions
{
    partial class AddNewItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.questionTB = new System.Windows.Forms.TextBox();
            this.answerTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Question";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // questionTB
            // 
            this.questionTB.Location = new System.Drawing.Point(180, 122);
            this.questionTB.Multiline = true;
            this.questionTB.Name = "questionTB";
            this.questionTB.Size = new System.Drawing.Size(392, 83);
            this.questionTB.TabIndex = 2;
            // 
            // answerTB
            // 
            this.answerTB.Location = new System.Drawing.Point(180, 312);
            this.answerTB.Multiline = true;
            this.answerTB.Name = "answerTB";
            this.answerTB.Size = new System.Drawing.Size(392, 82);
            this.answerTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Answer";
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answerTB);
            this.Controls.Add(this.questionTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AddNewItem";
            this.Text = "AddNewItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox questionTB;
        private System.Windows.Forms.TextBox answerTB;
        private System.Windows.Forms.Label label2;
    }
}