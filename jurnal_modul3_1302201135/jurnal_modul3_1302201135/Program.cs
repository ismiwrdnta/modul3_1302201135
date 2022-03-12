// See https://aka.ms/new-console-template for more information

namespace jurnal_modul3_1302201135
{
    public class Program
    {
        static void Main(string[] args)
        {
            KodeBuah kode = new KodeBuah();
            Console.WriteLine("Nama Buah   " + "Kode Buah");
            Console.WriteLine("Apel        " + kode.getKodeBuah(KodeBuah.namaBuah.Apel));
            Console.WriteLine("Aprikot     " + kode.getKodeBuah(KodeBuah.namaBuah.Aprikot));
            Console.WriteLine("Alpukat     " + kode.getKodeBuah(KodeBuah.namaBuah.Alpukat));
            Console.WriteLine("Pisang      " + kode.getKodeBuah(KodeBuah.namaBuah.Pisang));
            Console.WriteLine("Paprika     " + kode.getKodeBuah(KodeBuah.namaBuah.Paprika));
            Console.WriteLine("Blackberry  " + kode.getKodeBuah(KodeBuah.namaBuah.Blackberry));
            Console.WriteLine("Ceri        " + kode.getKodeBuah(KodeBuah.namaBuah.Ceri));
            Console.WriteLine("Kelapa      " + kode.getKodeBuah(KodeBuah.namaBuah.Kelapa));
            Console.WriteLine("Jagung      " + kode.getKodeBuah(KodeBuah.namaBuah.Jagung));
            Console.WriteLine("Kurma       " + kode.getKodeBuah(KodeBuah.namaBuah.Kurma));
            Console.WriteLine("Durian      " + kode.getKodeBuah(KodeBuah.namaBuah.Durian));
            Console.WriteLine("Anggur      " + kode.getKodeBuah(KodeBuah.namaBuah.Anggur));
            Console.WriteLine("Melon       " + kode.getKodeBuah(KodeBuah.namaBuah.Melon));
            Console.WriteLine("Semangka    " + kode.getKodeBuah(KodeBuah.namaBuah.Semangka));

            PosisiKarakterGame posisi = new PosisiKarakterGame();
            Console.WriteLine(posisi.currentState);

            posisi.activateTrigger(PosisiKarakterGame.triggerState.TombolS);
            Console.WriteLine(posisi.currentState);

            posisi.activateTrigger(PosisiKarakterGame.triggerState.TombolS);
            Console.WriteLine(posisi.currentState);

            posisi.activateTrigger(PosisiKarakterGame.triggerState.TombolW);
            Console.WriteLine(posisi.currentState);

            posisi.activateTrigger(PosisiKarakterGame.triggerState.TombolW);
            Console.WriteLine(posisi.currentState);

        }
    }    
}


