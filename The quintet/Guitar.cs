using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_quintet
{
    public class Guitar : StringInstrument
    {
        public Guitar(int numberOfStrings) : base(numberOfStrings)
        {
        }

        public override void Play()
        {
            using (var audioFile = new AudioFileReader(@"C:\temp\guitar.wav"))
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
            return base.ToString() + "Guitaren er et knipset strengeinstrument normalt med seks strenge, men fire, syv, otte, ni, ti eller 12 (dobbeltkor) findes også. Den oprindelige form er akustisk med en krop, der danner resonansbund for strengenes vibrationer. \n";
        }
    }
}
