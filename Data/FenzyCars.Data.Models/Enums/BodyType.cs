namespace FenzyCars.Data.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum BodyType
    {
        Coupe,
        Hatchback,
        Minibus,
        Pick_Up,
        Sports,
        Saloon,
        [Display(Name = "Five Door Hatchback")]
        Five_Door_Hatchback,
    }
}
