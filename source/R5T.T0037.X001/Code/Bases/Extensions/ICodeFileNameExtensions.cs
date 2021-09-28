using System;

using R5T.T0037;
using R5T.T0037.X001;


namespace System
{
    public static class ICodeFileNameExtensions
    {
        public static string Class1(this ICodeFileName _)
        {
            return CodeFileNames.Class1;
        }

        public static string Interface1(this ICodeFileName _)
        {
            return CodeFileNames.Interface1;
        }

        public static string Program(this ICodeFileName _)
        {
            return CodeFileNames.Program;
        }

        public static string Startup(this ICodeFileName _)
        {
            return CodeFileNames.Startup;
        }
    }
}
