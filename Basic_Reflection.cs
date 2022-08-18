using System;

using System.Reflection;
public class emp{
    public int a {get;set;}
    public emp(int a){
        this.a =a;
    }
    public void Fun(){
        Console.WriteLine("dkjlfa");
    }
}
class kl
{
  
public static void Main ()
  {
    
int i = 42;
    
Type type = i.GetType ();
    
Console.WriteLine (type);

emp e = new emp(1);
Type t = e.GetType();
Console.WriteLine(t);
MethodInfo[] mi = t.GetMethods();
Console.WriteLine(mi[0]);

} 
}
