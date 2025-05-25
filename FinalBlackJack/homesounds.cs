using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace FinalBlackJack
{
    internal class homesounds
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private string filePath;

        public homesounds(string path)
        {
            filePath = path;
            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(filePath);
            outputDevice.Init(audioFile);
        }

        public void PlayOnce()
        {
            if (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Stop();
            }
            audioFile.Position = 0;
            outputDevice.Play();
        }
    }
}
