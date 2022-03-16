using FFmpeg.AutoGen;
using System;
using System.Runtime.InteropServices;

namespace FCGG
{
    public static class Helpers
    {
        public static unsafe string StringError(this int error)
        {
            var bufferSize = 1024;
            var buffer = stackalloc byte[bufferSize];
            
            ffmpeg.av_strerror(error, buffer, (ulong)bufferSize);
            
            var message = Marshal.PtrToStringAnsi((IntPtr)buffer);

            return message;
        }

        public static int ThrowExceptionIfError(this int error)
        {
            if (error < 0)
            {
                throw new ApplicationException(error.StringError());
            }

            return error;
        }
    }
}
