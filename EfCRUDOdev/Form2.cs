using EfCRUDOdev.Models;
using EfCRUDOdev.Repositories;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfCRUDOdev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
            shipperRepository = new ShipperRepository();
            orderRepository = new OrderRepository();
        }
        public Form2(int orderID)
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
            shipperRepository = new ShipperRepository();
            orderRepository=new OrderRepository();
            this.orderID=orderID;
        }
        EmployeeRepository employeeRepository;
        ShipperRepository shipperRepository;
        OrderRepository orderRepository;
        int orderID = 0;
        Order order;
        private void Form2_Load(object sender, EventArgs e)
        {
            List<Employee> employees = employeeRepository.GetAllEmployees();
            cbxEmployee.DataSource = employees;
            cbxEmployee.DisplayMember = "FirstName";
            cbxEmployee.ValueMember = "EmployeeId";

            List<Shipper> shippers = shipperRepository.GetAllShippers();
            cbxShipper.DataSource = shippers;
            cbxShipper.DisplayMember = "CompanyName";
            cbxShipper.ValueMember = "ShipperId";

            if (orderID>0)
            {
                btnAdd.Text = "Update";
                order =orderRepository.GetOrderByID(orderID);
                cbxEmployee.SelectedValue = order.EmployeeId;
                cbxOrderDate.Value = order.OrderDate.Value;
                txtShipcity.Text = order.ShipCity;
                cbxShipper.SelectedValue = order.ShipVia;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            orderRepository =new OrderRepository();

            if (orderID>0)//(order is not null)
            {
                order.EmployeeId = (int)cbxEmployee.SelectedValue;
                order.OrderDate = cbxOrderDate.Value;
                order.ShipCity = txtShipcity.Text;
                order.ShipVia=(int)cbxShipper.SelectedValue;

                int affRows=orderRepository.UpdateOrder(order);
                if (affRows>0)
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Bir hata oluştu. Güncellenemedi.");
                }
                
            }
            else
            {
                order = new Order();
                order.EmployeeId = (int)cbxEmployee.SelectedValue;
                order.OrderDate = cbxOrderDate.Value;
                order.ShipCity = txtShipcity.Text;
                order.ShipVia = (int)cbxShipper.SelectedValue;
                int affRows=orderRepository.AddOrder(order);
                if (affRows > 0)
                {
                    MessageBox.Show("Ekleme Başarılı");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Eklenirken beklenmeyen bir hata oluştu.");
                }
            }

        }
    }
}
