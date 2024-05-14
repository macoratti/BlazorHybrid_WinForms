namespace WinformsBlazorHybrid
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
            lblNome = new Label();
            btnCalculaFatorial = new Button();
            btnEncerrar = new Button();
            btnContador = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.Blue;
            lblNome.Location = new Point(365, 21);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(370, 58);
            lblNome.TabIndex = 0;
            lblNome.Text = "Projeto Matemática ";
            // 
            // btnCalculaFatorial
            // 
            btnCalculaFatorial.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculaFatorial.ForeColor = Color.FromArgb(0, 0, 64);
            btnCalculaFatorial.Location = new Point(470, 107);
            btnCalculaFatorial.Name = "btnCalculaFatorial";
            btnCalculaFatorial.Size = new Size(233, 53);
            btnCalculaFatorial.TabIndex = 1;
            btnCalculaFatorial.Text = "Calcular Fatorial";
            btnCalculaFatorial.UseVisualStyleBackColor = true;
            btnCalculaFatorial.Click += btnCalculaFatorial_Click;
            // 
            // btnEncerrar
            // 
            btnEncerrar.BackColor = Color.FromArgb(255, 128, 0);
            btnEncerrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncerrar.ForeColor = Color.White;
            btnEncerrar.Location = new Point(709, 107);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(236, 53);
            btnEncerrar.TabIndex = 2;
            btnEncerrar.Text = "Encerrar";
            btnEncerrar.UseVisualStyleBackColor = false;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // btnContador
            // 
            btnContador.BackColor = Color.MediumSpringGreen;
            btnContador.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContador.Location = new Point(258, 107);
            btnContador.Name = "btnContador";
            btnContador.Size = new Size(206, 53);
            btnContador.TabIndex = 3;
            btnContador.Text = "Contador";
            btnContador.UseVisualStyleBackColor = false;
            btnContador.Click += btnContador_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Cyan;
            ClientSize = new Size(1102, 637);
            Controls.Add(btnContador);
            Controls.Add(btnEncerrar);
            Controls.Add(btnCalculaFatorial);
            Controls.Add(lblNome);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blazor Hybrid";
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private Button btnCalculaFatorial;
        private Button btnEncerrar;
        private Button btnContador;
    }
}
