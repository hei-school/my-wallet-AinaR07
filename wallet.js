class Wallet {
    constructor() {
        this.balance = 0.0;
        this.transactions = [];
        this.idCard = null;
        this.creditCard = null;
        this.businessCard = null;
        this.photoID = null;
    }

    addTransaction(amount) {
        if (amount >= 0) {
            this.balance += amount;
            this.transactions.push(amount);
            console.log(`Ajouter Argent: ${amount}`);
        } else {
            console.log(`Retrait d'Argent: ${amount}`);
            this.balance += amount;
            this.transactions.push(amount);
        }
    }

    getBalance() {
        return `Solde : ${this.balance}`;
    }

    getTransactionHistory() {
        return `Suivi total des transactions : ${this.transactions.filter(transaction => transaction !== 0)}`;
    }

    deleteTransaction(amount) {
        const index = this.transactions.indexOf(amount);
        if (index > -1) {
            this.transactions.splice(index, 1);
            console.log(`Transaction supprimée: ${amount}`);
            this.balance -= amount;
        } else {
            console.log("Transaction non trouvée.");
        }
    }

    getTotalExpenses() {
        const total = this.transactions.reduce((acc, transaction) => acc + (transaction < 0 ? transaction : 0), 0);
        return `Total Dépenses : ${Math.abs(total)}`;
    }


    setIdentityCard(name, birthdate, occupation) {
        this.identityCard = `Carte d'identité: "${name}, ${birthdate}, ${occupation}"`;
        console.log(`Carte d'identité: "${name}, ${birthdate}, ${occupation}"`);
    }

    setCreditCard(card) {
        this.creditCard = card;
        console.log(`Carte de bancaire de:  "${card}"`);
    }

    setIdCard(id) {
        this.idCard = id;
        console.log(`ID Carte: ${id}`);
    }

    setBusinessCard(card) {
        this.businessCard = `Nom de la Carte Bancaire : "${card}"`;
        console.log(`Nom de la Carte Bancaire : "${card}"`);
    }

    setDriverLicense(name, birthdate) {
        this.driverLicense = `Permis de conduire de: "${name}, ${birthdate}"`;
        console.log(`Permis de conduire de: "${name}, ${birthdate}"`);
    }

    setPhotoID(photo) {
        this.photoID = `Photo ID ajoutée: ${photo}`;
        console.log(`Photo ID ajoutée: ${photo}`);
    }
}


// Création d'une instance de Wallet
const myWallet = new Wallet();

// Ajout de quelques transactions
myWallet.addTransaction(10000);
myWallet.addTransaction(1500);
myWallet.addTransaction(-500);
myWallet.addTransaction(-1000);

// Ajout de cartes et d'une photo d'identité
myWallet.setIdCard("1234567890");
myWallet.setIdentityCard("Aina Rass", "26/07/1999", "Informaticien");
myWallet.setCreditCard("Aina Rass");
myWallet.setBusinessCard("Banque BFV.SG");
myWallet.setDriverLicense("Aina Rass", "26/07/1999");
myWallet.setPhotoID("my_photo.jpg");

// Affichage des informations
console.log(myWallet.getBalance());
console.log(myWallet.getTotalExpenses());
console.log(myWallet.getTransactionHistory());
