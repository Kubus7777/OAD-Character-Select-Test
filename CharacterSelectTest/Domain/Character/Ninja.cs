using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;
using System.Security.Cryptography.X509Certificates;

namespace CharacterSelectTest.Domain.Character;

public sealed class Ninja : Entity.Character
{
    public Ninja(string name) : base(name, CharacterClass.Ninja)
    {
        Health = 80;
        Strength = 10;
        Intelligence = 16;
        Agility = 20;
        Aura = 3;
        SigmaLvl = 5;
    }

        public int spinjitsu()
        {
            Agility += 10;
            return Agility;
            
        }
    
}