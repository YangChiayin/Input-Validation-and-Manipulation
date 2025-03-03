namespace CYFinalExamReview
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
            lblSuit = new Label();
            txtSuit = new TextBox();
            groupBox1 = new GroupBox();
            rtbValidation = new RichTextBox();
            btnHasPunctuation = new Button();
            btnNumericOnly = new Button();
            btnAlphabeticOnly = new Button();
            btnMinimumLength = new Button();
            btnRequired = new Button();
            groupBox2 = new GroupBox();
            rtbManipulation = new RichTextBox();
            btnLeaveAlphanumeric = new Button();
            btnSplitonWhitespace = new Button();
            groupBox3 = new GroupBox();
            rtbPlayingCard = new RichTextBox();
            btnWritetoFile = new Button();
            btnValidatePlayingCard = new Button();
            txtValue = new TextBox();
            lblValue = new Label();
            lblInputText = new Label();
            txtInputText = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblSuit
            // 
            lblSuit.AutoSize = true;
            lblSuit.Location = new Point(26, 70);
            lblSuit.Name = "lblSuit";
            lblSuit.Size = new Size(55, 32);
            lblSuit.TabIndex = 0;
            lblSuit.Text = "Suit";
            // 
            // txtSuit
            // 
            txtSuit.Location = new Point(87, 67);
            txtSuit.Name = "txtSuit";
            txtSuit.Size = new Size(200, 39);
            txtSuit.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbValidation);
            groupBox1.Controls.Add(btnHasPunctuation);
            groupBox1.Controls.Add(btnNumericOnly);
            groupBox1.Controls.Add(btnAlphabeticOnly);
            groupBox1.Controls.Add(btnMinimumLength);
            groupBox1.Controls.Add(btnRequired);
            groupBox1.Location = new Point(30, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 375);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Validation";
            // 
            // rtbValidation
            // 
            rtbValidation.Location = new Point(6, 168);
            rtbValidation.Name = "rtbValidation";
            rtbValidation.ReadOnly = true;
            rtbValidation.Size = new Size(648, 192);
            rtbValidation.TabIndex = 1;
            rtbValidation.Text = "";
            // 
            // btnHasPunctuation
            // 
            btnHasPunctuation.Location = new Point(245, 90);
            btnHasPunctuation.Name = "btnHasPunctuation";
            btnHasPunctuation.Size = new Size(233, 46);
            btnHasPunctuation.TabIndex = 0;
            btnHasPunctuation.Text = "Has Punctuation";
            btnHasPunctuation.UseVisualStyleBackColor = true;
            btnHasPunctuation.Click += btnHasPunctuation_Click;
            // 
            // btnNumericOnly
            // 
            btnNumericOnly.Location = new Point(6, 90);
            btnNumericOnly.Name = "btnNumericOnly";
            btnNumericOnly.Size = new Size(233, 46);
            btnNumericOnly.TabIndex = 0;
            btnNumericOnly.Text = "Numeric Only";
            btnNumericOnly.UseVisualStyleBackColor = true;
            btnNumericOnly.Click += btnNumericOnly_Click;
            // 
            // btnAlphabeticOnly
            // 
            btnAlphabeticOnly.Location = new Point(401, 38);
            btnAlphabeticOnly.Name = "btnAlphabeticOnly";
            btnAlphabeticOnly.Size = new Size(233, 46);
            btnAlphabeticOnly.TabIndex = 0;
            btnAlphabeticOnly.Text = "Alphabetic Only";
            btnAlphabeticOnly.UseVisualStyleBackColor = true;
            btnAlphabeticOnly.Click += btnAlphabeticOnly_Click;
            // 
            // btnMinimumLength
            // 
            btnMinimumLength.Location = new Point(162, 38);
            btnMinimumLength.Name = "btnMinimumLength";
            btnMinimumLength.Size = new Size(233, 46);
            btnMinimumLength.TabIndex = 0;
            btnMinimumLength.Text = "Minimum Length";
            btnMinimumLength.UseVisualStyleBackColor = true;
            btnMinimumLength.Click += btnMinimumLength_Click;
            // 
            // btnRequired
            // 
            btnRequired.Location = new Point(6, 38);
            btnRequired.Name = "btnRequired";
            btnRequired.Size = new Size(150, 46);
            btnRequired.TabIndex = 0;
            btnRequired.Text = "Required";
            btnRequired.UseVisualStyleBackColor = true;
            btnRequired.Click += btnRequired_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtbManipulation);
            groupBox2.Controls.Add(btnLeaveAlphanumeric);
            groupBox2.Controls.Add(btnSplitonWhitespace);
            groupBox2.Location = new Point(30, 474);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(660, 307);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manipulation";
            // 
            // rtbManipulation
            // 
            rtbManipulation.Location = new Point(6, 102);
            rtbManipulation.Name = "rtbManipulation";
            rtbManipulation.ReadOnly = true;
            rtbManipulation.Size = new Size(648, 192);
            rtbManipulation.TabIndex = 1;
            rtbManipulation.Text = "";
            // 
            // btnLeaveAlphanumeric
            // 
            btnLeaveAlphanumeric.Location = new Point(371, 38);
            btnLeaveAlphanumeric.Name = "btnLeaveAlphanumeric";
            btnLeaveAlphanumeric.Size = new Size(263, 46);
            btnLeaveAlphanumeric.TabIndex = 0;
            btnLeaveAlphanumeric.Text = "Leave Alphanumeric";
            btnLeaveAlphanumeric.UseVisualStyleBackColor = true;
            btnLeaveAlphanumeric.Click += btnLeaveAlphanumeric_Click;
            // 
            // btnSplitonWhitespace
            // 
            btnSplitonWhitespace.Location = new Point(20, 38);
            btnSplitonWhitespace.Name = "btnSplitonWhitespace";
            btnSplitonWhitespace.Size = new Size(263, 46);
            btnSplitonWhitespace.TabIndex = 0;
            btnSplitonWhitespace.Text = "Split on Whitespace";
            btnSplitonWhitespace.UseVisualStyleBackColor = true;
            btnSplitonWhitespace.Click += btnSplitonWhitespace_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rtbPlayingCard);
            groupBox3.Controls.Add(btnWritetoFile);
            groupBox3.Controls.Add(btnValidatePlayingCard);
            groupBox3.Controls.Add(txtValue);
            groupBox3.Controls.Add(lblValue);
            groupBox3.Controls.Add(txtSuit);
            groupBox3.Controls.Add(lblSuit);
            groupBox3.Location = new Point(24, 798);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(660, 400);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Playing Card";
            // 
            // rtbPlayingCard
            // 
            rtbPlayingCard.Location = new Point(6, 194);
            rtbPlayingCard.Name = "rtbPlayingCard";
            rtbPlayingCard.ReadOnly = true;
            rtbPlayingCard.Size = new Size(648, 192);
            rtbPlayingCard.TabIndex = 1;
            rtbPlayingCard.Text = "";
            // 
            // btnWritetoFile
            // 
            btnWritetoFile.Location = new Point(401, 130);
            btnWritetoFile.Name = "btnWritetoFile";
            btnWritetoFile.Size = new Size(233, 46);
            btnWritetoFile.TabIndex = 0;
            btnWritetoFile.Text = "Write to File";
            btnWritetoFile.UseVisualStyleBackColor = true;
            btnWritetoFile.Click += btnWritetoFile_Click;
            // 
            // btnValidatePlayingCard
            // 
            btnValidatePlayingCard.Location = new Point(20, 130);
            btnValidatePlayingCard.Name = "btnValidatePlayingCard";
            btnValidatePlayingCard.Size = new Size(263, 46);
            btnValidatePlayingCard.TabIndex = 0;
            btnValidatePlayingCard.Text = "Validate Playing Card";
            btnValidatePlayingCard.UseVisualStyleBackColor = true;
            btnValidatePlayingCard.Click += btnValidatePlayingCard_Click;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(440, 70);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(200, 39);
            txtValue.TabIndex = 1;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(362, 73);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(72, 32);
            lblValue.TabIndex = 0;
            lblValue.Text = "Value";
            // 
            // lblInputText
            // 
            lblInputText.AutoSize = true;
            lblInputText.Location = new Point(44, 36);
            lblInputText.Name = "lblInputText";
            lblInputText.Size = new Size(120, 32);
            lblInputText.TabIndex = 0;
            lblInputText.Text = "Input Text";
            // 
            // txtInputText
            // 
            txtInputText.Location = new Point(170, 36);
            txtInputText.Name = "txtInputText";
            txtInputText.Size = new Size(200, 39);
            txtInputText.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 1303);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblInputText);
            Controls.Add(txtInputText);
            Name = "Form1";
            Text = "Final Exam Review";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSuit;
        private TextBox txtSuit;
        private GroupBox groupBox1;
        private RichTextBox rtbValidation;
        private Button btnMinimumLength;
        private Button btnRequired;
        private Button btnHasPunctuation;
        private Button btnNumericOnly;
        private Button btnAlphabeticOnly;
        private GroupBox groupBox2;
        private RichTextBox rtbManipulation;
        private Button btnLeaveAlphanumeric;
        private Button btnSplitonWhitespace;
        private GroupBox groupBox3;
        private RichTextBox rtbPlayingCard;
        private Button btnWritetoFile;
        private Button btnValidatePlayingCard;
        private TextBox txtValue;
        private Label lblValue;
        private Label lblInputText;
        private TextBox txtInputText;
    }
}
