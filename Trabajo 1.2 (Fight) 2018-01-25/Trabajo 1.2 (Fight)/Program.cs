using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._2__Fight_
{
    class Program
    {
        static void Main(string[] args)
        {
            WeaponBehavior knife = new Knife();
            WeaponBehavior sword = new Sword();
            WeaponBehavior axe = new Axe();
            WeaponBehavior bow = new BowAndArrow();
            Console.WriteLine("The party has grouped for an unforgiving experience.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The king of this land: ");
            String king = Console.ReadLine();
            var Putin = new King();
            Console.Clear();
            Console.WriteLine("His queen:  ");
            String queen = Console.ReadLine();
            var Trump = new Queen();
            Console.Clear();
            Console.WriteLine("And the best knight they have:   ");
            String knight = Console.ReadLine();
            var SirHomes = new Knight();
            Console.Clear();
            Console.WriteLine("Wonder through the woods in search for the monster that has slayed the common folk.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("As they walk on the road to the next village, a huge monster appears in their path.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Troll: You putrid beasts smell of wretched cow dong, such a pest I must eliminate from my land.");
            Console.ReadLine();
            Console.Clear();
            var fourchan = new Troll();
            Console.WriteLine(king + ": Foul beast, as I can sense from your words, you only mean harm to this land and others who traverse this road. As the king I shall slay you, follow me to battle "+knight+"!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(knight + ": For honor and glory!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(queen + ": I shall give you aid from afar my king.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Troll: Bring it on!");
            Console.ReadLine();
            Console.Clear();

            Putin.fight();
            SirHomes.fight();
            Trump.fight();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("(The troll receives damage)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("(But he shakes it off)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Troll: is that all you got?, now is my turn!");
            Console.ReadLine();
            Console.Clear();
            fourchan.fight();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("(The king blocks the attack)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("(The knight weapon breaks)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("(The queen is to far away)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(knight + ": Good thing i got my knife");
            Console.ReadLine();
            Console.Clear();
            SirHomes.setWeapon(knife);
            SirHomes.fight();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(knight + "(the knight climbs the trolls back, and cut his neck wide open)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(queen + ": I thought he would put up a bigger fight");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(king + ": It is beacuse our combined strenght, we can overcome any foe that threatens our land");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The end");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
