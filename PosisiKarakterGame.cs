using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302220101
{
    internal class PosisiKarakterGame
    {
        enum State {Berdiri, Jongkok, Tengkurap, Terbang};
        State state;
        enum Trigger {
            TombolW = 119,
            TombolS = 115,
            TombolX = 120
        }

        public PosisiKarakterGame()
        {
            this.state = State.Berdiri;
        }

        public void ChangePosisi()
        {
            int tombol = Console.ReadKey().KeyChar;

            switch (state)
            {
                case State.Berdiri:
                    if (tombol == (int)Trigger.TombolW)
                    {
                        state = State.Terbang;
                        Console.WriteLine("\ntombol arah atas ditekan\n");
                    } else if (tombol == (int)Trigger.TombolS)
                    {
                        state = State.Jongkok;
                        Console.WriteLine("\ntombol arah bawah ditekan\n");
                    }
                    break;
                case State.Terbang:
                    if (tombol == (int)Trigger.TombolX)
                    {
                        state = State.Jongkok;
                        Console.WriteLine("\n\n");
                    } else if (tombol == (int)Trigger.TombolS)
                    {
                        state = State.Berdiri;
                        Console.WriteLine("\ntombol arah bawah ditekan\n");
                    }
                    break;
                case State.Jongkok:
                    if (tombol == (int)Trigger.TombolW)
                    {
                        state = State.Berdiri;
                        Console.WriteLine("\ntombol arah atas ditekan\n");
                    } else if (tombol == (int)Trigger.TombolS)
                    {
                        state = State.Tengkurap;
                        Console.WriteLine("\ntombol arah bawah ditekan\n");
                    }
                    break;
                case State.Tengkurap:
                    if (tombol == (int)Trigger.TombolW)
                    {
                        state = State.Jongkok;
                        Console.WriteLine("\ntombol arah atas ditekan\n");
                    }
                    break;
            }
        }
    }
}
