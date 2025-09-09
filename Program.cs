
/* 
 Project type:
    Console App
Variable types:
    boolean's(true or False)
    Integer(whole numbers)
    Floats(any number with decimal even .0)
    strings("")
 */

//tell user what to do
Console.WriteLine("type anything any it'll echo back 3 times");
//use camel case
string userInput;

userInput = Console.ReadLine();
//string interpolation
Console.Write($"{userInput}    {userInput}     {userInput}");

//echo three times
/*
Console.WriteLine(userInput);
Console.WriteLine(userInput);
Console.WriteLine(userInput);
*/

//string concatenation
//Console.Write(userInput + " " + userInput + " " + userInput);