using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS1
{
    public partial class start : Form
    {
        Process[] processCollection; 
        public start()
        {
            InitializeComponent();
            
            createProcessesTable();
        }

        private void createProcessesTable()
        {
            if (dataGrid_processes.Columns.Count == 0)
            {
                dataGrid_processes.Columns.Add("Name", "Name");
                dataGrid_processes.Columns.Add("ID", "ID");
            }
            
            processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                dataGrid_processes.Rows.Add(p.ProcessName, p.Id.ToString());
            }
        }

        private void searchByNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (!(searchByNameTextBox.Text.Equals("Enter Name...")))
            {
                dataGrid_processes.Rows.Clear();
                foreach (Process p in processCollection)
                {
                    if (!(searchByIdTextBox.Text.Equals("Enter ID...")))
                    {
                        if (p.Id.ToString().Contains(searchByIdTextBox.Text) && p.ProcessName.Contains(searchByNameTextBox.Text))
                            dataGrid_processes.Rows.Add(p.ProcessName, p.Id.ToString());
                    }
                    else
                    {
                        if (p.ProcessName.Contains(searchByNameTextBox.Text))
                            dataGrid_processes.Rows.Add(p.ProcessName, p.Id.ToString());
                    }

                }
                if (!(dataGrid_processes.Rows.Count > 1))
                {
                    MessageBox.Show("A process with name: " + searchByNameTextBox.Text + " and ID: " + searchByIdTextBox.Text + " is not exist");
                    searchByNameTextBox.Text = "Enter Name...";

                    createProcessesTable();
                }
            }
            
        }

        private void searchByIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(searchByIdTextBox.Text.Equals("Enter ID...")))
            {
                dataGrid_processes.Rows.Clear();
                foreach (Process p in processCollection)
                {
                    if (!(searchByNameTextBox.Text.Equals("Enter Name...")))
                    {
                        if (p.Id.ToString().Contains(searchByIdTextBox.Text) && p.ProcessName.Contains(searchByNameTextBox.Text))
                            dataGrid_processes.Rows.Add(p.ProcessName, p.Id.ToString());
                    }
                    else
                    {
                        if (p.Id.ToString().Contains(searchByIdTextBox.Text))
                            dataGrid_processes.Rows.Add(p.ProcessName, p.Id.ToString());
                    }

                }
                if (!(dataGrid_processes.Rows.Count > 1))
                {
                    MessageBox.Show("A process with name: " + searchByNameTextBox.Text + " and ID: " + searchByIdTextBox.Text + " is not exist");
                    searchByIdTextBox.Text = "Enter ID...";

                    createProcessesTable();
                }
            }
            
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            if (dataGrid_processes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose a process to kill");
                return;
            }

            if (dataGrid_processes.SelectedRows.Count > 1)
            {
                MessageBox.Show("Cannot kill more then one process in a time!");
                return;
            }
            string processID = dataGrid_processes.SelectedRows[0].Cells[1].Value.ToString();
            Process.GetProcessById(int.Parse(processID)).Kill();

            Thread.Sleep(10);
            dataGrid_processes.Rows.Clear();
            createProcessesTable();


        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dataGrid_processes.Rows.Clear();
            createProcessesTable();
        }

    }
}
