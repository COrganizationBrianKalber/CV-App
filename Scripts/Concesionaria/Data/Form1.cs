using BLL;
using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReescriviendoCSharp.Scripts.Concesionaria.Data
{
    public partial class Form1 : Form
    {
        private DataBase dataBase;
        public Form1()
        {
            InitializeComponent();
            dataBase = new DataBase();
        }

        private void conection_Click(object sender, EventArgs e)
        {
            string result = "";
            MySqlDataReader mySqlDataReader = null;
            string consulta = "select * from usuarios";
            if (dataBase.getConexion() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = dataBase.getConexion();
                mySqlDataReader = cmd.ExecuteReader();

                while (mySqlDataReader.Read()) 
                {
                    result = mySqlDataReader.GetString("apellido");
                }
                MessageBox.Show(result);
            }
            else 
            {
                MessageBox.Show("Error al conectar, Brian!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Contexto ctx = new Contexto()) 
            {
                var oAutos = new ServicioAutos(ctx);
                List<Autos> oLista = oAutos.Obtener();

                if (oLista != null) 
                {
                    foreach (var autos in oLista) 
                    {
                        MessageBox.Show(autos.Marcas);
                    }
                }
            }
        }
    }
}
