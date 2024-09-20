//Name: Miguel Stoyke
//App Name: Tic Tac Toe Game
//Date Created: October 14th, 2023
//Last Modified: October 17th, 2023
//Description: This app allows two players to play a game of tic tac toe and track there matches as they play (if they choose)

namespace Assignment2_MiguelStoyke
{
    public partial class TicTacToe : Form
    {
        //Variables
        bool p1Turn = true;
        bool isWinner = false;
        int roundNumber = 1;

        //Main form
        public TicTacToe()
        {
            InitializeComponent();

            //Game is disabled by default
            one.Enabled = false;
            two.Enabled = false;
            three.Enabled = false;
            four.Enabled = false;
            five.Enabled = false;
            six.Enabled = false;
            seven.Enabled = false;
            eight.Enabled = false;
            nine.Enabled = false;

            // Assign the same event handler to each button's Click event
            one.Click += (s, e) => populateButton(one);
            two.Click += (s, e) => populateButton(two);
            three.Click += (s, e) => populateButton(three);
            four.Click += (s, e) => populateButton(four);
            five.Click += (s, e) => populateButton(five);
            six.Click += (s, e) => populateButton(six);
            seven.Click += (s, e) => populateButton(seven);
            eight.Click += (s, e) => populateButton(eight);
            nine.Click += (s, e) => populateButton(nine);
        }

