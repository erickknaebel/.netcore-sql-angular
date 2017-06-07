using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DealerApp.Models;
using dotnetcore_sql_angular.Models;

namespace dotnetcore_sql_angular.Resources
{

    public class VehicleResource
    {
        public int Id { get; set; }

        public int ModelId { get; set; }
        
        public bool IsRegistered { get; set; }


        public DateTime LastUpdate { get; set; }

        public ContactResource Contact { get; set; }

        public ICollection<int> Features { get; set; }

        public VehicleResource()
        {
            Features = new Collection<int>();
        }
    }
}