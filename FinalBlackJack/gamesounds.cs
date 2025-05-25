using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace FinalBlackJack
{
    internal class gamesounds
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private string filePath;

        public gamesounds(string path)
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
