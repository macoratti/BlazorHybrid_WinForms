﻿namespace WinformsBlazorHybrid
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
            blazorWebView1 = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
            btnRetornar = new Button();
            SuspendLayout();
            // 
            // blazorWebView1
            // 
            blazorWebView1.BackColor = Color.FromArgb(255, 255, 192);
            blazorWebView1.Dock = DockStyle.Bottom;
            blazorWebView1.Location = new Point(0, 64);
            blazorWebView1.Name = "blazorWebView1";
            blazorWebView1.Size = new Size(685, 381);
            blazorWebView1.StartPath = "/";
            blazorWebView1.TabIndex = 0;
            blazorWebView1.Text = "blazorWebView1";
            // 
            // btnRetornar
            // 
            btnRetornar.BackColor = Color.Cyan;
            btnRetornar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetornar.Location = new Point(228, 12);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(214, 43);
            btnRetornar.TabIndex = 1;
            btnRetornar.Text = "Retornar";
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(685, 445);
            Controls.Add(btnRetornar);
            Controls.Add(blazorWebView1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcular Fatorial";
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebView1;
        private Button btnRetornar;
    }
}