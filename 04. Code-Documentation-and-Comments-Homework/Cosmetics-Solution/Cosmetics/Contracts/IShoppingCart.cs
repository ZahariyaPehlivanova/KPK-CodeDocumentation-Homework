namespace Cosmetics.Contracts
{
    /// <summary>
    ///  Interface which specifies the contents of each shopping cart
    /// </summary>
    public interface IShoppingCart
    {
        /// <summary>
        /// Method which shows if certain product is in the cart
        /// </summary>
        /// <param name="product">The product which is searched in the cart</param>
        /// <returns>Boolean which shows if the cart contains certain product</returns>
        bool ContainsProduct(IProduct product);

        decimal TotalPrice();

        void AddProduct(IProduct product);

        void RemoveProduct(IProduct product);
    }
}
