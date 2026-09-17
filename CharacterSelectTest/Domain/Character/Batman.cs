using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Batman : Entity.Character
{
    public Batman(string name) : base(name, CharacterClass.Batman)
    {
        Health = 70;
        Strength = 12;
        Intelligence = 10;
        Agility = 17;
    }
}