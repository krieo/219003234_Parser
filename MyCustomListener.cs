using System;
using System.Collections.Generic;
using Antlr4.Runtime.Misc;

namespace _219003234_Parser
{
    public class MyCustomListener : RecipeLanguageBaseListener
    {

        private string askInput = "";
        // Declare the dictionary
        Dictionary<string, object> variablesString = new Dictionary<string, object>();
        Dictionary<string, object> variablesInteger = new Dictionary<string, object>();
        Dictionary<string, object> variablesFloat = new Dictionary<string, object>();

        public override void EnterProgram([NotNull] RecipeLanguageParser.ProgramContext context)
        {
            
            Console.WriteLine("EnterProgram");
        }

        public override void ExitProgram([NotNull] RecipeLanguageParser.ProgramContext context)
        {
            Console.WriteLine("ExitProgram");
        }

        public override void EnterStatement([NotNull] RecipeLanguageParser.StatementContext context)
        {
            Console.WriteLine("EnterStatement");
        }

        public override void ExitStatement([NotNull] RecipeLanguageParser.StatementContext context)
        {
            Console.WriteLine("ExitStatement");
        }

        //   public override void EnterAskStatement([NotNull] RecipeLanguageParser.AskStatementContext context)
        //  {
        //     Console.WriteLine("EnterAskStatement");
        //  }

        /// <summary>
        /// This method performs the ask statement which is essentially console.readline
        /// </summary>
        /// <param name="context"></param>
        public override void EnterAskStatement([NotNull] RecipeLanguageParser.AskStatementContext context)
        {
            Console.WriteLine("EnterAskStatement");
            string variableName = context.ID().GetText(); // Get the variable name

            // Prompt the user for input
            Console.Write($"Enter a value for '{variableName}': ");

            // Read the user's input
            string userInput = Console.ReadLine();

            // Determine the variable type and store the input value accordingly
            if (variablesString.ContainsKey(variableName))
            {
                variablesString[variableName] = userInput; // Update the string variable
            }
            else if (variablesInteger.ContainsKey(variableName))
            {
                int intValue;
                if (int.TryParse(userInput, out intValue))
                {
                    variablesInteger[variableName] = intValue; // Update the integer variable
                }
                else
                {
                    Console.WriteLine($"Error: Input is not a valid integer for '{variableName}'.");
                }
            }
            else if (variablesFloat.ContainsKey(variableName))
            {
                float floatValue;
                if (float.TryParse(userInput, out floatValue))
                {
                    variablesFloat[variableName] = floatValue; // Update the float variable
                }
                else
                {
                    Console.WriteLine($"Error: Input is not a valid float for '{variableName}'.");
                }
            }
            else
            {
                Console.WriteLine($"Error: Variable '{variableName}' not found.");
            }
        }

        public override void ExitAskStatement([NotNull] RecipeLanguageParser.AskStatementContext context)
        {
            Console.WriteLine("ExitAskStatement");
        }

        public override void EnterDeclaration([NotNull] RecipeLanguageParser.DeclarationContext context)
        {
            Console.WriteLine("EnterDeclaration");
        }

        public override void ExitDeclaration([NotNull] RecipeLanguageParser.DeclarationContext context)
        {
            Console.WriteLine("ExitDeclaration");
        }

        /// <summary>
        /// This method is used to create variables
        /// </summary>
        /// <param name="context"></param>
        public override void EnterIngredientDeclaration([NotNull] RecipeLanguageParser.IngredientDeclarationContext context)
        {
            Console.WriteLine("EnterIngredientDeclaration");

            //This is used to store integer variables in a list
            if (context.INTEGER() != null)
            {
                Console.WriteLine(context.INTEGER().GetText() + " THIS IS THE INTEGER ===========================================");
                Console.WriteLine(context.ID().GetText() + " THIS IS THE id ===========================================");
                //This checks if the variable is in the dictionary if its not it adds the entry if it is it shows an error
                if (!variablesInteger.ContainsKey(context.ID().GetText()))
                {
                    variablesInteger.Add(context.ID().GetText(), 0);
                    Console.WriteLine($"Variable '{context.ID().GetText()}' added with value: {0}");
                }
                else
                {
                    Console.WriteLine($"Error: Variable '{context.ID().GetText()}' already exists.");
                }

            }

            //This is used to store string variables in a list
            if (context.STRING() != null)
            {
                Console.WriteLine(context.STRING().GetText() + " THIS IS THE STRING ===========================================");
                Console.WriteLine(context.ID().GetText() + " THIS IS THE id ===========================================");
                //This checks if the variable is in the dictionary if its not it adds the entry if it is it shows an error
                if (!variablesString.ContainsKey(context.ID().GetText()))
                {
                    variablesString.Add(context.ID().GetText(), "empty variable");
                    Console.WriteLine($"Variable '{context.ID().GetText()}' added with value: {"empty variable"}");
                }
                else
                {
                    Console.WriteLine($"Error: Variable '{context.ID().GetText()}' already exists.");
                }

            }



            //This is used to store FLOAT variables in a list
            if (context.FLOAT() != null)
            {
                Console.WriteLine(context.FLOAT().GetText() + " THIS IS THE FLOAT ===========================================");
                Console.WriteLine(context.ID().GetText() + " THIS IS THE id ===========================================");
                //This checks if the variable is in the dictionary if its not it adds the entry if it is it shows an error
                if (!variablesFloat.ContainsKey(context.ID().GetText()))
                {
                    variablesFloat.Add(context.ID().GetText(), 0.0);
                    Console.WriteLine($"Variable '{context.ID().GetText()}' added with value: {0.0}");
                }
                else
                {
                    Console.WriteLine($"Error: Variable '{context.ID().GetText()}' already exists.");
                }

            }


        }

