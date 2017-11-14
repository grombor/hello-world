
import java.time.Clock;
import sun.rmi.runtime.Log;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author grombor
 */
public class Main {
    public static void main (String[] args){
    
        /** Car porsche = new Car();
        Car uno = new Car();
        
        porsche.setModel("Carrera");
        **/
        
        // Variables
        int amount=100;
        
        // Set default customer details
        Account acc = new Account();
       
        // Deposit method
        acc.deposit(100);
        // Withdraw method
        acc.withdraw(5000);
        // print info
        acc.printInfo();
        
        System.out.println();
        
        // Set up Bob's account
        Account bob = new Account(9001, "Bob", "bob@bob.com", 99);
        
        // Set up Tim  account
        Account tim = new Account("Tim", "tim@yahoo.com");
        
        //*************//
        System.out.println("");
        
        // Setting up a default VIP customer account
        VipCustomer vipDefault = new VipCustomer();
        
        //Checking getters
        System.out.println("Credit limit is: " +vipDefault.getCreditLimit());
        System.out.println("VIP name: " +vipDefault.getCustomerName());
        System.out.println("Customer email address: " +vipDefault.getEmailAddress());
        
        // Creating VIP Jay's account
        VipCustomer jay = new VipCustomer("Jay Williams", "jay@jaywilliams.com", 1999);
        
        // Setting up fast account with default credit limit
        VipCustomer Martin = new VipCustomer("Martin Bowler", "mbowler@atime.co.uk");

    }
    
  

}
