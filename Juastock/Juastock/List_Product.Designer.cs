
namespace Juastock
{
    partial class List_Product
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pic = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.tbnInsertImg = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DName,
            this.Stock,
            this.Cost,
            this.Pic});
            this.dataGridView1.Location = new System.Drawing.Point(356, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 150;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 592);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PSU Stidti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1026, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("PSU Stidti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(1077, 509);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 30);
            this.txtName.TabIndex = 2;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("PSU Stidti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(1077, 555);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(221, 30);
            this.txtStock.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PSU Stidti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1022, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock :";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("PSU Stidti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(1077, 605);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(221, 30);
            this.txtCost.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PSU Stidti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1026, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(1022, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.Font = new System.Drawing.Font("PSU Stidti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBrowseImg.Location = new System.Drawing.Point(1022, 262);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(276, 39);
            this.btnBrowseImg.TabIndex = 9;
            this.btnBrowseImg.Text = "Browse";
            this.btnBrowseImg.UseVisualStyleBackColor = true;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "product_id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // DName
            // 
            this.DName.DataPropertyName = "product_name";
            this.DName.HeaderText = "Name";
            this.DName.Name = "DName";
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "product_stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "product_cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // Pic
            // 
            this.Pic.DataPropertyName = "Pic";
            this.Pic.HeaderText = "Pic";
            this.Pic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Pic.Name = "Pic";
            this.Pic.Width = 200;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("PSU Stidti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(1077, 459);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(221, 30);
            this.txtId.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PSU Stidti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1026, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID :";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("PSU Stidti", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(1022, 230);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(276, 26);
            this.txtPath.TabIndex = 12;
            // 
            // tbnInsertImg
            // 
            this.tbnInsertImg.Font = new System.Drawing.Font("PSU Stidti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbnInsertImg.Location = new System.Drawing.Point(1022, 307);
            this.tbnInsertImg.Name = "tbnInsertImg";
            this.tbnInsertImg.Size = new System.Drawing.Size(276, 39);
            this.tbnInsertImg.TabIndex = 13;
            this.tbnInsertImg.Text = "Insert";
            this.tbnInsertImg.UseVisualStyleBackColor = true;
            this.tbnInsertImg.Click += new System.EventHandler(this.tbnInsertImg_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("PSU Stidti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnUpdate.Location = new System.Drawing.Point(1022, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(276, 39);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("PSU Stidti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDelete.Location = new System.Drawing.Point(1022, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(276, 39);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // List_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 647);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbnInsertImg);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrowseImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "List_Product";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.List_Product_Load);
            this.Click += new System.EventHandler(this.List_Product_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewImageColumn Pic;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button tbnInsertImg;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

