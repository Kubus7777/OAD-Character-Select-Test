using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class BatmanTest
{
    [TestMethod]
    public void TestBatmanCreation()
    {
        var Batman = new Batman("Batman");

        Assert.IsNotNull(Batman);
    }

    [TestMethod]
    public void TestBatmanStats()
    {
        var Batman = new Batman("Batman");

        Assert.AreEqual(70, Batman.Health);
        Assert.AreEqual(12, Batman.Strength);
        Assert.AreEqual(10, Batman.Intelligence);
        Assert.AreEqual(17, Batman.Agility);
    }

    [TestMethod]
    public void TestBatmanAura()
    {
        var Batman = new Batman("Batman");

        Assert.AreEqual(5, Batman.Aura);
        Assert.AreEqual(3, Batman.SigmaLvl);

    }

    [TestMethod]
    public void TestBatmanIziBust()
    {
        var Batman = new Batman("Batman");
        Assert.AreEqual(33, Batman.Mogging());

    }
    [TestMethod]
    public void TestBatmanAttack()
    {
        var Batman = new Batman("Batman");

        Assert.AreEqual(36, Batman.Attack());
    }
}