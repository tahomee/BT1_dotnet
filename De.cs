using System;

namespace BT1
{
    public class De : GiaSuc
    {
        public De(int soLuong) : base("Dê", soLuong)
        {
        }
        public override void PhatTiengKeu()
        {
            Console.Write("Deeeeee");

        }

        protected override void SinhCon()
        {
            Random rand = new Random();
            for (int i = 0; i < soLuong; i++)
            {
                soCon.Add(rand.Next(1, 4));
            }
        }

        protected override void ChoSua()
        {
            Random rand = new Random();
            for (int i = 0; i < soLuong; i++)
            {
                soSua.Add(rand.Next(0, 11));
            }
        }
    }
}
