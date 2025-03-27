namespace GithubActionsLab;

[TestClass]
public class Addition
{
    [TestMethod]
    public void Add_Valid_Wilson()
    {
        Assert.AreEqual(3, Program.Add("1", "2"));
        Assert.AreEqual(5, Program.Add("3", "2"));
        Assert.AreEqual(12, Program.Add("5", "7"));
    }

    [TestMethod]
    public void Add_Invalid_Wilson()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
    }

    [TestMethod]
    public void Add_Null_Wilson()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
    }
}

[TestClass]
public class Subtraction
{
    [TestMethod]
    public void Subtract_Valid_Wilson()
    {
        Assert.AreEqual(1, Program.Subtract("2", "1"));
        Assert.AreEqual(4, Program.Subtract("5", "1"));
        Assert.AreEqual(3, Program.Subtract("8", "5"));
    }

    [TestMethod]
    public void Subtract_Invalid_Wilson()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }

    [TestMethod]
    public void Subtract_Null_Wilson()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }
}

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Subtract_Valid_Wilson()
    {
        Assert.AreEqual(1, Program.Multiply("1", "1"));
        Assert.AreEqual(4, Program.Multiply("2", "2"));
        Assert.AreEqual(12, Program.Multiply("3", "4"));
    }

    [TestMethod]
    public void Subtract_Invalid_Wilson()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
    }

    [TestMethod]
    public void Subtract_Null_Wilson()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }
}