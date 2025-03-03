namespace CYFinalExamReview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Validation group box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRequired_Click(object sender, EventArgs e)
        {
            string input = txtInputText.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                rtbValidation.ForeColor = Color.Red;
                rtbValidation.Text = "Input text must not be null or empty.";
            }
            else
            {
                rtbValidation.ForeColor = Color.Green;
                rtbValidation.Text = "Valid input.";
            }
        }

        private void btnMinimumLength_Click(object sender, EventArgs e)
        {
            string input = txtInputText.Text.Trim();
            if (input.Length < 2)
            {
                rtbValidation.ForeColor = Color.Red;
                rtbValidation.Text = "Input text must contain at least 2 characters.";
            }
            else
            {
                rtbValidation.ForeColor = Color.Green;
                rtbValidation.Text = "Valid input.";
            }
        }

        private void btnAlphabeticOnly_Click(object sender, EventArgs e)
        {
            string input = txtInputText.Text;
            if (!input.All(char.IsLetter))
            {
                rtbValidation.ForeColor = Color.Red;
                rtbValidation.Text = "Input text must contain only alphabetic characters.";
            }
            else
            {
                rtbValidation.ForeColor = Color.Green;
                rtbValidation.Text = "Valid input.";
            }
        }

        private void btnNumericOnly_Click(object sender, EventArgs e)
        {
            string input = txtInputText.Text;
            if (!input.All(char.IsDigit))
            {
                rtbValidation.ForeColor = Color.Red;
                rtbValidation.Text = "Input text must contain only numeric characters.";
            }
            else
            {
                rtbValidation.ForeColor = Color.Green;
                rtbValidation.Text = "Valid input.";
            }
        }

        private void btnHasPunctuation_Click(object sender, EventArgs e)
        {
            string input = txtInputText.Text;
            if (!input.Any(char.IsPunctuation))
            {
                rtbValidation.ForeColor = Color.Red;
                rtbValidation.Text = "Input text must contain at least one punctuation character.";
            }
            else
            {
                rtbValidation.ForeColor = Color.Green;
                rtbValidation.Text = "Valid input.";
            }
        }
        /// <summary>
        /// Manipulation groupbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSplitonWhitespace_Click(object sender, EventArgs e)
        {
            string input = txtInputText.Text;
            string[] substrings = input.Split(' ');
            rtbManipulation.Clear();
            foreach (string substring in substrings)
            {
                rtbManipulation.AppendText(substring + "\n");
            }
        }

        private void btnLeaveAlphanumeric_Click(object sender, EventArgs e)
        {
            string input = txtInputText.Text;
            string result = new string(input.Where(char.IsLetter).ToArray());
            rtbManipulation.Text = result;
        }
        /// <summary>
        /// Playing card group box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidatePlayingCard_Click(object sender, EventArgs e)
        {
            string suit = txtSuit.Text;
            int value;
            if (int.TryParse(txtValue.Text, out value))
            {
                PlayingCard card = new PlayingCard(suit, value);
                if (card.IsValid())
                {
                    rtbPlayingCard.Text = "Valid";
                }
                else
                {
                    rtbPlayingCard.Text = "Invalid";
                }
            }
            else
            {
                rtbPlayingCard.Text = "Invalid input for value.";
            }
        }

        private void btnWritetoFile_Click(object sender, EventArgs e)
        {
            string suit = txtSuit.Text;
            int value;
            if (int.TryParse(txtValue.Text, out value))
            {
                PlayingCard card = new PlayingCard(suit, value);
                if (card.IsValid())
                {
                    card.Write();
                    rtbPlayingCard.Text = "Playing card written to file.";
                }
                else
                {
                    rtbPlayingCard.Text = "Invalid playing card.";
                }
            }
            else
            {
                rtbPlayingCard.Text = "Invalid input for value.";
            }
        }
    }
}
