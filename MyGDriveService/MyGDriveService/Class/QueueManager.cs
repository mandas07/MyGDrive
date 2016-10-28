using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGDriveService
{
    class QueueManager
    {
        private static FileSyncQueue _queue;

        private QueueManager() { }

        public static FileSyncQueue GetQueue()
        {
            if (_queue == null)
            {
                _queue = new FileSyncQueue();
            }

            return _queue;
        }
    }
}
