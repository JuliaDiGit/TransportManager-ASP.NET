using System.Collections.Generic;
using Entities.Abstract;

namespace Entities
{
    public class DriverEntity : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<VehicleEntity> Vehicles { get; set; }
        public CompanyEntity Company { get; set; }
        public int CompanyId { get; set; }
    }
}