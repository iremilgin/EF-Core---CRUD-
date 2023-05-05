using EfCRUDOdev.Context;
using EfCRUDOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCRUDOdev.Repositories
{
    internal class ShipperRepository
    {
        public ShipperRepository()
        {
            db = new NorthwindContext();
        }
        NorthwindContext db;

        public List<Shipper>GetAllShippers()
        {
            List<Shipper>shippers=db.Shippers.ToList();
            return shippers;
        }
    }
}
