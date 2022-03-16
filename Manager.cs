using FFmpeg.AutoGen;
using System;
using System.Collections.Generic;
using System.Threading;

namespace FCGG
{
    public class Manager
    {
        private readonly AutoResetEvent _reset = new AutoResetEvent(false);
        private long _channelNumber = 0;

        private Thread _mainThread;

        public string FfmpegVersion { get; private set; }

        public Dictionary<long, Channel> Channels { get; } = new Dictionary<long, Channel>();

        public bool IsRunning => _mainThread != null && _mainThread.IsAlive;

        public event Action<bool> StateChange;

        public event Action<Channel> ChannelAdded;

        public event Action<Channel> ChannelRemoved;

        public Manager()
        {
            FfmpegVersion = ffmpeg.av_version_info();
        }

        public void Start()
        {
            if (IsRunning)
            {
                return;
            }

            _mainThread = new Thread(Run);

            // Setup

            _mainThread.Start();

            StateChange?.Invoke(true);
        }

        public void Stop()
        {
            _reset.Set();

            Channels.Clear();
            _channelNumber = 0;
            // Unsetup

            StateChange?.Invoke(false);
        }

        public void AddChannel()
        {
            var newChannelNumber = Interlocked.Increment(ref _channelNumber);
            var newChannel = new Channel((uint)newChannelNumber);

            Channels.Add(newChannelNumber, newChannel);

            ChannelAdded?.Invoke(newChannel);
        }

        private void Run()
        {
            Log.WriteLine($"[FCGG] Manager Started, Thread #{_mainThread.ManagedThreadId}");

            _reset.WaitOne();

            Log.WriteLine($"[FCGG] Manager Quitting Thread #{_mainThread.ManagedThreadId}");

            _mainThread = null;
        }
    }
}
