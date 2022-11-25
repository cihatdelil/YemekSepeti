using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekSepeti.Business.Abstract;
using YemekSepeti.Business.Concrete;
using YemeSepeti.DataAccess.Concrete.EntityFramework;

namespace YemekSepeti.WebFormUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ICategoryService categoryService = new CategoryManager(new EfCatgoryDal());
        IProductService productService = new ProductManager(new EfProductDal());
        ICommonService commonService=new CommonManager(new EfCommonDal());  
        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource= productService.GetProductsByCategory(5);

            foreach (var item in productService.GetProductsByCategory(5))
            {
                comboBox1.Items.Add(item.ProductName);
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = commonService.GetAll();
        }
    }
}
