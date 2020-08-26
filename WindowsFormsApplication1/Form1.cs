﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadrastrar_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = connect();
            OleDbCommand command = null;

            try
            {
                connection.Open();

                string sql = "insert into Funcionario values (?,?,?,?,?,?,?,?)";

                command = new OleDbCommand(sql, connection);

                command.Parameters.Add(new OleDbParameter("Codigo", int.Parse(txtCodigo.Text)));
                command.Parameters.Add(new OleDbParameter("Nome", txtNome.Text));
                command.Parameters.Add(new OleDbParameter("Contacto", int.Parse(txtContacto.Text)));
                command.Parameters.Add(new OleDbParameter("NivelAcademico", cboNivel.Text));
                command.Parameters.Add(new OleDbParameter("Salario", int.Parse(txtSalarioHora.Text)));
                command.Parameters.Add(new OleDbParameter("CargaHoraria", int.Parse(txtCargaHoraria.Text)));
                if (rbtMasculino.Checked)
                {
                    command.Parameters.Add(new OleDbParameter("Sexo", "Masculino"));
                }
                else
                {
                    command.Parameters.Add(new OleDbParameter("Sexo", "Femenino"));
                }

                if (rbtSolteiro.Checked)
                {
                    command.Parameters.Add(new OleDbParameter("EstadoCivil", "Solteiro"));
                }
                else if (rbtCasado.Checked)
                {
                    command.Parameters.Add(new OleDbParameter("EstadoCivil", "Casado"));
                }
                else if (rbtDivorciado.Checked)
                {
                    command.Parameters.Add(new OleDbParameter("EstadoCivil", "Divorciado"));
                }
                else if(rbtViuvo.Checked)
                {
                    command.Parameters.Add(new OleDbParameter("EstadoCivil", "Viuvo"));
                }

                command.ExecuteNonQuery();
                clean();

                MessageBox.Show("Cadastro feito com sucesso! ", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static OleDbConnection connect()
        {
            OleDbConnection connection = null;

            try 
	        {	        
		        String path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\BD-AULA\Professor.accdb";

                connection = new OleDbConnection(path);

                MessageBox.Show("Conexao feita com successo!", "Conexao", MessageBoxButtons.OK,MessageBoxIcon.Information);
	        }
	        catch (Exception e)
	        {
		        MessageBox.Show("Error: " + e.Message, "Conexao", MessageBoxButtons.OK,MessageBoxIcon.Error);
	        }

            return connection;
        }

        /*public static ArrayList recoverStudent() {

           // return true;
        }*/
        
        private void clean()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtContacto.Clear();
            cboNivel.Items.Clear();
            txtSalarioHora.Clear();
            txtCargaHoraria.Clear();
            rbtMasculino.Checked = false;
            rbtFeminino.Checked = false;
            rbtSolteiro.Checked = false;
            rbtCasado.Checked = false;
            rbtViuvo.Checked = false;
            rbtDivorciado.Checked = false;
        }

        public static Arr
        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }
    }
}