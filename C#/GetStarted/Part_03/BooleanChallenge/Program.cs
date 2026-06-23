//string permission = "Admin|Manager";
//int level = 55;


Console.Write("Enter your permission level (Admin or Manager): ");
string userPermission = Console.ReadLine() ?? "Default";
if (userPermission == "" || userPermission == null)
{
    userPermission = "Default";
}

Console.Write("Enter your level: ");
string userLevelInput = Console.ReadLine() ?? "0";
int userLevel = 0;
if (userLevelInput == "")
    userLevel = 0;  
else if (userLevelInput != null)
    userLevel = int.Parse(userLevelInput);



if (userPermission == "Admin")
    { 
        if (userLevel > 55)
        {
            Console.WriteLine("Welcome, Super Admin user.");
        }
        else 
        {
            Console.WriteLine("Welcome, Admin user.");
        }
    }

else if (userPermission == "Manager")
    {
        if (userLevel >= 20)
        {
            Console.WriteLine("Contact an Admin for access.");
        }
        else 
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
else
{
    Console.WriteLine($"You do not have sufficient privileges as {userPermission}.");
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();
