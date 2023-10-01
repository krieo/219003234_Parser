using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
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

            // Console.WriteLine("EnterProgram");
        }

        public override void ExitProgram([NotNull] RecipeLanguageParser.ProgramContext context)
        {
            // Console.WriteLine("ExitProgram");
        }

        public override void EnterStatement([NotNull] RecipeLanguageParser.StatementContext context)
        {
            // Console.WriteLine("EnterStatement");
        }

        public override void ExitStatement([NotNull] RecipeLanguageParser.StatementContext context)
        {
            // Console.WriteLine("ExitStatement");
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
            // Console.WriteLine("EnterAskStatement");
            string variableName = context.ID().GetText(); // Get the variable name

            // Prompt the user for input
            // Console.Write($"Enter a value for '{variableName}': ");

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
            // Console.WriteLine("ExitAskStatement");
        }

        public override void EnterDeclaration([NotNull] RecipeLanguageParser.DeclarationContext context)
        {
            // Console.WriteLine("EnterDeclaration");
        }

        public override void ExitDeclaration([NotNull] RecipeLanguageParser.DeclarationContext context)
        {
            // Console.WriteLine("ExitDeclaration");
        }

        /// <summary>
        /// This method is used to create variables
        /// </summary>
        /// <param name="context"></param>
        public override void EnterIngredientDeclaration([NotNull] RecipeLanguageParser.IngredientDeclarationContext context)
        {
            //  Console.WriteLine("EnterIngredientDeclaration");

            //This is used to store integer variables in a list
            if (context.INTEGER() != null)
            {
                // Console.WriteLine(context.INTEGER().GetText() + " THIS IS THE INTEGER ===========================================");
                //  Console.WriteLine(context.ID().GetText() + " THIS IS THE id ===========================================");
                //This checks if the variable is in the dictionary if its not it adds the entry if it is it shows an error
                if (!variablesInteger.ContainsKey(context.ID().GetText()))
                {
                    variablesInteger.Add(context.ID().GetText(), 0);
                    // Console.WriteLine($"Variable '{context.ID().GetText()}' added with value: {0}");
                }
                else
                {
                    Console.WriteLine($"Error: Variable '{context.ID().GetText()}' already exists.");
                }

            }

            //This is used to store string variables in a list
            if (context.STRING() != null)
            {
                // Console.WriteLine(context.STRING().GetText() + " THIS IS THE STRING ===========================================");
                // Console.WriteLine(context.ID().GetText() + " THIS IS THE id ===========================================");
                //This checks if the variable is in the dictionary if its not it adds the entry if it is it shows an error
                if (!variablesString.ContainsKey(context.ID().GetText()))
                {
                    variablesString.Add(context.ID().GetText(), "empty variable");
                    // Console.WriteLine($"Variable '{context.ID().GetText()}' added with value: {"empty variable"}");
                }
                else
                {
                    Console.WriteLine($"Error: Variable '{context.ID().GetText()}' already exists.");
                }

            }



            //This is used to store FLOAT variables in a list
            if (context.FLOAT() != null)
            {
                //  Console.WriteLine(context.FLOAT().GetText() + " THIS IS THE FLOAT ===========================================");
                //   Console.WriteLine(context.ID().GetText() + " THIS IS THE id ===========================================");
                //This checks if the variable is in the dictionary if its not it adds the entry if it is it shows an error
                if (!variablesFloat.ContainsKey(context.ID().GetText()))
                {
                    variablesFloat.Add(context.ID().GetText(), 0.0);
                    //      Console.WriteLine($"Variable '{context.ID().GetText()}' added with value: {0.0}");
                }
                else
                {
                    Console.WriteLine($"Error: Variable '{context.ID().GetText()}' already exists.");
                }

            }


        }

        public override void ExitIngredientDeclaration([NotNull] RecipeLanguageParser.IngredientDeclarationContext context)
        {
            //  Console.WriteLine("ExitIngredientDeclaration");
        }

        public override void EnterArrayDeclaration([NotNull] RecipeLanguageParser.ArrayDeclarationContext context)
        {
            //  Console.WriteLine("EnterArrayDeclaration");
        }

        public override void ExitArrayDeclaration([NotNull] RecipeLanguageParser.ArrayDeclarationContext context)
        {
            //  Console.WriteLine("ExitArrayDeclaration");
        }

        /// <summary>
        /// This method is used to print items to the screen
        /// </summary>
        /// <param name="context"></param>
        public override void EnterSpeakStatement([NotNull] RecipeLanguageParser.SpeakStatementContext context)
        {
            // Console.WriteLine("EnterSpeakStatement");

            if (context.ID() != null)
            {
                // Console.WriteLine(context.ID().GetText() + "THIS IS THE SPEAK STATEMENT ====================");
                string valueToPrint = context.ID().GetText();

                //this checks if the variable is in the list and prints the message to the screen
                if (variablesString.ContainsKey(valueToPrint))
                {
                    Console.WriteLine(variablesString[valueToPrint]);

                }
                else if (variablesInteger.ContainsKey(valueToPrint))
                {
                    Console.WriteLine(variablesInteger[valueToPrint]);
                }
                else if (variablesFloat.ContainsKey(valueToPrint))
                {
                    Console.WriteLine(variablesFloat[valueToPrint]);
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
            //  Console.WriteLine("ExitSpeakStatement");
        }

        public override void EnterShareStatement([NotNull] RecipeLanguageParser.ShareStatementContext context)
        {
            // Console.WriteLine("EnterShareStatement");
            int childIndex = 0;

            while (true)
            {
                var child = context.GetChild(childIndex);
                if (child == null)
                {
                    break; // No more children, exit the loop
                }


                childIndex++;
            }

            //this returns the value to the screen
            if (context.INTEGERLIT() != null)
            {
                Console.WriteLine("Returned " + context.INTEGERLIT().GetText());
            }
            else if (context.STRINGLIT() != null)
            {
                Console.WriteLine("Returned " + context.STRINGLIT().GetText());
            }
            else if (context.FLOATLIT() != null)
            {
                Console.WriteLine("Returned " + context.FLOATLIT().GetText());
            }
            else if (context.BOOLLITFALSE() != null)
            {
                Console.WriteLine("Returned " + context.BOOLLITFALSE().GetText());
            }
            else if (context.BOOLLITTRUE() != null)
            {
                Console.WriteLine("Returned " + context.BOOLLITTRUE().GetText());
            }


        }

        public override void ExitShareStatement([NotNull] RecipeLanguageParser.ShareStatementContext context)
        {
            // Console.WriteLine("ExitShareStatement");
        }

        public override void EnterAssignment([NotNull] RecipeLanguageParser.AssignmentContext context)
        {
            //  Console.WriteLine("EnterAssignment");
            string assignmentStatement = context.GetText(); // Get the entire assignment statement
                                                            //  Console.WriteLine(assignmentStatement + " this is the assignement statement knadjfhiusfhieuwfnjksefhkfweewfwe");
                                                            // Split the assignment statement by the '=' operator
            string[] assignmentParts = assignmentStatement.Split('=');

            if (assignmentParts.Length == 2)
            {
                string lhs = assignmentParts[0].Trim(); // Left-hand side (variable name)
                string rhs = assignmentParts[1].Trim(); // Right-hand side (expression)
                                                        //  Console.WriteLine(lhs + " this is the lhs statement knadjfhiusfhieuwfnjksefhkfweewfwe");
                                                        //  Console.WriteLine(rhs + " this is the rhs statement knadjfhiusfhieuwfnjksefhkfweewfwe");

                // Check which dictionary the LHS variable is in
                if (variablesString.ContainsKey(lhs))
                {
                    // LHS is a string variable, so perform string concatenation
                    // variablesString[lhs] = PerformStringConcatenation(rhs);
                    string[] terms = rhs.Split('+');
                    string result = "";
                    foreach (var item in terms)
                    {
                        if (variablesString.ContainsKey(item))
                        {
                            result += (string)variablesString[item];
                        }
                        else
                        {
                            result += item;
                        }
                    }
                    // Update the value of the LHS variable in the variablesString dictionary
                    variablesString[lhs] = result;

                    //  Console.WriteLine(result + " THIS IS WHAT WE HAVE OUT RESUTL AS");
                }
                //This sorts the integer parts of the assignment
                else if (variablesInteger.ContainsKey(lhs))
                {
                    // LHS is an integer variable, so perform integer addition

                    // Use stacks for operator precedence
                    Stack<string> operators = new Stack<string>();
                    Queue<string> outputQueue = new Queue<string>();

                    int childIndex = 0;
                    int result = 0;

                    while (true)
                    {
                        var child = context.GetChild(childIndex);

                        if (child == null)
                        {
                            break; // No more children, exit the loop
                        }
                        else
                        {
                            string token = child.GetText();
                            if (variablesInteger.ContainsKey(token))
                            {
                                string integerVariable = variablesInteger[token].ToString();
                                token = integerVariable;
                            }
                            if (int.TryParse(token, out int intValue))
                            {
                                // If it's a number, add it to the output queue
                                outputQueue.Enqueue(intValue.ToString());
                            }
                            else if (token == "+" || token == "-" || token == "*" || token == "/")
                            {
                                // If it's an operator
                                while (operators.Count > 0 && GetPrecedence(operators.Peek()) >= GetPrecedence(token))
                                {
                                    // Pop operators with higher or equal precedence and enqueue them
                                    outputQueue.Enqueue(operators.Pop());
                                }
                                operators.Push(token);
                            }
                        }

                        childIndex++;
                    }

                    // Enqueue remaining operators to output
                    while (operators.Count > 0)
                    {
                        outputQueue.Enqueue(operators.Pop());
                    }

                    // Evaluate the RPN expression
                    Stack<int> evalStack = new Stack<int>();

                    foreach (var item in outputQueue)
                    {
                        if (int.TryParse(item, out int intValue))
                        {
                            evalStack.Push(intValue);
                        }
                        else
                        {
                            int b = evalStack.Pop();
                            int a = evalStack.Pop();

                            switch (item)
                            {
                                case "+":
                                    evalStack.Push(a + b);
                                    break;
                                case "-":
                                    evalStack.Push(a - b);
                                    break;
                                case "*":
                                    evalStack.Push(a * b);
                                    break;
                                case "/":
                                    evalStack.Push(a / b);
                                    break;
                            }
                        }
                    }

                    result = evalStack.Pop();
                    variablesInteger[lhs] = result;

                    //  Console.WriteLine("Result of expression: " + result);
                }

                //This performs the assignment for the float variables
                else if (variablesFloat.ContainsKey(lhs))
                {
                    // LHS is an float variable, so perform float addition

                    // Use stacks for operator precedence
                    Stack<string> operators = new Stack<string>();
                    Queue<string> outputQueue = new Queue<string>();

                    int childIndex = 0;
                    float result = 0;

                    while (true)
                    {
                        var child = context.GetChild(childIndex);

                        if (child == null)
                        {
                            break; // No more children, exit the loop
                        }
                        else
                        {
                            string token = child.GetText();
                            if (variablesFloat.ContainsKey(token))
                            {
                                string floatVariable = variablesFloat[token].ToString();
                                token = floatVariable;
                            }
                            if (float.TryParse(token, out float floatValue))
                            {
                                // If it's a number, add it to the output queue
                                outputQueue.Enqueue(floatValue.ToString());
                            }
                            else if (token == "+" || token == "-" || token == "*" || token == "/")
                            {
                                // If it's an operator
                                while (operators.Count > 0 && GetPrecedence(operators.Peek()) >= GetPrecedence(token))
                                {
                                    // Pop operators with higher or equal precedence and enqueue them
                                    outputQueue.Enqueue(operators.Pop());
                                }
                                operators.Push(token);
                            }
                        }

                        childIndex++;
                    }

                    // Enqueue remaining operators to output
                    while (operators.Count > 0)
                    {
                        outputQueue.Enqueue(operators.Pop());
                    }

                    // Evaluate the RPN expression
                    Stack<float> evalStack = new Stack<float>();

                    foreach (var item in outputQueue)
                    {
                        if (float.TryParse(item, out float floatValue))
                        {
                            evalStack.Push(floatValue);
                        }
                        else
                        {
                            float b = evalStack.Pop();
                            float a = evalStack.Pop();

                            switch (item)
                            {
                                case "+":
                                    evalStack.Push(a + b);
                                    break;
                                case "-":
                                    evalStack.Push(a - b);
                                    break;
                                case "*":
                                    evalStack.Push(a * b);
                                    break;
                                case "/":
                                    evalStack.Push(a / b);
                                    break;
                            }
                        }
                    }

                    result = evalStack.Pop();
                    variablesFloat[lhs] = result;

                    //  Console.WriteLine("Result of expression: " + result);
                }

                else
                {
                    Console.WriteLine($"Error: Variable '{lhs}' not found.");
                }
            }
            else
            {
                Console.WriteLine($"Error: Invalid assignment statement: {assignmentStatement}");
            }

            //  Console.WriteLine("ExitAssignment");
        }

        // Function to get operator precedence
        int GetPrecedence(string op)
        {
            switch (op)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default:
                    return 0;
            }
        }
        public override void ExitAssignment([NotNull] RecipeLanguageParser.AssignmentContext context)
        {
            //   Console.WriteLine("ExitAssignment");

        }

        public override void EnterRecipeStatement([NotNull] RecipeLanguageParser.RecipeStatementContext context)
        {
            //  Console.WriteLine("EnterRecipeStatement");
        }

        public override void ExitRecipeStatement([NotNull] RecipeLanguageParser.RecipeStatementContext context)
        {
            //  Console.WriteLine("ExitRecipeStatement");
        }

        public override void EnterMethodStatement([NotNull] RecipeLanguageParser.MethodStatementContext context)
        {
            //    Console.WriteLine("EnterMethodStatement");
        }

        public override void ExitMethodStatement([NotNull] RecipeLanguageParser.MethodStatementContext context)
        {
            //  Console.WriteLine("ExitMethodStatement");
        }

        public override void EnterFunctionCall([NotNull] RecipeLanguageParser.FunctionCallContext context)
        {
            //  Console.WriteLine("EnterFunctionCall");
        }

        public override void ExitFunctionCall([NotNull] RecipeLanguageParser.FunctionCallContext context)
        {
            //  Console.WriteLine("ExitFunctionCall");
        }

        public override void EnterLoopStatement([NotNull] RecipeLanguageParser.LoopStatementContext context)
        {
            int childIndex = 0;
            string intVariable = "";
            string op = "";
            int endValue = 0;

            // Step 1: Parse the loop condition and extract relevant values
            while (true)
            {
                var child = context.GetChild(childIndex);
                if (child == null)
                {
                    break; // No more children, exit the loop
                }

                string childText = child.GetText();

                if (variablesInteger.ContainsKey(childText))
                {
                    intVariable = childText;
                }
                else if (childText == ">" || childText == "<" || childText == "==" || childText == "<>")
                {
                    op = childText;
                    string endValueStr = context.GetChild(childIndex + 1).GetText();
                    if (int.TryParse(endValueStr, out endValue))
                    {
                        break; // Exit the loop after parsing the condition
                    }
                }

                childIndex++;
            }

            // Step 2: Execute the loop based on the condition
            int value = (int)variablesInteger[intVariable];
            while (true)
            {
                if (op == ">" && value > endValue)
                {
                    // Your loop body here (e.g., i = i - 1;)
                    value = value - 1;
                }
                else if (op == "<" && value < endValue)
                {
                    // Your loop body here (e.g., i = i + 1;)
                    value = value + 1;
                }
                else if (op == "==" && value == endValue)
                {
                    // Your loop body here (e.g., i = i + 1;)
                    value = value + 1;
                }
                else if (op == "<>" && value != endValue)
                {
                    // Your loop body here (e.g., i = i + 1;)
                    value = value + 1;
                }
                else
                {
                    break; // Exit the loop when the condition is no longer met
                }

                // Update the variable value if necessary
                variablesInteger[intVariable] = value;
                //   Console.WriteLine(value + " THIS IS THE VALUE");
            }
        }


        public override void ExitLoopStatement([NotNull] RecipeLanguageParser.LoopStatementContext context)
        {
            //   Console.WriteLine("ExitLoopStatement");
        }

        public override void EnterConditionalStatement([NotNull] RecipeLanguageParser.ConditionalStatementContext context)
        {
            //  Console.WriteLine("EnterConditionalStatement");
            // Get the condition expression as text
            string conditionExpression = context.condition().GetText();
            Console.WriteLine(conditionExpression + " THIS IS THE EXPRESSION");
            // Evaluate the condition expression
            bool conditionResult = EvaluateCondition(conditionExpression);

            if (conditionResult)
            {
                // The condition is true, execute the IF block
                EnterStatement(context.statement(0));
            }
            else if (context.statement().Length > 1)
            {
                // The ELSE block is present and the condition is false, execute the ELSE block
                EnterStatement(context.statement(1));
            }

        }



        // Helper method to evaluate a condition expression
        public bool EvaluateCondition(string conditionExpression)
        {
            int lhs = 0;
            string op = "";
            int rhs = 0;
            int lhs2 = 0;
            string op2 = "";
            int rhs2 = 0;

            if (conditionExpression.Contains("AND"))
            {
                string[] parts = conditionExpression.Split(new string[] { "AND" }, StringSplitOptions.RemoveEmptyEntries);
                string logicalOperator = "AND";
                string[] subConditions = parts[0].Split(new string[] { "==", ">", "<", "<>", ">=", "<=" }, StringSplitOptions.RemoveEmptyEntries);

                if (int.TryParse(subConditions[0].Trim(), out int parsedValue))
                {
                    // Parsing was successful, and parsedValue contains the integer value
                    lhs = parsedValue;
                }
                else
                {
                    int myVarValue = (int)variablesInteger[subConditions[0].Trim()];
                    lhs = myVarValue;
                }

                if (int.TryParse(subConditions[1].Trim(), out int parsedValue2))
                {
                    // Parsing was successful, and parsedValue contains the integer value
                    rhs = parsedValue2;
                }
                else
                {
                    int myVarValue = (int)variablesInteger[subConditions[1].Trim()];
                    rhs = myVarValue;
                }

                string[] subConditions2 = parts[1].Split(new string[] { "==", ">", "<", "<>", ">=", "<=" }, StringSplitOptions.RemoveEmptyEntries);

                if (int.TryParse(subConditions2[0].Trim(), out int parsedValue3))
                {
                    // Parsing was successful, and parsedValue contains the integer value
                    lhs2 = parsedValue3;
                }
                else
                {
                    int myVarValue = (int)variablesInteger[subConditions2[0].Trim()];
                    lhs2 = myVarValue;
                }

                if (int.TryParse(subConditions2[1].Trim(), out int parsedValue4))
                {
                    // Parsing was successful, and parsedValue contains the integer value
                    rhs2 = parsedValue4;
                }
                else
                {
                    int myVarValue = (int)variablesInteger[subConditions2[1].Trim()];
                    rhs2 = myVarValue;
                }

                bool value1ToCheck = false;

                bool value2ToCheck = false;
                //this checks the operand
                if (parts[0].Contains("==")) { if (lhs == rhs) { value1ToCheck = true; } }
                else if (parts[0].Contains(">")) { if (lhs > rhs) { value1ToCheck = true; } }
                else if (parts[0].Contains("<")) { if (lhs < rhs) { value1ToCheck = true; } }
                else if (parts[0].Contains("<>")) { if (lhs != rhs) { value1ToCheck = true; } }
                else if (parts[0].Contains(">=")) { if (lhs >= rhs) { value1ToCheck = true; } }
                else if (parts[0].Contains("<=")) { if (lhs <= rhs) { value1ToCheck = true; } }

                if (parts[1].Contains("==")) { if (lhs2 == rhs2) { value2ToCheck = true; } }
                else if (parts[1].Contains(">")) { if (lhs2 > rhs2) { value2ToCheck = true; } }
                else if (parts[1].Contains("<")) { if (lhs2 < rhs2) { value2ToCheck = true; } }
                else if (parts[1].Contains("<>")) { if (lhs2 != rhs2) { value2ToCheck = true; } }
                else if (parts[1].Contains(">=")) { if (lhs2 >= rhs2) { value2ToCheck = true; } }
                else if (parts[1].Contains("<=")) { if (lhs2 <= rhs2) { value2ToCheck = true; } }

                if (value1ToCheck == value2ToCheck) { return true; } else { return false; }
            }
            else if (conditionExpression.Contains("OR"))
            {
                string[] parts = conditionExpression.Split(new string[] { "AND" }, StringSplitOptions.RemoveEmptyEntries);
                string logicalOperator = "AND";
                string[] subConditions = parts[0].Split(new string[] { "==", ">", "<", "<>", ">=", "<=" }, StringSplitOptions.RemoveEmptyEntries);

                if (int.TryParse(subConditions[0].Trim(), out int parsedValue))
                {
                    // Parsing was successful, and parsedValue contains the integer value
                    lhs = parsedValue;
                }
                else
                {
                    int myVarValue = (int)variablesInteger[subConditions[0].Trim()];
                    lhs = myVarValue;
                }

                if (int.TryParse(subConditions[1].Trim(), out int parsedValue2))
                {
                    // Parsing was successful, and parsedValue contains the integer value
                    rhs = parsedValue2;
                }
                else
                {
                    int myVarValue = (int)variablesInteger[subConditions[1].Trim()];
                    rhs = myVarValue;
                }

                string[] subConditions2 = parts[1].Split(new string[] { "==", ">", "<", "<>", ">=", "<=" }, StringSplitOptions.RemoveEmptyEntries);

                if (int.TryParse(subConditions2[0].Trim(), out int parsedValue3))
                {
                    // Parsing was successful, and parsedValue contains the integer value
                    lhs2 = parsedValue3;
                }
                else
                {
                    int myVarValue = (int)variablesInteger[subConditions2[0].Trim()];
                    lhs2 = myVarValue;
                }

                if (int.TryParse(subConditions2[1].Trim(), out int parsedValue4))
                {
                    // Parsing was successful, and parsedValue contains the integer value
                    rhs2 = parsedValue4;
                }
                else
                {
                    int myVarValue = (int)variablesInteger[subConditions2[1].Trim()];
                    rhs2 = myVarValue;
                }

                bool value1ToCheck = false;

                bool value2ToCheck = false;
                //this checks the operand
                if (parts[0].Contains("==")) { if (lhs == rhs) { value1ToCheck = true; } }
                else if (parts[0].Contains(">")) { if (lhs > rhs) { value1ToCheck = true; } }
                else if (parts[0].Contains("<")) { if (lhs < rhs) { value1ToCheck = true; } }
                else if (parts[0].Contains("<>")) { if (lhs != rhs) { value1ToCheck = true; } }
                else if (parts[0].Contains(">=")) { if (lhs >= rhs) { value1ToCheck = true; } }
                else if (parts[0].Contains("<=")) { if (lhs <= rhs) { value1ToCheck = true; } }

                if (parts[1].Contains("==")) { if (lhs2 == rhs2) { value2ToCheck = true; } }
                else if (parts[1].Contains(">")) { if (lhs2 > rhs2) { value2ToCheck = true; } }
                else if (parts[1].Contains("<")) { if (lhs2 < rhs2) { value2ToCheck = true; } }
                else if (parts[1].Contains("<>")) { if (lhs2 != rhs2) { value2ToCheck = true; } }
                else if (parts[1].Contains(">=")) { if (lhs2 >= rhs2) { value2ToCheck = true; } }
                else if (parts[1].Contains("<=")) { if (lhs2 <= rhs2) { value2ToCheck = true; } }

                if (value1ToCheck == true || value2ToCheck == true) { return true; } else { return false; }
            }
            else
            {
                string[] subConditions = conditionExpression.Split(new string[] { "==", ">", "<", "<>", ">=", "<=" }, StringSplitOptions.RemoveEmptyEntries);

                if (int.TryParse(subConditions[0].Trim(), out int parsedValue))
                {
                    // Parsing was successful, and parsedValue contains the integer value
                    lhs = parsedValue;
                }
                else
                {
                    int myVarValue = (int)variablesInteger[subConditions[0].Trim()];
                    lhs = myVarValue;
                }

                if (int.TryParse(subConditions[1].Trim(), out int parsedValue2))
                {
                    // Parsing was successful, and parsedValue contains the integer value
                    rhs = parsedValue2;
                }
                else
                {
                    int myVarValue = (int)variablesInteger[subConditions[1].Trim()];
                    rhs = myVarValue;
                }

                bool value1ToCheck = false;

                //this checks the operand
                if (conditionExpression.Contains("==")) { if (lhs == rhs) { value1ToCheck = true; } }
                else if (conditionExpression.Contains(">")) { if (lhs > rhs) { value1ToCheck = true; } }
                else if (conditionExpression.Contains("<")) { if (lhs < rhs) { value1ToCheck = true; } }
                else if (conditionExpression.Contains("<>")) { if (lhs != rhs) { value1ToCheck = true; } }
                else if (conditionExpression.Contains(">=")) { if (lhs >= rhs) { value1ToCheck = true; } }
                else if (conditionExpression.Contains("<=")) { if (lhs <= rhs) { value1ToCheck = true; } }

          
                if (value1ToCheck == true) { return true; } else { return false; }

            }
        }


        public override void ExitConditionalStatement([NotNull] RecipeLanguageParser.ConditionalStatementContext context)
        {
            //   Console.WriteLine("ExitConditionalStatement");
        }

        public override void EnterCondition([NotNull] RecipeLanguageParser.ConditionContext context)
        {
            //  Console.WriteLine("EnterCondition");
        }

        public override void ExitCondition([NotNull] RecipeLanguageParser.ConditionContext context)
        {
            //  Console.WriteLine("ExitCondition");
        }
    }
}
