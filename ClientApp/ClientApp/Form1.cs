using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        private TcpClient tcpClient;
        private bool success = false;

        public Form1()
        {
            InitializeComponent();
            ConnectToServer();

            // Aggiungi il gestore di eventi al pulsante "PRENOTA"
            bookbutton.Click += bookbutton_Click_1;
        }

        private void ConnectToServer()
        {
            tcpClient = new TcpClient();
            tcpClient.Connect("127.0.0.1", 5555);
        }

        private void bookbutton_Click_1(object sender, EventArgs e)
        {
            // Ottieni i dati inseriti dall'utente
            string nome = namebox.Text;
            string cognome = surnamebox.Text;
            string codiceFiscale = aziendabox.Text;
            string dataVisita = datePicker.Value.ToString("yyyy-MM-dd"); // Formatta la data come richiesto
            string tipoVisita = comboBox1.Text;  // Ottieni il valore dalla ComboBox
            string dataPrenotazione = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  // Data e ora attuali

            // Controllo se la data è antecedente a quella odierna
            if (DateTime.Parse(dataVisita) < DateTime.Now.Date)
            {
                MessageBox.Show("La data selezionata è antecedente a quella odierna. Selezionare una data valida.");
                return;
            }

            // Controlla se la data è disponibile
            if (IsDateAvailable(dataVisita))
            {
                // Aggiungi la data al file CSV locale su un thread separato
                Thread csvThread = new Thread(() => AddDateToLocalFile($"{dataVisita};{nome};{cognome};{codiceFiscale};{tipoVisita};{dataPrenotazione}"));
                csvThread.Start();
                csvThread.Join(); // Attendi la fine del thread

                // Invia i dati al server solo se l'inserimento nel CSV ha avuto successo
                SendBookingDataToServer(dataVisita, nome, cognome, codiceFiscale, tipoVisita, dataPrenotazione);

                MessageBox.Show("PRENOTAZIONE AVVENUTA CORRETTAMENTE");

            }
            else
            {
                MessageBox.Show("DATA NON DISPONIBILE");
            }
        }

        private bool IsDateAvailable(string newDate)
        {
            // Leggi tutte le date dal file CSV locale e controlla se la nuova data è già presente
            string filePath = $@"C:\\Data\data.csv";
            string[] existingDates = File.Exists(filePath) ? File.ReadAllLines(filePath) : new string[0];

            foreach (string date in existingDates)
            {
                if (date.Trim().StartsWith(newDate))
                {
                    return false; // Data non disponibile
                }
            }
            return true; // Data disponibile
        }

        private void AddDateToLocalFile(string newDate)
        {
            // Aggiungi la nuova data al file CSV locale
            string filePath = $@"C:\\Data\data.csv";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(newDate);
                success = true;
            }
        }

        private void SendBookingDataToServer(string dataVisita, string nome, string cognome, string azienda, string tipoConsulenza, string dataPrenotazione)
        {
            // Concatena i dati in una stringa e inviala al server
            string bookingData = $"{dataVisita},{nome},{cognome},{azienda},{tipoConsulenza},{dataPrenotazione}";
            SendDataToServer(bookingData);

            // Chiudi la connessione TCP dopo l'invio dei dati
            tcpClient.Close();
        }

        private void SendDataToServer(string data)
        {
            // Invia i dati al server attraverso la connessione TcpClient
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            tcpClient.GetStream().Write(bytes, 0, bytes.Length);
        }
    }
}
