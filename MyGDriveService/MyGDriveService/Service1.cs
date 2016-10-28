using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyGDriveService
{
    public partial class GDriveService : ServiceBase
    {
        public GDriveService()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            filesWatcher watcher = new filesWatcher();
            filFileWatcher.Path = @"C:\Trunk";
            filFileWatcher.Changed += watcher.fileWatcherWatchDDriveMYdataFolder_Modified;
            filFileWatcher.Created += watcher.fileWatcherWatchDDriveMYdataFolder_Modified;
            filFileWatcher.Deleted += watcher.fileWatcherWatchDDriveMYdataFolder_Modified;
            filFileWatcher.Renamed += watcher.fileWatcherWatchDDriveMYdataFolder_Modified;
            filFileWatcher.NotifyFilter = System.IO.NotifyFilters.FileName;
        }

        protected override void OnStop()
        {
        }
    }
}
