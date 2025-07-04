public class Weapon
{
    private string Name ;
    public int Damage; //make it private

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
        Console.WriteLine($"weapon created {Name} {Damage}");
    }

   
} 