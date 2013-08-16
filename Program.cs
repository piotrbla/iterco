using System;
using System.IO;

namespace icsc
{
    class Program
    {
        private readonly MainParser m_mainParser = new MainParser();

        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("No parameters");
                return;
            }
            MainParser.OneFileCodeModification(File.ReadAllText(args[0]));
        }
    }
}
