/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author grombor
 */
public class Vehicle {
    
    private String name;
    private String size;
    private int Velocity;
    private int Direction;

    public Vehicle(String name, String size) {
        this.name = name;
        this.size = size;
        this.Velocity = 0;
        this.Direction = 0;
    }
    
   public void steering(int direction) {
       this.Direction += direction;
       System.out.println("Vehicle.steering() at " + this.Direction + " direction");
   }
   
   public void move (int velocity, int direction){
       Velocity = velocity;
       Direction = direction;
       System.out.println("Vehicle.move() at" + Direction + " with speed of" + Velocity);
   }
   
   public void stop(){
       Velocity=0;
   }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getSize() {
        return size;
    }

    public void setSize(String size) {
        this.size = size;
    }

    public int getVelocity() {
        return Velocity;
    }

    public void setVelocity(int Velocity) {
        this.Velocity = Velocity;
    }

    public int getDirection() {
        return Direction;
    }

    public void setDirection(int Direction) {
        this.Direction = Direction;
    }
    
   
   
}
