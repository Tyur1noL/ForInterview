using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Task searchTask;
        TimerCallback tm = new TimerCallback(TimerUpdate);
        System.Threading.Timer timer;
        CancellationTokenSource cancellationTokenSource;
        public static ManualResetEvent _stopper = new ManualResetEvent(true);
        public Form1() => InitializeComponent();
        public TreeNode GetTreeNodeParent(string _parentPath)
        {
            if (treeView1.Nodes.Find(_parentPath, true).Length == 0)
            {
                if (_parentPath == textBox1.Text)
                {
                    Action<string> a = (s) =>
                    {
                        TreeNode tn = new TreeNode
                        {
                            Text = _parentPath,
                            Name = _parentPath
                        };

                        treeView1.Nodes.Add(tn);
                    };

                    if (treeView1.InvokeRequired)
                        treeView1.Invoke(a, _parentPath);
                    else
                        a(_parentPath);
                }
                else
                {
                    AddTreeNode(_parentPath, GetTreeNodeParent(new FileInfo(_parentPath).Directory.FullName));
                }
            }
            return treeView1.Nodes.Find(_parentPath, true)[0];
        }
        public void AddTreeNode(string file, TreeNode _parent)
        {
            Action<string, TreeNode> a = (s, i) =>
            {
                TreeNode tn = new TreeNode
                {
                    Text = new FileInfo(file).Name,
                    Name = file
                };

                _parent.Nodes.Add(tn);
            };

            if (treeView1.InvokeRequired)
                treeView1.Invoke(a, file, _parent);
            else
                a(file, _parent);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            treeView1.Nodes.Clear();
            if (Directory.Exists(textBox1.Text))
            {
                try
                {
                    new FileSearch(textBox1.Text, textBox2.Text, this, cancellationTokenSource).Compare(textBox1.Text);
                    timer = new System.Threading.Timer(tm, null, 0, 1000);
                    FileInfoUpdater.ChangeFields += UpdateLabels;
                    FileInfoUpdater.Refresh();
                    cancellationTokenSource = new CancellationTokenSource();
                    if (searchTask != null)
                        searchTask.Dispose();
                    searchTask = new Task(() => new FileSearch(textBox1.Text, textBox2.Text, this, cancellationTokenSource).Search(), cancellationTokenSource.Token);
                    searchTask.Start();
                    Task waitTask = new Task(() => { searchTask.Wait(); button4_Click(new object(), new EventArgs()); });
                    waitTask.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CancelledButtons();
                }
            }
        }
        private void TreeView1_DoubleClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(treeView1.SelectedNode.Name)
                {
                    UseShellExecute = true
                };
                Process.Start(processStartInfo);
            }
        }
        private void UpdateLabels()
        {
            Action a = () =>
            {
                label4.Text = FileInfoUpdater.TotalFilesCount.ToString();
            };
            if (label4.InvokeRequired)
                label4.Invoke(a);
            else
                a();

            Action b = () =>
            {
                label6.Text = FileInfoUpdater.TotalFilesFind.ToString();
            };
            if (label6.InvokeRequired)
                label6.Invoke(b);
            else
                b();

            Action c = () =>
            {
                label8.Text = "Текущая директория поиска: " + FileInfoUpdater.CurrentDirectory;
            };
            if (label8.InvokeRequired)
                label8.Invoke(c);
            else
                c();

            Action d = () =>
            {
                label7.Text = "Время поиска: " + FileInfoUpdater.Time.ToString();
            };
            if (label7.InvokeRequired)
                label7.Invoke(d);
            else
                d();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _stopper.Reset();
            timer.Dispose();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _stopper.Set();
            timer = new System.Threading.Timer(tm, null, 0, 1000);
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
            _stopper.Set();
            timer.Dispose();
            CancelledButtons();
        }
        private static void TimerUpdate(object _obj)
        {
            FileInfoUpdater.AddTimer();
        }
        private void CancelledButtons()
        {
            Action a = () =>
            {
                button1.Enabled = true;
            };
            if (button1.InvokeRequired)
                button1.Invoke(a);
            else
                a();
            Action b = () =>
            {
                button2.Enabled = false;
            };
            if (button2.InvokeRequired)
                button2.Invoke(b);
            else
                b();
            Action c = () =>
            {
                button3.Enabled = false;
            };
            if (button3.InvokeRequired)
                button3.Invoke(c);
            else
                c();
            Action d = () =>
            {
                button4.Enabled = false;
            };
            if (button4.InvokeRequired)
                button4.Invoke(d);
            else
                d();
        }
    }
}