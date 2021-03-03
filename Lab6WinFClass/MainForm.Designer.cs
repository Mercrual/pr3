namespace Lab6WinFClass
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PannelBottom = new System.Windows.Forms.Panel();
            this.TxtBoxProvider = new System.Windows.Forms.TextBox();
            this.TxtBoxNameProduct = new System.Windows.Forms.TextBox();
            this.NumUDPriceProduct = new System.Windows.Forms.NumericUpDown();
            this.NumUDCountProduct = new System.Windows.Forms.NumericUpDown();
            this.NumUDId = new System.Windows.Forms.NumericUpDown();
            this.LabPriceProduct = new System.Windows.Forms.Label();
            this.LabCountProduct = new System.Windows.Forms.Label();
            this.LabProvider = new System.Windows.Forms.Label();
            this.LabId = new System.Windows.Forms.Label();
            this.LabNameProduct = new System.Windows.Forms.Label();
            this.PanelFill = new System.Windows.Forms.Panel();
            this.BtnSumProduct = new System.Windows.Forms.Button();
            this.BtnInfProduct = new System.Windows.Forms.Button();
            this.PannelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPriceProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCountProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDId)).BeginInit();
            this.PanelFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(534, 50);
            this.PanelTop.TabIndex = 0;
            // 
            // PannelBottom
            // 
            this.PannelBottom.BackColor = System.Drawing.Color.Aquamarine;
            this.PannelBottom.Controls.Add(this.TxtBoxProvider);
            this.PannelBottom.Controls.Add(this.TxtBoxNameProduct);
            this.PannelBottom.Controls.Add(this.NumUDPriceProduct);
            this.PannelBottom.Controls.Add(this.NumUDCountProduct);
            this.PannelBottom.Controls.Add(this.NumUDId);
            this.PannelBottom.Controls.Add(this.LabPriceProduct);
            this.PannelBottom.Controls.Add(this.LabCountProduct);
            this.PannelBottom.Controls.Add(this.LabProvider);
            this.PannelBottom.Controls.Add(this.LabId);
            this.PannelBottom.Controls.Add(this.LabNameProduct);
            this.PannelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PannelBottom.Location = new System.Drawing.Point(0, 50);
            this.PannelBottom.Name = "PannelBottom";
            this.PannelBottom.Size = new System.Drawing.Size(534, 311);
            this.PannelBottom.TabIndex = 1;
            // 
            // TxtBoxProvider
            // 
            this.TxtBoxProvider.Location = new System.Drawing.Point(16, 206);
            this.TxtBoxProvider.Name = "TxtBoxProvider";
            this.TxtBoxProvider.Size = new System.Drawing.Size(200, 31);
            this.TxtBoxProvider.TabIndex = 8;
            // 
            // TxtBoxNameProduct
            // 
            this.TxtBoxNameProduct.Location = new System.Drawing.Point(16, 118);
            this.TxtBoxNameProduct.Name = "TxtBoxNameProduct";
            this.TxtBoxNameProduct.Size = new System.Drawing.Size(200, 31);
            this.TxtBoxNameProduct.TabIndex = 7;
            // 
            // NumUDPriceProduct
            // 
            this.NumUDPriceProduct.DecimalPlaces = 2;
            this.NumUDPriceProduct.Location = new System.Drawing.Point(284, 119);
            this.NumUDPriceProduct.Name = "NumUDPriceProduct";
            this.NumUDPriceProduct.Size = new System.Drawing.Size(150, 31);
            this.NumUDPriceProduct.TabIndex = 6;
            // 
            // NumUDCountProduct
            // 
            this.NumUDCountProduct.Location = new System.Drawing.Point(284, 29);
            this.NumUDCountProduct.Name = "NumUDCountProduct";
            this.NumUDCountProduct.Size = new System.Drawing.Size(150, 31);
            this.NumUDCountProduct.TabIndex = 5;
            // 
            // NumUDId
            // 
            this.NumUDId.Location = new System.Drawing.Point(16, 29);
            this.NumUDId.Name = "NumUDId";
            this.NumUDId.Size = new System.Drawing.Size(150, 31);
            this.NumUDId.TabIndex = 4;
            // 
            // LabPriceProduct
            // 
            this.LabPriceProduct.AutoSize = true;
            this.LabPriceProduct.Location = new System.Drawing.Point(280, 89);
            this.LabPriceProduct.Name = "LabPriceProduct";
            this.LabPriceProduct.Size = new System.Drawing.Size(172, 23);
            this.LabPriceProduct.TabIndex = 3;
            this.LabPriceProduct.Text = "Стоимость продукта";
            // 
            // LabCountProduct
            // 
            this.LabCountProduct.AutoSize = true;
            this.LabCountProduct.Location = new System.Drawing.Point(280, 3);
            this.LabCountProduct.Name = "LabCountProduct";
            this.LabCountProduct.Size = new System.Drawing.Size(180, 23);
            this.LabCountProduct.TabIndex = 2;
            this.LabCountProduct.Text = "Количество продукта";
            // 
            // LabProvider
            // 
            this.LabProvider.AutoSize = true;
            this.LabProvider.Location = new System.Drawing.Point(8, 180);
            this.LabProvider.Name = "LabProvider";
            this.LabProvider.Size = new System.Drawing.Size(98, 23);
            this.LabProvider.TabIndex = 1;
            this.LabProvider.Text = "Поставщик";
            this.LabProvider.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabId
            // 
            this.LabId.AutoSize = true;
            this.LabId.Location = new System.Drawing.Point(8, 3);
            this.LabId.Name = "LabId";
            this.LabId.Size = new System.Drawing.Size(28, 23);
            this.LabId.TabIndex = 0;
            this.LabId.Text = "ID";
            // 
            // LabNameProduct
            // 
            this.LabNameProduct.AutoSize = true;
            this.LabNameProduct.Location = new System.Drawing.Point(8, 89);
            this.LabNameProduct.Name = "LabNameProduct";
            this.LabNameProduct.Size = new System.Drawing.Size(208, 23);
            this.LabNameProduct.TabIndex = 0;
            this.LabNameProduct.Text = "Наименование продукта";
            // 
            // PanelFill
            // 
            this.PanelFill.BackColor = System.Drawing.Color.PowderBlue;
            this.PanelFill.Controls.Add(this.BtnSumProduct);
            this.PanelFill.Controls.Add(this.BtnInfProduct);
            this.PanelFill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFill.Location = new System.Drawing.Point(0, 309);
            this.PanelFill.Name = "PanelFill";
            this.PanelFill.Size = new System.Drawing.Size(534, 52);
            this.PanelFill.TabIndex = 2;
            // 
            // BtnSumProduct
            // 
            this.BtnSumProduct.Location = new System.Drawing.Point(350, 8);
            this.BtnSumProduct.Name = "BtnSumProduct";
            this.BtnSumProduct.Size = new System.Drawing.Size(181, 32);
            this.BtnSumProduct.TabIndex = 1;
            this.BtnSumProduct.Text = "Общая стоимость";
            this.BtnSumProduct.UseVisualStyleBackColor = true;
            this.BtnSumProduct.Click += new System.EventHandler(this.BtnSumProduct_Click);
            // 
            // BtnInfProduct
            // 
            this.BtnInfProduct.Location = new System.Drawing.Point(201, 8);
            this.BtnInfProduct.Name = "BtnInfProduct";
            this.BtnInfProduct.Size = new System.Drawing.Size(124, 32);
            this.BtnInfProduct.TabIndex = 0;
            this.BtnInfProduct.Text = "Информация";
            this.BtnInfProduct.UseVisualStyleBackColor = true;
            this.BtnInfProduct.Click += new System.EventHandler(this.BtnInfProduct_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.PanelFill);
            this.Controls.Add(this.PannelBottom);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 450);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PannelBottom.ResumeLayout(false);
            this.PannelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPriceProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCountProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDId)).EndInit();
            this.PanelFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PannelBottom;
        private System.Windows.Forms.Panel PanelFill;
        private System.Windows.Forms.Label LabId;
        private System.Windows.Forms.Label LabNameProduct;
        private System.Windows.Forms.Label LabProvider;
        private System.Windows.Forms.TextBox TxtBoxProvider;
        private System.Windows.Forms.TextBox TxtBoxNameProduct;
        private System.Windows.Forms.NumericUpDown NumUDPriceProduct;
        private System.Windows.Forms.NumericUpDown NumUDCountProduct;
        private System.Windows.Forms.NumericUpDown NumUDId;
        private System.Windows.Forms.Label LabPriceProduct;
        private System.Windows.Forms.Label LabCountProduct;
        private System.Windows.Forms.Button BtnSumProduct;
        private System.Windows.Forms.Button BtnInfProduct;
    }
}

