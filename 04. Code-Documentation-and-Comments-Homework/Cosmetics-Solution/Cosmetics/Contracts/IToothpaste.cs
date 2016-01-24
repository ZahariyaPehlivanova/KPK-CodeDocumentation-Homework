namespace Cosmetics.Contracts
{
    /// <summary>
    ///  Interface which specifies the contents of each toothpaste
    /// </summary>
    public interface IToothpaste : IProduct
    {
        string Ingredients { get; }
    }
}