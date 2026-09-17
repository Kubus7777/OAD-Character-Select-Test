using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Ninja : Entity.Character
{
    public Ninja(string name) : base(name, CharacterClass.Ninja)
    {
        Health = 80;
        Strength = 10;
        Intelligence = 16;
        Agility = 20;
    }
}