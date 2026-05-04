using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema6
{   public static class Extensions
    {   public static string ToProductCode(this string code)
        {   if (string.IsNullOrWhiteSpace(code))
            {return "SIN-CODIGO"; //[cite: 1]
            }
            return code.Trim().ToUpper().Replace(" ", "-");
        }
    }
}