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
        Outlander outlander = new Outlander(5);
        outlander.Accelerate(20);
        outlander.steering(25);
        outlander.Accelerate(40);
        outlander.Accelerate(-50);
    }
}
