using EfCRUDOdev.Models;
using EfCRUDOdev.Repositories;

namespace EfCRUDOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
            shipperRepository = new ShipperRepository();

        }
        EmployeeRepository employeeRepository;
        ShipperRepository shipperRepository;
        OrderRepository orderRepository;
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> employees = employeeRepository.GetAllEmployees();
            foreach (Employee employee in employees)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = employee.FirstName + " " + employee.LastName;
                lvi.Tag = employee.EmployeeId;
                lvEmployeeName.Items.Add(lvi);
            }

            List<Shipper> shippers = shipperRepository.GetAllShippers();
            foreach (Shipper shipper in shippers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = shipper.CompanyName;
                lvi.Tag = shipper.ShipperId;
                lvShipperName.Items.Add(lvi);
            }

        }
        private void btnGetOrderList_Click(object sender, EventArgs e)
        {
            lvOrderDetail.Items.Clear();
            orderRepository = new OrderRepository();
            bool isEmployeeChecked = lvEmployeeName.SelectedItems.Count > 0;
            bool isShipperChecked = lvShipperName.SelectedItems.Count > 0;

            if (isEmployeeChecked && isShipperChecked)
            {
                int employeeID = (int)lvEmployeeName.FocusedItem.Tag;
                int shipperID = (int)lvShipperName.FocusedItem.Tag;
                List<Order> orders = orderRepository.GetOrdersByEmployeeIDAndByShipperID(employeeID, shipperID);
                FillOrdersListView(orders);

            }
            else if (isEmployeeChecked)
            {
                int employeeID = (int)lvEmployeeName.FocusedItem.Tag;
                List<Order> orders = orderRepository.GetOrdersByEmployeeID(employeeID);
                FillOrdersListView(orders);
            }
            else if (isShipperChecked)
            {
                int shipperID = (int)lvShipperName.FocusedItem.Tag;
                List<Order> orders = orderRepository.GetOrdersByShipperID(shipperID);
                FillOrdersListView(orders);
            }
            else
            {
                List<Order> orders = orderRepository.GetAllOrders();
                FillOrdersListView(orders);
            }
        }
        private void FillOrdersListView(List<Order> orders)
        {
            if (orders is not null)
            {
                foreach (Order order in orders)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = order.OrderId.ToString();
                    lvi.SubItems.Add(order.OrderDate.Value.ToShortTimeString());
                    lvi.SubItems.Add(order.ShipCity);
                    lvi.Tag = order.OrderId;
                    lvOrderDetail.Items.Add(lvi);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int orderID = (int)lvOrderDetail.FocusedItem.Tag;
            Form2 form2 = new Form2(orderID);
            form2.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silme iþlemini onaylýyor musunuz?", "Onay Mesajý", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (lvOrderDetail.SelectedItems.Count>0)
                {
                    int orderID=(int)lvOrderDetail.FocusedItem.Tag;
                    int affRows=orderRepository.DeleteOrder(orderID);
                    if (affRows > 0)
                    {
                        MessageBox.Show($"{orderID}id'li sipariþ baþarýyla silindi");
                        
                    }
                    else
                    {
                        MessageBox.Show("Silme iþlemi gerçekleþtirilemedi");
                    }

                }

            }
        }
    }
}