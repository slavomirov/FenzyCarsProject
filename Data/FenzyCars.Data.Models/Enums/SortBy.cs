namespace FenzyCars.Data.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum SortBy
    {
        Hp,
        Mileage,
        [Display(Name = "Engine size")]
        EngineSize,
        Year,
        Price,
        Default,
    }
}
