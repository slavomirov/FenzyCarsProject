﻿namespace FenzyCars.Data.Models.Enums
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public enum FuelTypeForSearch
    {
        Diesel,
        Electric,
        Gas,
        [Display(Name = "Hybrid/Electric")]
        HybridElectric,
        Petrol,
        [Display(Name = "Petrol/Gas")]
        PetrolAndGas,
        All
    }
}
