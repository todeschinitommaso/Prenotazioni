using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class Form1 : Form
    {
        private TcpListener tcpListener;
        private Thread listenerThread;
        private Thread updateListViewThread;

        public Form1()
        {
            InitializeComponent();
            StartServer();

            // Avvia un thread per l'aggiornamento automatico della ListView ogni 2 secondi
            updateListViewThread = new Thread(new ThreadStart(UpdateListViewThread));
            updateListViewThread.Start();
        }

        private void StartServer()
        {
            tcpListener = new TcpListener(IPAddress.Any, 5555);
            listenerThread = new Thread(new ThreadStart(ListenForClients));
            listenerThread.Start();
        }

        private void ListenForClients()
        {
            tcpListener.Start();

            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object clientObj)
        {
            TcpClient tcpClient = (TcpClient)clientObj;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    break;
                }

                if (bytesRead == 0)
                    break;

                string dataReceived = Encoding.ASCII.GetString(message, 0, bytesRead);
                string[] dataParts = dataReceived.Split(',');

                if (dataParts.Length >= 4)
                {
                    // Aggiungi alla ListView ordinando per data visita
                    AddItemToListView(dataParts[0], dataParts[1], dataParts[2], dataParts[3], dataParts[4], dataParts[5]);
                }
            }

            tcpClient.Close();
        }

        private void AddItemToListView(string dataVisita, string nome, string cognome, string azienda, string consulenza, string dataPrenotazione)
        {
            // Ottieni la data e ora attuale
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd");

            ListViewItem item = new ListViewItem(new[] { dataVisita, nome, cognome, azienda, consulenza, dataPrenotazione });

            // Ordina per data visita (colonna 0) e aggiungi alla ListView
            listView1.BeginInvoke((MethodInvoker)(() =>
            {
                if (listView1.IsHandleCreated)
                {
                    listView1.Items.Add(item);
                    listView1.Sorting = SortOrder.Ascending;
                    listView1.Sort();
                }
            }));
        }

        private void UpdateListViewThread()
        {
            while (true)
            {
                // Aggiorna la ListView ogni 2 secondi
                Thread.Sleep(2000);

                // Leggi i dati dal file CSV e aggiorna la ListView
                ReadDataFromCSVAndUpdateListView();
            }
        }

        private void ReadDataFromCSVAndUpdateListView()
        {
            string filePath = $@"C:\\Data\data.csv";

            if (File.Exists(filePath))
            {
                List<string[]> dataRows = new List<string[]>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] data = line.Split(';');
                        dataRows.Add(data);
                    }
                }

                listView1.BeginInvoke((MethodInvoker)(() =>
                {
                    if (listView1.IsHandleCreated)
                    {
                        listView1.Items.Clear();

                        foreach (var data in dataRows)
                        {
                            AddItemToListView(data[0], data[1], data[2], data[3], data[4], data[5]);
                        }

                        listView1.Sorting = SortOrder.Ascending;
                        listView1.Sort();
                    }
                }));
            }
        }
    }
}
