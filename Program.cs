using System;

namespace Memento_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new Document();
            var his = new DocumentHistory();
            doc.Content = "Testing Memento Pattern!";

            his.Push(doc.CreateState());
            doc.FontName = "TimeNewRoman";
            his.Push(doc.CreateState());
            Console.WriteLine(doc);

            doc.Restore(his.Pop);
            Console.WriteLine(doc);
        }
    }
}
