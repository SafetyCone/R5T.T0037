using System;

using R5T.T0037;
using R5T.T0037.X002;


namespace System
{
    public static class ICodeFileNameExtensions
    {
        public static string Documentation(this ICodeFileName _)
        {
            return CodeFileNames.Documentation;
        }

        public static string HostStartup(this ICodeFileName _)
        {
            return CodeFileNames.HostStartup;
        }

        public static string Instances(this ICodeFileName _)
        {
            return CodeFileNames.Instances;
        }
    }
}
