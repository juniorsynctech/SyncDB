using System;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;
using System.Data;
using Newtonsoft.Json;
using System.IO;
using SyncDB.SQL;
using FirebirdSql.Data.Isql;

namespace SyncDB
{
    public partial class SyncDB : Form
    {
        private string stringConexao { get; set; }
        private FbConnection conn { get; set; }
        
        public SyncDB()
        {
            InitializeComponent();
            GerarSQL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDB.Text == "" || txtIP.Text == "")
            {
                MessageBox.Show("Verifique os dados informados");
                return;
            }
            
            stringConexao = String.Format(@"User=analistats;Password=wvaebxti;Database={0};DataSource={1};Pooling=False;Connection timeout=25", txtDB.Text, txtIP.Text);
            conn = new FbConnection { ConnectionString = stringConexao };

            try
            {
                conn.Open();
                FbCommand cmd = new FbCommand("select CPF_CNPJ from favorecidos where favorecido = -1", conn);
                txtCNPJ.Text = (RetornaDataSet(cmd)).Tables[0].Rows[0].ItemArray[0].ToString();
                txtCNPJ.ReadOnly=true;
                txtID.Select();

                conn.Close();
            }
            catch 
            {
                MessageBox.Show("Verifique Local da Base, Serviço Firebird ou IP do Servidor!");
            }

        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtIP.Text == "" || txtDB.Text == "")
            {
                MessageBox.Show("Verifique os dados informados e a ID da Empresa");
                return;
            }

            conn.Open();
            DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\SQL");
            
            foreach (FileInfo file in dir.GetFiles())
            {

                string tabela = file.Name.Replace(".sql", "");
                string sql = File.ReadAllText(file.FullName).Replace('#', '"');

                if (conn.State.ToString() == "Open")
                {
                    //Executar SQL
                    FbCommand cmd = new FbCommand(sql.Replace("{0}", txtID.Text), conn);
                    string json = JsonConvert.SerializeObject(RetornaDataSet(cmd), Formatting.None);

                    //Salvar Arquivos
                    StreamWriter salvar = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\JSON\\" + tabela + ".json");
                    salvar.WriteLine(json.Replace("Table", tabela));
                    salvar.Close();

                }

            }            

            MessageBox.Show("Arquivos Gerados com Sucesso!");
            conn.Close();
        }

        private DataSet RetornaDataSet(FbCommand cmdComando)
        {   
            FbDataAdapter daAdaptador = new FbDataAdapter();
            DataSet dsDataSet = new DataSet();
            try
            {                
                cmdComando.Connection = conn;
                daAdaptador.SelectCommand = cmdComando;
                daAdaptador.Fill(dsDataSet);
                return dsDataSet;
            }
            catch (FbException ex)
            {
                throw ex;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            if (txtIP.TextLength > 0) 
            {
                txtIP.Text = null;
            }
            
            string ip = System.Net.IPAddress.Loopback.ToString();
            txtIP.SelectedText = ip;
        }

        private void bntDB_Click(object sender, EventArgs e)
        {
            if (txtDB.TextLength > 0)
            {
                txtDB.Text = null;
            }

            buscaBase.ShowDialog();
            txtDB.Text = buscaBase.FileName;

        }

        private void GerarSQL() {

            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\SQL"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\SQL");
            }
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\JSON"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\JSON");
            }
            GerarSQL FonteSQL = new GerarSQL();


            //Criar SQL
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\SQL\\grupos.sql"))
            {
                sw.WriteLine(FonteSQL.Grupos());
                sw.Close();                
            }

            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\SQL\\fabricantes.sql"))
            {
                sw.WriteLine(FonteSQL.Fabricantes());
                sw.Close();
            }

            using(StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\SQL\\unidades.sql"))
            {
                sw.WriteLine(FonteSQL.Unidades());
                sw.Close();
            }

            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\SQL\\produtos.sql"))
            {
                sw.WriteLine(FonteSQL.Produtos());
                sw.Close();
            }

            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\SQL\\favorecidos.sql"))
            {
                sw.WriteLine(FonteSQL.Favorecidos());
                sw.Close();
            }

            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\SQL\\empresa.sql"))
            {
                sw.WriteLine(FonteSQL.Empresa());
                sw.Close();
            }

            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\SQL\\usuario.sql"))
            {
                sw.WriteLine(FonteSQL.Usuario());
                sw.Close();
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SyncDB_Load(object sender, EventArgs e)
        {

        }
    }
}
