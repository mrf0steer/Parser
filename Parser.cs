using HtmlAgilityPack;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            INPUT input = new INPUT();

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(input.HTML);

            var order_id = htmlDoc.DocumentNode.SelectSingleNode("main/article/span[2]/div/span");

            Console.WriteLine(order_id.InnerText);

        }
            
    }
}

