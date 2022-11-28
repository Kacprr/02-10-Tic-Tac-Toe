// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");
string[] board = {" "," "," "," "," "," "," "," "," "};
int i = 0;
int positionx = 0;
int positiono = 0;

//X FIRST TURN
Console.WriteLine("Game of Tic-Tac-Toe, input the space you would like to take\nX'x turn");
positionx = int.Parse(Console.ReadLine());
board[positionx - 1] = "X";
Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} \n" +
                  $"---+---+---\n" +
                  $" {board[3]} | {board[4]} | {board[5]} \n" +
                  $"---+---+---\n" +
                  $" {board[6]} | {board[7]} | {board[8]} ");

while (i <= 8)
{
    bool xspace = true;
    bool ospace = true;

    //O TURN

    Console.WriteLine("O'x turn");
    while (ospace)
    {
        positiono = int.Parse(Console.ReadLine());

        if (board[positiono - 1] != " ")
        {
            Console.WriteLine("sorry this is taken try again");
        }
        else
        {
            board[positiono - 1] = "O";
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} \n" +
                      $"---+---+---\n" +
                      $" {board[3]} | {board[4]} | {board[5]} \n" +
                      $"---+---+---\n" +
                      $" {board[6]} | {board[7]} | {board[8]} ");
            ospace = false;
        }
    }
    //X TURN
    
    Console.WriteLine("X's turn");
    while (xspace)
    {
        positionx = int.Parse(Console.ReadLine());
        if (board[positionx - 1] != " ")
        {
            Console.WriteLine("sorry this is taken try again");
        }
        else
        {
            board[positionx - 1] = "X";
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} \n" +
                      $"---+---+---\n" +
                      $" {board[3]} | {board[4]} | {board[5]} \n" +
                      $"---+---+---\n" +
                      $" {board[6]} | {board[7]} | {board[8]} ");
            xspace = false;
        }
    }
    i++;
}

Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} \n" +
                  $"---+---+---\n" +
                  $" {board[3]} | {board[4]} | {board[5]} \n" +
                  $"---+---+---\n" +
                  $" {board[6]} | {board[7]} | {board[8]} ");
Console.WriteLine("Game Over !");