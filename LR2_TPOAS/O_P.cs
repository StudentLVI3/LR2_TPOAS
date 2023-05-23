using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_TPOAS
{
    public class O_P
    {
        public double OP(double X, double Y, double Z)
        {
            // OP = sqrt((X-X0)*(X-X0) + (Y-Y0)*(Y-Y0) + (Z-Z0)*(Z-Z0)) =>
            return Math.Round(Math.Sqrt((X * X + Y * Y + Z * Z)), 3);
        }
    }
}