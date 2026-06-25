Random random = new Random();
int current = 0;
int sum = 0;

do
{
    current = random.Next(1, 11);
    sum += current;
    if (current <= 3) continue;
    Console.WriteLine($"{current} sum: {sum}");
} while (current != 7);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");