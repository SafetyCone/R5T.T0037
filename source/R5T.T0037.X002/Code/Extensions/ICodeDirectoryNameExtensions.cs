using System;

using R5T.T0037;
using R5T.T0037.X002;


namespace System
{
    public static class ICodeDirectoryNameExtensions
    {
        public static string Aggregations(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Aggregations;
        }

        public static string Bases(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Bases;
        }

        public static string Definitions(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Definitions;
        }

        public static string Implementations(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Implementations;
        }

        public static string Services(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Services;
        }
    }
}