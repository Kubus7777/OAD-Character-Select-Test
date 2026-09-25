using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Warrior : Entity.Character
{
    public Warrior(string name) : base(name, CharacterClass.Warrior)
    {
        Health = 120;
        Strength = 14;
        Intelligence = 6;
        Agility = 8;
        Aura = 2;
        SigmaLvl = 4;

    }
    public int PowerStrike()
    {
        Strength += 10;
        return Strength;
    }

    public int Attack()
    {
        return Strength * 3;
    }
}