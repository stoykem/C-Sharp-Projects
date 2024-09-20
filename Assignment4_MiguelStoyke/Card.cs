//Name: Miguel Stoyke
//App Name: Deck Builder (Form1.cs)
//Date Created: November 14th, 2023
//Last Modified: November 19th, 2023
//Description: Allows a user to view a deck of cards, deal cards from the deck, and add their own custom cards to it as well. This is the Card class.

using System;

//Default constructor to determine a Card Object - Suit, Rank, and Custom, or Default card?
public class Card
{
    //Getters and setters
	public string Suit {  get; set; }
	public string Rank { get; set; }
    public bool IsCustom { get; set; }

    //Override ToString() to properly format a card in string format
    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}
