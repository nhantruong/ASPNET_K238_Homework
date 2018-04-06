using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using BaiTap.Homework._3._3_Phanso;

namespace BaiTap.Homework._3._4_Phanso_Nangcao
{
    public class Phanso
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }



        #region Nạp chồng toán tử
        /// <summary>
        /// Nạp chồng toán tử +
        /// </summary>
        /// <param name="ps1"></param>
        /// <param name="ps2"></param>
        /// <returns></returns>
        public static Phanso operator +(Phanso ps1, Phanso ps2)
            {
            Phanso KQ = new Phanso();
            KQ = ps1 - ps2;
            return KQ;
            }

        /// <summary>
        /// Nạp chồng toán tử -
        /// </summary>
        /// <param name="ps1"></param>
        /// <param name="ps2"></param>
        /// <returns></returns>
        public static Phanso operator -(Phanso ps1, Phanso ps2)
        {
            Phanso KQ = new Phanso();
            KQ = ps1 - ps2;            
            return KQ;
        }

        /// <summary>
        /// Nạp chồng toán tử so sánh =
        /// </summary>
        /// <param name="ps1"></param>
        /// <param name="ps2"></param>
        /// <returns></returns>
        public static bool operator ==(Phanso ps1, Phanso ps2)
        {
            bool status = false;
            if (ps1 == ps2)
            {
                status = true;
            }
            status = false;
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
            if (ps1 != ps2)
            {
                status = true;
            }
            status = false;
            return status;
        }
        #endregion

        #region Method Override


        #endregion
    }
}