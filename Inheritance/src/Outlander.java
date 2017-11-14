/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author grombor
 */
public class Outlander extends Car {
    
    private int mot;

    public Outlander(int mot) {
        super(4, 6, 5, false, "Outlander", "big");
        this.mot = mot;
    }
    
    public void Accelerate(int rate){
        int newVelocity = getVelocity() + rate;
        if (newVelocity==0){
            stop();
            changeGear(0);
        }
        else if(newVelocity>0 && newVelocity<10){
            changeGear(1);
        }
        else if(newVelocity>=10 && newVelocity<20){
            changeGear(2);
        }
                else if(newVelocity>0 && newVelocity<10){
            changeGear(1);
        }
        else if(newVelocity>=10 && newVelocity<20){
            changeGear(2);
        }
        else if(newVelocity>=20 && newVelocity<30){
            changeGear(3);
        }
        else if(newVelocity>=30 && newVelocity<40){
            changeGear(4);
        }
        else if(newVelocity>=40 && newVelocity<50){
            changeGear(45);
        }
        if (newVelocity>0){
            changeVelocity(newVelocity, getDirection());
        }
    }
    
}
