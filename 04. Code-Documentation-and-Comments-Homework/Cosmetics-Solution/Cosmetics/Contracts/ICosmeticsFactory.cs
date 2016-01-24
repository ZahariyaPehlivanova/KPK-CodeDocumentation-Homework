namespace Cosmetics.Contracts
{
    using System.Collections.Generic;
    using Common;

    /// <summary>
    ///  Interface which specifies the contents of each cosmetic factory
    /// </summary>
    public interface ICosmeticsFactory
    {
        ICategory CreateCategory(string name);

        IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage);

        IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients);

        /// <summary>
        /// Creates new empty shopping cart
        /// </summary>
        /// <returns>Returns new shopping cart</returns>
        IShoppingCart ShoppingCart();
    }
}
