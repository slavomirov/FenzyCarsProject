namespace FenzyCars.Data.Models.Enums
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public enum BodyType
    {
        Coupe,
        Hatchback,
        Minibus,
        PickUp,
        Sports,
        Saloon,
        [Description("Five Door Hatchback")]
        FiveDoorHatchback,
    }
}
