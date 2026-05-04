using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema4
{   public class Problema4
    {public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {   double suma = 0;
            int cantidadNotasV = 0;
            if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10)
         {  suma += nota1.Value;
            cantidadNotasV++;
         }
            if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
         {     suma += nota2.Value;
                cantidadNotasV++;
         }
            if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
         {   suma += nota3.Value;
                cantidadNotasV++;
         }  if (cantidadNotasV == 0)
         {  return 0;
         }  return suma / cantidadNotasV;
        }
    }
}