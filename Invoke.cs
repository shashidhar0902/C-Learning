using System;

using System.Reflection;

class Rect{
    
    public double GetArea(double l,double b){
        return l*b;
    }
    
}

class HelloWorld {
    
  static void Main() {
      
    Rect re = new Rect();
    object[] ob = new object[2];
    ob[0] = 2;
    ob[1] = 4;
    Type t = re.GetType();
    
    MethodInfo mi = t.GetMethod("GetArea");
    int len = mi.GetParameters().Length;
    Console.WriteLine($"Length: {len}");
    double area = (double)mi.Invoke(re,ob);
    Console.WriteLine("Area : {0}",area);
    
  }
}
