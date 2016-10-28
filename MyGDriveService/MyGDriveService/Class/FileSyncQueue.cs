using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGDriveService
{
    class FileSyncQueue
    {
        private List<FileSync> _fileList;

        public FileSyncQueue ()
        {
            _fileList = new List<FileSync>();
        }

        public void Add(FileSync file)
        {
            _fileList.Add(file);
        }

        public List<FileSync> FileList
        {
            get
            {
                return _fileList;
            }
        }
    }
}
