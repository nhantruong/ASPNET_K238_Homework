using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai04.Giaiphuongtrinh
{
    public class GiaiPhuongTrinh
    {
        #region Properties

        private double _SoA;

        public double SoA
        {
            get { return _SoA; }
            set
            {
                if (value == 0) throw new Exception("Số A phải khác 0");
               _SoA = value;
            }
        }
        //Kiểm tra chuỗi nhập vào là Ký tự hay Số
        private bool IsNumber(string pvalue)
        {
            foreach (Char c in pvalue)
            {
                if (!Char.IsDigit(c)) return false;
            }
            return true;
        }

        private double _SoB;

        public double SoB
        {
            get { return _SoB; }
            set { _SoB = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Giải phương trình bậc 1, có dạng Ax+B=0, không bao gồm biến
        /// </summary>
        public GiaiPhuongTrinh() { }
        /// <summary>
        /// Giải phương trình bậc 1, có dạng Ax+B=0, bao gồm biến
        /// </summary>
        /// <param name="SoA"></param>
        /// <param name="SoB"></param>
        public GiaiPhuongTrinh(double SoA, double SoB)
        {
            this.SoA = SoA;
            this.SoB = SoB;
        }

        #endregion

        #region Method
        /// <summary>
        /// Method Giải phương trình bậc 1 với tham số đầu vào A và B
        /// </summary>
        /// <param name="SoA"></param>
        /// <param name="SoB"></param>
        /// <returns></returns>
        public string GiaiPT(double SoA, double SoB)
        {
            string kq = "";
            this.SoA = SoA;
            this.SoB = SoB;
            if (SoA==0)
            {
                return kq = "Phương trình vô nghiệm";
            }
            double x = -SoB / SoA;
            kq = string.Format("Phương trình có nghiệm: {0}", x);
            return kq;
        }


        #endregion

    }
}