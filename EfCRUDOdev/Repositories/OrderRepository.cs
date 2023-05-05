using EfCRUDOdev.Context;
using EfCRUDOdev.Models;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCRUDOdev.Repositories
{
    internal class OrderRepository
    {
        public OrderRepository()
        {
            db = new NorthwindContext();
        }
        NorthwindContext db;

        public List<Order>GetAllOrders()
        {
            List<Order> orders = db.Orders.ToList();
            return orders;
        }

        public List<Order> GetOrdersByEmployeeID(int employeeID)
        {
            List<Order>orders=db.Orders.Where(x=>x.EmployeeId==employeeID).ToList();
            return orders;
        }

        public List<Order> GetOrdersByShipperID(int shipperID)
        {
            List<Order> orders = db.Orders.Where(x => x.ShipVia == shipperID).ToList();
            return orders;
        }

        public List<Order> GetOrdersByEmployeeIDAndByShipperID(int employeeID,int shipperID)
        {
            List<Order> orders = db.Orders.Where(a => a.EmployeeId == employeeID && a.ShipVia == shipperID).ToList();
            return orders;
        }

        public int AddOrder(Order order)
        {
            db.Orders.Add(order);
            int affRows=db.SaveChanges();//Etkilenen satır sayısını döner..
            return affRows;
        }

        public int UpdateOrder(Order order) 
        {
            db.Orders.Update(order);
            int affRows = db.SaveChanges();
            return affRows;
        }

        public int DeleteOrder(int orderID)
        {
            Order order = db.Orders.Find(orderID);
            db.Orders.Remove(order);
            int affRows = db.SaveChanges();
            return affRows;
        }
        public Order GetOrderByID(int orderID)
        {
            Order order=db.Orders.Find(orderID);
            return order;
        }

    }
}
