using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204034
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jahfal Mudrik Ramadhan_1302204034");
            KodeBuah table_Kodebuah = new KodeBuah();
            Console.Write("Nama Buah: ");
            table_Kodebuah.getKodebuah(Console.ReadLine());
            Console.WriteLine("          Kode Nama Buah          ");
            table_Kodebuah.getAllkodebuah();

            Console.WriteLine("         Posisi Karakter Game         ");
            PosisiKarakterGame game = new PosisiKarakterGame();
            game.posisi();
        }
    }
    class KodeBuah
    {

        Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"Nama Buah", "Kode Buah"},
            {"Apel", "A00"},
            {"Aprikot", "B00"},
            {"Alpukat", "C00"},
            {"Pisang", "D00"},
            {"Paprika", "E00"},
            {"Blackberry", "F00"},
            {"Ceri", "H00"},
            {"Kelapa", "I00"},
            {"Jagung", "J00"},
            {"Kurma", "K00"},
            {"Durian", "L00"},
            {"Anggur", "M00"},
            {"Melon", "N00"},
            {"Semangka", "O00"} };

        public void getKodebuah(string kel)
        {
            if (dic.ContainsKey(kel))
            {
                Console.WriteLine(kel + " : " + dic[kel]);
            }
            else
            {
                Console.WriteLine(kel + " tidak ditemukan");
            }
        }

        public void getAllkodebuah()
        {
            foreach (KeyValuePair<string, string> ele1 in dic)
            {
                Console.WriteLine("{0} \t\t {1}", ele1.Key, ele1.Value);
            }
        }
    }
    class PosisiKarakterGame
    {
        enum State { BERDIRI, TENGKURAP, EXIT };
        public void posisi()
        {
            State state = State.BERDIRI;

            String[] screenName = { "Standby", "Istirahat" };
            do
            {
                Console.WriteLine("Posisi " + screenName[(int)state]);
                Console.Write("Posisi? ");
                String command = Console.ReadLine();
                switch (state)
                {
                    case State.BERDIRI:
                        if (command == "Tengkurap")
                        {
                            state = State.TENGKURAP;
                        }
                        break;
                    case State.TENGKURAP:
                        if (command == "Berdiri")
                        {
                            state = State.BERDIRI;
                        }
                        break;
                    case State.EXIT:
                        if (command == "Exit")
                        {
                            state = State.EXIT;
                        }
                        break;
                }
            }
            while (state != State.EXIT);
        }
    }

}
