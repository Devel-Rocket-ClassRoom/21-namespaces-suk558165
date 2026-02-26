using MyGame.Characters;
using MyGame.Items;
using System;
using System.Xml.Linq;

Console.WriteLine("=== 캐릭터 시스템 ===");
Player player = new Player { Name = "용사" };
Enemy enemy = new Enemy { Name = "고블린" };

player.Attack();
enemy.TakeDamage();

Console.WriteLine("\n=== 아이템 시스템 ===");
// === 아이템 시스템 ===
Weapon sword = new Weapon { Name = "불꽃검" };
Potion hpPotion = new Potion { Name = "체력 포션" };
Console.WriteLine($"무기 {sword.Name}의 공격력: {sword.GetDamage()}");
hpPotion.Use();

namespace MyGame.Characters
{
    public class Player
    {
        public string Name = "용사";
        public void Attack() => Console.WriteLine($"플레이어 {Name}(이)가 공격합니다!");
    }
    public class Enemy
    {
        public string Name = "고블린";
        public void TakeDamage() => Console.WriteLine($"적{Name}(이)가 데미지를 받았습니다!");
    }
}
namespace MyGame.Items
{
    public class Weapon
    {
        public string Name = "불꽃검";
        public int Damage = 50;
        public int GetDamage() => Damage;
    }

        public class Potion
        {
            public string Name = "체력 포션";
            public void Use() => Console.WriteLine($"포션 {Name}을(를) 사용했습니다");
        }
    }








