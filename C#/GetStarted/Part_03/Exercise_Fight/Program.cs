Console.WriteLine("Exerise Fight!");

Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;

while (heroHealth > 0 && monsterHealth > 0)
{
    int heroAttack = random.Next(1, 11);
    monsterHealth -= heroAttack;
    Console.Write($"Hero attacks for {heroAttack} damage. ");
    
    if (monsterHealth <= 0)
    {
        Console.WriteLine("Monster is defeated!");
        Console.WriteLine("The Hero is victorious!");
        break;
    }
    else
    {
        Console.WriteLine($"Monster has {monsterHealth} health remaining.");
    }

    int monsterAttack = random.Next(1, 11);
    Console.Write($"Monster attacks for {monsterAttack} damage. ");
    heroHealth -= monsterAttack;

    if (heroHealth <= 0)
    {
        Console.WriteLine("Hero is defeated!");
        Console.WriteLine("The Monster eats well tonight!");
        break;
    }
    else
    {
        Console.WriteLine($"Hero has {heroHealth} health remaining.");
    }
}