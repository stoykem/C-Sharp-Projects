//Name: Miguel Stoyke
//App Name: Deck Builder (Form1.cs)
//Date Created: November 14th, 2023
//Last Modified: November 19th, 2023
//Description: Allows a user to view a deck of cards, deal cards from the deck, and add their own custom cards to it as well. This is the Deck class.

using System;

//Deck class - base class to initialize a deck of cards
public class Deck
{
    protected List<Card> cards; //Class accessibility

    //Default constructor - creates the base list for a deck of cards
    public Deck()
    {
        cards = new List<Card>();
    }

    // Initialize the deck with a full set of 52 cards
    public virtual void InitializeDeck()
    {
        string[] cardSuits = { 
            "Hearts", 
            "Diamonds", 
            "Clubs", 
            "Spades" 
        };
        string[] cardRanks = { 
            "Ace",
            "2", 
            "3",
            "4", 
            "5",
            "6", 
            "7", 
            "8", 
            "9", 
            "10", 
            "Jack", 
            "Queen", 
            "King" 
        };

        //Uses the cards list to populate the default set of cards based on their gathered suits and ranks from the above arrays.
        for (int i = 0; i < cardSuits.Length; i++)
        {
            for (int j = 0; j < cardRanks.Length; j++)
            {
                cards.Add(new Card {
                    Suit = cardSuits[i], Rank = cardRanks[j]
                });
            }
        }
    }

    //Called to shuffle the current deck of cards in a random order
    public void ShuffleCards()
    {
        Random randomCard = new Random();
        cards = cards.OrderBy(card => randomCard.Next()).ToList(); //Generates integers from card values to determine a random order
    }

    //Simple call to return all cards from deck
    public List<Card> DisplayFullDeck()
    {
        return cards;
    }

    //Base deal method, reads through the deck of cards to determine how many can be dealt
    public virtual List<Card> Deal(int cardCount, List<Card> deck)
    {
        if (cardCount <= 0 || cardCount > deck.Count)
        {
            MessageBox.Show("Please enter a number between 1 and " + deck.Count, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return new List<Card>();
        }

        //Creates a numbered list based on how many cards have been chosen to be dealt
        List<Card> dealtCards = deck.GetRange(0, cardCount);
        deck.RemoveRange(0, cardCount); //Pulls the specified number range to display the correct amount of cards to be dealt

        return dealtCards;
    }

    //Called to add a custom card to the base card list
    public void AddCustomCard(Card customCard)
    {
        cards.Add(customCard);
    }

    //Used when resetting - boolean check to determine if a card is custom, so that it can be removed from the default deck upon reset
    protected bool IsCustomCard(Card card)
    {
        return card.IsCustom;
    }
}