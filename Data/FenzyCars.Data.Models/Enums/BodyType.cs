namespace FenzyCars.Data.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum BodyType
    {
        Coupe,
        Hatchback,
        Minibus,
        Pickup,
        Sports,
        Saloon,
        [Display(Name ="Five Door Hatchback")]
        FiveDoorHatchback,
    }
}
