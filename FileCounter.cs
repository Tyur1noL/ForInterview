using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinFormsApp1
{
    internal static class FileInfoUpdater
    {
        public delegate void UpdateView();
        static public event UpdateView? ChangeFields;
        static public int TotalFilesCount {  get; private set; }
        static public int TotalFilesFind { get; private set; }
        static public string? CurrentDirectory {  get; private set; }
        static public TimeSpan Time { get; private set; }
        static public void AddFilesCount()
        {
            TotalFilesCount++;
            ChangeFields?.Invoke();
        }
        static public void Refresh()
        {
            TotalFilesCount = 0;
            TotalFilesFind = 0;
            CurrentDirectory = "";
            Time = new TimeSpan();
            ChangeFields?.Invoke();
        }
        static public void AddFilesFinded()
        {
            TotalFilesFind++;
            ChangeFields?.Invoke();
        }
        static public void SetCurrentDirectory(string _directoryPath)
        {
            CurrentDirectory = _directoryPath;
            ChangeFields?.Invoke();
        }
        static public void AddTimer()
        {

            Time += new TimeSpan(0, 0, 1);
            ChangeFields?.Invoke();
        }
    }
}
