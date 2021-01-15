namespace FenzyCars.Data.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum BodyTypeForSearch
    {
        Coupe,
        Hatchback,
        Minibus,
        Pickup,
        Sports,
        Saloon,
        [Display(Name = "Five Door Hatchback")]
        FiveDoorHatchback,
        All,
    }
}
