namespace Cosmetics.Contracts
{
    using System.Collections.Generic;
    /// <summary>
    ///  Interface which pecifies the contents of each command
    /// </summary>
    public interface ICommand
    {
        string Name { get; }

        /// <summary>
        /// Method which takes the commands from the input
        /// </summary>
        IList<string> Parameters { get; }
    }
}
