using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6WinFClass.Models
{
 
        class Shop
        {
            public int IdProduct { set; get; }
            //{ set; get; } означает что полю можно задать значение
            //и получить значение соответственно
            public String NameProduct { set; get; }
            public String Provider { set; get; }
            public int CountProduct { set; get; }
            public double PriceProduct { set; get; }
            public String InfProduct
            {
                get
                {
                    return String.Format("Продукт {0} доставлен поставщиком {1}",
                NameProduct, Provider);
                }
            }
            public double SumProduct()
            {
                return CountProduct * PriceProduct;
            }
        }
    }

