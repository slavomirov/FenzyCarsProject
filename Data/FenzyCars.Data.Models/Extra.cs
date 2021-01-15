namespace FenzyCars.Data.Models
{
    using System.Collections.Generic;

    public class Extra
    {
        public Extra()
        {
            this.CarExtras = new HashSet<CarExtra>();
        }

        public int Id { get; set; }

        public string Details { get; set; }

        public bool Selected { get; set; }

        public ICollection<CarExtra> CarExtras { get; set; }
    }
}
