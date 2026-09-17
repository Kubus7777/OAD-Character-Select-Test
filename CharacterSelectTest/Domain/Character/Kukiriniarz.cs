using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Kukiriniarz : Entity.Character
{
    public Kukiriniarz(string name) : base(name, CharacterClass.Kukiriniarz)
    {
        Health = 110;
        Strength = 5;
        Intelligence = 3;
        Agility = 25;
    }
}