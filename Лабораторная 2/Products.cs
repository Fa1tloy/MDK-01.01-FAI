using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Лабораторная_2
{
    public class Products
    {
        private string product_name;
        private double valueproduct;

        public void Setnames(string n)
        {
            product_name = n;
        }
        public string getnameinstring()
        {
            return product_name;
        }
        public void Setvalue( double v)
        {
            v = valueproduct;
        }
        public Products(string NAMESS,double PR ) 
        {
            product_name = NAMESS ;
            valueproduct = PR ;
        }
        

    }
}
