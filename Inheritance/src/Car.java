/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author grombor
 */
public class Car extends Vehicle {
    
 private int wheels;
 private int gears;
 private int doors;
 private boolean isManual;
    
private int currentGear;

    public Car(int wheels, int gears, int doors, boolean isManual, String name, String size) {
        super(name, size);
        this.wheels = wheels;
        this.gears = gears;
        this.doors = doors;
        this.isManual = isManual;
        this.currentGear = 1;
    }

    public void changeGear(int currentGear) {
        this.currentGear = currentGear;
        System.out.println("Car.setCurrentGear() changed gear to" + this.currentGear);
        
    }

    public void changeVelocity(int speed, int direction){
        move(speed, direction);
        System.out.println("Car.changeVelocity() at speed: " + speed + 
                " and at: " + direction + " direction");
    }
   
    
}
