namespace QA;
class Program
{
    static void Main(string[] args)
    {
    }
   
}
public class Bank
{
    private double balance;
    private string name;

    public Bank(double balance, string name)
    {
        this.balance = balance;
        this.name = name;
    }
    public double Balance { get => balance; set => balance = value; }
    public string Name { get => name; set => name = value; }

    public void Credit(double amount)
    {
        if (amount <= 0)
            throw new Exception(string.Format("balance less than 0"));
        else
        {
            this.balance -= amount;
            Console.WriteLine("credit done");
        }
    }
    public void Debit(double amount)
    {
        if (this.balance - amount <= 0)
            throw new Exception(string.Format("balance less than 0"));
        else
        {
            this.balance -= amount;
            Console.WriteLine("debit done");
        }
    }
}

