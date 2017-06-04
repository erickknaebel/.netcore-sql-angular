using System.ComponentModel.DataAnnotations;

namespace dotnetcore_sql_angular.Models
{
    public class Feature
    {
       public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}