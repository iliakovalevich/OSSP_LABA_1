using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class ProcessInfo
    {
        
        static Process[] processes;
        public static ListViewItem[] GetProcessesInfo()
        {
            processes = Process.GetProcesses();
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            for (int i = 0; i < processes.Length; i++)
            {
                ListViewItem temp = new ListViewItem();
                temp.Text = processes[i].ProcessName;
                temp.SubItems.Add(processes[i].Id.ToString());
                temp.SubItems.Add(processes[i].MachineName);
                temp.SubItems.Add(processes[i].NonpagedSystemMemorySize64.ToString());
                temp.SubItems.Add(processes[i].BasePriority.ToString());
                temp.SubItems.Add(processes[i].Threads.Count.ToString());
                temp.SubItems.Add(processes[i].Responding.ToString());
                listViewItems.Add(temp);
            }
            return listViewItems.ToArray();
        }
        public static ListViewItem[] GetThreadInfo(int index)
        {
            ProcessThreadCollection threads = processes[index].Threads;
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            for (int i = 0; i < threads.Count; i++)
            {
                ListViewItem temp = new ListViewItem();
                temp.Text = threads[i].Id.ToString();
                temp.SubItems.Add(threads[i].CurrentPriority.ToString());
                listViewItems.Add(temp);
            }
            return listViewItems.ToArray();
        }


    }
}
