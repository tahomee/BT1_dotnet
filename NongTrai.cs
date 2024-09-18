using System;
using System.Collections.Generic;

namespace BT1
{
    public class NongTrai
    {
        private List<GiaSuc> giaSucs;

        public NongTrai()
        {
            giaSucs = new List<GiaSuc>();
        }

        public void ThemGiaSuc(GiaSuc giaSuc)
        {
            giaSucs.Add(giaSuc);
        }

        public void PhatTiengKeuTatCa()
        {
            Console.WriteLine("Tat ca gia suc trong nong trai đang keu đoi an:");
            foreach (var giaSuc in giaSucs)
            {
                giaSuc.PhatTiengKeu();
            }
        }

        public void ThongKeToanBo()
        {
            Console.WriteLine("Thong ke toan bo nong trai:");
            foreach (var giaSuc in giaSucs)
            {
                giaSuc.ThongKe();
            }
        }
        public void TongSoSua()
        {
            int tongSoLitSua = 0;
            foreach (var giaSuc in giaSucs)
            {
                tongSoLitSua += giaSuc.GetTongSoSua(); // Gọi phương thức lấy số lượng sữa từ mỗi gia súc
            }

            Console.WriteLine($"Tổng số lít sữa trong nông trại: {tongSoLitSua} lít");
        }
    }

}
