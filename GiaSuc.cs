using System;
using System.Collections.Generic;

namespace BT1
{
    public abstract class GiaSuc
    {
        protected string loai;
        protected int soLuong;
        protected List<int> soCon;
        protected List<int> soSua;

        public GiaSuc(string loai, int soLuong)
        {
            this.loai = loai;
            this.soLuong = soLuong;
            soCon = new List<int>();
            soSua = new List<int>();
            SinhCon();
            ChoSua();
        }

        protected abstract void SinhCon();
        protected abstract void ChoSua();
        public abstract void PhatTiengKeu();
        public void ThongKe()
        {
            int tongSoGiaSuc = soCon.Count + soLuong;
            Console.WriteLine($"Tổng số {loai}: {tongSoGiaSuc}");
        }
        public int GetTongSoSua()
        {
            int tongSoSua = 0;
            foreach (var sua in soSua)
            {
                tongSoSua += sua;
            }
            return tongSoSua;
        }
    }
}
