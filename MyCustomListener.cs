using System;
using System.Collections.Generic;
using Antlr4.Runtime.Misc;

namespace _219003234_Parser
{
    public class MyCustomListener : RecipeLanguageBaseListener
    {

        private string askInput = "";

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
        public override void EnterAskStatement([NotNull] RecipeLanguageParser.AskStatementContext context)
        {
            Console.WriteLine("EnterAskStatement");
            // Get the ID (variable name) from the context
            //string variableName = context.ID().GetText();
            // Prompt the user for input
            //     Console.Write($"Enter a value for '{variableName}': ");
            // Read the user's input
            //   string userInput = Console.ReadLine();
            //  askInput = userInput;
            // Console.WriteLine($"You entered: {userInput}");
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

        public override void EnterIngredientDeclaration([NotNull] RecipeLanguageParser.IngredientDeclarationContext context)
        {
            Console.WriteLine("EnterIngredientDeclaration");
            // Access the values of INGREDIENT, ID, and STRING
            string ingredientType = context.INGREDIENT().GetText();
            string ingredientName = context.ID().GetText();
            string ingredientValue = context.STRING().GetText();
            
            // Now you can work with these values
            Console.WriteLine($"Ingredient Type: {ingredientType}");
            Console.WriteLine($"Ingredient Name: {ingredientName}");
            Console.WriteLine($"Ingredient Value: {ingredientValue}");

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

        public override void EnterSpeakStatement([NotNull] RecipeLanguageParser.SpeakStatementContext context)
        {
            Console.WriteLine("EnterSpeakStatement");
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
