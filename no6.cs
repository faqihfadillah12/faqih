using System; 

    class no6
    {
        static void Main(string[] args){
        Console.WriteLine("n = 7");
        
        int[] a = {1, 5};
        int[] b = {13, 17};
        int[] c = {25};
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