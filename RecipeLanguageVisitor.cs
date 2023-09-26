//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from RecipeLanguage.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="RecipeLanguageParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IRecipeLanguageVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] RecipeLanguageParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] RecipeLanguageParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.askStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAskStatement([NotNull] RecipeLanguageParser.AskStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaration([NotNull] RecipeLanguageParser.DeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.ingredientDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIngredientDeclaration([NotNull] RecipeLanguageParser.IngredientDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.arrayDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayDeclaration([NotNull] RecipeLanguageParser.ArrayDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.speakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpeakStatement([NotNull] RecipeLanguageParser.SpeakStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.shareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShareStatement([NotNull] RecipeLanguageParser.ShareStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] RecipeLanguageParser.AssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.recipeStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRecipeStatement([NotNull] RecipeLanguageParser.RecipeStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.methodStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodStatement([NotNull] RecipeLanguageParser.MethodStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] RecipeLanguageParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.loopStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLoopStatement([NotNull] RecipeLanguageParser.LoopStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.conditionalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionalStatement([NotNull] RecipeLanguageParser.ConditionalStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RecipeLanguageParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondition([NotNull] RecipeLanguageParser.ConditionContext context);
}
