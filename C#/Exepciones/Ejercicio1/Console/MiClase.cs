using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase miClase = new MiClase(5);
            }
            catch (Exception e)
            {
                throw new UnaExepcion("Segundo ctor de instancia", e); 
            }
        }
        public MiClase(int numero)
        {
            try
            {
                MetodoEstatico();
            }
            catch(Exception e)
            {
                throw ;
            }
        }
        
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException();
        }

    }
}
