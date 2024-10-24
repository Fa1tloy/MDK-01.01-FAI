using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_2
{
    public struct Prodazha
    {
        public int kolishestvo;
        public int data;
        public Prodykti product;
    }
    internal class Istoriaprodazh
    {
        Dictionary<tovarniegryppiprodyktov, List<Prodazha>> dannie;
        public void ADDdanie(int kolishestvo_2, int data_2, Prodykti product_2)
        {
            dannie.Add(kolishestvo_2 = 2, data_2 = 6,);
        }
    }
   
}
