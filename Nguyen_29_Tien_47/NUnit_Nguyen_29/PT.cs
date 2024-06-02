using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Nguyen_29
{
    public class PT
    {
        //Khai bao bien he so a,b,c - KhaiNguyen_29
        private float a, b, c;
        //Constructor
        public PT(float a, float b, float c = 0)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //Ham tinh phuong trinh bac 1
        public String PTB1_KhaiNguyen_29()
        {
            String result;
            if (this.a == 0)
            {
                if (this.b == 0)
                {
                    result = "VSN";     // neu a=0 va b=0 thi PT vo so nghiem
                }
                else
                {
                    result = "VN";      // neu a=0 va b!=0 thi PT vo nghiem
                }
            }
            else
            {
                float res = -(this.b / this.a);    //neu a!=0 va b!=0 thi PT co nghiem duy nhat
                result = res.ToString();            // ep nghiem ve kieu string de dong bo
            }
            return result;
        }

        public List<String> PTB2_KhaiNguyen_29()
        {
            List<String> result = new List<String>();       //Dang tra ve la kieu list vi PTB2 co the co 2 nghiem
            if (a == 0)
            {
                String res = this.PTB1_KhaiNguyen_29();     //Neu PTB2 co he so a=0 thi se quay ve bai toan PTB1
                result.Add(res);
            }
            else
            {
                float delta = this.b * this.b - 4 * this.a * this.c;        //tinh delta
                if (delta < 0)
                {
                    result.Add("VN");                                       //TH delta<0 thi se tra ve kqua la VN
                }
                else if (delta == 0)
                {
                    float x = -this.b / (2 * this.a);                   //TH delta=0 thi se tra ve kqua la nghiem kep x
                    result.Add(x.ToString());
                }
                else                                                        //TH delta>0 thi se tra ve kqua 2 nghiem
                {
                    float x1 = (float)(-this.b - Math.Sqrt(delta)) / (2 * this.a);
                    float x2 = (float)(-this.b + Math.Sqrt(delta)) / (2 * this.a);
                    result.Add(x1.ToString());
                    result.Add(x2.ToString());
                }
            }
            return result;
        }
    }
}
