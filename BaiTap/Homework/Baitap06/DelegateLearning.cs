using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Homework.Baitap06
{
    public class DelegateLearning
    {
        #region Method

        int Sum(int a, int b)
        {
            return a + b;
        }

        int Substract(int a, int b)
        {
            return a - b;
        }

        int Plus(int a, int b)
        {
            return a * b;
        }
        #endregion


        #region Delegate
        //Khai báo một delegate
        public delegate int PhepTinh(int a, int b);

        //Khởi tạo Delegate
        PhepTinh subDelegate = (a, b) => a - b;
        PhepTinh sumDelegate = (x, y) => x + y;

        public int testDele()
        {
            //Gọi Delegate
            int a = 0;
            a = subDelegate(3,7);
            return a;
        }



    }


        #endregion
    }
