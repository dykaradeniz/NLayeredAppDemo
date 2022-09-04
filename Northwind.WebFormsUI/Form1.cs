using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IProductService _productService = InstanceFactory.GetInstance<IProductService>();
        //IProductService _productService2 = new ProductManager(new EfProductDal());
        ICategoryService _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        //ICategoryService _categoryService2 = new CategoryManager(new EfCategoryDal());
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategory();
            LoadCategoryId();
        }

        private void LoadCategory()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void LoadCategoryId()
        {
            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

            cbxCategoryIdUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryIdUpdate.DisplayMember = "CategoryName";
            cbxCategoryIdUpdate.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch 
            {

            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSearch.Text))
            {
                LoadProducts();
            }
            else
            {
                dgwProducts.DataSource = _productService.GetProductByName(tbxSearch.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductName.Text,
                    QuantityPerUnit = tbxQuantity.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAmount.Text)
                });

                MessageBox.Show("Ürün eklendi!!");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                    ProductName = tbxProductNameUpdate.Text,
                    QuantityPerUnit = tbxQuantityUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAmountUpdate.Text)

                });
                MessageBox.Show("Ürün güncellendi!!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProducts.CurrentRow;

            tbxProductNameUpdate.Text = row.Cells[2].Value.ToString();
            cbxCategoryIdUpdate.SelectedValue=row.Cells[1].Value;
            tbxUnitPriceUpdate.Text=row.Cells[3].Value.ToString();
            tbxQuantityUpdate.Text=row.Cells[4].Value.ToString();
            tbxStockAmountUpdate.Text=row.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwProducts.CurrentRow != null)
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
                    });
                }
                MessageBox.Show("Ürün silindi!!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        
    }
}