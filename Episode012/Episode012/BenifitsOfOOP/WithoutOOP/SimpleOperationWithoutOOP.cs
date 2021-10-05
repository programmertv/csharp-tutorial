using System;
namespace Episode012.BenifitsOfOOP.WithoutOOP
{
    public class SimpleOperationWithoutOOP
    {
        public void Process()
        {
            Print(new Ninja() { Weapon = "Fireball", SecretWeapon = "Shureken" });
            Print(new Samurai() { Weapon = "Sword", SecretWeapon = "3 swords style" });
        }

        public void Print(Ninja ninja)
        {
            ninja.SecretWeapon = "Gun";
            ninja.Attack();
        }

        public void Print(Samurai samurai)
        {
            samurai.SecretWeapon = "Knife";
            samurai.Attack();
        }
    }

    #region -- Demo Class --

    public class Ninja
    {
        public string Name { get; } = "Ninja";
        public string SecretWeapon { get; set; }
        public string Weapon { get; set; }
        public void Attack()
        {
            Console.WriteLine($"{Name}: Attack By {Weapon} & {SecretWeapon}");
        }
    }

    public class Samurai
    {
        public string Name { get; } = "Samurai";
        public string SecretWeapon { get; set; }
        public string Weapon { get; set; }
        public void Attack()
        {
            Console.WriteLine($"{Name}: Attack By {Weapon} & {SecretWeapon}");
        }
    }

    #endregion
}
