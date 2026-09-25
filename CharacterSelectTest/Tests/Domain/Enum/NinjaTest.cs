using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class NinjaTest
{
    [TestMethod]
    public void TestNinjaCreation()
    {
        var ninja = new Ninja("Ninja");

        Assert.IsNotNull(ninja);
    }

    [TestMethod]
    public void TestNinjaStats()
    {
        var ninja = new Ninja("Ninja");

        Assert.AreEqual(80, ninja.Health);
        Assert.AreEqual(10, ninja.Strength);
        Assert.AreEqual(16, ninja.Intelligence);
        Assert.AreEqual(20, ninja.Agility);
    }

    [TestMethod]
    public void TestNinjaAura()
    {
        var ninja = new Ninja("Ninja");

        Assert.AreEqual(3, ninja.Aura);
        Assert.AreEqual(5, ninja.SigmaLvl);

    }

    [TestMethod]
    public void TestNinjaIziBust()
    {
        var ninja = new Ninja("Ninja");
        Assert.AreEqual(30, ninja.spinjitsu());

    }

    [TestMethod]
    public void TestNinjaAttack()
    {
        var ninja = new Ninja("Ninja");

        Assert.AreEqual(30, ninja.Attack());
    }
}