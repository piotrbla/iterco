using System;
using System.Diagnostics;
using System.Text;
using Roslyn.Compilers.CSharp;

namespace icsc
{
    class MainParser
    {
        public static string OneFileCodeModification(string code)
        {
            var codeTree = SyntaxTree.ParseCompilationUnit(code);
            var result = new StringBuilder();
            foreach (var syntaxToken in codeTree.Root.DescendentTokens())
            {
                    result.Append(syntaxToken.ToString());
            }
            return result.ToString();
        }
    }
}