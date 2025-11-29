namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service");

            Console.Write($"Number of small carpets: ");
            int smallNumber = Convert.ToInt32( Console.ReadLine());
            Console.Write($"Number of large carpets: ");
            int largeNumber = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Price per small room: $25  \nPrice per large room: $35");

            int cost = smallNumber * 25 + largeNumber * 35;
            decimal taxRate = (decimal)(cost * 0.06);
            decimal total = cost  + taxRate;

            Console.WriteLine($"Cost : {cost :c}");
            Console.WriteLine($"Tax: {taxRate :c}");
            Console.WriteLine($"======================\n\nTotal estimate: {total :c}\nThis estimate is valid for 30 days");
            






        } 
        

    }
}
