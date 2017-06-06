using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcore_sql_angular.Models
{
    [Table("VehicleFeatures")]
    public class VehicleFeature
    {
        public int VehicleId { get; set; }

        public int FeatureId { get; set; } 

        public Vehicle Vehicle { get; set; }

        public Feature Feature { get; set; }
    }
}