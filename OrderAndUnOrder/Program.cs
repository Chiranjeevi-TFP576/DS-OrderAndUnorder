namespace OrderAndUnOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            OrderList orderList = new OrderList();

            Console.WriteLine("Enter word to search");
            string word = Console.ReadLine();
            orderList.Ordered(word);

        }
    }
}