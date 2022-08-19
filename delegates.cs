using System;
using kri;
class HelloWorld {
    
    delegate void NC(int k);
    delegate int SU(int k,int u);
    delegate bool CE(int k);
    
    static void Main() {
        
        A a = new A();
        
        NC nc = delegate(int m){
            Console.WriteLine("jaffa");
        };
        nc(9);
        
        SU k = (e,r) => {return e+r;};
        int l = k.Invoke(90,90);
        Console.WriteLine(l);
        
        CE ce = (m) => m%2==0;
        Console.WriteLine(ce(9));
        
  }
}
