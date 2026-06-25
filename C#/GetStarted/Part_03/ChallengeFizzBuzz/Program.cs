using System.Text;
StringBuilder suffix = new StringBuilder();

for (int i = 1; i <= 100; i++)
{
    //string suffix = "";
    suffix.Clear();
    if (i % 3 == 0)
        suffix.Append("Fizz");
    if (i % 5 == 0)
        suffix.Append("Buzz");
    
    if (suffix.Length == 0)
        Console.WriteLine(i);
    else
        Console.WriteLine($"{i} - {suffix}");    
}

/*
Checked this one with AI to see if defining suffix used less resources
inside the loop or outside. While we both agreed inside the loop is best,
the AI also suggested using StringBuilder instead of string concatenation for better performance.
and that would have to be defined outside the loop.
*/