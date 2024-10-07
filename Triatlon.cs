using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Triatlon
    {
        public string Nev { get; set; }
        public int Kor { get; set; }

        public int Rajtsz { get; set; }

        public string Nem { get; set; }

        public string Eletkorkateg { get; set; }

        public TimeSpan Uszasido { get; set; }
        public TimeSpan Elsodepoido { get; set; }
        public TimeSpan Kerekparido { get; set; }
        public TimeSpan Masodikdepoido { get; set; }
        public TimeSpan Futasido { get; set; }
        public TimeSpan Osszido => Uszasido + Elsodepoido + Kerekparido + Masodikdepoido + Futasido;

        public override string ToString()
        {
            return $"\tNév: {Nev} \tSzületési év{Kor} \tRajtszám: {Rajtsz} \tNeme: {Nem} \tKor kategória: {Eletkorkateg} " +
                $"\tÚszás ideje: {Uszasido} \tElső depóban töltött ideje: {Elsodepoido} \tKerékpározási ideje: {Kerekparido} \tMásodik deóban töltött ideje: {Masodikdepoido} \tFutási ideje: {Futasido} \tÖssz. ideje: {Osszido}";
        }





    }
}
