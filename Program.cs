class Program{
    public static void Main(string[] arg) {
        
        Humano player1 = new Humano("Player 1");
        Console.WriteLine($"{player1.Name}: Health - {player1.Health}");

        
        Humano player2 = new Humano("Player 2", 5, 4, 6, 120);
        Console.WriteLine($"{player2.Name}: Health - {player2.Health}");

        
        player1.Attack(player2);
        Console.WriteLine($"{player2.Name}: Health after attack - {player2.Health}");
    }
}