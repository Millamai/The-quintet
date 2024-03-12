using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_quintet
{
    public class Saxophone : Instrument
    {


        public override void Play()
        {
            using (var audioFile = new AudioFileReader(@"C:\temp\sax.wav"))
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
            return base.ToString() + "En saxofon er et transponerende instrument af typen træblæser, selvom den normalt er lavet af messing. Den blev opfundet i 1840'erne af den belgiske instrumentbygger Adolphe Sax.";
        }
    }
}
