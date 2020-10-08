using Memory;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace HorizonTrain
{
    public partial class MainForm : Form
    {
        public Mem m = new Mem();

        bool running;

        public MainForm()
        {
            InitializeComponent();
        }

        const int PROCESS_ALL_ACCESS = 0x1F0FFF;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);





        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            bool running;
            while (!worker.CancellationPending)
            {

                running = m.OpenProcess("HorizonZeroDawn.exe");

                BGWorker.ReportProgress(0, running);


                Thread.Sleep(1000);
            }


        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            running = (bool)e.UserState;
            if (!running)
            {
                GameStatusLbl.Text = "N/A";
                return;
            }
            GameStatusLbl.Text = "Running";
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool validInt = int.TryParse(ShardTxt.Text,out _);
            if (running && validInt)
            {
                m.WriteMemory("base+07122C68,40,8,10,50,300,68,1d8,58", "int", ShardTxt.Text);
                ShardTxt.Text = "";
            }

        }


    }
}
