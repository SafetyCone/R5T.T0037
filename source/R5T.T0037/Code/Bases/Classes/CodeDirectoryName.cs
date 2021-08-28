using System;


namespace R5T.T0037
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class CodeDirectoryName : ICodeDirectoryName
    {
        #region Static

        public static CodeDirectoryName Instance { get; } = new();

        #endregion
    }
}