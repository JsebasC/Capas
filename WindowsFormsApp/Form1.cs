using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CapaDato;
using CapaNegocio;


namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NegocioUsers metodosNegocio = new NegocioUsers();
        EntidadUsers entidadUser = new EntidadUsers();
        BindingList<Users> UserDataSource = new BindingList<Users>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Guardar()
        {
            if(txtFirstName.Text == "")
            {
                MessageBox.Show("Error");
            }
            entidadUser.name = txtFirstName.Text;
            entidadUser.last_name = txtLastName.Text;
            string cumple = txtBirthday.Text;
            DateTime ConvertCumple = DateTime.Parse(cumple, System.Globalization.CultureInfo.InvariantCulture);
            entidadUser.birthday = ConvertCumple;
            entidadUser.eps_id = Convert.ToInt32(txtEps.Text);
            entidadUser.created_at = DateTime.Now;
            entidadUser.updated_at = DateTime.Now;

            metodosNegocio.Guardar(entidadUser);
            Mostrar();





        }


        private void Mostrar()
        {
            UserDataSource = metodosNegocio.MostrarDatos();
            //var datos = metodosNegocio.MostrarDatos();
            dataGridView1.DataSource = UserDataSource;

            foreach (DataGridViewRow Fila in dataGridView1.Rows)
            {
                Fila.Cells["_RegType"].Value = "NoTemp";
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows.Add();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            Mostrar();
          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Guardar();

            UserDataSource.AddNew();
            //dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["_RegType"].Value = "Temp";
           // Mostrar();
            //Limpiar();
        }

        public void Limpiar()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtBirthday.Text = "";
            txtEps.Text = "";
        }
    }
}
