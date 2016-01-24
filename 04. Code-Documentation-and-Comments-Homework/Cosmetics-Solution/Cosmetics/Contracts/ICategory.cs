namespace Cosmetics.Contracts
{
    /// <summary>
    /// Interface which specifies the contents of each category
    /// </summary>
    public interface ICategory
    {
        string Name { get; }

        /// <summary>
        /// Method which gives the whole information about a category
        /// </summary>
        /// <returns>Returns information about a category</returns>
        string Print();

        void AddToCosmetics(IProduct cosmetics);

        void RemoveFromCosmetics(IProduct cosmetics);
    }
}
