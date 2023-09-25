using System;
using System.Collections.Generic;
using System.IO;
using _219003234_Naidoo_KN_CC;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace _219003234_Parser
{

    class Program
    {

        static string ReadTextFromFile(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                return content;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                return null;
            }
        }


        static void Main(string[] args)
        {
            //scanner start
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string dataFolderPath = Path.Combine(projectDirectory, "sample programs");
            string filename = "sample8.txt";
            bool continuee = true;
            // ParsingTable parsingTable1 = new ParsingTable();
            while (continuee == true)
            {
                Console.WriteLine("Enter number to load file from 1 to 8 (any other input will result in file 8 being loaded):");
                string fileNumber = Console.ReadLine();

                switch (fileNumber)
                {
                    case "1":
                        filename = "sample1.txt";
                        break;
                    case "2":
                        filename = "sample2.txt";
                        break;
                    case "3":
                        filename = "sample3.txt";
                        break;
                    case "4":
                        filename = "sample4.txt";
                        break;
                    case "5":
                        filename = "sample5.txt";
                        break;
                    case "6":
                        filename = "sample6.txt";
                        break;
                    case "7":
                        filename = "sample7.txt";
                        break;
                    case "8":
                        filename = "sample8.txt";
                        break;
                    default:
                        filename = "sample8.txt";
                        break;
                }

                string filePath = Path.Combine(dataFolderPath, filename);
                Console.WriteLine(filePath);

                string input = ReadTextFromFile(filePath);

                // Print the contents from the file to the screen
                Console.WriteLine(input);
                Console.WriteLine("\n");

                // Create an instance of the Scanner class and tokenize the input
                Scanner scanner = new Scanner();
                List<Token> tokens = scanner.Tokenize(input);
                var inputTokens = new List<string>();
                // Print out the type and lexeme pairs from the tokenized input
                foreach (Token token in tokens)
                {
                    //Console.WriteLine($"Type: {token.Type}, Lexeme: {token.Lexeme}");
                    // Console.WriteLine(token.Lexeme +" = " + token.Type);
                    //Console.WriteLine(token.Lexeme + " = " + token.Type + " ");
                    Console.WriteLine(token.Type + " ");
                    inputTokens.Add(token.Type);
                    //Console.WriteLine(token.Type);
                }

            }



            //scanner end
/*            Console.WriteLine("Enter an expression: ");
            string input = Console.ReadLine();

            ICharStream stream = new AntlrInputStream(input);
            RecipeLanguageLexer lexer = new RecipeLanguageLexer(stream); // Replace with your lexer class nam
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            RecipeLanguageParser parser = new RecipeLanguageParser(tokens); // Replace with your parser class name

            IParseTree tree = parser.recipe(); // Replace 'start' with your entry rule name
            Console.WriteLine("Parse tree: " + tree.ToStringTree(parser));
  */
            }
    }
}
