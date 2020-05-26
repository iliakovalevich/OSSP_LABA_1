using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshButton_Click(null, null);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    string processi = string.Empty;
            //    foreach (Process process in Process.GetProcesses())
            //    { 

            //        foreach (Process winProc in Process.GetProcesses())
            //        {
            //            processi += string.Format("Process " + winProc.Id + ": " + winProc.ProcessName + "\n");
            //            /*MessageBox.Show("Process " + winProc.Id + ": " + winProc.ProcessName);*/
            //            break;
            //        }
            //        listBox1.Items.Add(processi);
            //    }

            //Process[] processes;
            //processes = Process.GetProcesses();
            //foreach (Process instance in processes)
            //{
            //    listBox1.Items.Add("Process " + instance.ProcessName +" ID=  " +instance.Id + 
            //        " Memory =  "+instance.VirtualMemorySize64);

            //}
                            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            int processIndex = listView1.FocusedItem.Index;
            label1.Text = "Process name : " + listView1.SelectedItems[0].SubItems[0].Text;
            listView2.Items.AddRange(ProcessInfo.GetThreadInfo(processIndex));
            RefreshButton_Click(null, null);
            label2.Text = "Count : " + listView2.Items.Count;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
              listView1.Items.Clear();
              listView1.Items.AddRange(ProcessInfo.GetProcessesInfo());
              label1.Text = "Number of processes : " + listView1.Items.Count;           
        }
    }
}