        public override void ExitIngredientDeclaration([NotNull] RecipeLanguageParser.IngredientDeclarationContext context)
        {
            Console.WriteLine("ExitIngredientDeclaration");
        }

        public override void EnterArrayDeclaration([NotNull] RecipeLanguageParser.ArrayDeclarationContext context)
        {
            Console.WriteLine("EnterArrayDeclaration");
        }

        public override void ExitArrayDeclaration([NotNull] RecipeLanguageParser.ArrayDeclarationContext context)
        {
            Console.WriteLine("ExitArrayDeclaration");
        }

        /// <summary>
        /// This method is used to print items to the screen
        /// </summary>
        /// <param name="context"></param>
        public override void EnterSpeakStatement([NotNull] RecipeLanguageParser.SpeakStatementContext context)
        {
            Console.WriteLine("EnterSpeakStatement");

            if (context.ID() != null) 
            {
                Console.WriteLine(context.ID().GetText() + "THIS IS THE SPEAK STATEMENT ====================");
                string valueToPrint = context.ID().GetText();

                //this checks if the variable is in the list and prints the message to the screen
                if (variablesString.ContainsKey(valueToPrint))
                {
                    Console.WriteLine(variablesString[valueToPrint] + " VALUE STRING FOUND +++++++++++++++++++++");
                  
                }
                else if (variablesInteger.ContainsKey(valueToPrint))
                {
                    Console.WriteLine(variablesInteger[valueToPrint] + " VALUE INTEGER FOUND +++++++++++++++++++++");
                }
                else if (variablesFloat.ContainsKey(valueToPrint))
                {
                    Console.WriteLine(variablesFloat[valueToPrint] + " VALUE FLOAT FOUND +++++++++++++++++++++");
                }
                else
                {
                    Console.WriteLine($"Variable '{valueToPrint}' not found.");
                }
            }

            // Declare a variable and assign a value
            // variables["myVar"] = 42;

            // Access the variable
            //int myVarValue = (int)variables["myVar"];
        }

        public override void ExitSpeakStatement([NotNull] RecipeLanguageParser.SpeakStatementContext context)
        {
            Console.WriteLine("ExitSpeakStatement");
        }

        public override void EnterShareStatement([NotNull] RecipeLanguageParser.ShareStatementContext context)
        {
            Console.WriteLine("EnterShareStatement");
           Console.WriteLine("THISSSSSSSSSSSSSSSSSSSSSSSS"+context.INTEGERLIT().GetText());
        }

        public override void ExitShareStatement([NotNull] RecipeLanguageParser.ShareStatementContext context)
        {
            Console.WriteLine("ExitShareStatement");
        }

        public override void EnterAssignment([NotNull] RecipeLanguageParser.AssignmentContext context)
        {
            Console.WriteLine("EnterAssignment");
        }

        public override void ExitAssignment([NotNull] RecipeLanguageParser.AssignmentContext context)
        {
            Console.WriteLine("ExitAssignment");
        }

        public override void EnterRecipeStatement([NotNull] RecipeLanguageParser.RecipeStatementContext context)
        {
            Console.WriteLine("EnterRecipeStatement");
        }

        public override void ExitRecipeStatement([NotNull] RecipeLanguageParser.RecipeStatementContext context)
        {
            Console.WriteLine("ExitRecipeStatement");
        }

        public override void EnterMethodStatement([NotNull] RecipeLanguageParser.MethodStatementContext context)
        {
            Console.WriteLine("EnterMethodStatement");
        }

        public override void ExitMethodStatement([NotNull] RecipeLanguageParser.MethodStatementContext context)
        {
            Console.WriteLine("ExitMethodStatement");
        }

        public override void EnterFunctionCall([NotNull] RecipeLanguageParser.FunctionCallContext context)
        {
            Console.WriteLine("EnterFunctionCall");
        }

        public override void ExitFunctionCall([NotNull] RecipeLanguageParser.FunctionCallContext context)
        {
            Console.WriteLine("ExitFunctionCall");
        }

        public override void EnterLoopStatement([NotNull] RecipeLanguageParser.LoopStatementContext context)
        {
            Console.WriteLine("EnterLoopStatement");
        }

        public override void ExitLoopStatement([NotNull] RecipeLanguageParser.LoopStatementContext context)
        {
            Console.WriteLine("ExitLoopStatement");
        }

        public override void EnterConditionalStatement([NotNull] RecipeLanguageParser.ConditionalStatementContext context)
        {
            Console.WriteLine("EnterConditionalStatement");
        }

        public override void ExitConditionalStatement([NotNull] RecipeLanguageParser.ConditionalStatementContext context)
        {
            Console.WriteLine("ExitConditionalStatement");
        }

        public override void EnterCondition([NotNull] RecipeLanguageParser.ConditionContext context)
        {
            Console.WriteLine("EnterCondition");
        }

        public override void ExitCondition([NotNull] RecipeLanguageParser.ConditionContext context)
        {
            Console.WriteLine("ExitCondition");
        }
    }
}
