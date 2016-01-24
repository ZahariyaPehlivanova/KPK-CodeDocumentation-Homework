namespace Cosmetics.Contracts
{
    using Common;
    /// <summary>
    ///  Interface which specifies the contents of each product
    /// </summary>
    public interface IProduct
    {
        string Name { get; }

        string Brand { get; }

        decimal Price { get; }

        GenderType Gender { get; }

        /// <summary>
        /// Gives the whole information about a product when it's called
        /// </summary>
        /// <returns>Returns the information of a product</returns>
        string Print();
    }
}
