using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Star_staff_1
{
    public static class SqTri90dgr
    {
        public static object countS(object a, object b, object c)
        {
            try
            {
                double A = Convert.ToDouble(a);
                double B = Convert.ToDouble(b);
                double C = Convert.ToDouble(c);

                if (A > 0 && B > 0 && C > 0)
                {
                    if (A * A == B * B + C * C)
                        return B * C / 2.0;

                    if (B * B == A * A + C * C)
                        return A * C / 2.0;

                    if (C * C == A * A + B * B)
                        return A * B / 2.0;
                }

            }
            catch { };

            return null;
        }
    }
}
