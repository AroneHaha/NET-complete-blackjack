using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using NAudio.Wave;

namespace FinalBlackJack
{
    internal class backgroundmusic
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private string filePath;
        private bool isPaused;

        public backgroundmusic(string path)
        {
            filePath = path;
            isPaused = false;
        }

        public void PlayLoop()
        {
            Stop(); 

            audioFile = new AudioFileReader(filePath);
            audioFile.Volume = 0.1f;
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.Play();

            outputDevice.PlaybackStopped += (s, e) =>
            {
                if (outputDevice != null && !isPaused)
                {

                    audioFile.Position = 0;
                    outputDevice.Play();
                }
            };
        }

        public void Pause()
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
                isPaused = true;
            }
        }

        public void Resume()
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Paused)
            {
                outputDevice.Play();
                isPaused = false;
            }
        }

        public void Stop()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }

            isPaused = false;
        }
    }
}