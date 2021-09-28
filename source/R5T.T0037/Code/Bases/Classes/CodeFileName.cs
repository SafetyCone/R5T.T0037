using System;


namespace R5T.T0037
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class CodeFileName : ICodeFileName
    {
        #region Static
        
        public static CodeFileName Instance { get; } = new();

        #endregion
    }
}