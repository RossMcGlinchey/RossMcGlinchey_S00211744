using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossMcGlinchey_S00211744
{
    public class RentalProperty
    {
        //Properties
        public int ID { get; set; }
        public enum RentalType { House, Flat, Share }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }


        //Constructor

        //Methods
        public void IncreaseRent(decimal percentIncrease)
        {
            Price = Price + (Price * percentIncrease / 100);
        }

        public override string ToString()
        {
            return Location;
        }
    } //End of RentalProperty class

    public class RentalData:DbContext
    {
        public RentalData() : base("MyRentalData") { }

        public DbSet<RentalProperty> Properties { get; set; }
    }
}
