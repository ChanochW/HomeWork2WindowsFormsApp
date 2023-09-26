namespace HomeWork1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            naturalBorn = new CheckBox();
            ageInput = new NumericUpDown();
            lengthOfResidencyInput = new NumericUpDown();
            prevTermsInput = new NumericUpDown();
            treasonous = new CheckBox();
            age = new Label();
            lengthOfResidence = new Label();
            numOfPrevTerms = new Label();
            calculate = new Button();
            result = new Label();
            ((System.ComponentModel.ISupportInitialize)ageInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lengthOfResidencyInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prevTermsInput).BeginInit();
            SuspendLayout();
            // 
            // naturalBorn
            // 
            naturalBorn.AutoSize = true;
            naturalBorn.Location = new Point(21, 19);
            naturalBorn.Name = "naturalBorn";
            naturalBorn.Size = new Size(458, 45);
            naturalBorn.TabIndex = 0;
            naturalBorn.Text = "Are you a natural born citizen?";
            naturalBorn.UseVisualStyleBackColor = true;
            // 
            // ageInput
            // 
            ageInput.Location = new Point(851, 87);
            ageInput.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            ageInput.Name = "ageInput";
            ageInput.Size = new Size(300, 47);
            ageInput.TabIndex = 1;
            // 
            // lengthOfResidencyInput
            // 
            lengthOfResidencyInput.Location = new Point(851, 155);
            lengthOfResidencyInput.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            lengthOfResidencyInput.Name = "lengthOfResidencyInput";
            lengthOfResidencyInput.Size = new Size(300, 47);
            lengthOfResidencyInput.TabIndex = 2;
            // 
            // prevTermsInput
            // 
            prevTermsInput.Location = new Point(851, 222);
            prevTermsInput.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            prevTermsInput.Name = "prevTermsInput";
            prevTermsInput.Size = new Size(300, 47);
            prevTermsInput.TabIndex = 3;
            // 
            // treasonous
            // 
            treasonous.AutoSize = true;
            treasonous.Location = new Point(21, 309);
            treasonous.Name = "treasonous";
            treasonous.Size = new Size(508, 45);
            treasonous.TabIndex = 4;
            treasonous.Text = "Have you rebelled against the US?";
            treasonous.UseVisualStyleBackColor = true;
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(28, 93);
            age.Name = "age";
            age.Size = new Size(250, 41);
            age.TabIndex = 5;
            age.Text = "How old are you?";
            // 
            // lengthOfResidence
            // 
            lengthOfResidence.AutoSize = true;
            lengthOfResidence.Location = new Point(28, 155);
            lengthOfResidence.Name = "lengthOfResidence";
            lengthOfResidence.Size = new Size(522, 41);
            lengthOfResidence.TabIndex = 6;
            lengthOfResidence.Text = "How long have you resided in the US?";
            // 
            // numOfPrevTerms
            // 
            numOfPrevTerms.AutoSize = true;
            numOfPrevTerms.Location = new Point(28, 222);
            numOfPrevTerms.Name = "numOfPrevTerms";
            numOfPrevTerms.Size = new Size(756, 41);
            numOfPrevTerms.TabIndex = 7;
            numOfPrevTerms.Text = "How many previous terms have you served as president";
            // 
            // calculate
            // 
            calculate.Location = new Point(145, 374);
            calculate.Name = "calculate";
            calculate.Size = new Size(361, 88);
            calculate.TabIndex = 8;
            calculate.Text = "Determine Eligibility";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += handleClick;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(794, 398);
            result.Name = "result";
            result.Size = new Size(97, 41);
            result.TabIndex = 9;
            result.Text = "label1";
            result.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 489);
            Controls.Add(result);
            Controls.Add(calculate);
            Controls.Add(numOfPrevTerms);
            Controls.Add(lengthOfResidence);
            Controls.Add(age);
            Controls.Add(treasonous);
            Controls.Add(prevTermsInput);
            Controls.Add(lengthOfResidencyInput);
            Controls.Add(ageInput);
            Controls.Add(naturalBorn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ageInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)lengthOfResidencyInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)prevTermsInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox naturalBorn;
        private NumericUpDown ageInput;
        private NumericUpDown lengthOfResidencyInput;
        private NumericUpDown prevTermsInput;
        private CheckBox treasonous;
        private Label age;
        private Label lengthOfResidence;
        private Label numOfPrevTerms;
        private Button calculate;
        private Label result;
    }
}