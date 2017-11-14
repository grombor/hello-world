/**
 *
 * @author grombor
 */

public class Account {
    private int accNumber;
    private String customerName;
    private String emailAddress;
    private int balance;
    private boolean auth=false;
    
    // Calling an empty constructor with default values
    public Account (){
        this(10001,"Default name", "Default email address", 1000);
        System.out.println("Default account created successfully");
    }
    
    // Creating an account for account number, user name and email only
    public Account(String customerName, String emailAddress) {
        this(10002,customerName,emailAddress,1);
    }
    
    // Calling a constructor
    public Account(int accNumber, String customerName, String emailAddress, int balance){
        this.accNumber = accNumber;
        this.customerName = customerName;
        this.emailAddress = emailAddress;
        this.balance = balance;
        System.out.println("Account created successfully");
    }
    
    public void printInfo(){
        System.out.println("An account nnumber is: " + this.accNumber + 
                " customer name is " + this.customerName + 
                " customer email address is: " + this.emailAddress + 
                " and balance is: " + this.balance);
    }
    
    public void withdraw (int amount){
        if (amount <= this.balance){
            setBalance(this.balance-amount);
            System.out.println("Withdrawed " + amount);
            System.out.println("Current balance is " + getBalance());
        }
        else {
            System.out.println("Withdraw failed");
            System.out.println("Not enought founds");
        }
    }
    
    public void deposit (int amount){
        this.balance += amount;
        System.out.println("Added " + amount + " to an account");
    }

    public int getAccNumber() {
        return this.accNumber;
    }

    public void setAccNumber(int accNumber) {
        this.accNumber = accNumber;
    }

    public String getCustomerName() {
        return this.customerName;
    }

    public void setCustomerName(String customerName) {
        this.customerName = customerName;
    }

    public String getEmailAddress() {
        return this.emailAddress;
    }

    public String setEmailAddress(String emailAddress) {
        return this.emailAddress = emailAddress;
    }

    public int getBalance() {
        return this.balance;
    }

    public int setBalance(int balance) {
       return this.balance = balance;
    }

    public boolean getAuth() {
        return this.auth;
    }

    public boolean setAuth(boolean auth) {
        if (true) {
            this.auth = true; 
        }   
        return this.auth = false;
    }
    
}
