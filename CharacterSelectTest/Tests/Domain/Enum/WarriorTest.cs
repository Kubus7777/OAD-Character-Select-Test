using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class WarriorTest
{
    [TestMethod]
    public void TestWarriorCreation()
    {
        var warrior = new Warrior("Warrior");

        Assert.IsNotNull(warrior);
    }

    [TestMethod]
    public void TestWarriorStats()
    {
        var warrior = new Warrior("Warrior");

        Assert.AreEqual(120, warrior.Health);
        Assert.AreEqual(10, warrior.Strength);
        Assert.AreEqual(16, warrior.Intelligence);
        Assert.AreEqual(20, warrior.Agility);
    }

    [TestMethod]
    public void TestWarriorAura()
    {
        var warrior = new Warrior("Warrior");

        Assert.AreEqual(2, warrior.Aura);
        Assert.AreEqual(4, warrior.SigmaLvl);

    }

    [TestMethod]
    public void TestWarriorIziBust()
    {
        var warrior = new Warrior("Warrior");
        Assert.AreEqual(24, warrior.PowerStrike());

    }
    [TestMethod]
    public void TestWarriorAttack()
    {
        var warrior = new Warrior("Warrior");

        Assert.AreEqual(42, warrior.Attack());
    }
}