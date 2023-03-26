namespace BankTest;
using BankAccount;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int expected1 = 6;
        int expected2 = 4;
        BankAccount ba = new BankAccount(1, "Zainab");
        ba.Credit(5);
        ba.Debit(5);
        Assert.AreEqual(expected1, ba.GetBalance());
        Assert.AreEqual(expected2, ba.GetBalance());
    }
}