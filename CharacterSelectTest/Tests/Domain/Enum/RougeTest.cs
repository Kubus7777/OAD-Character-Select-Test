using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class RogueTest
{
    [TestMethod]
    public void TestRogueCreation()
    {
        var rogue = new Rogue("Rogue");

        Assert.IsNotNull(rogue);
    }

    [TestMethod]
    public void TestRogueStats()
    {
        var rogue = new Rogue("Rogue");

        Assert.AreEqual(80, rogue.Health);
        Assert.AreEqual(10, rogue.Strength);
        Assert.AreEqual(16, rogue.Intelligence);
        Assert.AreEqual(20, rogue.Agility);
    }

    [TestMethod]
    public void TestRogueAura()
    {
        var rogue = new Rogue("Rogue");

        Assert.AreEqual(4, rogue.Aura);
        Assert.AreEqual(6, rogue.SigmaLvl);

    }

    [TestMethod]
    public void TestRogueIziBust()
    {
        var rogue = new Rogue("Rogue");
        Assert.AreEqual(22, rogue.StealthAttack());

    }

    [TestMethod]
    public void TestRogueAttack()
    {
        var rogue = new Rogue("Rogue");

        Assert.AreEqual(27, rogue.Attack());
    }
}