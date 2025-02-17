using System;

class Program
{
    static void Main(string[] args) {
      const int buffer_size = 10;
      char[] buf = new char[buffer_size];

      if(args.Length == 0) {
        Console.WriteLine("Args no");
         return
      }

      foreach(var arg in args)
      {
        try{
            if(arg.Length > buffer_size){
                throw ex OverflowException("Very long String");
            }
            for(int i = 0; i < arg.Length; i++){
                buf[i] = arg[i];
            }
            Console.WriteLine($"buf super {new string(buf, 0, arg.Length)}");
        }
        catch(OverflowException ex) {
            Console.WriteLine(ex.Message)
        }
      }
     
    }
}

//