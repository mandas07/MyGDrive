using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGDriveService.Enums;
using System.IO;

namespace MyGDriveService
{
    class FileSyncManager
    {
        public FileSync GetFileSync(FileSystemEventArgs file)
        {
            return new FileSync() { ChangeReason = GetChangeReason(file.ChangeType), FileName = file.Name, FullPath = file.FullPath, OldFullPath = "", Status = FileStatus.InQueue };
        }

        public FileSync GetFileSync(RenamedEventArgs file)
        {
            return new FileSync() { ChangeReason = GetChangeReason(file.ChangeType), FileName = file.Name, FullPath = file.FullPath, OldFullPath = file.OldFullPath, Status = FileStatus.InQueue };
        }

        private FileChangeReason GetChangeReason(WatcherChangeTypes changeType)
        {
            switch (changeType)
            {
                case WatcherChangeTypes.Changed:
                    return FileChangeReason.Changed;
                case WatcherChangeTypes.Created:
                    return FileChangeReason.Createed;
                case WatcherChangeTypes.Deleted:
                    return FileChangeReason.Deleted;
                case WatcherChangeTypes.Renamed:
                    return FileChangeReason.Renamed;
                default:
                    return FileChangeReason.Createed;
            }
        }
    }
}
