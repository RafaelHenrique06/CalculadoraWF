namespace Calculadora1
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            txtResultado = new TextBox();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnQuatro = new Button();
            btnTres = new Button();
            btnDois = new Button();
            btnUm = new Button();
            btnDoisZeros = new Button();
            btnZero = new Button();
            btnIgual = new Button();
            btnMais = new Button();
            btnMenos = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnLimpar = new Button();
            btnApagar = new Button();
            btnVirgulas = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Control;
            txtResultado.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(12, 12);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(505, 34);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSete
            // 
            btnSete.BackColor = SystemColors.ButtonHighlight;
            btnSete.FlatAppearance.BorderColor = Color.Blue;
            btnSete.FlatAppearance.BorderSize = 2;
            btnSete.FlatStyle = FlatStyle.Flat;
            btnSete.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSete.Location = new Point(12, 56);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(78, 43);
            btnSete.TabIndex = 1;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = SystemColors.ButtonHighlight;
            btnOito.FlatAppearance.BorderColor = Color.Blue;
            btnOito.FlatAppearance.BorderSize = 2;
            btnOito.FlatStyle = FlatStyle.Flat;
            btnOito.Font = new Font("Britannic Bold", 14.25F);
            btnOito.Location = new Point(96, 56);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(78, 43);
            btnOito.TabIndex = 2;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = SystemColors.ButtonHighlight;
            btnNove.FlatAppearance.BorderColor = Color.Blue;
            btnNove.FlatAppearance.BorderSize = 2;
            btnNove.FlatStyle = FlatStyle.Flat;
            btnNove.Font = new Font("Britannic Bold", 14.25F);
            btnNove.Location = new Point(180, 56);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(78, 43);
            btnNove.TabIndex = 3;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += btnNove_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = SystemColors.ButtonHighlight;
            btnSeis.FlatAppearance.BorderColor = Color.Blue;
            btnSeis.FlatAppearance.BorderSize = 2;
            btnSeis.FlatStyle = FlatStyle.Flat;
            btnSeis.Font = new Font("Britannic Bold", 14.25F);
            btnSeis.Location = new Point(180, 105);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(78, 43);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = SystemColors.ButtonHighlight;
            btnCinco.FlatAppearance.BorderColor = Color.Blue;
            btnCinco.FlatAppearance.BorderSize = 2;
            btnCinco.FlatStyle = FlatStyle.Flat;
            btnCinco.Font = new Font("Britannic Bold", 14.25F);
            btnCinco.Location = new Point(96, 105);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(78, 43);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = SystemColors.ButtonHighlight;
            btnQuatro.FlatAppearance.BorderColor = Color.Blue;
            btnQuatro.FlatAppearance.BorderSize = 2;
            btnQuatro.FlatStyle = FlatStyle.Flat;
            btnQuatro.Font = new Font("Britannic Bold", 14.25F);
            btnQuatro.Location = new Point(12, 105);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(78, 43);
            btnQuatro.TabIndex = 4;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = SystemColors.ButtonHighlight;
            btnTres.FlatAppearance.BorderColor = Color.Blue;
            btnTres.FlatAppearance.BorderSize = 2;
            btnTres.FlatStyle = FlatStyle.Flat;
            btnTres.Font = new Font("Britannic Bold", 14.25F);
            btnTres.Location = new Point(180, 154);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(78, 43);
            btnTres.TabIndex = 9;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = SystemColors.ButtonHighlight;
            btnDois.FlatAppearance.BorderColor = Color.Blue;
            btnDois.FlatAppearance.BorderSize = 2;
            btnDois.FlatStyle = FlatStyle.Flat;
            btnDois.Font = new Font("Britannic Bold", 14.25F);
            btnDois.Location = new Point(96, 154);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(78, 43);
            btnDois.TabIndex = 8;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += btnDois_Click;
            // 
            // btnUm
            // 
            btnUm.BackColor = SystemColors.ButtonHighlight;
            btnUm.FlatAppearance.BorderColor = Color.Blue;
            btnUm.FlatAppearance.BorderSize = 2;
            btnUm.FlatStyle = FlatStyle.Flat;
            btnUm.Font = new Font("Britannic Bold", 14.25F);
            btnUm.Location = new Point(12, 154);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(78, 43);
            btnUm.TabIndex = 7;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnUm_Click;
            // 
            // btnDoisZeros
            // 
            btnDoisZeros.BackColor = SystemColors.ButtonHighlight;
            btnDoisZeros.FlatAppearance.BorderColor = Color.Blue;
            btnDoisZeros.FlatAppearance.BorderSize = 2;
            btnDoisZeros.FlatStyle = FlatStyle.Flat;
            btnDoisZeros.Font = new Font("Britannic Bold", 14.25F);
            btnDoisZeros.Location = new Point(180, 203);
            btnDoisZeros.Name = "btnDoisZeros";
            btnDoisZeros.Size = new Size(78, 43);
            btnDoisZeros.TabIndex = 12;
            btnDoisZeros.Text = "00";
            btnDoisZeros.UseVisualStyleBackColor = false;
            btnDoisZeros.Click += btnDoisZeros_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.ButtonHighlight;
            btnZero.FlatAppearance.BorderColor = Color.Blue;
            btnZero.FlatAppearance.BorderSize = 2;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Britannic Bold", 14.25F);
            btnZero.Location = new Point(96, 203);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(78, 43);
            btnZero.TabIndex = 11;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.FromArgb(255, 128, 0);
            btnIgual.FlatAppearance.BorderColor = Color.Black;
            btnIgual.FlatAppearance.BorderSize = 2;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(264, 203);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(253, 43);
            btnIgual.TabIndex = 13;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnMais
            // 
            btnMais.BackColor = SystemColors.ButtonHighlight;
            btnMais.FlatAppearance.BorderColor = Color.Red;
            btnMais.FlatAppearance.BorderSize = 3;
            btnMais.FlatStyle = FlatStyle.Flat;
            btnMais.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMais.Location = new Point(264, 56);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(111, 43);
            btnMais.TabIndex = 14;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = false;
            btnMais.Click += btnMais_Click;
            // 
            // btnMenos
            // 
            btnMenos.BackColor = SystemColors.ButtonHighlight;
            btnMenos.FlatAppearance.BorderColor = Color.Red;
            btnMenos.FlatAppearance.BorderSize = 3;
            btnMenos.FlatStyle = FlatStyle.Flat;
            btnMenos.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenos.Location = new Point(406, 56);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(111, 43);
            btnMenos.TabIndex = 15;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = SystemColors.ButtonHighlight;
            btnMultiplicacao.FlatAppearance.BorderColor = Color.Red;
            btnMultiplicacao.FlatAppearance.BorderSize = 3;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicacao.Location = new Point(264, 105);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(111, 43);
            btnMultiplicacao.TabIndex = 16;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = SystemColors.ButtonHighlight;
            btnDivisao.FlatAppearance.BorderColor = Color.Red;
            btnDivisao.FlatAppearance.BorderSize = 3;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivisao.Location = new Point(406, 105);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(111, 43);
            btnDivisao.TabIndex = 17;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.FlatAppearance.BorderColor = Color.GreenYellow;
            btnLimpar.FlatAppearance.BorderSize = 3;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(264, 154);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(131, 43);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.White;
            btnApagar.FlatAppearance.BorderColor = Color.GreenYellow;
            btnApagar.FlatAppearance.BorderSize = 3;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApagar.Image = (Image)resources.GetObject("btnApagar.Image");
            btnApagar.Location = new Point(406, 154);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(113, 43);
            btnApagar.TabIndex = 19;
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnVirgulas
            // 
            btnVirgulas.BackColor = SystemColors.ButtonHighlight;
            btnVirgulas.FlatAppearance.BorderColor = Color.Blue;
            btnVirgulas.FlatAppearance.BorderSize = 2;
            btnVirgulas.FlatStyle = FlatStyle.Flat;
            btnVirgulas.Font = new Font("Britannic Bold", 14.25F);
            btnVirgulas.Location = new Point(12, 203);
            btnVirgulas.Name = "btnVirgulas";
            btnVirgulas.Size = new Size(78, 43);
            btnVirgulas.TabIndex = 20;
            btnVirgulas.Text = ",";
            btnVirgulas.UseVisualStyleBackColor = false;
            btnVirgulas.Click += btnVirgulas_Click;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(529, 263);
            Controls.Add(btnVirgulas);
            Controls.Add(btnApagar);
            Controls.Add(btnLimpar);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnMenos);
            Controls.Add(btnMais);
            Controls.Add(btnIgual);
            Controls.Add(btnDoisZeros);
            Controls.Add(btnZero);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(txtResultado);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnTres;
        private Button btnDois;
        private Button btnUm;
        private Button btnDoisZeros;
        private Button btnZero;
        private Button btnIgual;
        private Button btnMais;
        private Button btnMenos;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnLimpar;
        private Button btnApagar;
        private Button btnVirgulas;
    }
}
