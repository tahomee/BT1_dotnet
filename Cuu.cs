using System;

namespace BT1
{
    public class Cuu : GiaSuc
    {
        public Cuu(int soLuong) : base("Cừu", soLuong)
        {
        }

        protected override void SinhCon()
        {
            Random rand = new Random();
            for (int i = 0; i < soLuong; i++)
            {
                soCon.Add(rand.Next(1, 3));
            }
        }

        protected override void ChoSua()
        {
            Random rand = new Random();
            for (int i = 0; i < soLuong; i++)
            {
                soSua.Add(rand.Next(0, 6));
            }
        }
        public override void PhatTiengKeu()
        {
            Console.Write("Cuuu");

        }
    }
}
