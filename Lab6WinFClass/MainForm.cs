using Lab6WinFClass.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6WinFClass
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

            private void BtnInfProduct_Click(object sender, EventArgs e)
            {
                //заполнение свойств экемпляра класса Shop
                product.IdProduct = Convert.ToInt32(NumUDId.Value);
                product.NameProduct = TxtBoxNameProduct.Text;
                product.Provider = TxtBoxProvider.Text;
                product.CountProduct =
               Convert.ToInt32(NumUDCountProduct.Value);
                product.PriceProduct =
               Convert.ToDouble(NumUDPriceProduct.Value);
                //извлечение значение изсвойства
                MessageBox.Show(product.InfProduct);
            }

        private void BtnSumProduct_Click(object sender, EventArgs e)
        {
                //заполнение свойств экемпляра класса Shop
                product.IdProduct = Convert.ToInt32(NumUDId.Value);
 product.NameProduct = TxtBoxNameProduct.Text;
                product.Provider = TxtBoxProvider.Text;
                product.CountProduct =
               Convert.ToInt32(NumUDCountProduct.Value);
                product.PriceProduct =
               Convert.ToDouble(NumUDPriceProduct.Value);
                //извлечение значение изсвойства
                MessageBox.Show(product.SumProduct().ToString());
            }
        }
    }
    namespace Lab6WinFClass
    {
        public partial class MainForm : Form
        {
            //создание экземпляра класса Shop
            private Shop product = new Shop();
        }
    }
