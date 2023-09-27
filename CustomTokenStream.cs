using _219003234_Naidoo_KN_CC;
using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;

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
                if (myTokens.Count > 0)
                {
                    var customToken = CreateCustomToken(token, myTokens[0].Lexeme);
                    tokens.Add(customToken);
                    myTokens.RemoveAt(0);
                }

            }
        }

        // Create a custom token with modified Text.
        private IToken CreateCustomToken(IToken originalToken, string text)
        {
            return new CommonToken(originalToken)
            {
                Text = text
            };
        }
    }
}
