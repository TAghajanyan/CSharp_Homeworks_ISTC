using System;
using System.IO;
using System.Threading;

namespace ThirdStage._GC
{
    public class ResourceManager : IDisposable
    {
        public FileStream UnmanagedResource;
        public int[] ManagedResource;

        public void SetManagedResourceValue(out Int64 memory)
        {
            ManagedResource = new int[1024*500]; // ~2MB
            for (int i = 0; i < ManagedResource.Length; i++)
            {
                ManagedResource[i] = new int();
            }
            //GC.Collect();
            Thread.Sleep(300);
            memory = GC.GetTotalMemory(false) / 1024;
        }

        public void SetUnmanagedResourceValue(out Int64 memory)
        {
            UnmanagedResource = new FileStream(@"UnmanagedResourceFile.txt", FileMode.Open);
            memory = GC.GetTotalMemory(false) / 1024;
        }

        private bool disposedValue = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposedValue)
                return;

            if (disposing)
            {
                UnmanagedResource.Dispose();
            }

            disposedValue = true;
        }

        ~ResourceManager()
        {
          Dispose(false);
        }

    }
}
