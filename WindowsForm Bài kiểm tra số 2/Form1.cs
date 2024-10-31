using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForm_Bài_kiểm_tra_số_2
{
    public partial class Form1 : Form
    {
        private BindingList<Product> productList = new BindingList<Product>(); // Sử dụng BindingList để tự động cập nhật
        private ShoppingCart shoppingCart = new ShoppingCart();

        public Form1()
        {
            InitializeComponent();

            // Kiểm tra và khởi tạo DataGridView nếu chưa có trong thiết kế
            if (dataSanpham == null)
            {
                dataSanpham = new DataGridView
                {
                    Name = "dataSanpham",
                    Location = new Point(10, 10),
                    Size = new Size(400, 200),
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                };
                this.Controls.Add(dataSanpham);
            }
        }

        public class Product
        {
            public Image Image { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }

        public class ShoppingCart
        {
            public List<Product> CartItems { get; set; } = new List<Product>();

            public decimal TotalAmount => CartItems.Sum(p => p.Price * p.Quantity);

            public void AddToCart(Product product)
            {
                var item = CartItems.FirstOrDefault(p => p.Name == product.Name);
                if (item != null)
                    item.Quantity += 1;
                else
                    CartItems.Add(new Product
                    {
                        Image = product.Image,
                        Name = product.Name,
                        Price = product.Price,
                        Quantity = 1
                    });
            }

            public void RemoveFromCart(Product product)
            {
                CartItems.Remove(product);
            }

            public void ClearCart()
            {
                CartItems.Clear();
            }
        }

        private void LoadSampleData()
        {
            productList.Add(new Product
            {
                Image = Image.FromFile("image_path_1.jpg"),
                Name = "Sản phẩm 1",
                Price = 100000,
                Quantity = 10
            });

            productList.Add(new Product
            {
                Image = Image.FromFile("image_path_2.jpg"),
                Name = "Sản phẩm 2",
                Price = 150000,
                Quantity = 5
            });

            productList.Add(new Product
            {
                Image = Image.FromFile("image_path_3.jpg"),
                Name = "Sản phẩm 3",
                Price = 200000,
                Quantity = 8
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSampleData();

            // Xóa DataSource trước khi thiết lập lại để làm mới
            dataSanpham.DataSource = null;
            dataSanpham.DataSource = productList;
            dataSanpham.Refresh();// Sử dụng BindingList làm DataSource
        }
    }
}
