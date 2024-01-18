using System;
using TurnBase;

//Unit stats

Unit Player = new Unit(100, 20, 12, "Player 1");
Unit Enemy = new Unit(80, 10, 10, "Enemy Troll");
Random random = new Random();

while (!Player.isDead && !Enemy.isDead)
{
    //Player turns

    Console.WriteLine(Player.Name + " HP = " + Player.Hp + " || " + Enemy.Name + " HP = " + Enemy.Hp);
    Console.WriteLine("A = Attack || H = Heal");
    Console.Write("Player Turn: What will you do? - ");
    string choice = Console.ReadLine();

    //Player choice

    if (choice == "a")
        Player.Attack(Enemy);
    else
        Player.Heal();

    if (Player.isDead || Enemy.isDead)
        break;

    //Enemy turns

    Console.WriteLine("");
    Console.WriteLine("Enemy Turn:");

    //Enemy random choice

    int rand = random.Next(0, 2);
    if (rand == 0)
        Enemy.Attack(Player);
    else
        Enemy.Heal();

}