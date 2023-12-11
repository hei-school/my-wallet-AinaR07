using System;
using System.Collections.Generic;
using System.Linq;

public class Wallet
{
    private double balance;
    private List<double> transactions;
    private string idCard;
    private string creditCard;
    private string businessCard;
    private string photoID;

    public Wallet()
    {
        balance = 0.0;
        transactions = new List<double>();
        idCard = null;
        creditCard = null;
        businessCard = null;
        photoID = null;
    }

    public void AddTransaction(double amount)
    {
        if (amount >= 0)
        {
            balance += amount;
            transactions.Add(amount);
            Console.WriteLine("Ajouter Argent: " + amount);
        }
        else
        {
            Console.WriteLine("Retrait d'Argent: " + amount);
            balance += amount;
            transactions.Add(amount);
        }
    }

    public string GetBalance()
    {
        return "Solde : " + balance;
    }

    public string GetTransactionHistory()
    {
        var nonZeroTransactions = transactions.Where(transaction => transaction != 0).ToList();
        return "Suivi total des transactions : " + string.Join(", ", nonZeroTransactions);
    }

    public void DeleteTransaction(double amount)
    {
        if (transactions.Contains(amount))
        {
            transactions.Remove(amount);
            Console.WriteLine("Transaction supprimée: " + amount);
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Transaction non trouvée.");
        }
    }

    public string GetTotalExpenses()
    {
        var total = transactions.Where(transaction => transaction < 0).Sum();
        return "Total Dépenses : " + Math.Abs(total);
    }

    public void SetIdentityCard(string name, string birthdate, string occupation)
    {
        idCard = "Carte d'identité: \"" + name + ", " + birthdate + ", " + occupation + "\"";
        Console.WriteLine("Carte d'identité: \"" + name + ", " + birthdate + ", " + occupation + "\"");
    }

    public void SetCreditCard(string card)
    {
        creditCard = card;
        Console.WriteLine("Carte de bancaire de:  \"" + card + "\"");
    }

    public void SetIdCard(string id)
    {
        idCard = id;
        Console.WriteLine("ID Carte: " + id);
    }

    public void SetBusinessCard(string card)
    {
        businessCard = "Nom de la Carte Bancaire : \"" + card + "\"";
        Console.WriteLine("Nom de la Carte Bancaire : \"" + card + "\"");
    }

    public void SetDriverLicense(string name, string birthdate)
    {
        photoID = "Permis de conduire de: \"" + name + ", " + birthdate + "\"";
        Console.WriteLine("Permis de conduire de: \"" + name + ", " + birthdate + "\"");
    }

    public void SetPhotoID(string photo)
    {
        photoID = "Photo ID ajoutée: " + photo;
        Console.WriteLine("Photo ID ajoutée: " + photo);
    }

    public static void Main(string[] args)
    {
        Wallet myWallet = new Wallet();

        myWallet.AddTransaction(10000);
        myWallet.AddTransaction(1500);
        myWallet.AddTransaction(-500);
        myWallet.AddTransaction(-1000);

        myWallet.SetIdCard("1234567890");
        myWallet.SetIdentityCard("Aina Rass", "26/07/1999", "Informaticien");
        myWallet.SetCreditCard("Aina Rass");
        myWallet.SetBusinessCard("Banque BFV.SG");
        myWallet.SetDriverLicense("Aina Rass", "26/07/1999");
        myWallet.SetPhotoID("my_photo.jpg");

        Console.WriteLine(myWallet.GetBalance());
        Console.WriteLine(myWallet.GetTotalExpenses());
        Console.WriteLine(myWallet.GetTransactionHistory());
    }
}
