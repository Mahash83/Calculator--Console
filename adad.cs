using System;

namespace training2._5
{
    class adad
    {
        public double x { get; set; }
        public int y { get; set; }

        public void getresult (double J)
        {var res = J ; }
        public static adad operator + (adad A , adad B)
        {
           var z =  new adad ();
           double c = A.x + B.y;
           z.getresult(c);
           
           return z;
        }
         public static adad operator * (adad A , adad B)
        {
           var z =  new adad ();
           double c = A.x * B.y;
            z.getresult(c);
           
           return z;
        }
        public static adad operator - (adad A , adad B)
        {
           var z =  new adad ();
           double c = A.x - B.y;
           z.getresult(c);
           
           return z;
        }
        public static adad operator / (adad A , adad B)
        {
           var z =  new adad ();
           double c = A.x / B.y;
           z.getresult(c);
           
           return z;
        }
        public double  tavan (double A, int  B)
        {
           double sum = 1 ;
           for (var i = 0; i < B; i++)
           {
              sum *= A ;
           }
          // double c =Math.Pow(A, B);
           return sum ;
        }
        // اضافه کردن عملیات های بیشتر
    }
}