        //Method called each round to determine if there is a winner yet
        public void CheckForWinner()
        {
            //Checks whos turn it is, in order to display appropriate name
            string winnerSym = p1Turn ? Player1SymText.Text : Player2SymText.Text;
            string winnerName = p1Turn ? Player1Text.Text : Player2Text.Text;

            //Checks all possible rows to determine if there is a winner
            if ((one.Text.Equals(winnerSym)
                && two.Text.Equals(winnerSym)
                && three.Text.Equals(winnerSym))
                || (one.Text.Equals(winnerSym)
                && two.Text.Equals(winnerSym)
                && three.Text.Equals(winnerSym)))
            {
                //Assigns winners name to the winner text box
                WinnerText.Text = winnerName;

                one.Enabled = false;
                two.Enabled = false;
                three.Enabled = false;
                four.Enabled = false;
                five.Enabled = false;
                six.Enabled = false;
                seven.Enabled = false;
                eight.Enabled = false;
                nine.Enabled = false;

                //Sets boolean flag to true to identify a winner, and write report of game winner
                isWinner = true;
                ContinueButton.Enabled = true;
                ContinueButton.Focus();
                GameStatsList.Items.Add($"Game {roundNumber} ~ Winner: {winnerName}");
                roundNumber++; //increment each round

                return; //end game early
            }
            else if ((four.Text.Equals(winnerSym)
                && five.Text.Equals(winnerSym)
                && six.Text.Equals(winnerSym))
                || (four.Text.Equals(winnerSym)
                && five.Text.Equals(winnerSym)
                && six.Text.Equals(winnerSym)))
            {
                WinnerText.Text = winnerName;

                one.Enabled = false;
                two.Enabled = false;
                three.Enabled = false;
                four.Enabled = false;
                five.Enabled = false;
                six.Enabled = false;
                seven.Enabled = false;
                eight.Enabled = false;
                nine.Enabled = false;

                isWinner = true;
                ContinueButton.Enabled = true;
                ContinueButton.Focus();
                GameStatsList.Items.Add($"Game {roundNumber} ~ Winner: {winnerName}");
                roundNumber++;

                return;
            }
            else if ((seven.Text.Equals(winnerSym)
                && eight.Text.Equals(winnerSym)
                && nine.Text.Equals(winnerSym))
                || (seven.Text.Equals(winnerSym)
                && eight.Text.Equals(winnerSym)
                && nine.Text.Equals(winnerSym)))
            {
                WinnerText.Text = winnerName;

                one.Enabled = false;
                two.Enabled = false;
                three.Enabled = false;
                four.Enabled = false;
                five.Enabled = false;
                six.Enabled = false;
                seven.Enabled = false;
                eight.Enabled = false;
                nine.Enabled = false;

                isWinner = true;
                ContinueButton.Enabled = true;
                ContinueButton.Focus();
                GameStatsList.Items.Add($"Game {roundNumber} ~ Winner: {winnerName}");
                roundNumber++;

                return;
            }
            else if ((one.Text.Equals(winnerSym)
                && four.Text.Equals(winnerSym)
                && seven.Text.Equals(winnerSym))
                || (one.Text.Equals(winnerSym)
                && four.Text.Equals(winnerSym)
                && seven.Text.Equals(winnerSym)))
            {
                WinnerText.Text = winnerName;

                one.Enabled = false;
                two.Enabled = false;
                three.Enabled = false;
                four.Enabled = false;
                five.Enabled = false;
                six.Enabled = false;
                seven.Enabled = false;
                eight.Enabled = false;
                nine.Enabled = false;

                isWinner = true;
                ContinueButton.Enabled = true;
                ContinueButton.Focus();
                GameStatsList.Items.Add($"Game {roundNumber} ~ Winner: {winnerName}");
                roundNumber++;

                return;
            }
            else if ((two.Text.Equals(winnerSym)
                && five.Text.Equals(winnerSym)
                && eight.Text.Equals(winnerSym))
                || (two.Text.Equals(winnerSym)
                && five.Text.Equals(winnerSym)
                && eight.Text.Equals(winnerSym)))
            {
                WinnerText.Text = winnerName;

                one.Enabled = false;
                two.Enabled = false;
                three.Enabled = false;
                four.Enabled = false;
                five.Enabled = false;
                six.Enabled = false;
                seven.Enabled = false;
                eight.Enabled = false;
                nine.Enabled = false;

                isWinner = true;
                ContinueButton.Enabled = true;
                ContinueButton.Focus();
                GameStatsList.Items.Add($"Game {roundNumber} ~ Winner: {winnerName}");
                roundNumber++;

                return;
            }
            else if ((three.Text.Equals(winnerSym)
                && six.Text.Equals(winnerSym)
                && nine.Text.Equals(winnerSym))
                || (three.Text.Equals(winnerSym)
                && six.Text.Equals(winnerSym)
                && nine.Text.Equals(winnerSym)))
            {
                WinnerText.Text = winnerName;

                one.Enabled = false;
                two.Enabled = false;
                three.Enabled = false;
                four.Enabled = false;
                five.Enabled = false;
                six.Enabled = false;
                seven.Enabled = false;
                eight.Enabled = false;
                nine.Enabled = false;

                isWinner = true;
                ContinueButton.Enabled = true;
                ContinueButton.Focus();
                GameStatsList.Items.Add($"Game {roundNumber} ~ Winner: {winnerName}");
                roundNumber++;

                return;
            }
            else if ((one.Text.Equals(winnerSym)
                && five.Text.Equals(winnerSym)
                && nine.Text.Equals(winnerSym))
                || (one.Text.Equals(winnerSym)
                && five.Text.Equals(winnerSym)
                && nine.Text.Equals(winnerSym)))
            {
                WinnerText.Text = winnerName;

                one.Enabled = false;
                two.Enabled = false;
                three.Enabled = false;
                four.Enabled = false;
                five.Enabled = false;
                six.Enabled = false;
                seven.Enabled = false;
                eight.Enabled = false;
                nine.Enabled = false;

                isWinner = true;
                ContinueButton.Enabled = true;
                ContinueButton.Focus();
                GameStatsList.Items.Add($"Game {roundNumber} ~ Winner: {winnerName}");
                roundNumber++;

                return;
            }
            else if ((three.Text.Equals(winnerSym)
                && five.Text.Equals(winnerSym)
                && seven.Text.Equals(winnerSym))
                || (three.Text.Equals(winnerSym)
                && five.Text.Equals(winnerSym)
                && seven.Text.Equals(winnerSym)))
            {
                WinnerText.Text = winnerName;

                one.Enabled = false;
                two.Enabled = false;
                three.Enabled = false;
                four.Enabled = false;
                five.Enabled = false;
                six.Enabled = false;
                seven.Enabled = false;
                eight.Enabled = false;
                nine.Enabled = false;

                isWinner = true;
                ContinueButton.Enabled = true;
                ContinueButton.Focus();
                GameStatsList.Items.Add($"Game {roundNumber} ~ Winner: {winnerName}");
                roundNumber++;

                return;
            }
            else
            {
                //if all fields are full but there is still no winner, it means there is a draw
                if (!string.IsNullOrEmpty(one.Text)
                 && !string.IsNullOrEmpty(two.Text)
                 && !string.IsNullOrEmpty(three.Text)
                 && !string.IsNullOrEmpty(four.Text)
                 && !string.IsNullOrEmpty(five.Text)
                 && !string.IsNullOrEmpty(six.Text)
                 && !string.IsNullOrEmpty(seven.Text)
                 && !string.IsNullOrEmpty(eight.Text)
                 && !string.IsNullOrEmpty(nine.Text))
                {
                    //Identifies no winner and states a draw
                    WinnerText.Text = "Draw";

                    //Same logic as if there was a winner
                    one.Enabled = false;
                    two.Enabled = false;
                    three.Enabled = false;
                    four.Enabled = false;
                    five.Enabled = false;
                    six.Enabled = false;
                    seven.Enabled = false;
                    eight.Enabled = false;
                    nine.Enabled = false;

                    isWinner = true;
                    ContinueButton.Enabled = true;
                    ContinueButton.Focus();
                    GameStatsList.Items.Add($"Game {roundNumber} ~ Draw");
                    roundNumber++;
                    return;
                }
            }
        }

