using NAudio.Wave;
using System;

namespace AudioMixer
{
    public class AudioPlayer
    {
        private WaveOutEvent outputDevice;
        public AudioFileReader AudioFile { get; private set; }

        public void Load(string filePath)
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }
            AudioFile = new AudioFileReader(filePath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(AudioFile);
        }

        public void Play()
        {
            outputDevice?.Play();
        }

        public void Pause()
        {
            outputDevice?.Pause();
        }

        public void Stop()
        {
            outputDevice?.Stop();
        }

        public void SetVolume(int volume)
        {
            if (AudioFile != null)
            {
                AudioFile.Volume = volume / 100.0f;
            }
        }

        public void SetSpatial(int spatialValue)
        {
            // Логика применения эффекта объёмности звука
        }

        public void Save(string outputPath)
        {
            // Логика сохранения файла с изменениями
        }
    }
}
