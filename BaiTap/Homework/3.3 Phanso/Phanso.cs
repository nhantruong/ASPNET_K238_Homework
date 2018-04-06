using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Homework._3._3_Phanso
{
    public class Phanso
    {
        #region Properties


        private int _TuSo = 1;

        public int TuSo
        {
            get { return _TuSo; }
            set { _TuSo = value; }
        }
        private int _MauSo = 1;

        public int MauSo
        {
            get { return _MauSo; }
            set
            {
                if (value == 0) throw new Exception("Giá trị của Mẫu số phải khác 0");
                _MauSo = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Đối tượng kiểu Phân Số không tham số
        /// </summary>
        public Phanso() { }

        /// <summary>
        /// Đối tượng kiểu Phân Số có tham số đầu vào Tử số và Mẩu số
        /// </summary>
        /// <param name="tuSo"></param>
        /// <param name="mauSo"></param>
        public Phanso(int tuSo, int mauSo)
        {
            this.TuSo = tuSo;
            this.MauSo = mauSo;
        }

        #endregion

        #region Method
        public string Xuat()
        {
            string kq = "";
            if (_TuSo == _MauSo)
            {
                kq = "1";
            }
            else if (_MauSo==1)
            {
                kq = _TuSo.ToString();
            }
            else
            {
                kq = _TuSo.ToString() + "/" + _MauSo.ToString();
            }
            return kq;
        }

        public static Phanso Parse(string chuoi)
        {
            Phanso phanso = new Phanso();
            phanso._TuSo = int.Parse(chuoi.Split('/')[0]);
            phanso._MauSo = int.Parse(chuoi.Split('/')[1]);
            return phanso;
        }
    
        private Phanso ToiGian(Phanso p)
        {
            Phanso pToigian =  new Phanso();
            int USCLN;
            if (p._MauSo > p.TuSo)
            {
                USCLN = p.MauSo % p.TuSo;
            }
            else
            {
                USCLN = p.TuSo % p.MauSo;
            }

            if (USCLN == 0) return p;
            else
            {
                pToigian.TuSo = p.TuSo / USCLN;
                pToigian.MauSo = p.MauSo / USCLN;
            }
            return pToigian;
        }

        public virtual Phanso Cong(Phanso p)
        {
            Phanso KQ = new Phanso();
            KQ.TuSo = _TuSo * p._MauSo + _MauSo * p.TuSo;
            KQ.MauSo = _MauSo * p._MauSo;
            KQ = KQ.ToiGian(KQ);
            return KQ;
        }

        public virtual Phanso Tru(Phanso p)
        {
            Phanso KQ = new Phanso();
            KQ.TuSo = _TuSo * p._MauSo - _MauSo * p.TuSo;
            KQ.MauSo = _MauSo * p._MauSo;
            KQ = KQ.ToiGian(KQ);
            return KQ;
        }

        public Phanso Nhan(Phanso p)
        {
            Phanso KQ = new Phanso();
            KQ.TuSo = _TuSo * p.TuSo;
            KQ.MauSo = _MauSo * p._MauSo;
            KQ = KQ.ToiGian(KQ);
            return KQ;
        }
        public Phanso Chia(Phanso p)
        {
            Phanso KQ = new Phanso();
            KQ.TuSo = _TuSo * p._MauSo ;
            KQ.MauSo = _MauSo * p.TuSo;
            KQ = KQ.ToiGian(KQ);
            return KQ;
        }


        #endregion

        #region Nâng cao

        #region Nạp chồng toán tử
        // phần Nâng cao

        /// <summary>
        /// Nạp chồng toán tử '+' hai Phân số
        /// </summary>
        /// <param name="ps1"></param>
        /// <param name="ps2"></param>
        /// <returns></returns>
        public static Phanso operator +(Phanso ps1, Phanso ps2)
        {
            ps1 = ps1.ToiGian(ps1);
            ps2 = ps2.ToiGian(ps2);
            Phanso KQ = new Phanso();
            KQ = ps1.Cong(ps2);
            return KQ;
        }

        /// <summary>
        /// Nạp chồng toán tử '-' cho 2 Phân số
        /// </summary>
        /// <param name="ps1"></param>
        /// <param name="ps2"></param>
        /// <returns></returns>
        public static Phanso operator -(Phanso ps1, Phanso ps2)
        {
            ps1 = ps1.ToiGian(ps1);
            ps2 = ps2.ToiGian(ps2);
            Phanso KQ = new Phanso();
            KQ = ps1.Tru(ps2);
            return KQ;
        }
        /// <summary>
        /// Nạp chồng toán tử so sánh bằng
        /// </summary>
        /// <param name="ps1"></param>
        /// <param name="ps2"></param>
        /// <returns></returns>
        public static bool operator ==(Phanso ps1, Phanso ps2)
        {
            bool status = false;
            ps1 = ps1.ToiGian(ps1);
            ps2 = ps2.ToiGian(ps2);
            if (ps1._TuSo == ps2.TuSo && ps1.MauSo == ps2.MauSo)
            {
                status = true;
            }
            return status;
        }

        /// <summary>
        /// Nạp chồng toán tử so sánh không bằng
        /// </summary>
        /// <param name="ps1"></param>
        /// <param name="ps2"></param>
        /// <returns></returns>
        public static bool operator !=(Phanso ps1, Phanso ps2)
        {
            bool status = false;
            ps1 = ps1.ToiGian(ps1);
            ps2 = ps2.ToiGian(ps2);
            if (ps1._TuSo != ps2.TuSo || ps1.MauSo != ps2.MauSo)
            {
                status = true;
            }
            return status;
        }
        #endregion

        #endregion

    }
}