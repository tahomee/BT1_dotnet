using System;

namespace BT1
{
    public class Bo : GiaSuc
    {
        public Bo(int soLuong) : base("Bò", soLuong)
        {
        }

        protected override void SinhCon()
        {
            Random rand = new Random();
            for (int i = 0; i < soLuong; i++)
            {
                soCon.Add(rand.Next(1, 5));
            }
        }

        protected override void ChoSua()
        {
            Random rand = new Random();
            for (int i = 0; i < soLuong; i++)
            {
                soSua.Add(rand.Next(0, 21));
            }
        }
        public override void PhatTiengKeu()
        {
            Console.Write("Boooo");

        }

    }
}
