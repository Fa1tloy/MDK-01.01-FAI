using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_2
{
    public class Prodykti
    {
        private string nameprodykta;
        private double valueprodykta;

        public void getnames(string n)
        {
            nameprodykta = n;
        }
        public string getvaluestring()
        {
            return nameprodykta;
        }
        public void Setvalue( double v)
        {
            v = valueprodykta;
        }
        public Prodykti(string NAMESS,double PR ) 
        {
            nameprodykta = NAMESS ;
            valueprodykta = PR ;
        }
        

    }
}
