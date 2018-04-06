using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Homework.TinhKhoangCach
{

    public class Diem
   
    {
        #region Properties

        public int X { get; set; }
        public int Y { get; set; }

        #endregion
        
        #region Constructor
        /// <summary>
        /// Tạo Điểm không tọa độ
        /// </summary>
        public Diem() { }

        /// <summary>
        /// Tạo điểm có tọa độ X và Y
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public Diem(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }



        #endregion

        #region Method

        public static Diem Parse(string toado)
        {
            Diem _diem = new Diem();
            _diem.X = int.Parse(toado.Split(';')[0]);
            _diem.Y = int.Parse(toado.Split(';')[1]);
            return _diem;
        }

        #endregion


    }
}