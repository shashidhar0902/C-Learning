using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;

class HelloWorld {
  static void Main() {
  
    FileStream fs = new FileStream("info.txt",FileMode.Append,FileAccess.Write);
    
    //to avoid bytes conversion StreamWriter is used
    
    StreamWriter sw = new StreamWriter(fs);
    string s = "keradfarbhcv ahdsbvh";
    
    sw.WriteLine(s);
    sw.Flush();
    sw.Close();

  }
}
