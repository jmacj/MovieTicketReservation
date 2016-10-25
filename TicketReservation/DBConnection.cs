using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TicketReservation
{
    class DBConnection
    {
        string connetionString = null;
        MySqlConnection cnn;
        public DBConnection()
        {
            connetionString = "Data Source=localhost;Initial Catalog=ticketreservationsystemdb;User ID=root;Password=1234";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        public void Open()
        {
            cnn.Open();
        }
        public void Close()
        {
            cnn.Close();
        }

    }
}
