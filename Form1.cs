using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;


namespace LR_1_TSPP
{
    public partial class Form1 : Form
    {
      
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
	
	tones of
	fa
	fdds
	f eds
	fs f
	sdf
	sd
	f
	sdf
	sd
	f dsf
	 s
	 f ggfh
	 
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ourDatabaseDataSet.CustomerSet". При необходимости она может быть перемещена или удалена.
            this.customerSetTableAdapter.Fill(this.ourDatabaseDataSet.CustomerSet);
            try
            {
                LoadData();
                LoadCustomers();
                LoadItems();
                LoadOrders();
                LoadParts();
            }
            catch (Exception ex)
            {
                
            }

            try
            {
                data = JsonConvert.DeserializeObject<DataSet>(Jdata.ToString());

                var Tcustomers = JsonConvert.DeserializeObject<DataTable>(Jcustomers.ToString());
                dataGridView1.DataSource = Tcustomers;

                //data.Tables.Add(Tcustomers);
                /*for (int i = 0; i < 3; i++)
                {
                    dataGridView1.Columns.RemoveAt(0);
                }*/

                var Torders = JsonConvert.DeserializeObject(Jorders.ToString());
                dataGridView2.DataSource = Torders;
                dataGridView2.Columns.RemoveAt(0);

                var Titems = JsonConvert.DeserializeObject(Jitems.ToString());
                dataGridView3.DataSource = Titems;
                dataGridView3.Columns.RemoveAt(0);

                var Tparts = JsonConvert.DeserializeObject(Jparts.ToString());
                dataGridView4.DataSource = Tparts;
                dataGridView4.Columns.RemoveAt(0);

                
            }
            catch(Exception ex)
            {
                string message = ex.Message;
            }
        }

        void LoadData()
        {
            HttpWebRequest request =
               (HttpWebRequest)WebRequest.Create(
               "http://localhost:55086/Home/GetData");

            request.Method = "GET";
            request.Accept = "application/json";


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            Jdata.Append(reader.ReadToEnd());

            response.Close();
        }

        void LoadCustomers()
        {
            HttpWebRequest request =
               (HttpWebRequest)WebRequest.Create(
               "http://localhost:55086/Home/GetCustomers");

            request.Method = "GET";
            request.Accept = "application/json";


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            
            Jcustomers.Append(reader.ReadToEnd());

            response.Close();
        }

        void LoadOrders()
        {
            HttpWebRequest request =
               (HttpWebRequest)WebRequest.Create(
               "http://localhost:55086/Home/GetOrders");

            request.Method = "GET";
            request.Accept = "application/json";


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            Jorders.Append(reader.ReadToEnd());

            response.Close();
        }

        void LoadItems()
        {
            HttpWebRequest request =
               (HttpWebRequest)WebRequest.Create(
               "http://localhost:55086/Home/GetItems");

            request.Method = "GET";
            request.Accept = "application/json";


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            Jitems.Append(reader.ReadToEnd());

            response.Close();
        }

        void LoadParts()
        {
            HttpWebRequest request =
               (HttpWebRequest)WebRequest.Create(
               "http://localhost:55086/Home/GetParts");

            request.Method = "GET";
            request.Accept = "application/json";


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            Jparts.Append(reader.ReadToEnd());

            response.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Help\glava_1__o_programme.htm");
        }

        private void оСоздателеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Help\glava_8__o_sozdatele.htm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string commandText = (@"D:\Project C++, C#\LR_1_TSPP\LR_1_TSPP\Help.rtf");
	        var proc = new System.Diagnostics.Process();
 	        proc.StartInfo.FileName = commandText;
 	        proc.StartInfo.UseShellExecute = true;
 	        proc.Start ();
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Данная таблица предназначена для отображения информации о клиенте, который заказывает товар";
        }

        private void dataGridView2_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Данная таблица предназначена для отображения информации о товаре, который непосредственно заказан";
        }

        private void dataGridView3_MouseMove_1(object sender, MouseEventArgs e)
        {
            label1.Text = "Данная таблица предназначена для отображения информации о складе, где находится товар для заказа";
        }

        private void dataGridView4_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Данная таблица предназначена для отображения информации о товаре, условиях гарантии, комплектующих";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "При нажатии на данную кнопку будут сохранены все изменения внесенные в таблицы";
        }

        private void dataGridView1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Diagnostics.Process.Start(@"D:\Help\glava_3__informatsiya_o_kliente.htm");
        }

        private void dataGridView2_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Diagnostics.Process.Start(@"D:\Help\glava_4__opisanie_tovara.htm");
        }

        private void dataGridView3_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Diagnostics.Process.Start(@"D:\Help\glava_5__informatsiya_o_sklade.htm");
        }

        private void dataGridView4_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Diagnostics.Process.Start(@"D:\Help\glava_6__informatsiya_o_tovare.htm");
        }

        private void button1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Diagnostics.Process.Start(@"D:\Help\glava_7__obnovit_dannye.htm");
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Diagnostics.Process.Start(@"D:\Help\glava_1__o_programme.htm");
        }

    }
}
