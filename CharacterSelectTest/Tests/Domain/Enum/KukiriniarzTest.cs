using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class KukiriniarzTest
{
    [TestMethod]
    public void TestKukiriniarzCreation()
    {
        var kukiriniarz = new Kukiriniarz("Kukiriniarz");

        Assert.IsNotNull(kukiriniarz);
    }

    [TestMethod]
    public void TestKukiriniarzStats()
    {
        var Kukiriniarz = new Kukiriniarz("Kukiriniarz");

        Assert.AreEqual(110, Kukiriniarz.Health);
        Assert.AreEqual(5, Kukiriniarz.Strength);
        Assert.AreEqual(3, Kukiriniarz.Intelligence);
        Assert.AreEqual(25, Kukiriniarz.Agility);
    }

    [TestMethod]
    public void TestKukiriniarzAura()
    {
        var Kukiriniarz = new Kukiriniarz("Kukiriniarz");

        Assert.AreEqual(1, Kukiriniarz.Aura);
        Assert.AreEqual(6, Kukiriniarz.SigmaLvl);

    }

    [TestMethod]
    public void TestKukiriniarzIziBust()
    {
        var Kukiriniarz = new Kukiriniarz("Kukiriniarz");
        Assert.AreEqual(6, Kukiriniarz.AuraBoost());

    }
}