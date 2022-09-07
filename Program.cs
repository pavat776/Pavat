class store
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
    public void exchange()
    {
        Console.Write("Please input money : ");
        float money = 0;
        if (float.TryParse(Console.ReadLine(), out money))
        {
            Console.WriteLine("1000 : {0}", Math.Truncate(money / 1000));
            Console.WriteLine("500 : {0}", Math.Truncate((money % 1000) / 500));
            Console.WriteLine("100 : {0}", Math.Truncate(((money % 1000) % 500) / 100));
            Console.WriteLine("50 : {0}", Math.Truncate((((money % 1000) % 500) % 100) / 50));
            Console.WriteLine("20 : {0}", Math.Truncate(((((money % 1000) % 500) % 100) % 50) / 20));
            Console.WriteLine("10 : {0}", Math.Truncate((((((money % 1000) % 500) % 100) % 50) % 20) / 10));
            Console.WriteLine("2 : {0}", Math.Truncate(((((((money % 1000) % 500) % 100) % 50) % 20) % 10) / 2));
            Console.WriteLine("1 : {0}", Math.Truncate((((((((money % 1000) % 500) % 100) % 50) % 20) % 10) % 2) / 1));
            Console.WriteLine("0.50 : {0}", Math.Truncate(((((((((money % 1000) % 500) % 100) % 50) % 20) % 10) % 2) % 1) / 0.50));
            Console.WriteLine("0.25 : {0}", Math.Truncate((((((((((money % 1000) % 500) % 100) % 50) % 20) % 10) % 2) % 1) % 0.50) / 0.25));
        }
        else
            throw new Exception("Please input new data.");
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

        Console.WriteLine("—--------- Shop Information —-----");
        Console.WriteLine("Name : {0}",store1.Store_Name());
        Console.WriteLine("Number : {0}", store1.Store_Number());
        Console.WriteLine("Owner Name : {0}", store1.Name);
        Console.WriteLine("Registered Value : {0}", store1.Value);
        Console.WriteLine("—-----------------------------------------------------");

        store1.exchange();
    }
}

