using NUnit.Framework;
using DateFormat;
namespace Library.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestParte1()
    {
        string test1Date = "19/04/2022";
        string res = Program.ChangeFormat(test1Date);

        Assert.AreEqual("2022-04-19",res);
    }

    [Test]
    public void TestParte2()
    {
        string test1Date = "19/04/2022";
        string res = Program.ChangeFormat2(test1Date);

        Assert.AreEqual("19.04.2022",res);
    }
}