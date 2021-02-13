using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace Repository
{

    public class DBRepository
    {
        String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Customer";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer()
                        {
                            CustomerId = (int)reader["Id"],
                            CustomerFirstName = (string)reader["FirstName"],
                            CustomerLastName = (string)reader["LastName"],
                            CustomerCity = (string)reader["City"],
                            CustomerCountry = (string)reader["Country"],
                            CustomerPhone = (string)reader["Phone"]
                        });
                    }
                }
                connection.Close();
            }
            return customers;
        }
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Orders";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order()
                        {
                            OrderId = (int)reader["Id"],
                            OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                            OrderNumber = (string)reader["OrderNumber"],
                            OrderCustomerId = (int)reader["CustomerId"],
                            OrderTotalAmount = (decimal)reader["TotalAmount"]
                        });
                    }
                }
                connection.Close();
            }
            return orders;
        }
        public List<OrderItem> GetOrderItems()
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM OrderItem";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orderItems.Add(new OrderItem()
                        {
                            OrderItemId = (int)reader["Id"],
                            OrderItemOrderId = (int)reader["OrderId"],
                            OrderItemProductId = (int)reader["ProductId"],
                            OrderItemUnitPrice = (decimal)reader["UnitPrice"],
                            OrderItemQuantity = (int)reader["Quantity"]
                        });
                    }
                }
                connection.Close();
            }
            return orderItems;
        }
        public List<OrderVM> GetOrdersToDisplay()
        {
            var orders = GetOrders();
            var customers = GetCustomers();
            var orderItems = GetOrderItems();
            List<OrderVM> orderVMs = new List<OrderVM>();
            foreach (Order order in orders)
            {
                orderVMs.Add(new OrderVM()
                {
                    OrderVMId = order.OrderId,
                    OrderVMNumber = order.OrderNumber,
                    OrderVMDate = Convert.ToDateTime(order.OrderDate),
                    OrderVMTotalAmount = (decimal)order.OrderTotalAmount,
                    OrderVMCustomerFullName = customers.Where(x => x.CustomerId == order.OrderCustomerId).Select(y => y.CustomerFirstName + " " + y.CustomerLastName).FirstOrDefault().ToString(),
                    OrderVMItems = orderItems.Where(x => x.OrderItemOrderId == order.OrderId).ToList()
                });
            }
            return orderVMs;
        }
        public List<OrderItemVM> GetOrderItemsOfOrder(int orderId) 
        {
            var orders = GetOrdersToDisplay();
            var products = GetProducts();
            List<OrderItemVM> orderItemsVMs = new List<OrderItemVM>();
            foreach (OrderVM order in orders) 
            {
                
                if (order.OrderVMId == orderId)
                {
                    foreach (OrderItem orderItem in order.OrderVMItems) 
                    {
                        orderItemsVMs.Add(new OrderItemVM()
                        {
                            OrderItemVMId = orderItem.OrderItemId,
                            OrderItemVMProductName = products.Where(x=>x.ProductId == orderItem.OrderItemProductId).Select(y=>y.ProductName).FirstOrDefault().ToString(),
                            OrderItemVMProductPackage = products.Where(x => x.ProductId == orderItem.OrderItemProductId).Select(y=>y.ProductPackage).FirstOrDefault().ToString(),
                            OrderItemVMUnitPrice = (decimal)orderItem.OrderItemUnitPrice,
                            OrderItemVMQuantity = orderItem.OrderItemQuantity
                        });
                    }
                }
            }
            return orderItemsVMs;
        }
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Product";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product()
                        {
                            ProductId = (int)reader["Id"],
                            ProductName = (string)reader["ProductName"],
                            ProductSupplierId = (int)reader["SupplierId"],
                            ProductUnitPrice = (decimal)reader["UnitPrice"],
                            ProductPackage = (string)reader["Package"],
                            ProductIsDiscontinued = (bool)reader["IsDiscontinued"]
                        });
                    }
                }
                connection.Close();
            }
            return products;
        }
        public List<ProductVM> GetProductsToDisplay() 
        {
            var products = GetProducts();
            var suppliers = GetSuppliers();
            List<ProductVM> productVMs = new List<ProductVM>();
            foreach (var product in products)
            {
                productVMs.Add(new ProductVM()
                {
                    ProductVMId = product.ProductId,
                    ProductVMName = product.ProductName,
                    ProductVMSupplierName = suppliers.Where(x=>x.SupplierId == product.ProductSupplierId).Select(y=>y.SupplierCompanyName).FirstOrDefault().ToString(),
                    ProductVMUnitPrice = product.ProductUnitPrice,
                    ProductVMPackage = product.ProductPackage,
                    ProductVMIsDiscontinued = product.ProductIsDiscontinued
                });
            }
            return productVMs;
        }
        public List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Supplier";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(new Supplier()
                        {
                            SupplierId = (int)reader["Id"],
                            SupplierCompanyName = (string)reader["CompanyName"],
                            SupplierContactName = (string)reader["ContactName"],
                            SupplierContactTitle = (string)reader["ContactTitle"],
                            SupplierCity = (string)reader["City"],
                            SupplierCountry = (string)reader["Country"],
                            SupplierPhone = (string)reader["Phone"],
                            SupplierFax = (string)reader["Fax"]
                        });
                    }
                }
                connection.Close();
            }
            return suppliers;
        }
    }
}
