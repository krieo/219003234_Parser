using _219003234_Naidoo_KN_CC;
using Antlr4.Runtime;
using System;
using System.Collections.Generic;

namespace _219003234_Parser
{
    public class CustomTokenStream : CommonTokenStream
    {
        public CustomTokenStream(CommonTokenStream tokenStream, List<Token> myTokens)
            : base(tokenStream.TokenSource)
        {
            // Copy the existing tokens from the provided token stream.
            foreach (var token in tokenStream.GetTokens())
            {
                var customToken = CreateCustomToken(token);
                tokens.Add(customToken);
            }
        }

        // Create a custom token with modified Text.
        private IToken CreateCustomToken(IToken originalToken)
        {
            return new CommonToken(originalToken)
            {
                Text = "hello" // Modify the Text proper
            };
        }
    }
}
