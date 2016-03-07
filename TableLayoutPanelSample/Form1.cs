using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TableLayoutPanelSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var TimeStamp = new DataGridViewTextBoxColumn();
            var Server = new DataGridViewTextBoxColumn();
            var Nord_Cluster = new DataGridViewTextBoxColumn();
            var Request_Name = new DataGridViewTextBoxColumn();
            var View = new DataGridViewLinkColumn();
            var Req_details = new DataGridViewTextBoxColumn();

            TimeStamp.HeaderText = "TimeStamp";
            TimeStamp.Name = "TimeStamp";
            Server.HeaderText = "Server";
            Server.Name = "Server";
            Nord_Cluster.HeaderText = "Nord_Cluster";
            Nord_Cluster.Name = "Nord_Cluster";
            Request_Name.HeaderText = "Request_Name";
            Request_Name.Name = "Request_Name";
            View.HeaderText = "View";
            View.Name = "View";
            Req_details.Visible = false;

            ListReqGridView.Columns.AddRange(new DataGridViewColumn[] { Req_details,TimeStamp, Server, Nord_Cluster, Request_Name, View });
            
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int counter = 0; 
            int wordfound = 1;
            String outputScreen = "";
            string ReqType = ReqTypeComboBox.Text;
            bool lineFound = false;
            string paneContent = "";
            
             
            

            
            //for (int k = 1; k <= 8; k++)
            //{
            //    ListReqGridView.Rows.Add("vew", "http://www.kettic.com");
               
            //}
            foreach (string line in System.IO.File.ReadAllLines("d:\\log.txt"))
            {
                int writeTo = 0;
                if (line.Contains(ReqType))
                {
                    lineFound = !lineFound;
                    if (!lineFound)
                    {
                        writeTo = 1;
                    }


                }
                else
                {
                    if (lineFound)
                    {
                        paneContent += line+"\n";
                    }
                }
                if (writeTo == 1)
                {
                    ListReqGridView.Rows.Add(paneContent,1, 1, 1, paneContent, "http://www.kettic.com");
                    paneContent = "";
                }
            }
            //using (TextReader reader = new StringReader(paneContent))
            //{
            //    data = (PaneData)(serializer.Deserialize(reader));
            //}

        }

        private void ListReqGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("CEll Double_Click event calls");
            int rowIndex = e.RowIndex;
            DataGridViewRow row = ListReqGridView.Rows[rowIndex];
           // textBox5.Text = row.Cells[1].Value;
            MessageBox.Show(row.Cells[0].Value.ToString());
        }
    }
}