﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soNguyenTo
{
    public class soNguyenToo
    {
       public bool soNT(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
