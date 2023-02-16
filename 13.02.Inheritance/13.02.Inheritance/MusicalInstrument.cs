using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2023.Inheritance {
    internal abstract class MusicalInstrument {
        internal abstract void Show();
        internal abstract void Desc();
        internal abstract void Sound();
        internal abstract void History();
    }
    internal class Violin : MusicalInstrument {
        internal override void Show() => Console.WriteLine("Violin.");
        internal override void Desc() => Console.WriteLine("Description: the violin, sometimes known as a fiddle, is a wooden chordophone (string instrument) in the violin family.");
        internal override void Sound() => Console.WriteLine("keuu-kheukkkk.");
        internal override void History() => Console.WriteLine("History: the earliest stringed instruments were mostly plucked.");
    }
    internal class Trombone : MusicalInstrument {
        internal override void Show() => Console.WriteLine("Trombone.");
        internal override void Desc() => Console.WriteLine("Description: diverse in strokes and technically mobile tool.");
        internal override void Sound() => Console.WriteLine("Too-tooo-tooo-to.");
        internal override void History() => Console.WriteLine("History: the forerunners of this instrument were rocker pipes.");
    }
    internal class Ukulele : MusicalInstrument {
        internal override void Show() => Console.WriteLine("Ukulele.");
        internal override void Desc() => Console.WriteLine("Description: guitar body.");
        internal override void Sound() => Console.WriteLine("strum-strum.");
        internal override void History() => Console.WriteLine("History: the ukulele appeared in the Hawaiian Islands in the second half of the 19th century.");
    }
    internal class Cello : MusicalInstrument {
        internal override void Show() => Console.WriteLine("Cello.");
        internal override void Desc() => Console.WriteLine("Description: the cello is a bowed (sometimes plucked and occasionally hit) string instrument of the violin family.");
        internal override void Sound() => Console.WriteLine("khhiu-kkhiuu");
        internal override void History() => Console.WriteLine("History: the violin family, including cello-sized instruments, emerged c. 1500 as a family of instruments distinct from the viola da gamba family.");
    }
}
