using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekSepeti.Business.Abstract;
using YemekSepeti.Business.Concrete;
using YemekSepeti.Entities.Concrete;
using YemeSepeti.DataAccess.Abstract;
using YemeSepeti.DataAccess.Concrete.EntityFramework;

namespace YemekSepeti.WebFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ICategoryService categoryService = new CategoryManager(new EfCatgoryDal());
        IProductService productService = new ProductManager(new EfProductDal());
        private void Form1_Load(object sender, EventArgs e)
        {

            GetCategory();
            GetProducts();

        }
        private void GetCategory()
        {
            foreach (var item in categoryService.GetAll())
            {
                comboBox1.Items.Add(item.CategoryName);
            }
        }
        private void GetProducts()
        {
            dataGridView1.DataSource = productService.GetAll();
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productService.GetProductsByCategory(comboBox1.SelectedIndex + 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                dataGridView1.DataSource = productService.GetProductsByProdyctName(textBox1.Text);
            }
            else
            {
                GetProducts();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            foreach (var item in categoryService.GetAll())
            {
                comboBox2.Items.Add(item.CategoryName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //productService.Add(new Product
            //{
            //    ProductName = textBox2.Text,
            //    UnitPrice = Convert.ToDecimal(textBox3.Text),
            //    QuantityPerUnit = textBox4.Text,
            //    UnitsInStock = Convert.ToInt16(textBox5.Text),
            //    CategoryId = comboBox2.SelectedIndex + 1
            //});


            MessageBox.Show("Added");
            GetProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //productService.Update(new Product
            //{
            //    ProductId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
            //    ProductName = textBox2.Text,
            //    UnitPrice = Convert.ToDecimal(textBox3.Text),
            //    QuantityPerUnit = textBox4.Text,
            //    UnitsInStock = Convert.ToInt16(textBox5.Text),
            //    CategoryId = comboBox2.SelectedIndex + 1

            //});
            MessageBox.Show("Updated");
            GetProducts();
        }

        private void button3_Click(object sender, EventArgs e)
        {  if(dataGridView1.CurrentRow != null)
            {

            productService.Delete(new Product
            {
                ProductId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())
            });
            }
            MessageBox.Show("deleted");
            GetProducts();
        }
    }
}
//private void LoadCategories()
//{
//    comboBox1.DataSource = _categoryService.GetAll();
//    comboBox1.DisplayMember = "CategoryName";
//    comboBox1.ValueMember = "CategoryId";

//    comboBox2.DataSource = _categoryService.GetAll();
//    comboBox2.DisplayMember = "CategoryName";
//    comboBox2.ValueMember = "CategoryId";
//}