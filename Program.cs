//aisha mashrah
//10/18/22
//mimi challangle 2 adding numbers
//it is asking the user to enter a first and second number and the adding them.
bool playAgain = true;
Console.Clear();
{
Console.WriteLine("Lets add two numbers: ");

Console.WriteLine("Enter ur 1st number: ");
string firstNum = Console.ReadLine();

Console.WriteLine("Enter ur 2nd number: ");
string secNum = Console.ReadLine();

int num1 = Convert.ToInt32(firstNum);
int num2 = Convert.ToInt32(secNum);


int ansswer =  0;
ansswer  = num1 + num2;

Console.WriteLine( num1 + " + " + num2 + " = " + ansswer );
Console.WriteLine(" ");
    Console.WriteLine("Would you like to play again? Yes or No");
  
    string rePlay = Console.ReadLine();
    if(rePlay == "YES" || rePlay == "Yes" || rePlay == "yes"){
        playAgain = true;
        Console.Clear();
        Console.WriteLine( "LETS PLAY AGAIN!!" );
        Console.WriteLine( " " );
    } 
    if(rePlay == "NO" || rePlay == "no"){
        playAgain = false;
        Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
    } 
}