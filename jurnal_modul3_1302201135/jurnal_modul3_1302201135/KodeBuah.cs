using System;

namespace jurnal_modul3_1302201135
{
	class KodeBuah
	{
		public enum namaBuah
        {
			Apel,
			Aprikot,
			Alpukat,
			Pisang,
			Paprika,
			Blackberry,
			Ceri,
			Kelapa,
			Jagung,
			Kurma,
			Durian,
			Anggur,
			Melon,
			Semangka
        }

		public string getKodeBuah(namaBuah a)
        {
			string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
			return kodeBuah[(int)a];
        }
	}

}
