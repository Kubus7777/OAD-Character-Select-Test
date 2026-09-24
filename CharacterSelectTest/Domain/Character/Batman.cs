using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;
using System.Security.Cryptography.X509Certificates;

namespace CharacterSelectTest.Domain.Character;

public sealed class Batman : Entity.Character
{
    public Batman(string name) : base(name, CharacterClass.Batman)
    {
        Health = 70;
        Strength = 12;
        Intelligence = 10;
        Agility = 17;
        Aura = 5;
        SigmaLvl = 3;

    }

        public int Mogging()
        {
        SigmaLvl += 30;
        return SigmaLvl;
    }
    
}