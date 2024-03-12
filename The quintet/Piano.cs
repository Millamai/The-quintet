using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_quintet
{
    public class Piano: StringInstrument
    {
        public Piano(int numberOfStrings) : base(numberOfStrings)
        {
        }

        public override void Play()
        {
            using (var audioFile = new AudioFileReader(@"C:\temp\piano.wav"))
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

        public override string ToString()
        {
            return base.ToString() + "Et klaver er et musikinstrument der sammen med flygelet også kaldes for piano (kort form af pianoforte – italiensk for \"stille kraftigt\"). Et klaver består af et klaviatur, der med tangenter får filtbeklædte hamre til at anslå stemte strenge \n";
        }
    }
}
