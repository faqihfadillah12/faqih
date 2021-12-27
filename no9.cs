using System; 

    class no9
    {
        static void Main(string[] args){
        Console.WriteLine("n = 7");
        
        int[] a = {4, 16};
        int[] b = {64, 256};
        int[] c = {1024};
        for(int x=0; x < a.Length; x++)
        {
        Console.Write(a[x]+" ");
        Console.Write(" * ");

        }
        for(int x=0; x < b.Length; x++)
        {
        Console.Write(b[x]+" "); 
        }
        for(int x=0; x < c.Length; x++)
        {
        Console.Write(" * ");
        Console.Write(c[x]+" ");  
        }
        Console.ReadLine();
        
    }
} 