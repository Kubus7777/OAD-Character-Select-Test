using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class MageTest
{
    [TestMethod]
    public void TestMageCreation()
    {
        var mage = new Mage("Mage");

        Assert.IsNotNull(mage);
    }

    [TestMethod]
    public void TestMageStats()
    {
        var mage = new Mage("Mage");

        Assert.AreEqual(60, mage.Health);
        Assert.AreEqual(10, mage.Strength);
        Assert.AreEqual(16, mage.Intelligence);
        Assert.AreEqual(20, mage.Agility);
    }

    [TestMethod]
    public void TestMageAura()
    {
        var mage = new Mage("Mage");

        Assert.AreEqual(6, mage.Aura);
        Assert.AreEqual(8, mage.SigmaLvl);

    }

    [TestMethod]
    public void TestMageIziBust()
    {
        var mage = new Mage("Mage");
        Assert.AreEqual(21, mage.CzaryMary());

    }
}