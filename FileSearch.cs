using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    internal class FileSearch
    {
        CancellationTokenSource tokenSource;
        public string FilePath { get; }
        public string RegularExpression { get; }
        public Form1 ControlForm { get; }
        public FileSearch(string _filePath, string _regularExpression, Form1 _controlForm, CancellationTokenSource _tokenSource)
        {
            FilePath = _filePath;
            RegularExpression = _regularExpression;
            ControlForm = _controlForm;
            tokenSource = _tokenSource;
        }
        public bool Compare(string _filePath)
        {
            return Regex.IsMatch(_filePath, RegularExpression);
        }
        public void Search()
        {
            try
            {
                if (tokenSource.Token.IsCancellationRequested)
                    tokenSource.Token.ThrowIfCancellationRequested();
                string[] directories = Directory.GetDirectories(FilePath);
                foreach (string dir in directories)
                {
                    if (tokenSource.Token.IsCancellationRequested)
                        tokenSource.Token.ThrowIfCancellationRequested();
                    new FileSearch(dir, RegularExpression, ControlForm, tokenSource).Search();
                }
                string[] files = Directory.GetFiles(FilePath);
                foreach (string file in files)
                {
                    if (tokenSource.Token.IsCancellationRequested)
                        tokenSource.Token.ThrowIfCancellationRequested();
                    FileInfoUpdater.SetCurrentDirectory(new FileInfo(file).Directory.FullName);
                    Form1._stopper.WaitOne(Timeout.Infinite, false);
                    FileInfoUpdater.AddFilesCount();
                    if (Compare(file))
                    {
                        ControlForm.AddTreeNode(file, ControlForm.GetTreeNodeParent(new FileInfo(file).Directory.FullName));
                        FileInfoUpdater.AddFilesFinded();
                    }
                }
            }
            catch
            {
            }
        }
    }
}
