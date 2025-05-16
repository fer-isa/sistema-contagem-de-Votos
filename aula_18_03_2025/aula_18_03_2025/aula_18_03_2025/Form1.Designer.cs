namespace aula_18_03_2025
{
    partial class Form1
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
            lbl_ = new Label();
            btn_Resultado = new Button();
            lbl_Votos_Nulos = new Label();
            lbl_Votos_Em_Branco = new Label();
            txt_Votos_brancos = new TextBox();
            lbl_Votos_Validos = new Label();
            txt_Votos_Validos = new TextBox();
            txt_Votos_Nulos = new TextBox();
            lbl_resultado = new Label();
            SuspendLayout();
            // 
            // lbl_
            // 
            lbl_.AutoSize = true;
            lbl_.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_.ForeColor = SystemColors.HotTrack;
            lbl_.Location = new Point(16, 16);
            lbl_.Name = "lbl_";
            lbl_.Size = new Size(222, 32);
            lbl_.TabIndex = 0;
            lbl_.Text = "Atividade Eleitores:";
            lbl_.Click += lbl__Click;
            // 
            // btn_Resultado
            // 
            btn_Resultado.Font = new Font("Segoe UI", 12F);
            btn_Resultado.ForeColor = SystemColors.HotTrack;
            btn_Resultado.Location = new Point(379, 158);
            btn_Resultado.Name = "btn_Resultado";
            btn_Resultado.Size = new Size(93, 35);
            btn_Resultado.TabIndex = 2;
            btn_Resultado.Text = "Resultado";
            btn_Resultado.UseVisualStyleBackColor = true;
            btn_Resultado.Click += btn_Resultado_Click;
            // 
            // lbl_Votos_Nulos
            // 
            lbl_Votos_Nulos.AutoSize = true;
            lbl_Votos_Nulos.ForeColor = SystemColors.HotTrack;
            lbl_Votos_Nulos.Location = new Point(12, 87);
            lbl_Votos_Nulos.Margin = new Padding(8, 0, 3, 8);
            lbl_Votos_Nulos.Name = "lbl_Votos_Nulos";
            lbl_Votos_Nulos.Size = new Size(73, 15);
            lbl_Votos_Nulos.TabIndex = 3;
            lbl_Votos_Nulos.Text = "Votos Nulos:";
            // 
            // lbl_Votos_Em_Branco
            // 
            lbl_Votos_Em_Branco.AutoSize = true;
            lbl_Votos_Em_Branco.ForeColor = SystemColors.HotTrack;
            lbl_Votos_Em_Branco.Location = new Point(12, 129);
            lbl_Votos_Em_Branco.Margin = new Padding(8, 0, 3, 8);
            lbl_Votos_Em_Branco.Name = "lbl_Votos_Em_Branco";
            lbl_Votos_Em_Branco.Size = new Size(99, 15);
            lbl_Votos_Em_Branco.TabIndex = 4;
            lbl_Votos_Em_Branco.Text = "Votos em Branco:";
            // 
            // txt_Votos_brancos
            // 
            txt_Votos_brancos.Location = new Point(114, 126);
            txt_Votos_brancos.Margin = new Padding(3, 8, 3, 8);
            txt_Votos_brancos.Name = "txt_Votos_brancos";
            txt_Votos_brancos.Size = new Size(238, 23);
            txt_Votos_brancos.TabIndex = 5;
            // 
            // lbl_Votos_Validos
            // 
            lbl_Votos_Validos.AutoSize = true;
            lbl_Votos_Validos.ForeColor = SystemColors.HotTrack;
            lbl_Votos_Validos.Location = new Point(12, 167);
            lbl_Votos_Validos.Margin = new Padding(8, 0, 3, 8);
            lbl_Votos_Validos.Name = "lbl_Votos_Validos";
            lbl_Votos_Validos.Size = new Size(79, 15);
            lbl_Votos_Validos.TabIndex = 6;
            lbl_Votos_Validos.Text = "Votos Válidos:";
            // 
            // txt_Votos_Validos
            // 
            txt_Votos_Validos.Location = new Point(114, 165);
            txt_Votos_Validos.Margin = new Padding(3, 8, 3, 8);
            txt_Votos_Validos.Name = "txt_Votos_Validos";
            txt_Votos_Validos.Size = new Size(238, 23);
            txt_Votos_Validos.TabIndex = 7;
            // 
            // txt_Votos_Nulos
            // 
            txt_Votos_Nulos.Location = new Point(114, 87);
            txt_Votos_Nulos.Margin = new Padding(3, 8, 3, 8);
            txt_Votos_Nulos.Name = "txt_Votos_Nulos";
            txt_Votos_Nulos.Size = new Size(238, 23);
            txt_Votos_Nulos.TabIndex = 8;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Location = new Point(25, 213);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(19, 15);
            lbl_resultado.TabIndex = 9;
            lbl_resultado.Text = "....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_resultado);
            Controls.Add(txt_Votos_Nulos);
            Controls.Add(txt_Votos_Validos);
            Controls.Add(lbl_Votos_Validos);
            Controls.Add(txt_Votos_brancos);
            Controls.Add(lbl_Votos_Em_Branco);
            Controls.Add(lbl_Votos_Nulos);
            Controls.Add(btn_Resultado);
            Controls.Add(lbl_);
            Name = "Form1";
            Text = "Atividade_Eleitores";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_;
        private Button btn_Resultado;
        private Label lbl_Votos_Nulos;
        private Label lbl_Votos_Em_Branco;
        private TextBox txt_Votos_brancos;
        private Label lbl_Votos_Validos;
        private TextBox txt_Votos_Validos;
        private TextBox txt_Votos_Nulos;
        private Label lbl_resultado;
    }
}
