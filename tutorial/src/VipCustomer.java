/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author grombor
 */
public class VipCustomer {
    
    private String customerName;
    private String emailAddress;
    private int creditLimit;

    public VipCustomer(){
        this("John Doe", "john@doe.com", 999);
    }

    public VipCustomer(String customerName, String emailAddress) {
        this(customerName, emailAddress, 999);
    }

    public VipCustomer(String customerName, String emailAddress, int creditLimit) {
        this.customerName = customerName;
        this.emailAddress = emailAddress;
        this.creditLimit = creditLimit;
    }

    public String getCustomerName() {
        return customerName;
    }

    public String getEmailAddress() {
        return emailAddress;
    }

    public int getCreditLimit() {
        return creditLimit;
    }
    
    
    
}