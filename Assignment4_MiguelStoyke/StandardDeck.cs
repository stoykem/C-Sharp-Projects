//Name: Miguel Stoyke
//App Name: Deck Builder (Form1.cs)
//Date Created: November 14th, 2023
//Last Modified: November 19th, 2023
//Description: Allows a user to view a deck of cards, deal cards from the deck, and add their own custom cards to it as well. This is the StandardDeck class.

using System;

//StandardDeck class - inherits Deck Class
public class StandardDeck : Deck
{
    //Initializes the default deck of the base class
    public override void InitializeDeck()
	{
		base.InitializeDeck();
    }

    //Adds the users custom card to the standard displayed deck
    public void AddCustomCardToStandard(string cardSuit, string cardRank)
    {
        //Create the card, add to base class
        Card customCard = new Card { Suit = cardSuit, Rank = cardRank, IsCustom = true };
        base.AddCustomCard(customCard);
    }

    //Deals a card or set of cards from the current list of cards
    public List<Card> Deal(int cardCount)
    {
        int totalCards = cards.Count; //sets a counter from the base cards list to determine how many cards are available

        //Validation - Ensures the user types at least one card to draw, cannot exceed the amount of cards currently in the deck
        if (cardCount <= 0 || cardCount > totalCards)
        {
            MessageBox.Show("Please enter a number between 1 and " + totalCards, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new List<Card>(); //Returns empty list if validation fails
        }

        //Create a copy of the list before dealing cards
        List<Card> deckCopy = cards.ToList();

        List<Card> dealtCards = base.Deal(cardCount, deckCopy); //Pass the copy of the deck to the base class Deal method

        return dealtCards;
    }
    public void ResetDeck()
    {
        InitializeDeck(); // Reset to default 52 cards
    }

    //Called to remove custom cards the user added when the app is reset to default
    public void RemoveCustomCards()
    {
        cards.RemoveAll(card => IsCustomCard(card)); //Uses a handler to check the boolean method to determine a card as custom, or default
    }
}