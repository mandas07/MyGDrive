using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGDriveService.Enums;

namespace MyGDriveService
{
    class FileSync
    {
        private string _fileName = "";
        private FileChangeReason _changeReason;
        private string _fullPath = "";
        private string _oldFullPath = "";
        private FileStatus _status;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public FileChangeReason ChangeReason
        {
            get { return _changeReason; }
            set { _changeReason = value; }
        }

        public string FullPath
        {
            get { return _fullPath; }
            set { _fullPath = value; }
        }

        public string OldFullPath
        {
            get { return _oldFullPath; }
            set { _oldFullPath = value; }
        }

        public FileStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

    }
}
