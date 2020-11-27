namespace FenzyCars.Data.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum FuelType
    {
        Diesel,
        Electric,
        Gas,
        [Display(Name = "Hybrid/Electric")]
        Hybrid_Electric,
        Petrol,
        [Display(Name = "Petrol/Gas")]
        Petrol_Gas,
    }
}
