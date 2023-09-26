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

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class RecipeLanguageLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		RECIPE=1, ID=2, DO=3, METHOD=4, LEFTPARENTHESIS=5, RIGHTPARENTHESIS=6, 
		AS=7, INTEGER=8, INGREDIENT=9, STRING=10, SEMICOLON=11, ASK=12, ASSIGN=13, 
		STRINGLIT=14, PLUS=15, SPEAK=16, SHARE=17, INTEGERLIT=18, DONE=19, LOOP=20, 
		WHILE=21, LESSEREQUAL=22, IF=23, EQUAL=24, THEN=25, ELSE=26, LEFTBRACKET=27, 
		RIGHTBRACKET=28, WS=29;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"RECIPE", "ID", "DO", "METHOD", "LEFTPARENTHESIS", "RIGHTPARENTHESIS", 
		"AS", "INTEGER", "INGREDIENT", "STRING", "SEMICOLON", "ASK", "ASSIGN", 
		"STRINGLIT", "PLUS", "SPEAK", "SHARE", "INTEGERLIT", "DONE", "LOOP", "WHILE", 
		"LESSEREQUAL", "IF", "EQUAL", "THEN", "ELSE", "LEFTBRACKET", "RIGHTBRACKET", 
		"WS"
	};


	public RecipeLanguageLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public RecipeLanguageLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'RECIPE'", "'ID'", "'DO'", "'METHOD'", "'LEFTPARENTHESIS'", "'RIGHTPARENTHESIS'", 
		"'AS'", "'INTEGER'", "'INGREDIENT'", "'STRING'", "'SEMICOLON'", "'ASK'", 
		"'ASSIGN'", "'STRINGLIT'", "'PLUS'", "'SPEAK'", "'SHARE'", "'INTEGERLIT'", 
		"'DONE'", "'LOOP'", "'WHILE'", "'LESSEREQUAL'", "'IF'", "'EQUAL'", "'THEN'", 
		"'ELSE'", "'LEFTBRACKET'", "'RIGHTBRACKET'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "RECIPE", "ID", "DO", "METHOD", "LEFTPARENTHESIS", "RIGHTPARENTHESIS", 
		"AS", "INTEGER", "INGREDIENT", "STRING", "SEMICOLON", "ASK", "ASSIGN", 
		"STRINGLIT", "PLUS", "SPEAK", "SHARE", "INTEGERLIT", "DONE", "LOOP", "WHILE", 
		"LESSEREQUAL", "IF", "EQUAL", "THEN", "ELSE", "LEFTBRACKET", "RIGHTBRACKET", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "RecipeLanguage.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static RecipeLanguageLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,29,279,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,2,1,2,1,2,1,3,1,3,1,3,1,
		3,1,3,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,
		1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,
		5,1,5,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,8,1,8,
		1,8,1,8,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,
		1,10,1,10,1,10,1,10,1,10,1,10,1,11,1,11,1,11,1,11,1,12,1,12,1,12,1,12,
		1,12,1,12,1,12,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,14,
		1,14,1,14,1,14,1,14,1,15,1,15,1,15,1,15,1,15,1,15,1,16,1,16,1,16,1,16,
		1,16,1,16,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,18,
		1,18,1,18,1,18,1,18,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,20,
		1,20,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,22,
		1,22,1,22,1,23,1,23,1,23,1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,24,1,25,
		1,25,1,25,1,25,1,25,1,26,1,26,1,26,1,26,1,26,1,26,1,26,1,26,1,26,1,26,
		1,26,1,26,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,
		1,27,1,28,4,28,274,8,28,11,28,12,28,275,1,28,1,28,0,0,29,1,1,3,2,5,3,7,
		4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,33,
		17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,57,
		29,1,0,1,3,0,9,10,13,13,32,32,279,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,
		0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,
		0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,
		0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,
		1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,
		0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,1,59,1,0,0,0,3,66,
		1,0,0,0,5,69,1,0,0,0,7,72,1,0,0,0,9,79,1,0,0,0,11,95,1,0,0,0,13,112,1,
		0,0,0,15,115,1,0,0,0,17,123,1,0,0,0,19,134,1,0,0,0,21,141,1,0,0,0,23,151,
		1,0,0,0,25,155,1,0,0,0,27,162,1,0,0,0,29,172,1,0,0,0,31,177,1,0,0,0,33,
		183,1,0,0,0,35,189,1,0,0,0,37,200,1,0,0,0,39,205,1,0,0,0,41,210,1,0,0,
		0,43,216,1,0,0,0,45,228,1,0,0,0,47,231,1,0,0,0,49,237,1,0,0,0,51,242,1,
		0,0,0,53,247,1,0,0,0,55,259,1,0,0,0,57,273,1,0,0,0,59,60,5,82,0,0,60,61,
		5,69,0,0,61,62,5,67,0,0,62,63,5,73,0,0,63,64,5,80,0,0,64,65,5,69,0,0,65,
		2,1,0,0,0,66,67,5,73,0,0,67,68,5,68,0,0,68,4,1,0,0,0,69,70,5,68,0,0,70,
		71,5,79,0,0,71,6,1,0,0,0,72,73,5,77,0,0,73,74,5,69,0,0,74,75,5,84,0,0,
		75,76,5,72,0,0,76,77,5,79,0,0,77,78,5,68,0,0,78,8,1,0,0,0,79,80,5,76,0,
		0,80,81,5,69,0,0,81,82,5,70,0,0,82,83,5,84,0,0,83,84,5,80,0,0,84,85,5,
		65,0,0,85,86,5,82,0,0,86,87,5,69,0,0,87,88,5,78,0,0,88,89,5,84,0,0,89,
		90,5,72,0,0,90,91,5,69,0,0,91,92,5,83,0,0,92,93,5,73,0,0,93,94,5,83,0,
		0,94,10,1,0,0,0,95,96,5,82,0,0,96,97,5,73,0,0,97,98,5,71,0,0,98,99,5,72,
		0,0,99,100,5,84,0,0,100,101,5,80,0,0,101,102,5,65,0,0,102,103,5,82,0,0,
		103,104,5,69,0,0,104,105,5,78,0,0,105,106,5,84,0,0,106,107,5,72,0,0,107,
		108,5,69,0,0,108,109,5,83,0,0,109,110,5,73,0,0,110,111,5,83,0,0,111,12,
		1,0,0,0,112,113,5,65,0,0,113,114,5,83,0,0,114,14,1,0,0,0,115,116,5,73,
		0,0,116,117,5,78,0,0,117,118,5,84,0,0,118,119,5,69,0,0,119,120,5,71,0,
		0,120,121,5,69,0,0,121,122,5,82,0,0,122,16,1,0,0,0,123,124,5,73,0,0,124,
		125,5,78,0,0,125,126,5,71,0,0,126,127,5,82,0,0,127,128,5,69,0,0,128,129,
		5,68,0,0,129,130,5,73,0,0,130,131,5,69,0,0,131,132,5,78,0,0,132,133,5,
		84,0,0,133,18,1,0,0,0,134,135,5,83,0,0,135,136,5,84,0,0,136,137,5,82,0,
		0,137,138,5,73,0,0,138,139,5,78,0,0,139,140,5,71,0,0,140,20,1,0,0,0,141,
		142,5,83,0,0,142,143,5,69,0,0,143,144,5,77,0,0,144,145,5,73,0,0,145,146,
		5,67,0,0,146,147,5,79,0,0,147,148,5,76,0,0,148,149,5,79,0,0,149,150,5,
		78,0,0,150,22,1,0,0,0,151,152,5,65,0,0,152,153,5,83,0,0,153,154,5,75,0,
		0,154,24,1,0,0,0,155,156,5,65,0,0,156,157,5,83,0,0,157,158,5,83,0,0,158,
		159,5,73,0,0,159,160,5,71,0,0,160,161,5,78,0,0,161,26,1,0,0,0,162,163,
		5,83,0,0,163,164,5,84,0,0,164,165,5,82,0,0,165,166,5,73,0,0,166,167,5,
		78,0,0,167,168,5,71,0,0,168,169,5,76,0,0,169,170,5,73,0,0,170,171,5,84,
		0,0,171,28,1,0,0,0,172,173,5,80,0,0,173,174,5,76,0,0,174,175,5,85,0,0,
		175,176,5,83,0,0,176,30,1,0,0,0,177,178,5,83,0,0,178,179,5,80,0,0,179,
		180,5,69,0,0,180,181,5,65,0,0,181,182,5,75,0,0,182,32,1,0,0,0,183,184,
		5,83,0,0,184,185,5,72,0,0,185,186,5,65,0,0,186,187,5,82,0,0,187,188,5,
		69,0,0,188,34,1,0,0,0,189,190,5,73,0,0,190,191,5,78,0,0,191,192,5,84,0,
		0,192,193,5,69,0,0,193,194,5,71,0,0,194,195,5,69,0,0,195,196,5,82,0,0,
		196,197,5,76,0,0,197,198,5,73,0,0,198,199,5,84,0,0,199,36,1,0,0,0,200,
		201,5,68,0,0,201,202,5,79,0,0,202,203,5,78,0,0,203,204,5,69,0,0,204,38,
		1,0,0,0,205,206,5,76,0,0,206,207,5,79,0,0,207,208,5,79,0,0,208,209,5,80,
		0,0,209,40,1,0,0,0,210,211,5,87,0,0,211,212,5,72,0,0,212,213,5,73,0,0,
		213,214,5,76,0,0,214,215,5,69,0,0,215,42,1,0,0,0,216,217,5,76,0,0,217,
		218,5,69,0,0,218,219,5,83,0,0,219,220,5,83,0,0,220,221,5,69,0,0,221,222,
		5,82,0,0,222,223,5,69,0,0,223,224,5,81,0,0,224,225,5,85,0,0,225,226,5,
		65,0,0,226,227,5,76,0,0,227,44,1,0,0,0,228,229,5,73,0,0,229,230,5,70,0,
		0,230,46,1,0,0,0,231,232,5,69,0,0,232,233,5,81,0,0,233,234,5,85,0,0,234,
		235,5,65,0,0,235,236,5,76,0,0,236,48,1,0,0,0,237,238,5,84,0,0,238,239,
		5,72,0,0,239,240,5,69,0,0,240,241,5,78,0,0,241,50,1,0,0,0,242,243,5,69,
		0,0,243,244,5,76,0,0,244,245,5,83,0,0,245,246,5,69,0,0,246,52,1,0,0,0,
		247,248,5,76,0,0,248,249,5,69,0,0,249,250,5,70,0,0,250,251,5,84,0,0,251,
		252,5,66,0,0,252,253,5,82,0,0,253,254,5,65,0,0,254,255,5,67,0,0,255,256,
		5,75,0,0,256,257,5,69,0,0,257,258,5,84,0,0,258,54,1,0,0,0,259,260,5,82,
		0,0,260,261,5,73,0,0,261,262,5,71,0,0,262,263,5,72,0,0,263,264,5,84,0,
		0,264,265,5,66,0,0,265,266,5,82,0,0,266,267,5,65,0,0,267,268,5,67,0,0,
		268,269,5,75,0,0,269,270,5,69,0,0,270,271,5,84,0,0,271,56,1,0,0,0,272,
		274,7,0,0,0,273,272,1,0,0,0,274,275,1,0,0,0,275,273,1,0,0,0,275,276,1,
		0,0,0,276,277,1,0,0,0,277,278,6,28,0,0,278,58,1,0,0,0,2,0,275,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
