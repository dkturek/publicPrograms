Random coin = new Random();
int coinValue = coin.Next(0, 2);
Console.WriteLine((coinValue == 0) ? "Heads" : "Tails");

