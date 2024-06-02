namespace PI_03
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.DetalheDll = new System.Windows.Forms.Label();
            this.IniciarPartida = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AtualizarJogadores = new System.Windows.Forms.Button();
            this.listJogadores = new System.Windows.Forms.ListBox();
            this.SenhaJogador = new System.Windows.Forms.Label();
            this.ListaJogadores = new System.Windows.Forms.Label();
            this.NomeJogador = new System.Windows.Forms.Label();
            this.entrarPartida = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.DetalhesJogador = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListarPartida = new System.Windows.Forms.Button();
            this.listaPartida = new System.Windows.Forms.ListBox();
            this.SelecionarPartida = new System.Windows.Forms.Button();
            this.DetalhesServidor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.NomePartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.SenhaServidor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.DetalheDll);
            this.panel1.Controls.Add(this.IniciarPartida);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(458, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 877);
            this.panel1.TabIndex = 0;
            // 
            // DetalheDll
            // 
            this.DetalheDll.AutoSize = true;
            this.DetalheDll.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalheDll.ForeColor = System.Drawing.Color.White;
            this.DetalheDll.Location = new System.Drawing.Point(3, 859);
            this.DetalheDll.Name = "DetalheDll";
            this.DetalheDll.Size = new System.Drawing.Size(140, 18);
            this.DetalheDll.TabIndex = 96;
            this.DetalheDll.Text = "Detalhes da DLL:";
            // 
            // IniciarPartida
            // 
            this.IniciarPartida.BackColor = System.Drawing.Color.Silver;
            this.IniciarPartida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IniciarPartida.FlatAppearance.BorderSize = 2;
            this.IniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarPartida.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarPartida.ForeColor = System.Drawing.Color.Black;
            this.IniciarPartida.Location = new System.Drawing.Point(843, 787);
            this.IniciarPartida.Name = "IniciarPartida";
            this.IniciarPartida.Size = new System.Drawing.Size(183, 70);
            this.IniciarPartida.TabIndex = 90;
            this.IniciarPartida.Text = "Iniciar Partida";
            this.IniciarPartida.UseVisualStyleBackColor = false;
            this.IniciarPartida.Click += new System.EventHandler(this.IniciarPartida_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.AtualizarJogadores);
            this.panel4.Controls.Add(this.listJogadores);
            this.panel4.Controls.Add(this.SenhaJogador);
            this.panel4.Controls.Add(this.ListaJogadores);
            this.panel4.Controls.Add(this.NomeJogador);
            this.panel4.Controls.Add(this.entrarPartida);
            this.panel4.Controls.Add(this.txtSenha);
            this.panel4.Controls.Add(this.txtNome);
            this.panel4.Controls.Add(this.DetalhesJogador);
            this.panel4.Location = new System.Drawing.Point(31, 596);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 174);
            this.panel4.TabIndex = 85;
            // 
            // AtualizarJogadores
            // 
            this.AtualizarJogadores.BackColor = System.Drawing.Color.Silver;
            this.AtualizarJogadores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AtualizarJogadores.FlatAppearance.BorderSize = 2;
            this.AtualizarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AtualizarJogadores.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtualizarJogadores.Location = new System.Drawing.Point(877, 124);
            this.AtualizarJogadores.Name = "AtualizarJogadores";
            this.AtualizarJogadores.Size = new System.Drawing.Size(94, 29);
            this.AtualizarJogadores.TabIndex = 91;
            this.AtualizarJogadores.Text = "Atualizar";
            this.AtualizarJogadores.UseVisualStyleBackColor = false;
            this.AtualizarJogadores.Click += new System.EventHandler(this.AtualizarJogadores_Click);
            // 
            // listJogadores
            // 
            this.listJogadores.BackColor = System.Drawing.Color.Black;
            this.listJogadores.ForeColor = System.Drawing.Color.White;
            this.listJogadores.FormattingEnabled = true;
            this.listJogadores.Location = new System.Drawing.Point(705, 58);
            this.listJogadores.Name = "listJogadores";
            this.listJogadores.Size = new System.Drawing.Size(163, 95);
            this.listJogadores.TabIndex = 90;
            // 
            // SenhaJogador
            // 
            this.SenhaJogador.BackColor = System.Drawing.Color.Transparent;
            this.SenhaJogador.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaJogador.ForeColor = System.Drawing.Color.White;
            this.SenhaJogador.Location = new System.Drawing.Point(14, 48);
            this.SenhaJogador.Name = "SenhaJogador";
            this.SenhaJogador.Size = new System.Drawing.Size(158, 36);
            this.SenhaJogador.TabIndex = 86;
            this.SenhaJogador.Text = "Senha da Partida:";
            this.SenhaJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListaJogadores
            // 
            this.ListaJogadores.AutoSize = true;
            this.ListaJogadores.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaJogadores.ForeColor = System.Drawing.Color.White;
            this.ListaJogadores.Location = new System.Drawing.Point(702, 22);
            this.ListaJogadores.Name = "ListaJogadores";
            this.ListaJogadores.Size = new System.Drawing.Size(166, 18);
            this.ListaJogadores.TabIndex = 89;
            this.ListaJogadores.Text = "Lista de Joagadores:";
            // 
            // NomeJogador
            // 
            this.NomeJogador.BackColor = System.Drawing.Color.Transparent;
            this.NomeJogador.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeJogador.ForeColor = System.Drawing.Color.White;
            this.NomeJogador.Location = new System.Drawing.Point(14, 12);
            this.NomeJogador.Name = "NomeJogador";
            this.NomeJogador.Size = new System.Drawing.Size(158, 36);
            this.NomeJogador.TabIndex = 85;
            this.NomeJogador.Text = "Nome do Jogador:";
            this.NomeJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entrarPartida
            // 
            this.entrarPartida.BackColor = System.Drawing.Color.Silver;
            this.entrarPartida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.entrarPartida.FlatAppearance.BorderSize = 2;
            this.entrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrarPartida.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarPartida.Location = new System.Drawing.Point(178, 94);
            this.entrarPartida.Name = "entrarPartida";
            this.entrarPartida.Size = new System.Drawing.Size(118, 36);
            this.entrarPartida.TabIndex = 84;
            this.entrarPartida.Text = "Conectar";
            this.entrarPartida.UseVisualStyleBackColor = false;
            this.entrarPartida.Click += new System.EventHandler(this.ConectarPartida);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(178, 56);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(116, 23);
            this.txtSenha.TabIndex = 83;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(178, 22);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(116, 23);
            this.txtNome.TabIndex = 82;
            // 
            // DetalhesJogador
            // 
            this.DetalhesJogador.AutoSize = true;
            this.DetalhesJogador.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalhesJogador.ForeColor = System.Drawing.Color.White;
            this.DetalhesJogador.Location = new System.Drawing.Point(410, 19);
            this.DetalhesJogador.Name = "DetalhesJogador";
            this.DetalhesJogador.Size = new System.Drawing.Size(170, 18);
            this.DetalhesJogador.TabIndex = 81;
            this.DetalhesJogador.Text = "Detalhes do Jogador:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.ListarPartida);
            this.panel3.Controls.Add(this.listaPartida);
            this.panel3.Controls.Add(this.SelecionarPartida);
            this.panel3.Controls.Add(this.DetalhesServidor);
            this.panel3.Location = new System.Drawing.Point(26, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 275);
            this.panel3.TabIndex = 84;
            // 
            // ListarPartida
            // 
            this.ListarPartida.BackColor = System.Drawing.Color.Silver;
            this.ListarPartida.FlatAppearance.BorderSize = 2;
            this.ListarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListarPartida.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarPartida.Location = new System.Drawing.Point(844, 214);
            this.ListarPartida.Name = "ListarPartida";
            this.ListarPartida.Size = new System.Drawing.Size(132, 39);
            this.ListarPartida.TabIndex = 61;
            this.ListarPartida.Text = "Atualizar";
            this.ListarPartida.UseVisualStyleBackColor = false;
            this.ListarPartida.Click += new System.EventHandler(this.BotaoListar);
            // 
            // listaPartida
            // 
            this.listaPartida.BackColor = System.Drawing.Color.Black;
            this.listaPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaPartida.ForeColor = System.Drawing.Color.White;
            this.listaPartida.FormattingEnabled = true;
            this.listaPartida.Location = new System.Drawing.Point(22, 13);
            this.listaPartida.Name = "listaPartida";
            this.listaPartida.Size = new System.Drawing.Size(954, 195);
            this.listaPartida.TabIndex = 60;
            // 
            // SelecionarPartida
            // 
            this.SelecionarPartida.BackColor = System.Drawing.Color.Silver;
            this.SelecionarPartida.FlatAppearance.BorderSize = 2;
            this.SelecionarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelecionarPartida.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelecionarPartida.Location = new System.Drawing.Point(656, 214);
            this.SelecionarPartida.Name = "SelecionarPartida";
            this.SelecionarPartida.Size = new System.Drawing.Size(171, 39);
            this.SelecionarPartida.TabIndex = 62;
            this.SelecionarPartida.Text = "Selecionar Servidor";
            this.SelecionarPartida.UseVisualStyleBackColor = false;
            this.SelecionarPartida.Click += new System.EventHandler(this.BotaoSelecionarPartida);
            // 
            // DetalhesServidor
            // 
            this.DetalhesServidor.AutoSize = true;
            this.DetalhesServidor.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalhesServidor.ForeColor = System.Drawing.Color.White;
            this.DetalhesServidor.Location = new System.Drawing.Point(29, 214);
            this.DetalhesServidor.Name = "DetalhesServidor";
            this.DetalhesServidor.Size = new System.Drawing.Size(173, 18);
            this.DetalhesServidor.TabIndex = 63;
            this.DetalhesServidor.Text = "Detalhes do Servidor:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(995, 29);
            this.label2.TabIndex = 81;
            this.label2.Text = "Entrar no Servidor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.txtNomePartida);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.NomePartida);
            this.panel2.Controls.Add(this.txtSenhaPartida);
            this.panel2.Controls.Add(this.SenhaServidor);
            this.panel2.Location = new System.Drawing.Point(26, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 159);
            this.panel2.TabIndex = 83;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(164, 19);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(119, 20);
            this.txtNomePartida.TabIndex = 66;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(164, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 32);
            this.button3.TabIndex = 65;
            this.button3.Text = "Criar Partida";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BotaoCriar);
            // 
            // NomePartida
            // 
            this.NomePartida.BackColor = System.Drawing.Color.Transparent;
            this.NomePartida.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomePartida.ForeColor = System.Drawing.Color.White;
            this.NomePartida.Location = new System.Drawing.Point(6, 10);
            this.NomePartida.Name = "NomePartida";
            this.NomePartida.Size = new System.Drawing.Size(155, 29);
            this.NomePartida.TabIndex = 67;
            this.NomePartida.Text = "Nome Da Partida:";
            this.NomePartida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(164, 54);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(119, 20);
            this.txtSenhaPartida.TabIndex = 68;
            // 
            // SenhaServidor
            // 
            this.SenhaServidor.BackColor = System.Drawing.Color.Transparent;
            this.SenhaServidor.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaServidor.ForeColor = System.Drawing.Color.White;
            this.SenhaServidor.Location = new System.Drawing.Point(6, 43);
            this.SenhaServidor.Name = "SenhaServidor";
            this.SenhaServidor.Size = new System.Drawing.Size(158, 39);
            this.SenhaServidor.TabIndex = 69;
            this.SenhaServidor.Text = "Senha da Partida:";
            this.SenhaServidor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(995, 29);
            this.label1.TabIndex = 80;
            this.label1.Text = "Criar Servidor";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(995, 29);
            this.label3.TabIndex = 82;
            this.label3.Text = "Servidores";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_03.Properties.Resources.plano_de_fundo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label NomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label SenhaServidor;
        private System.Windows.Forms.ListBox listaPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ListarPartida;
        private System.Windows.Forms.Button SelecionarPartida;
        private System.Windows.Forms.Label DetalhesServidor;
        private System.Windows.Forms.Button IniciarPartida;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label SenhaJogador;
        private System.Windows.Forms.Label ListaJogadores;
        private System.Windows.Forms.Label NomeJogador;
        private System.Windows.Forms.Button entrarPartida;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label DetalhesJogador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listJogadores;
        private System.Windows.Forms.Button AtualizarJogadores;
        private System.Windows.Forms.Label DetalheDll;
    }
}