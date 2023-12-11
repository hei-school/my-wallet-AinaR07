import java.util.ArrayList;
import java.util.List;

public class Wallet {
    private double balance;
    private List<Double> transactions;
    private String idCard;
    private String creditCard;
    private String businessCard;
    private String photoID;

    public Wallet() {
        balance = 0.0;
        transactions = new ArrayList<>();
        idCard = null;
        creditCard = null;
        businessCard = null;
        photoID = null;
    }

    public void addTransaction(double amount) {
        if (amount >= 0) {
            balance += amount;
            transactions.add(amount);
            System.out.println("Ajouter Argent: " + amount);
        } else {
            System.out.println("Retrait d'Argent: " + amount);
            balance += amount;
            transactions.add(amount);
        }
    }

    public String getBalance() {
        return "Solde : " + balance;
    }

    public String getTransactionHistory() {
        List<Double> nonZeroTransactions = new ArrayList<>();
        for (Double transaction : transactions) {
            if (!transaction.equals(0.0)) {
                nonZeroTransactions.add(transaction);
            }
        }
        return "Suivi total des transactions : " + nonZeroTransactions;
    }

    public void deleteTransaction(double amount) {
        if (transactions.contains(amount)) {
            transactions.remove(amount);
            System.out.println("Transaction supprimée: " + amount);
            balance -= amount;
        } else {
            System.out.println("Transaction non trouvée.");
        }
    }

    public String getTotalExpenses() {
        double total = 0.0;
        for (Double transaction : transactions) {
            if (transaction < 0) {
                total += transaction;
            }
        }
        return "Total Dépenses : " + Math.abs(total);
    }

    public void setIdentityCard(String name, String birthdate, String occupation) {
        this.idCard = "Carte d'identité: \"" + name + ", " + birthdate + ", " + occupation + "\"";
        System.out.println("Carte d'identité: \"" + name + ", " + birthdate + ", " + occupation + "\"");
    }

    public void setCreditCard(String card) {
        this.creditCard = card;
        System.out.println("Carte de bancaire de:  \"" + card + "\"");
    }

    public void setIdCard(String id) {
        this.idCard = id;
        System.out.println("ID Carte: " + id);
    }

    public void setBusinessCard(String card) {
        this.businessCard = "Nom de la Carte Bancaire : \"" + card + "\"";
        System.out.println("Nom de la Carte Bancaire : \"" + card + "\"");
    }

    public void setDriverLicense(String name, String birthdate) {
        this.photoID = "Permis de conduire de: \"" + name + ", " + birthdate + "\"";
        System.out.println("Permis de conduire de: \"" + name + ", " + birthdate + "\"");
    }

    public void setPhotoID(String photo) {
        this.photoID = "Photo ID ajoutée: " + photo;
        System.out.println("Photo ID ajoutée: " + photo);
    }

    public static void main(String[] args) {
        Wallet myWallet = new Wallet();

        myWallet.addTransaction(10000);
        myWallet.addTransaction(1500);
        myWallet.addTransaction(-500);
        myWallet.addTransaction(-1000);

        myWallet.setIdCard("1234567890");
        myWallet.setIdentityCard("Aina Rass", "26/07/1999", "Informaticien");
        myWallet.setCreditCard("Aina Rass");
        myWallet.setBusinessCard("Banque BFV.SG");
        myWallet.setDriverLicense("Aina Rass", "26/07/1999");
        myWallet.setPhotoID("my_photo.jpg");

        System.out.println(myWallet.getBalance());
        System.out.println(myWallet.getTotalExpenses());
        System.out.println(myWallet.getTransactionHistory());
    }
}
