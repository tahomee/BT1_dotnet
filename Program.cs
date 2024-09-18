
using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            NongTrai nongTrai = new NongTrai();

            Console.WriteLine("Nhap so luong gia suc ban dau:");
            Console.Write("So luong bo: ");
            int soLuongBo = int.Parse(Console.ReadLine());
            Console.Write("So luong cuu: ");
            int soLuongCuu = int.Parse(Console.ReadLine());
            Console.Write("So luong de: ");
            int soLuongDe = int.Parse(Console.ReadLine());

            nongTrai.ThemGiaSuc(new Bo(soLuongBo));
            nongTrai.ThemGiaSuc(new Cuu(soLuongCuu));
            nongTrai.ThemGiaSuc(new De(soLuongDe));

            nongTrai.PhatTiengKeuTatCa();
            Console.WriteLine();

            nongTrai.ThongKeToanBo();
            nongTrai.TongSoSua();

        }
    }
}
