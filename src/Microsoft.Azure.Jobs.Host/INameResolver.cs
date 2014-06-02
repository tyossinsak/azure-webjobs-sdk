﻿namespace Microsoft.Azure.Jobs
{
    /// <summary>
    /// Resolve %name% in the endpoints.
    /// </summary>
    public interface INameResolver
    {
        /// <summary>
        /// Resolve a %name% to a value . Resolution is not recursive.
        /// </summary>
        /// <param name="name">The name to resolve (without the %... %)</param>
        /// <returns>the value that the name resolves to. Or Null if the name is not supported.</returns>
        string Resolve(string name);
    }
}