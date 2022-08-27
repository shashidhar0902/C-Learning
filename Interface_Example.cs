using System;

namespace App{
    
    interface ICake{
        
        double getPrice(string flavour,int toppings, double siezeinKg);
        
    }
    
    public class CupCake : ICake{
        
        
        public double getPrice(string flavour,int toppings, double siezeinKg){
            if(flavour == "Vanilla"){
                return 100*siezeinKg + 15*toppings*siezeinKg;
            }
            else{
                return 150*siezeinKg + 15*toppings*siezeinKg;
            }
            
        }
        
    }
    public class PiantaCake : ICake{
        public double getPrice(string flavour,int toppings, double siezeinKg){
            if(flavour == "Vanilla"){
                return 250*siezeinKg + 40*toppings*siezeinKg + 100;
            }
            else{
                return 350*siezeinKg + 40*toppings*siezeinKg + 100;
            }
        }
    }
    class HelloWorld {
      static void Main() {
        
        ICake cup = new CupCake();
        var res = cup.getPrice("Vanilla",2,0.5);
        Console.WriteLine(res);
        
      }
}
}
