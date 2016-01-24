namespace Cosmetics.Contracts
{
    using Common;
    /// <summary>
    ///  Interface which specifies the contents of each shampoo
    /// </summary>
    public interface IShampoo : IProduct
    {
        uint Milliliters { get; }

        UsageType Usage { get; }
    }
}