//Name: Miguel Stoyke
//App Name: Deck Builder (Form1.cs)
//Date Created: November 14th, 2023
//Last Modified: November 19th, 2023
//Description: Allows a user to view a deck of cards, deal cards from the deck, and add their own custom cards to it as well. This is the CustomDeck class.

using System;


//CustomDeck class - inherits Deck Class - NOTE: the app uses this just to track custom cards, 
//in processing, the cards are directly added to standardDeck
public class CustomDeck : Deck
{
    //Can display just the custom deck
    public List<Card> DisplayCustomDeck()
    {
        return cards;
    }

    //Adds a custom card to the custom card list
    public void AddCustomCard(string cardSuit, string cardRank)
	{
        Card customCard = new Card {Suit = cardSuit, Rank = cardRank, IsCustom = true};
        cards.Add(customCard);
    }

    //Overrides the deal method to include custom cards in the default deck
    public override List<Card> Deal(int cardCount, List<Card> card)
    {
        int totalCards = cards.Count;

        if (cardCount <= 0 || cardCount > totalCards)
        {
            MessageBox.Show("Please enter a number between 1 and " + totalCards, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new List<Card>();
        }

        List<Card> dealtCards = cards.GetRange(0, cardCount);
        cards.RemoveRange(0, cardCount);

        return dealtCards;
    }
}
