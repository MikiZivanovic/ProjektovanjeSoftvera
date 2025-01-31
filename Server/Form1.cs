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

namespace Server
{
    public partial class Form1 : Form
    {
        private Server server;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            label1.Text = "Server nije aktivan";
            btnStop.Visible = false;
           
            Thread thread = new Thread(azurirajDataGrid);
           thread.Start();
           
        }

       

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            server = new Server();
            btnStart.Enabled = false;
            btnStart.Visible = false;
            btnStop.Enabled = true;
            btnStop.Visible= true;
            label1.Text = "Server je pokrenut!";
            server.Start();

        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStart.Visible = true;
            btnStop.Enabled = false;
            btnStop.Visible = false;
            label1.Text = "Server je zaustavljen!";
            server.Stop();
        }
        private void azurirajDataGrid()
        {

            while (true) { 
                if (IsHandleCreated) { 
                Invoke(new Action(() => {dataGridView1.DataSource = null; dataGridView1.DataSource = Session.administratori;dataGridView1.Columns.Remove("Id");
                dataGridView1.Columns.Remove("Lozinka");
                dataGridView1.Columns.Remove("KrisnickoIme"); }));
          
                }
             
                Thread.Sleep(1500);
            
            
            }
            
           
        }    
    }   
}
