using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace t_schema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            GetFromDB();

        }

        public void GetFromDB()
        {
            //Server IP till vår Webbhotell 185.189.48.15
            //localhost
            string connStr = "server=localhost;user=phpuser;database=skolschema;port=3306;password=skolschema";
            MySqlConnection conn = new MySqlConnection(connStr);

            //Testa att ansluta
            try
            {
                //Öppna databasen
                conn.Open();
                // Perform database operations
                //Skapa en sql-sträng
                string sql = "SELECT veckodag, timeBegin, timeEnd, undervisningsgruppID FROM lektioner";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                //Läs en rad i taget i början
                while (rdr.Read())
                {
                    lblText.Text += " " + rdr[0] + " " + rdr[1] + " " + rdr[2];
                    lblUndgrp.Text += " " + rdr[3];
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                lblText.Text += ex.ToString();
                lblUndgrp.Text += ex.ToString();
            }
            //Stäng databasen
            conn.Close();

        }

        public void SkrivTillDB()
        {
            /*
            //Skriv till data basen
            Console.Write("Ange ditt namn: ");
            string strName = Console.ReadLine();
            Console.Write("Ange poäng: ");
            string strScore = Console.ReadLine();
            string strGame = "t-space";

            sql = "INSERT INTO scores (name, score, game) VALUES ('" + strName + "' ,'" + strScore + "', '" + strGame + "')";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Ansluten");
            */
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void lblUndgrp_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
