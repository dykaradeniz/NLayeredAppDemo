namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxQuantityUpdate = new System.Windows.Forms.TextBox();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblQuantity2 = new System.Windows.Forms.Label();
            this.lblStockAmount2 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblCategory2 = new System.Windows.Forms.Label();
            this.lblProductName2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            this.gbxUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 246);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(947, 201);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(11, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(947, 105);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(107, 46);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(261, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(33, 49);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori:";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxSearch);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(12, 123);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(947, 105);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Ara";
           
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(107, 56);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(261, 22);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(33, 59);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(61, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı:";
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.cbxCategoryId);
            this.gbxAddProduct.Controls.Add(this.btnAdd);
            this.gbxAddProduct.Controls.Add(this.tbxQuantity);
            this.gbxAddProduct.Controls.Add(this.tbxStockAmount);
            this.gbxAddProduct.Controls.Add(this.tbxUnitPrice);
            this.gbxAddProduct.Controls.Add(this.tbxProductName);
            this.gbxAddProduct.Controls.Add(this.lblQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.lblStock);
            this.gbxAddProduct.Controls.Add(this.lblUnitPrice);
            this.gbxAddProduct.Controls.Add(this.lblCategoryId);
            this.gbxAddProduct.Controls.Add(this.lblName);
            this.gbxAddProduct.Location = new System.Drawing.Point(12, 462);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(409, 291);
            this.gbxAddProduct.TabIndex = 3;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Yeni Ürün Ekle";
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(121, 87);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(247, 24);
            this.cbxCategoryId.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(157, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 31);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(122, 220);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(246, 22);
            this.tbxQuantity.TabIndex = 9;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(122, 177);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(246, 22);
            this.tbxStockAmount.TabIndex = 8;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(121, 134);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(246, 22);
            this.tbxUnitPrice.TabIndex = 7;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(121, 42);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(246, 22);
            this.tbxProductName.TabIndex = 5;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(27, 223);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(79, 16);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Birim Adedi:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(27, 177);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(68, 16);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok Adet:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(27, 134);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(39, 16);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Fiyat:";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(27, 87);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(60, 16);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Kategori:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ürün Adı:";
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.cbxCategoryIdUpdate);
            this.gbxUpdateProduct.Controls.Add(this.btnUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxQuantityUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxStockAmountUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxProductNameUpdate);
            this.gbxUpdateProduct.Controls.Add(this.lblQuantity2);
            this.gbxUpdateProduct.Controls.Add(this.lblStockAmount2);
            this.gbxUpdateProduct.Controls.Add(this.lblPrice2);
            this.gbxUpdateProduct.Controls.Add(this.lblCategory2);
            this.gbxUpdateProduct.Controls.Add(this.lblProductName2);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(447, 462);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(409, 291);
            this.gbxUpdateProduct.TabIndex = 11;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Ürünü Güncelle";
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(121, 87);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(247, 24);
            this.cbxCategoryIdUpdate.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(157, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 31);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxQuantityUpdate
            // 
            this.tbxQuantityUpdate.Location = new System.Drawing.Point(122, 220);
            this.tbxQuantityUpdate.Name = "tbxQuantityUpdate";
            this.tbxQuantityUpdate.Size = new System.Drawing.Size(246, 22);
            this.tbxQuantityUpdate.TabIndex = 9;
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(122, 177);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(246, 22);
            this.tbxStockAmountUpdate.TabIndex = 8;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(121, 134);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(246, 22);
            this.tbxUnitPriceUpdate.TabIndex = 7;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(121, 42);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(246, 22);
            this.tbxProductNameUpdate.TabIndex = 5;
            // 
            // lblQuantity2
            // 
            this.lblQuantity2.AutoSize = true;
            this.lblQuantity2.Location = new System.Drawing.Point(27, 223);
            this.lblQuantity2.Name = "lblQuantity2";
            this.lblQuantity2.Size = new System.Drawing.Size(79, 16);
            this.lblQuantity2.TabIndex = 4;
            this.lblQuantity2.Text = "Birim Adedi:";
            // 
            // lblStockAmount2
            // 
            this.lblStockAmount2.AutoSize = true;
            this.lblStockAmount2.Location = new System.Drawing.Point(27, 177);
            this.lblStockAmount2.Name = "lblStockAmount2";
            this.lblStockAmount2.Size = new System.Drawing.Size(68, 16);
            this.lblStockAmount2.TabIndex = 3;
            this.lblStockAmount2.Text = "Stok Adet:";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Location = new System.Drawing.Point(27, 134);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(39, 16);
            this.lblPrice2.TabIndex = 2;
            this.lblPrice2.Text = "Fiyat:";
            // 
            // lblCategory2
            // 
            this.lblCategory2.AutoSize = true;
            this.lblCategory2.Location = new System.Drawing.Point(27, 87);
            this.lblCategory2.Name = "lblCategory2";
            this.lblCategory2.Size = new System.Drawing.Size(60, 16);
            this.lblCategory2.TabIndex = 1;
            this.lblCategory2.Text = "Kategori:";
            // 
            // lblProductName2
            // 
            this.lblProductName2.AutoSize = true;
            this.lblProductName2.Location = new System.Drawing.Point(27, 42);
            this.lblProductName2.Name = "lblProductName2";
            this.lblProductName2.Size = new System.Drawing.Size(61, 16);
            this.lblProductName2.TabIndex = 0;
            this.lblProductName2.Text = "Ürün Adı:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(880, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 54);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 765);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxQuantityUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblQuantity2;
        private System.Windows.Forms.Label lblStockAmount2;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblCategory2;
        private System.Windows.Forms.Label lblProductName2;
        private System.Windows.Forms.Button btnDelete;
    }
}

