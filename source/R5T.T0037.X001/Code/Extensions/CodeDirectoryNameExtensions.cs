using System;

using R5T.T0037;
using R5T.T0037.X001;


namespace System
{
    public static class CodeDirectoryNameExtensions
    {
        public static string Classes(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Classes;
        }

        public static string Constants(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Constants;
        }

        public static string Extensions(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Extensions;
        }

        public static string Interfaces(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Interfaces;
        }
    }
}