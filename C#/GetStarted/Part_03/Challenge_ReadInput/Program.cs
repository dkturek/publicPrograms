
/*
Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/

int intValue = 0;


do
{
    Console.WriteLine("Please enter an integer value between 5 and 10:");
    if (int.TryParse(Console.ReadLine(), out intValue))
    {
        if (intValue < 5 || intValue > 10)
        {
            Console.Write("Invalid input. ");
        }
    }
    else
    {
        Console.Write("Invalid input. ");
    }
} while (intValue < 5 || intValue > 10);

Console.WriteLine($"Your input value of {intValue} has been accepted.");


/*
Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

*/

string? role = "";
while (role != "administrator" && role != "manager" && role != "user")
{
    Console.WriteLine("Please enter one of the following roles: Administrator, Manager, or User:");
    role = Console.ReadLine()?.Trim().ToLower();
    if (role != "administrator" && role != "manager" && role != "user")
    {
        Console.WriteLine("Invalid input. Please enter a valid role.");
    }
} 

Console.WriteLine($"Your input value of {role} has been accepted.");

/*
Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.

In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.

Your solution must include an inner do-while or while loop that can be used to process the myString variable.

In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.

In the inner loop, your solution must not display the period character.

In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.

*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string myString in myStrings)
{
    string[] sentences = myString.Split('.');
    foreach (string sentence in sentences)
    {
        Console.WriteLine(sentence.TrimStart());
    }
}

   