using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace The_quintet
{
    public class Violin : BowedString
    {
        public Violin(int numberOfStrings) : base(numberOfStrings)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "Violinen er et strygeinstrument med fire strenge, stemt i kvinter: G, D1, A1 og E2, hvor A-strengen således stemmes i kammertonen. Denne violin har " + NumberOfStrings + " strenge";
        }


        //playsound for a violin
        public override void Play()
        {
            using (var audioFile = new AudioFileReader(@"C:\temp\violin.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }

        }
    }
}
