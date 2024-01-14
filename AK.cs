int NumberSpell;
int RandomPoints;

Random numberGen = new Random();
RandomPoints = numberGen.Next(1,11);

Console.WriteLine("How many times, would you like to run your spell?(be careful, you have randomly generated spell points, so you might go over your spellpoints, resulting in the remaining experience gained from spells amounting to 0)");
NumberSpell = Convert.ToInt32(Console.ReadLine());


Wizard AK = new Wizard();
AK.name = "AK";
AK.age = 1000;
AK.spell = "fire";
AK.SpellPoints = RandomPoints;

while (NumberSpell > 0)
{
    NumberSpell--;
    AK.Spellcast();
}

Console.ReadKey();

class Wizard
{
    public string name;
    public int age;
    public string spell;
    public int SpellPoints;
    public int experience;
    public int ExpPoints;
    public void Spellcast()
    {
        if (SpellPoints > 0) 
        {
            Random numberGen = new Random();
            ExpPoints = numberGen.Next(1,101);

            Console.WriteLine(name + " casts " + spell + " on you.");
            SpellPoints--;
            experience += ExpPoints;
            Console.WriteLine("Your spell " + spell + " killed an enemy. Because of this, you got " + ExpPoints + " exp points. You now have " + SpellPoints + " Spellpoints");
            Console.WriteLine("Your total experience Level is now at " + experience + " experience");
        } else 
        {
            Console.WriteLine("Sorry, you have no more spellpoints left to continue this operation.");
        }
        
    }
}









