using System;

class Program
{
    static void Main(string[] args)
    {
        Weapon testWeapon = new Weapon("AK_47", 60);
        Warrior testWarrior = new Warrior("Jery", testWeapon);

        Weapon testWeapon2 = new Weapon("Glock", 30);
        Warrior testWarrior2 = new Warrior("Jeremy", testWeapon2);

        testWarrior.Fight(testWarrior2);
    }
}


