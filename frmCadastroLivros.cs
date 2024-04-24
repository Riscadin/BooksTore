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

namespace BooksTore
{
    public partial class frmCadastroLivros : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataReader dr;

        public frmCadastroLivros()
        {
            InitializeComponent();
        }

        private void frmCadastroLivros_Load(object sender, EventArgs e)
        {



            var tipo = (Owner as Form1)?.tp;
            if (tipo == "A")
            {
                this.Hide();
                txtTitulo.ReadOnly = false;
                txtAutor.ReadOnly = false;
                msktAno.ReadOnly = false;
            }
            else
            {
                txtTitulo.ReadOnly = true;
                txtAutor.ReadOnly = true;
                msktAno.ReadOnly = true;
            }
        }

        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            try
            {

                msktAno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara = msktAno.Text;

                conexao = new MySqlConnection("Server = localhost; Database = Bookstore; Uid = ri ; Pwd = 1205;");

                strSQL = "INSERT INTO T_Livros(titulo,autor,ano) values (@titulo,@autor,@ano);";
                comando = new MySqlCommand(strSQL, conexao);

                if (!msktAno.MaskCompleted || txtTitulo.Text == "" || txtAutor.Text == "" )
                {
                    MessageBox.Show("ESSE CADASTRO NÃO ESTÁ COMPLETO!!!");
                }
                else
                {
                    
                    comando.Parameters.AddWithValue("@ano", valorSemMascara);
                    comando.Parameters.AddWithValue("@autor", txtAutor.Text);
                    comando.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                    
                   


                }

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("LIVRO CADASTRADO COM SUCESSO!!");
                txtTitulo.Clear();
                txtAutor.Clear();
                msktAno.Clear();
                
                msktAno.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: ", ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnBuscarLivros_Click(object sender, EventArgs e)
        {
            try
            {
                msktAno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara1 = msktAno.Text;



               

                conexao = new MySqlConnection("Server = localhost; Database = Bookstore; Uid = ri ; Pwd = 1205;");
                strSQL = "SELECT * FROM T_Livros WHERE codigo = @codigo;";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@codigo", txtBuscarLivros.Text);


                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        msktAno.Text = Convert.ToString(dr["ano"]);
                        txtAutor.Text = Convert.ToString(dr["autor"]);
                        txtTitulo.Text = Convert.ToString(dr["titulo"]);

                        txtTitulo.ReadOnly = false;
                        txtAutor.ReadOnly = false;
                        msktAno.ReadOnly = false;

                    }
                    MessageBox.Show("CONTATO ENCONTRADO!");


                }
                else
                {
                    MessageBox.Show("ESSE CONTATO NÃO PODE SER ENCONTRADO, TALVEZ ESSE CONTATO NÃO EXISTA NO NOSSO SISTEMA!");
                }

                msktAno.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
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
    }
}
