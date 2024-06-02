using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_03
{
    public partial class Form4 : Form
    {
        public static Form4 form4Instance;
        public int idPartida;
        public int idJogador;
        public string senhaJogador;
        public string idJogadorAtual;
        public string idJogador1;
        public string idJogador2;
        public string idJogador3;
        public string idJogador4;
        public int round = 1;
        public int rodadaAtual = 1;
        public int rodadaAntiga = 1;
        public int qtdJogaram = 0;
        public int rodadasVencidas = 0;
        public bool iniciador = false;
        public bool iniciador2 = false;
        public bool naoIniciador = true;
        public bool naoIniciador2 = false;
        public bool estrategia = false;
        public bool estrategiaGeral = true;
        public bool minhaVez = false;
        public bool maiorMenor = true;
        public bool oponenteJogou = true;
        bool inicio = false;
        bool meio = false;
        bool dividido = false;
        bool carta2Primeiro = false;
        bool rodadaPenultima = false;
        bool novoRound = false;
        public int[] cartaMeio1 = { 0, 100 };
        public int[] cartaMeio2 = { 0, 100 };
        int cartaProximo = 0;
        public string[] cartas { get; set; }
        List<int> range = new List<int>();

        public Form4()
        {
            InitializeComponent();
            form4Instance = this;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            AtualizarMao();
            Valor0.Text = "";
            Valor1.Text = "";
            Valor2.Text = "";
            Valor3.Text = "";
            Valor4.Text = "";
            Valor5.Text = "";
            Valor6.Text = "";
            Valor7.Text = "";
            vencedor.Text = "";
            CartasJogador1.Text = "Jogador 1 (ID:" + idJogador1 + "):";
            CartasJogador2.Text = "Jogador 2 (ID:" + idJogador2 + "):";
            CartasJogador3.Text = "Jogador 3 (ID:" + idJogador3 + "):";
            CartasJogador4.Text = "Jogador 4 (ID:" + idJogador4 + "):";
            timerVerificarPartida.Enabled = true;
        }

        public void AtualizarCartas()
        {
            string mao = Jogo.ConsultarMao(idPartida);
            cartas = mao.Split(new char[] { ',', '\n' });

            string retorno = Jogo.VerificarVez(idPartida);
            string[] verificar = retorno.Split(new char[] { ',', '\n' });
            idJogadorAtual = verificar[1].Trim();
            tituloJogador.Text = "Vez do Jogador: ID(" + verificar[1] + ")";
            roundStatus.Text = retorno;

            string retorno2 = Jogo.ListarJogadores(idPartida);
            listaJogadores.Text = retorno2;
        }

        public void AtualizarMao()
        {
            AtualizarCartas();
            int numeroCarta = 1;
            int contador = 1;

            for (int i = 2; i < cartas.Length; i = i + 3)
            {
                string pictureBoxName = "card" + numeroCarta;
                PictureBox pictureBox = this.Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;

                if (contador == int.Parse(cartas[i - 1]))
                {
                    if ("C" == cartas[i].Trim())
                    {
                        pictureBox.Image = Properties.Resources.Copas1;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else if ("E" == cartas[i].Trim())
                    {
                        pictureBox.Image = Properties.Resources.Espadas1;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else if ("O" == cartas[i].Trim())
                    {
                        pictureBox.Image = Properties.Resources.Ouros1;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    pictureBox.Image = null;
                    i = i - 3;
                }

                contador++;
                numeroCarta++;

                if (contador > 14)
                {
                    contador = 1;
                }
            }
        }

        public void AtualizarMaoJogada()
        {
            string retorno2 = Jogo.ExibirJogadas2(idPartida, round);
            string[] jogadas = retorno2.Split(new char[] { ',', '\n' });
            string naipe = jogadas[jogadas.Length - 4];
            string valor = jogadas[jogadas.Length - 3];
            string posicao = jogadas[jogadas.Length - 2];

            if (minhaVez == true)
            {
                if (carta2Primeiro == true)
                {
                    if (cartaMeio2[1] == 100)
                    {
                        cartaMeio2[1] = int.Parse(valor);
                    }
                    else if (cartaMeio1[1] == 100)
                    {
                        cartaMeio1[1] = int.Parse(valor);
                        carta2Primeiro = false;
                    }
                }
                else
                {
                    if (cartaMeio1[1] == 100)
                    {
                        cartaMeio1[1] = int.Parse(valor);
                    }
                    else if (cartaMeio2[1] == 100)
                    {
                        cartaMeio2[1] = int.Parse(valor);
                    }
                }

                minhaVez = false;
            }


            int numJogador = 0;
            int JogadorVez = 0;

            if (idJogador1 == idJogadorAtual)
            {
                numJogador = 0;
                JogadorVez = 1;
                Valor0.Text = valor;
                Valor1.Text = valor;
            }
            else if (idJogador2 == idJogadorAtual)
            {
                numJogador = 14;
                JogadorVez = 2;
                Valor2.Text = valor;
                Valor3.Text = valor;
            }
            else if(idJogador3 == idJogadorAtual)
            {
                numJogador = 28;
                JogadorVez = 3;
                Valor4.Text = valor;
                Valor5.Text = valor;
            }
            else if(idJogador4 == idJogadorAtual)
            {
                numJogador = 42;
                JogadorVez = 4;
                Valor6.Text = valor;
                Valor7.Text = valor;
            }

            int total = numJogador + int.Parse(posicao);
            ((PictureBox)this.panel1.Controls["card" + total.ToString()]).Image = null;

            string pictureBoxName = "cardJogado" + JogadorVez;
            PictureBox pictureBox = this.panel1.Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;

            if ("C" == naipe.Trim())
            {
                pictureBox.Image = Properties.Resources.Copas2;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ("E" == naipe.Trim())
            {
                pictureBox.Image = Properties.Resources.Espadas2;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ("O" == naipe.Trim())
            {
                pictureBox.Image = Properties.Resources.Ouros2;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }




        public void VerificarJogo()
        {
            string retorno = Jogo.VerificarVez2(idPartida);
            string[] verificar = retorno.Split(new char[] { ',', '\n' });
            string naipe = "NENHUM";

            if (qtdJogaram == 4)     //Verificar se todos ja jogaram. Caso sim, atualizar round e resetar qtdJogaram
            {
                qtdJogaram = 0;
                rodadaAtual++;
                cardJogado1.Image = null;
                cardJogado2.Image = null;
                Valor0.Text = "";
                Valor1.Text = "";
                Valor2.Text = "";
                Valor3.Text = "";
                Valor4.Text = "";
                Valor5.Text = "";
                Valor6.Text = "";
                Valor7.Text = "";
                AtualizarCartas();

                if (rodadaAtual == 14 && novoRound == false)
                {
                    round++;
                    novoRound = true;
                    estrategiaGeral = true;
                    inicio = false;
                    meio = false;
                    dividido = false;
                    iniciador = false;
                    iniciador2 = false;
                    naoIniciador = true;
                    naoIniciador2 = false;
                    estrategia = false;
                    minhaVez = false;
                    maiorMenor = true;
                    oponenteJogou = false;
                    inicio = false;
                    meio = false;
                    dividido = false;
                    carta2Primeiro = false;
                    rodadaPenultima = false;
                    rodadaAtual = 1;
                    rodadaAntiga = 1;
                    rodadasVencidas = 0;
                    cartaProximo = 0;
                    cartaMeio1[0] = 0;
                    cartaMeio1[1] = 100;
                    cartaMeio2[0] = 0;
                    cartaMeio2[1] = 100;
                    range.Clear();
                    AtualizarMao();
                }
                if (rodadaAtual == 1)
                {
                    novoRound = false;
                }
            }

            if (rodadaAtual == 13 && rodadaPenultima == false)
            {
                rodadaPenultima = true;
                for(int i = 1; i < 57; i++)
                {
                    ((PictureBox)this.panel1.Controls["card" + i.ToString()]).Image = null;
                }

                AtualizarMao();
            }

            if (round == 5)
            {
                string retorno2 = Jogo.ListarJogadores(idPartida);
                string[] pontuacao = retorno2.Split(new char[] { ',', '\n' });
                int[] maiorPontuacao = { 0, -10000 };

                for (int i = 0; i < pontuacao.Length; i = i + 3)
                {
                    if (int.Parse(pontuacao[i + 2].Trim()) > maiorPontuacao[1])
                    {
                        maiorPontuacao[0] = int.Parse(pontuacao[i]);
                        maiorPontuacao[1] = int.Parse(pontuacao[i + 2]);
                    }
                }

                if (maiorPontuacao[0] == int.Parse(idJogador1))
                {
                    vencedor.Text = "Jogador 1 ID(" + maiorPontuacao[0] + ") Venceu!!!!";
                }
                else if(maiorPontuacao[0] == int.Parse(idJogador2))
                {
                    vencedor.Text = "Jogador 2 ID(" + maiorPontuacao[0] + ") Venceu!!!!";
                }
                else if(maiorPontuacao[0] == int.Parse(idJogador3))
                {
                    vencedor.Text = "Jogador 3 ID(" + maiorPontuacao[0] + ") Venceu!!!!";
                }
                else if(maiorPontuacao[0] == int.Parse(idJogador4))
                {
                    vencedor.Text = "Jogador 2 ID(" + maiorPontuacao[0] + ") Venceu!!!!";
                }
            }



            if (idJogadorAtual != verificar[1].Trim())      //Verificar se o oponente ja jogou. Caso sim, aumenta qtdJogaram e atualiza o jogo visual
            {
                qtdJogaram++;
                AtualizarMaoJogada();
                oponenteJogou = true;
                AtualizarCartas();
            }
            else if (verificar[1].Trim() == idJogador.ToString())     //Verificar se é a minha vez
            {
                oponenteJogou = true;
                idJogadorAtual = idJogador.ToString();
                qtdJogaram++;

                if (rodadaAtual != rodadaAntiga)          //Verificar se é um novo round
                {
                    string retorno1 = Jogo.ExibirJogadas2(idPartida, round);
                    string[] pontuacao = retorno1.Split(new char[] { ',', '\n' });
                    int[] maiorPontuacao = { 0, 0 };

                    for (int i = 0; i < pontuacao.Length - 4; i = i + 5)
                    {
                        if (int.Parse(pontuacao[i].Trim()) == rodadaAntiga)
                        {
                            if (int.Parse(pontuacao[i + 3].Trim()) > maiorPontuacao[1])
                            {
                                maiorPontuacao[0] = int.Parse(pontuacao[i + 1].Trim());
                                maiorPontuacao[1] = int.Parse(pontuacao[i + 3].Trim());
                            }
                        }
                    }

                    if (maiorPontuacao[0] == idJogador)     //Verificar se eu ganhei o round passado. Caso sim, atualizar rodadas vencidas
                    {
                        rodadasVencidas++;
                        if (rodadasVencidas >= cartaMeio1[1] && rodadasVencidas - cartaMeio1[1] <= 1 || rodadasVencidas >= cartaMeio2[1])
                        {
                            estrategiaGeral = true;
                            inicio = false;
                            meio = false;
                            dividido = false;
                            range.Clear();
                        }
                    }

                    rodadaAntiga = rodadaAtual;

                }

                if (verificar[verificar.Length - 5].Trim(new Char[] { ' ', ':', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }) == "C")
                {                                                                       //Iniciar estrategia que eu nao sou o iniciador do round
                    string retorno2 = Jogo.ExibirJogadas2(idPartida, round);
                    string[] jogadas = retorno2.Split(new char[] { ',', '\n' });
                    naipe = jogadas[jogadas.Length - 4];
                }
                else if (iniciador == false && estrategia == false)                     //Iniciar estrategia que eu  sou o iniciador do round
                {
                    iniciador = true;
                }

                if (round < 5)
                {
                    Jogar(naipe);
                }

            }
            else if (oponenteJogou == true)
            {
                string retorno1 = Jogo.ExibirJogadas2(idPartida, round);
                string[] mao = retorno1.Split(new char[] { ',', '\n' });
                string idVencedor = mao[mao.Length - 5].Trim();

                if (idVencedor.Trim() == idJogadorAtual.Trim() && idVencedor.Trim() != idJogador.ToString())
                {
                    oponenteJogou = false;
                    qtdJogaram++;
                    AtualizarMaoJogada();
                    AtualizarCartas();
                }
            }
        }

        public void Jogar(string naipe)
        {
            if (iniciador == true || iniciador2 == true)
            {
                EstrategiaIniciador(naipe);
            }
            else if (naoIniciador == true)
            {
                EstrategiaNaoIniciador(naipe);
            }
            else
            {
                EstrategiaGeral(naipe);
            }
        }

        public void Apostar()
        {
            List<String> totalCartas = new List<String>();
            int posicao = 0;

            for (int i = 1; i < cartas.Length; i = i + 3)
            {
                if (cartas[i - 1] == idJogador.ToString())
                {
                    totalCartas.Add(cartas[i]);
                    totalCartas.Add(cartas[i + 1]);
                }

            }

            if (totalCartas.Count == 4)
            {
                if (inicio == true)
                {
                    cartaMeio2[0] = cartaMeio1[0];
                    cartaMeio2[1] = cartaMeio1[1];
                    cartaMeio1[0] = 1;
                    cartaMeio1[1] = 0;
                }

                int inferior = rodadasVencidas - cartaMeio1[1];
                int superior = rodadasVencidas - cartaMeio2[1];

                if (superior < 0)
                {
                    superior = superior * -1;
                }

                if (inferior < superior)
                {
                    posicao = int.Parse(totalCartas[0]);
                }
                else if (superior < inferior)
                {
                    posicao = int.Parse(totalCartas[2]);
                }
                else
                {
                    string retorno2 = Jogo.ExibirJogadas2(idPartida, round);
                    string[] jogadas = retorno2.Split(new char[] { ',', '\n' });

                    for (int i = 2; i < jogadas.Length; i = i + 5)
                    {
                        if (jogadas[i].Trim() == totalCartas[1] && int.Parse(jogadas[i + 1]) == rodadasVencidas)
                        {
                            posicao = int.Parse(totalCartas[2]);
                            break;
                        }
                        else
                        {
                            posicao = int.Parse(totalCartas[0]);
                            break;
                        }
                    }
                }
            }

            Jogo.Apostar(idJogador, senhaJogador, posicao);
            AtualizarCartas();
        }




        public void EstrategiaIniciador(string naipe)
        {
            List<String> cartasdisponiveis = new List<String>();

            for (int i = 2; i < cartas.Length; i = i + 3)
            {
                if (naipe == "NENHUM" && cartas[i - 2] == idJogador.ToString())
                {
                    cartasdisponiveis.Add(cartas[i - 1]);
                }
                else if (cartas[i].Trim() == naipe.Trim() && cartas[i - 2] == idJogador.ToString())
                {
                    cartasdisponiveis.Add(cartas[i - 1]);
                }
            }

            if (iniciador == true && iniciador2 == false)
            {
                minhaVez = true;
                Jogo.Jogar(idJogador, senhaJogador, 4);
                AtualizarMaoJogada();
                AtualizarCartas();
                Apostar();
                iniciador2 = true;
                cartaMeio1[0] = 4;
            }
            else
            {
                int proximo = 0;
                int posicao = 0;

                for (int i = 2; i < cartas.Length; i = i + 3)
                {
                    if (naipe == "NENHUM" && cartas[i - 2] == idJogador.ToString())
                    {
                        cartasdisponiveis.Add(cartas[i - 1]);
                    }
                    else if (cartas[i].Trim() == naipe.Trim() && cartas[i - 2] == idJogador.ToString())
                    {
                        cartasdisponiveis.Add(cartas[i - 1]);
                    }
                }

                if (iniciador2 == true)
                {
                    int numero = 0;
                    ;
                    for (int i = 0; i < cartasdisponiveis.Count; i++)
                    {
                        numero = 11 - int.Parse(cartasdisponiveis[i]);

                        if (numero < 0)
                        {
                            numero = numero * -1;
                        }

                        if (numero < 11 - proximo)
                        {
                            proximo = int.Parse(cartasdisponiveis[i]);
                        }
                    }

                    posicao = proximo;

                    if (11 - proximo <= 2)
                    {
                        minhaVez = true;
                        iniciador = false;
                        iniciador2 = false;
                        naoIniciador = false;
                        estrategia = true;
                        cartaMeio2[0] = posicao;
                    }
                }

                Jogo.Jogar(idJogador, senhaJogador, posicao);
                AtualizarMaoJogada();
                AtualizarCartas();
                Apostar();

            }
        }

        public void EstrategiaNaoIniciador(string naipe)
        {
            List<String> cartasdisponiveis = new List<String>();
            int proximo = 0;
            int proximo2 = 0;
            int posicao = 0;

            for (int i = 2; i < cartas.Length; i = i + 3)
            {
                if (naipe == "NENHUM" && cartas[i - 2] == idJogador.ToString())
                {
                    cartasdisponiveis.Add(cartas[i - 1]);
                }
                else if (cartas[i].Trim() == naipe.Trim() && cartas[i - 2] == idJogador.ToString())
                {
                    cartasdisponiveis.Add(cartas[i - 1]);
                }
            }

            if (naoIniciador == true)
            {
                estrategia = true;

                if (naoIniciador2 == false)
                {
                    int aux1 = 0;
                    int aux2 = 0;

                    for (int i = 0; i < cartasdisponiveis.Count; i++)
                    {
                        aux1 = 11 - int.Parse(cartasdisponiveis[i]);
                        aux2 = 4 - int.Parse(cartasdisponiveis[i]);

                        if (aux1 < 0)
                        {
                            aux1 = aux1 * -1;
                        }
                        if (aux2 < 0)
                        {
                            aux2 = aux2 * -1;
                        }

                        if (aux1 < 11 - proximo)
                        {
                            proximo = int.Parse(cartasdisponiveis[i]);
                        }

                        if (aux2 < 4 - proximo2)
                        {
                            proximo2 = int.Parse(cartasdisponiveis[i]);
                        }
                    }

                    aux1 = 11 - proximo;
                    aux2 = 4 - proximo2;
                    if (aux1 < 0)
                    {
                        aux1 = aux1 * -1;
                    }
                    if (aux2 < 0)
                    {
                        aux2 = aux2 * -1;
                    }

                    if (aux1 == aux2)
                    {
                        posicao = proximo2;
                        cartaProximo = 4;
                        cartaMeio1[0] = posicao;
                    }
                    else if (aux1 < aux2)
                    {
                        posicao = proximo;
                        cartaProximo = 11;
                        cartaMeio2[0] = posicao;
                        carta2Primeiro = true;
                    }
                    else
                    {
                        posicao = proximo2;
                        cartaProximo = 4;
                        cartaMeio1[0] = posicao;
                    }

                    minhaVez = true;
                    naoIniciador2 = true;
                }
                else if (naoIniciador2 == true)
                {
                    if (cartaProximo == 4)
                    {
                        int numero = 0;
                        ;
                        for (int i = 0; i < cartasdisponiveis.Count; i++)
                        {
                            numero = 11 - int.Parse(cartasdisponiveis[i]);

                            if (numero < 0)
                            {
                                numero = numero * -1;
                            }

                            if (numero < 11 - proximo)
                            {
                                proximo = int.Parse(cartasdisponiveis[i]);
                            }
                        }

                        posicao = proximo;

                        if (11 - proximo <= 2)
                        {
                            minhaVez = true;
                            naoIniciador = false;
                            naoIniciador2 = false;
                            cartaMeio2[0] = posicao;
                        }

                    }
                    else if (cartaProximo == 11)
                    {
                        int numero = 0;
                        ;
                        for (int i = 0; i < cartasdisponiveis.Count; i++)
                        {
                            numero = 4 - int.Parse(cartasdisponiveis[i]);

                            if (numero < 0)
                            {
                                numero = numero * -1;
                            }

                            if (numero < 4 - proximo)
                            {
                                proximo = int.Parse(cartasdisponiveis[i]);
                            }
                        }

                        posicao = proximo;

                        if (4 - proximo <= 2)
                        {
                            minhaVez = true;
                            naoIniciador = false;
                            naoIniciador2 = false;
                            cartaMeio1[0] = posicao;
                        }
                    }
                }
            }

            Jogo.Jogar(idJogador, senhaJogador, posicao);
            AtualizarMaoJogada();
            AtualizarCartas();
            Apostar();

        }

        public void EstrategiaGeral(string naipe)
        {
            List<String> cartasdisponiveis = new List<String>();
            int posicao = 0;

            for (int i = 2; i < cartas.Length; i = i + 3)
            {
                if (naipe == "NENHUM" && cartas[i - 2] == idJogador.ToString())
                {
                    cartasdisponiveis.Add(cartas[i - 1]);
                }
                else if (cartas[i].Trim() == naipe.Trim() && cartas[i - 2] == idJogador.ToString())
                {
                    cartasdisponiveis.Add(cartas[i - 1]);
                }
            }

            if (cartasdisponiveis.Count == 0)
            {
                for (int i = 2; i < cartas.Length; i = i + 3)
                {
                    if (cartas[i - 2] == idJogador.ToString())
                    {
                        cartasdisponiveis.Add(cartas[i - 1]);
                    }
                }
            }

            if (estrategiaGeral == true)
            {
                if (rodadasVencidas == cartaMeio1[1])
                {
                    MessageBox.Show("RANGE DIVIDIO 1");
                    List<String> cartasdisponiveis2 = new List<String>();

                    for (int i = 2; i < cartas.Length; i = i + 3)
                    {
                        if (cartas[i - 2] == idJogador.ToString())
                        {
                            cartasdisponiveis2.Add(cartas[i - 1]);
                        }
                    }

                    if (cartasdisponiveis2.Contains((cartaMeio1[0] + 1).ToString()))
                    {
                        range.Add(cartaMeio1[0] - 1);
                        range.Add(cartaMeio1[0] + 1);
                        dividido = true;
                        estrategiaGeral = false;
                    }
                    else if (cartasdisponiveis2.Contains((cartaMeio1[0] - 1).ToString()))
                    {
                        for (int i = 1; i < cartas.Length; i = i + 3)
                        {
                            if (cartas[i - 1] == idJogador.ToString() && int.Parse(cartas[i]) < cartaMeio1[0])
                            {
                                range.Add(int.Parse(cartas[i]));
                            }
                        }

                        inicio = true;
                        estrategiaGeral = false;
                    }
                    else
                    {
                        for (int i = 1; i < cartas.Length; i = i + 3)
                        {
                            if (cartas[i - 1] == idJogador.ToString() && int.Parse(cartas[i]) <= cartaMeio2[0] && int.Parse(cartas[i]) > cartaMeio1[0])
                            {
                                range.Add(int.Parse(cartas[i]));
                            }
                        }

                        meio = true;
                        estrategiaGeral = false;
                    }

                }
                else if (rodadasVencidas == cartaMeio2[1])
                {
                    MessageBox.Show("RANGE DIVIDIO 2");
                    List<String> cartasdisponiveis2 = new List<String>();

                    for (int i = 2; i < cartas.Length; i = i + 3)
                    {
                        if (cartas[i - 2] == idJogador.ToString())
                        {
                            cartasdisponiveis2.Add(cartas[i - 1]);
                        }
                    }

                    if (cartasdisponiveis2.Contains((cartaMeio2[0] + 1).ToString()))
                    {
                        range.Add(cartaMeio2[0] - 1);
                        range.Add(cartaMeio2[0] + 1);
                        dividido = true;
                        estrategiaGeral = false;
                    }
                    else
                    {
                        for (int i = 1; i < cartas.Length; i = i + 3)
                        {
                            if (cartas[i - 1] == idJogador.ToString() && int.Parse(cartas[i]) <= cartaMeio2[0] && int.Parse(cartas[i]) > cartaMeio1[0])
                            {
                                range.Add(int.Parse(cartas[i]));
                            }
                        }

                        meio = true;
                        estrategiaGeral = false;
                    }


                }
                else if (rodadasVencidas < cartaMeio1[1])
                {
                    MessageBox.Show("RANGE INICIO");
                    for (int i = 1; i < cartas.Length; i = i + 3)
                    {
                        if (cartas[i - 1] == idJogador.ToString() && int.Parse(cartas[i]) < cartaMeio1[0])
                        {
                            range.Add(int.Parse(cartas[i]));
                        }
                    }

                    inicio = true;
                    estrategiaGeral = false;
                }
                else if (rodadasVencidas > cartaMeio1[1])
                {
                    MessageBox.Show("RANGE MEIO");
                    for (int i = 1; i < cartas.Length; i = i + 3)
                    {
                        if (cartas[i - 1] == idJogador.ToString() && int.Parse(cartas[i]) <= cartaMeio2[0] && int.Parse(cartas[i]) > cartaMeio1[0])
                        {
                            range.Add(int.Parse(cartas[i]));
                        }
                    }

                    meio = true;
                    estrategiaGeral = false;
                }
            }

            if (estrategiaGeral == false)
            {
                if (range.Count <= 6)
                {
                    if (naipe == "NENHUM")
                    {
                        MessageBox.Show("NAIPE NENHUM");
                        if (cartasdisponiveis.Count == 1)
                        {
                            posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);
                        }
                        else if (int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]) <= range[range.Count - 1] && int.Parse(cartasdisponiveis[0]) >= range[0])
                        {
                            range.Clear();
                            posicao = int.Parse(cartasdisponiveis[0]);
                            estrategiaGeral = true;
                            inicio = false;
                            meio = false;
                            dividido = false;
                        }
                        else if (int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]) <= range[range.Count - 1] && int.Parse(cartasdisponiveis[0]) < range[0])
                        {
                            posicao = int.Parse(cartasdisponiveis[0]);
                        }
                        else
                        {
                            posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("NAIPE ALGUM");
                        if (inicio == true)
                        {
                            MessageBox.Show("INICIO");
                            if (cartasdisponiveis.Count == 1)
                            {
                                posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);
                            }
                            else if (int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]) <= range[range.Count - 1] && int.Parse(cartasdisponiveis[0]) >= 0)
                            {
                                range.Clear();
                                posicao = int.Parse(cartasdisponiveis[0]);
                                estrategiaGeral = true;
                                inicio = false;
                                meio = false;
                                dividido = false;
                            }
                            else
                            {
                                posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);
                            }
                        }
                        else if (meio == true)
                        {
                            MessageBox.Show("MEIO");
                            if (cartasdisponiveis.Count == 1)
                            {
                                posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);
                            }
                            else if (int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]) <= range[range.Count - 1] && int.Parse(cartasdisponiveis[0]) >= range[0])
                            {
                                range.Clear();
                                posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);

                                if (posicao - cartaMeio1[0] < cartaMeio2[0] - posicao)
                                {
                                    minhaVez = true;
                                    estrategiaGeral = true;
                                    inicio = false;
                                    meio = false;
                                    dividido = false;
                                }
                                else if (cartaMeio2[0] - posicao < posicao - cartaMeio1[0])
                                {
                                    minhaVez = true;
                                    estrategiaGeral = true;
                                    inicio = false;
                                    meio = false;
                                    dividido = false;
                                }
                                else
                                {
                                    minhaVez = true;
                                    estrategiaGeral = true;
                                    inicio = false;
                                    meio = false;
                                    dividido = false;
                                }
                            }
                            else
                            {
                                if (int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]) <= range[range.Count - 1] && int.Parse(cartasdisponiveis[0]) < range[0])
                                {
                                    posicao = int.Parse(cartasdisponiveis[0]);
                                }
                                else
                                {
                                    posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);
                                }
                            }
                        }
                        else if (dividido == true)
                        {
                            MessageBox.Show("DIVIDIDO");
                            if (cartasdisponiveis.Count == 1)
                            {
                                posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);
                            }
                            else if (int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]) <= range[range.Count - 1] && int.Parse(cartasdisponiveis[0]) >= range[0])
                            {
                                range.Clear();
                                posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);
                                minhaVez = true;
                                estrategiaGeral = true;
                                inicio = false;
                                meio = false;
                                dividido = false;
                            }
                            else
                            {
                                if (int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]) <= range[range.Count - 1] && int.Parse(cartasdisponiveis[0]) < range[0])
                                {
                                    posicao = int.Parse(cartasdisponiveis[0]);
                                }
                                else
                                {
                                    posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);
                                }
                            }
                        }
                    }

                }
                else
                {
                    if (naipe == "NENHUM")
                    {
                        if (inicio == true)
                        {
                            minhaVez = true;
                            range.Clear();
                            posicao = int.Parse(cartasdisponiveis[0]);
                            estrategiaGeral = true;
                            inicio = false;
                            meio = false;
                            dividido = false;
                        }
                        else if (meio == true)
                        {
                            minhaVez = true;
                            range.Clear();
                            List<string> numerosEntre = cartasdisponiveis.Where(i => int.Parse(i) >= 0 && int.Parse(i) <= cartaMeio1[0]).ToList();
                            posicao = int.Parse(numerosEntre[0]);
                            range.Clear();
                            estrategiaGeral = true;
                            inicio = false;
                            meio = false;
                            dividido = false;
                        }
                    }
                    else
                    {
                        if (inicio == true)
                        {
                            List<string> numerosEntre = cartasdisponiveis.Where(i => int.Parse(i) >= 0 && int.Parse(i) <= cartaMeio1[0]).ToList();
                            if (numerosEntre.Any())
                            {
                                posicao = int.Parse(numerosEntre[0]);
                                range.Clear();
                                estrategiaGeral = true;
                                inicio = false;
                                meio = false;
                                dividido = false;
                            }
                            else
                            {
                                posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);
                                range.Clear();
                                estrategiaGeral = true;
                                inicio = false;
                                meio = false;
                                dividido = false;
                            }
                        }
                        else
                        {
                            List<string> numerosEntre = cartasdisponiveis.Where(i => int.Parse(i) >= cartaMeio1[0] && int.Parse(i) <= cartaMeio2[0]).ToList();
                            if (numerosEntre.Any())
                            {
                                posicao = int.Parse(numerosEntre[0]);
                                range.Clear();
                                estrategiaGeral = true;
                                inicio = false;
                                meio = false;
                                dividido = false;
                            }
                            else
                            {
                                posicao = int.Parse(cartasdisponiveis[cartasdisponiveis.Count - 1]);
                                range.Clear();
                                estrategiaGeral = true;
                                inicio = false;
                                meio = false;
                                dividido = false;
                            }
                        }
                    }

                }
            }

            Jogo.Jogar(idJogador, senhaJogador, posicao);
            AtualizarMaoJogada();
            AtualizarCartas();
            Apostar();

        }

        private void timerVerificarPartida_Tick(object sender, EventArgs e)
        {
            timerVerificarPartida.Enabled = false;
            if (round < 5)
            {
                VerificarJogo();
            }
            timerVerificarPartida.Enabled = true;
        }

    }
}
