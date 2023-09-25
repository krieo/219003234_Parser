using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace _219003234_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an expression: ");
            string input = Console.ReadLine();

            ICharStream stream = new AntlrInputStream(input);
            SimpleCalcLexer lexer = new SimpleCalcLexer(stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            SimpleCalcParser parser = new SimpleCalcParser(tokens);

            IParseTree tree = parser.start();
            Console.WriteLine("Parse tree: " + tree.ToStringTree(parser));
        }
    }
}