        //method to display appropriate player symbol on the playing board
        private void populateButton(Button button)
        {
            //If a button hasn't been clicked yet, a move can be made
            if (button.Text == "")
            {
                //checks the boolean condition to determine whos turn it is
                button.Text = p1Turn ? Player1SymText.Text : Player2SymText.Text;
                //checks if there is a winner each time the method is called
                CheckForWinner();

                //if there is not a winner yet, keep switching between players
                if (!isWinner)
                {
                    p1Turn = !p1Turn; // Toggle the turn to the other player

                    //If it is player 1's turn, their name will be displayed. If not, it means it is player 2's turn and their name will be displayed
                    if (p1Turn == true)
                    {
                        NextTurnText.Text = Player1Text.Text;
                    }
                    else
                    {
                        NextTurnText.Text = Player2Text.Text;
                    }
                }
            }
            else
            {
                //States invalid move if a button already clicked is clicked again in game
                NextTurnText.Text = "Invalid Move";
            }

        }

        //Actions for reset button
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Player1Text.Focus();
            //Resets all values back to their default state
            Player1Text.Text = "";
            Player2Text.Text = "";

            Player1SymText.Text = "";
            Player2SymText.Text = "";

            Player1SymText.Enabled = true;
            Player2SymText.Enabled = true;
            Player1Text.Enabled = true;
            Player2Text.Enabled = true;
            StartButton.Enabled = true;

            one.Text = "";
            two.Text = "";
            three.Text = "";
            four.Text = "";
            five.Text = "";
            six.Text = "";
            seven.Text = "";
            eight.Text = "";
            nine.Text = "";

            NextTurnText.Text = "";
            WinnerText.Text = "";

            isWinner = false; //there is no winner by default
            GameStatsList.Items.Clear(); //clear the report list

            roundNumber = 1; //reset back to round 1 at the start of every match

        }

        //Actions for start button
        private void StartButton_Click(object sender, EventArgs e)
        {
            //Validation
            //If there are not two symbols
            if (string.IsNullOrEmpty(Player1SymText.Text) || string.IsNullOrEmpty(Player2SymText.Text))
            {
                NextTurnText.Text = "Choose 2 Symbols To Play";
            }
            //If the symbols are any more than 1 character
            else if (Player1SymText.Text.Length > 1 || Player2SymText.Text.Length > 1)
            {
                NextTurnText.Text = "Choose 1 Character For Symbol";
            }
            //If two players have not been assigned names
            else if (string.IsNullOrEmpty(Player1Text.Text) || string.IsNullOrEmpty(Player2Text.Text))
            {
                NextTurnText.Text = "Please Enter 2 Player Names";
            }
            //Reaches here after passing validation
            else
            {
                //Enables the game grid buttons to begin the match
                one.Enabled = true;
                two.Enabled = true;
                three.Enabled = true;
                four.Enabled = true;
                five.Enabled = true;
                six.Enabled = true;
                seven.Enabled = true;
                eight.Enabled = true;
                nine.Enabled = true;

                //Disables the start button and sets the first turn to player 1 each time the game starts
                StartButton.Enabled = false;
                NextTurnText.Text = Player1Text.Text;

                //Text fields are locked until a new game is started
                Player1SymText.Enabled = false;
                Player2SymText.Enabled = false;
                Player1Text.Enabled = false;
                Player2Text.Enabled = false;
            }

        }

        //Actions for continue button
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            //If two of the same players want to play again, it only resets the gameboard and winner status
            //It also keeps the report active in the ListBox (GameStatsList)
            one.Text = "";
            two.Text = "";
            three.Text = "";
            four.Text = "";
            five.Text = "";
            six.Text = "";
            seven.Text = "";
            eight.Text = "";
            nine.Text = "";

            one.Enabled = true;
            two.Enabled = true;
            three.Enabled = true;
            four.Enabled = true;
            five.Enabled = true;
            six.Enabled = true;
            seven.Enabled = true;
            eight.Enabled = true;
            nine.Enabled = true;

            ContinueButton.Enabled = false;
            WinnerText.Text = "";
            isWinner = false;

            //Sets player 1 turn boolean condition back to true as it is a new game that will always start with player 1
            p1Turn = true;
        }
    }
}