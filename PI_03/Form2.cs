using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DetalheDll.Text = "Versão da DLL: " + Jogo.Versao;
        }

        int idPartida;
        int idjog { get; set; }
        string senhajog { get; set; }

        string grupo = "ANED";
        string[] jogadores { get; set; }

        bool entrou = false;


        private void BotaoListar(object sender, EventArgs e)
        {
            string retorno;
            retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");

            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                listaPartida.Items.Add(partidas[i]);
            }
        }

        private void BotaoSelecionarPartida(object sender, EventArgs e)
        {
            try
            {
                string partida = listaPartida.SelectedItem.ToString();
                string[] itens = partida.Split(',');
                idPartida = Convert.ToInt32(itens[0]);
                string nomePartida = itens[1];
                string dataPartida = itens[2];
                string status = itens[3];
                DetalhesServidor.Text = "ID do Server: " + idPartida.ToString() + "\nNome do Server: " + nomePartida + "\nNome do Grupo: " + grupo;
            }
            catch(Exception)
            {
                MessageBox.Show("Selecione um Servidor");
            }
            
        }

        private void BotaoCriar(object sender, EventArgs e)
        {
            string nome = txtNomePartida.Text;
            string senha = txtSenhaPartida.Text;
            string retorno = Jogo.CriarPartida(nome, senha, grupo);

            if(!retorno.All(char.IsDigit))
            {
                MessageBox.Show(retorno);
            }
            else
            {
                ListarPartida.PerformClick();
            }
            
        }

        private void ConectarPartida(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string senha = txtSenha.Text;
                string retorno = Jogo.EntrarPartida(idPartida, nome, senha);
                string retorno2 = Jogo.ListarJogadores(idPartida);
                retorno2 = retorno2.Replace("\r", "");
                jogadores = retorno2.Split('\n');
                string[] infos = retorno.Split(',');
                string id = infos[0];
                string senhajogador = infos[1];
                idjog = Convert.ToInt32(id);
                senhajog = senhajogador;
                DetalhesJogador.Text = "ID do Jogador: " + id.ToString() + "\nNome do jogador: " + nome + "\nSenha do jogador: " + senhajogador + "Grupo Pertencente: " + grupo;
                
                for (int i = 0; i < jogadores.Length; i++)
                {
                    listJogadores.Items.Add(jogadores[i]);
                }
                entrou = true;
            }
            catch (Exception) 
            {
                MessageBox.Show("Selecione um Servidor\nEscreva o Nome do Jogador e a Senha da Partida");
            }
        }

        private void AtualizarJogadores_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");
            jogadores = retorno.Split('\n');

            for (int i = 0; i < jogadores.Length; i++)
            {
                listJogadores.Items.Add(jogadores[i]);
            }
        }

        private void IniciarPartida_Click(object sender, EventArgs e)
        {
            AtualizarJogadores.PerformClick();

            if (entrou == false)
            {
               MessageBox.Show("Conecte Em Um Servidor");
            }
            else
            {
                if(jogadores.Length == 3)
                {
                    Jogo.IniciarPartida(idjog, senhajog);
                    string retorno = Jogo.ListarJogadores(idPartida);
                    string[] infoIds = retorno.Split(new char[] { ',', '\n' });

                    this.Hide();
                    Form3 f3 = new Form3();
                    Form3.form3Instance.idJogador = idjog;
                    Form3.form3Instance.senhaJogador = senhajog;
                    Form3.form3Instance.idPartida = idPartida;
                    Form3.form3Instance.idJogador1 = infoIds[0];
                    Form3.form3Instance.idJogador2 = infoIds[3];
                    f3.Show();
                }
                else if(jogadores.Length == 5)
                {
                    Jogo.IniciarPartida(idjog, senhajog);
                    string retorno = Jogo.ListarJogadores(idPartida);
                    string[] infoIds = retorno.Split(new char[] { ',', '\n' });

                    this.Hide();
                    Form4 f4 = new Form4();
                    Form4.form4Instance.idJogador = idjog;
                    Form4.form4Instance.senhaJogador = senhajog;
                    Form4.form4Instance.idPartida = idPartida;
                    Form4.form4Instance.idJogador1 = infoIds[0];
                    Form4.form4Instance.idJogador2 = infoIds[3];
                    Form4.form4Instance.idJogador3 = infoIds[6];
                    Form4.form4Instance.idJogador4 = infoIds[9];
                    f4.Show();
                }
                
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarJogadores(idPartida);
            string[] pontuacao = retorno.Split(new char[] { ',', '\n' });

            MessageBox.Show(pontuacao[0]);
            MessageBox.Show(pontuacao[2]);
            MessageBox.Show(pontuacao[3]);
            MessageBox.Show(pontuacao[5]);
        }
    }
}