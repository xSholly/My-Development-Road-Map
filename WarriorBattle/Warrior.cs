public class Warrior
{
    private string Name; 
    private int experience;
    private Weapon weapon;
    private int health;

    public Warrior(string name, Weapon w)
    {
        Name = name;
        experience = 0;
        weapon = w;
        health = 100;
        Console.WriteLine($"new Warrior {name} has been born");
    }

   public void Fight(Warrior opponent)
    {
        Console.WriteLine($"Death fight: {Name} vs {opponent.Name}");

        while (health > 0 && opponent.health > 0)
        {
            // This warrior attacks opponent
            opponent.health -= weapon.Damage;
            Console.WriteLine($"{Name} hits {opponent.Name} for {weapon.Damage} damage. {opponent.Name} health: {opponent.health}");

            if (opponent.health <= 0)
            {
                Console.WriteLine($"{opponent.Name} has been defeated!");
                GainExperience(100);
                break;
            }

            // Opponent counter-attacks
            health -= opponent.weapon.Damage;
            Console.WriteLine($"{opponent.Name} hits {Name} for {opponent.weapon.Damage} damage. {Name} health: { health }");

            if (health <= 0)
            {
                Console.WriteLine($"{Name} has been defeated!");
                opponent.GainExperience(100);
                break;
            }
        }
    }


    private void GainExperience(int amount)
    {
        experience += amount;
        Console.WriteLine($"{Name} gained {amount} XP. (Total: {experience})");
    }

}