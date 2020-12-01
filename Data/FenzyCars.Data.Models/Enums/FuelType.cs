namespace FenzyCars.Data.Models.Enums
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public enum FuelType
    {
        Diesel,
        Electric,
        Gas,
        [Description("Hybrid/Electric")]
        HybridElectric,
        Petrol,
        [Description("Petrol/Gas")]
        PetrolAndGas,
    }
}
