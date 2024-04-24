using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Expect;

namespace BooksTore
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataReader dr;
        public string tp = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnt_Click(object sender, EventArgs e)
        {
            try
            {
                //string login = "";
                //string senha = "";
                conexao = new MySqlConnection("Server = localhost; Database = Bookstore; Uid = ri ; Pwd = 1205;");

                strSQL = "SELECT * FROM T_Usuarios WHERE login = @login AND senha = @senha";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@login", txtLogin.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);
                
               
                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtTeste.Text = Convert.ToString(dr["tipo"]);
                    }
                    
                    tp = txtTeste.Text;
                    this.Hide();
                    //frmMenu menu = new frmMenu();
                    //menu.ShowDialog();

                    frmCadastroLivros cadastro = new frmCadastroLivros();
                    

                    
                    if (txtTeste.Text == "A")
                    {
                        cadastro.ShowDialog(this);
                       
                    }
                    else
                    {
                        cadastro.ShowDialog(this);
                    }


                    this.Close();
                }
                else
                {
                    MessageBox.Show("LOGIN OU SENHA ESTÁ ERRADO!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
