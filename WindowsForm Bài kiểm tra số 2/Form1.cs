using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static WindowsForm_Bài_kiểm_tra_số_2.Form1;

namespace WindowsForm_Bài_kiểm_tra_số_2
{
    public partial class Form1 : Form
    {
        private BindingList<Product> productList = new BindingList<Product>(); 
        private ShoppingCart shoppingCart = new ShoppingCart();

        public Form1()
        {
            InitializeComponent();

        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public Image Image { get; set; }
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
                Name = "Sản phẩm 1",
                Price = 100000,
                Quantity = 10,
                Image = null
            });

            productList.Add(new Product
            {
                Name = "Sản phẩm 2",
                Price = 50000,
                Quantity = 10,
                Image = null
            });

            productList.Add(new Product
            {
                Name = "Sản phẩm 3",
                Price = 200000,
                Quantity = 10,
                Image = null
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSampleData();
            dataSanpham.AutoGenerateColumns = true;
            dataSanpham.DataSource = null;
            dataSanpham.DataSource = productList;
            dataSanpham.Refresh();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var selectedProduct = dataSanpham.CurrentRow?.DataBoundItem as Product;

            if (selectedProduct != null)
            {
                shoppingCart.AddToCart(selectedProduct);
                UpdateCartDisplay();
                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để thêm vào giỏ hàng.");
            }
        }
        private void UpdateCartDisplay()
        {
            data_giohang.DataSource = null;
            data_giohang.DataSource = shoppingCart.CartItems;
            data_giohang.Refresh();
        }
        private void UpdateTotalAmount()
        {
            decimal totalAmount = shoppingCart.TotalAmount;
            txt_tongtien.Text = totalAmount.ToString("N0") + " VND";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            shoppingCart.ClearCart();
            UpdateCartDisplay();
            UpdateTotalAmount();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            shoppingCart.ClearCart();
            UpdateCartDisplay();
            UpdateTotalAmount();
            MessageBox.Show("Thanh toán thành công!");
        }
    }
}
