public class store
{
    private string store_name; 
    private string store_number;
    public string Name;
    public int Value;
    public store(string store_name, string store_number, string Name, int Value)
    {
        this.store_name = store_name;
        this.store_number = store_number;  
        this.Name = Name;
        this.Value = Value;
    }
    public string Store_Name()
    {
        return store_name;
    }
    public string Store_Number()
    {
        return store_number;
    }
    public int[] exchange(string money)
    {
        float A;
        int[] KJ = new int[10];
        if (float.TryParse(money, out A))
        {
            KJ[0] = (int)Math.Truncate(A / 1000);
            KJ[1] = (int)Math.Truncate((A % 1000) / 500);
            KJ[2] = (int)Math.Truncate(((A % 1000) % 500) / 100);
            KJ[3] = (int)Math.Truncate((((A % 1000) % 500) % 100) / 50);
            KJ[4] = (int)Math.Truncate(((((A % 1000) % 500) % 100) % 50) / 20);
            KJ[5] = (int)Math.Truncate((((((A % 1000) % 500) % 100) % 50) % 20) / 10);
            KJ[6] = (int)Math.Truncate(((((((A % 1000) % 500) % 100) % 50) % 20) % 10) / 2);
            KJ[7] = (int)Math.Truncate((((((((A % 1000) % 500) % 100) % 50) % 20) % 10) % 2) / 1);
            KJ[8] = (int)Math.Truncate(((((((((A % 1000) % 500) % 100) % 50) % 20) % 10) % 2) % 1) / 0.50);
            KJ[9] = (int)Math.Truncate((((((((((A % 1000) % 500) % 100) % 50) % 20) % 10) % 2) % 1) % 0.50) / 0.25);
        }
        else
            throw new Exception("Please input new data.");
        return KJ;
    }
        
}
class Bigbrain
{
    static void Main()
    {
        Console.Write("Please input Name : ");
        string x = Console.ReadLine();
        Console.Write("Please input Number : ");
        string y = Console.ReadLine();
        Console.Write("Please input Owner Name : ");
        string z = Console.ReadLine();
        Console.Write("Please input Registered Value : ");
        int p = int.Parse(Console.ReadLine());

        store store1 = new store(x,y,z,p);

        Console.WriteLine("—--------- Shop Information —---------");
        Console.WriteLine("Name : {0}",store1.Store_Name());
        Console.WriteLine("Number : {0}", store1.Store_Number());
        Console.WriteLine("Owner Name : {0}", store1.Name);
        Console.WriteLine("Registered Value : {0}", store1.Value);
        Console.WriteLine("—-----------------------------------------------------");
        
        Console.Write("Please input money : ");
        
        string money = Console.ReadLine();

        int[]output = store1.exchange(money);
        Console.WriteLine("1000 : {0}", output[0]);
        Console.WriteLine("500 : {0}", output[1]);
        Console.WriteLine("100 : {0}", output[2]);
        Console.WriteLine("50 : {0}", output[3]);
        Console.WriteLine("20 : {0}", output[4]);
        Console.WriteLine("10 : {0}", output[5]);
        Console.WriteLine("2 : {0}", output[6]);
        Console.WriteLine("1 : {0}", output[7]);
        Console.WriteLine("0.50 : {0}", output[8]);
        Console.WriteLine("0.25 : {0}", output[9]);
    }
}