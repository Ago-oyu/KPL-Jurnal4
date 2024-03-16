namespace modul4_1302220101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah kb = new KodeBuah();
            Console.WriteLine("Kode Buah : " + kb.GetKodeBuah(KodeBuah.NamaBuah.Semangka));

            PosisiKarakterGame ps = new PosisiKarakterGame();
            for (int i = 0; i < 5; i++)
            {
                ps.ChangePosisi();
            }
        }
    }
}
