//Name: Miguel Stoyke
//App Name: Deck Builder (Form1.cs)
//Date Created: November 14th, 2023
//Last Modified: November 19th, 2023
//Description: Allows a user to view a deck of cards, deal cards from the deck, and add their own custom cards to it as well. This is the main form for the app.

namespace Assignment4_MiguelStoyke
{
    public partial class Form1 : Form
    {
        //Initialize the custom and standard decks 
        private static StandardDeck standardDeck; //Set to static as this is shared amongst classes and methods
        private CustomDeck customDeck;
        public Form1()
        {
            InitializeComponent();

            //Allows additional access keys to be used, and adds the KeyUp method to the event handler
            this.KeyPreview = true;
            this.KeyUp += Form1_KeyUp;

            //Initializes the deck of cards upon form submission to ensure consistency with the numbers
            standardDeck = new StandardDeck();
            customDeck = new CustomDeck();
            standardDeck.InitializeDeck();
        }

        //Called to reset the specified fields back to blank default state
        private void ResetFields()
        {
            SuitText.Focus();
            SuitText.Text = "";
            RankText.Text = "";
            DrawText.Text = "";

            DeckView.Items.Clear();
            CardsDealtView.Clear();
        }

        //Will display all cards currently in the deck within DeckView
        private void CardDisplay(List<Card> cards)
        {
            DeckView.Items.Clear();

            //Iterates as many times as their are cards in the deck
            for (int i = 0; i < cards.Count; i++)
            {
                DeckView.Items.Add(cards[i].ToString());
            }
        }

        //Will display the random dealt cards in the CardsDealtView if validation is passed
        private void CardDisplayDealt(List<Card> dealtCards)
        {
            CardsDealtView.Items.Clear();

            for (int i = 0; i < dealtCards.Count; i++)
            {
                CardsDealtView.Items.Add(dealtCards[i].ToString());
            }
        }

        //ViewDeckButton - Resets input fields upon validation, uses the base DisplayFullDeck to populate the current deck of cards based on the base class deck
        private void ViewDeckButton_Click(object sender, EventArgs e)
        {
            SuitText.Text = "";
            RankText.Text = "";
            DrawText.Text = "";
            CardDisplay(standardDeck.DisplayFullDeck()); //call to base class
        }

        //ShuffleButton - shuffles the current cards randomly, and re displays the deck in a random order
        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            standardDeck.ShuffleCards();

            SuitText.Text = "";
            RankText.Text = "";
            DrawText.Text = "";

            CardDisplay(standardDeck.DisplayFullDeck());
        }

        //DealButton - deals random cards as many as the user selects within range. 
        private void DealButton_Click(object sender, EventArgs e)
        {
            standardDeck.ShuffleCards(); //calls shuffle to randomly order dealt cards

            try
            {
                //Tries to process dealt cards as integer so that cards dealt can be true
                if (int.TryParse(DrawText.Text, out int drawCounter))
                {
                    //Creates a list of cards based on the counter created by the user input for drawing cards
                    List<Card> dealtCards = standardDeck.Deal(drawCounter);

                    SuitText.Text = "";
                    RankText.Text = "";
                    DrawText.Text = "";

                    CardDisplayDealt(dealtCards); //display dealt cards
                }
                else
                {
                    throw new FormatException("Numeric input only for card draw.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //AddCustButton - adds the custom card to the private set of custom cards, as well as the official standardDeck
        private void AddCustButton_Click(object sender, EventArgs e)
        {
            string newSuit = SuitText.Text;
            string newRank = RankText.Text;

            if (!string.IsNullOrWhiteSpace(newSuit) && !string.IsNullOrWhiteSpace(newRank))
            {
                customDeck.AddCustomCard(newSuit, newRank);
                standardDeck.AddCustomCardToStandard(newSuit, newRank);

                SuitText.Text = "";
                RankText.Text = "";
                DrawText.Text = "";

                CardDisplay(standardDeck.DisplayFullDeck()); //Display the new deck of cards including new custom cards
            }
            else
            {
                MessageBox.Show("New Suit and Rank Required For New Card!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ResetButton - Removes custom cards based on boolean check, resets the deck to base initialized 52 cards, resets fields to default
        private void ResetButton_Click(object sender, EventArgs e)
        {
            standardDeck.RemoveCustomCards();
            standardDeck.ResetDeck();
            ResetFields();
        }

        //ExitButton - exit app
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //KeyUp method - Allows events to be accessed using specified keys
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //If escape key is clicked, trigger ResetButton
            if (e.KeyCode == Keys.Escape)
            {
                ResetButton.PerformClick();
            }

            //If enter key is clicked, trigger AddCustomButton
            else if (e.KeyCode == Keys.Enter)
            {
                AddCustButton.PerformClick();
            }
        }
    }
}