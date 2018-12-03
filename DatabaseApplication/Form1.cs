using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DatabaseApplication
{
    public partial class Form1 : Form
    {
        public Form1()

        {
           
            InitializeComponent();

            
        }

        private void buttonHozzaAd_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection("Server=localhost;Database=kutyak;Uid=root;Pwd=;"))
            {
                conn.Open();
                string nev = textBoxNev.Text;
                string fajta = textBoxFajta.Text;
                DateTime orokbe = dateTimePickerOrokbeFogad.Value;

                var lekerdezesCommand = conn.CreateCommand();
                lekerdezesCommand.CommandText = @"
                    SELECT COUNT(*) FROM kutyak WHERE nev = @nev
                ";
                lekerdezesCommand.Parameters.AddWithValue("@nev", nev);
                long db = (long) lekerdezesCommand.ExecuteScalar();
                if (db > 0)
                {
                    MessageBox.Show("Ilyen kutya már van");
                    return;
                }
                var command = conn.CreateCommand();
                command.CommandText = @"INSERT INTO 
                                    kutyak
                                    (
                                    nev,
                                    fajta,
                                    orokbefogadas_datum
                                    ) 
                                    VALUES 
                                    (
                                    @nev,
                                    @fajta,
                                    @orokbe)";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@fajta", fajta);
                command.Parameters.AddWithValue("@orokbe", orokbe);
                command.ExecuteNonQuery();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNev.Text != "")
            {
                var conn = new MySqlConnection("Server=localhost;Database=kutyak;Uid=root;Pwd=;");
                conn.Open();
                string nev = textBoxNev.Text;
                var torlesCommand = conn.CreateCommand();
                torlesCommand.CommandText = "Delete from kutyak where nev= @nev";
                torlesCommand.Parameters.AddWithValue("@nev", nev);
                torlesCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("nem jó");
            }
        }

        private void buttonModositas_Click(object sender, EventArgs e)
        {
            if (textBoxNev.Text != "")
            {
                var conn = new MySqlConnection("Server=localhost;Database=kutyak;Uid=root;Pwd=;");
                conn.Open();
                string nev = textBoxNev.Text;
                var torlesCommand = conn.CreateCommand();
                torlesCommand.CommandText = "Update kutyak set nev='"+textBoxNev.Text+"', fajta='"+textBoxFajta.Text+"' where nev= @nev";
                torlesCommand.Parameters.AddWithValue("@nev", nev);
                torlesCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Updated Successfully!");
            }
            else
            {
                Console.WriteLine("nem jó");
            }
        }
    }
}
