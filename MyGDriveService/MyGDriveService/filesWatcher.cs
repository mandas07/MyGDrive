using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGDriveService
{
    class filesWatcher
    {
        public void fileWatcherWatchDDriveMYdataFolder_Modified(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {
                FileSyncManager fsManager = new FileSyncManager();
                QueueManager.GetQueue().Add(fsManager.GetFileSync(e));

                StreamWriter file = File.AppendText(@"C:\test\log.txt");
                file.WriteLine(e.Name);
                file.Flush();
                file.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
