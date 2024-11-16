
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbDisplay = new System.Windows.Forms.TextBox();
            this.BtnSiete = new System.Windows.Forms.Button();
            this.BtnCuatro = new System.Windows.Forms.Button();
            this.BtnUno = new System.Windows.Forms.Button();
            this.BtnCero = new System.Windows.Forms.Button();
            this.BtnOcho = new System.Windows.Forms.Button();
            this.BtnCinco = new System.Windows.Forms.Button();
            this.BtnDos = new System.Windows.Forms.Button();
            this.BtnPunto = new System.Windows.Forms.Button();
            this.BtnNueve = new System.Windows.Forms.Button();
            this.BtnSeis = new System.Windows.Forms.Button();
            this.BtnTres = new System.Windows.Forms.Button();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.BtnSumar = new System.Windows.Forms.Button();
            this.BtnRestar = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnPosandNeg = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TbDisplayMini = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbDisplay
            // 
            this.TbDisplay.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.TbDisplay.Location = new System.Drawing.Point(18, 45);
            this.TbDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbDisplay.Multiline = true;
            this.TbDisplay.Name = "TbDisplay";
            this.TbDisplay.Size = new System.Drawing.Size(316, 51);
            this.TbDisplay.TabIndex = 0;
            this.TbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbDisplay.TextChanged += new System.EventHandler(this.TbDisplay_TextChanged);
            // 
            // BtnSiete
            // 
            this.BtnSiete.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnSiete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiete.Location = new System.Drawing.Point(18, 162);
            this.BtnSiete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSiete.Name = "BtnSiete";
            this.BtnSiete.Size = new System.Drawing.Size(72, 71);
            this.BtnSiete.TabIndex = 4;
            this.BtnSiete.Text = "7";
            this.BtnSiete.UseVisualStyleBackColor = false;
            this.BtnSiete.Click += new System.EventHandler(this.BtnSiete_Click);
            // 
            // BtnCuatro
            // 
            this.BtnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuatro.Location = new System.Drawing.Point(20, 252);
            this.BtnCuatro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCuatro.Name = "BtnCuatro";
            this.BtnCuatro.Size = new System.Drawing.Size(72, 71);
            this.BtnCuatro.TabIndex = 5;
            this.BtnCuatro.Text = "4";
            this.BtnCuatro.UseVisualStyleBackColor = true;
            this.BtnCuatro.Click += new System.EventHandler(this.BtnCuatro_Click);
            // 
            // BtnUno
            // 
            this.BtnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUno.Location = new System.Drawing.Point(18, 345);
            this.BtnUno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUno.Name = "BtnUno";
            this.BtnUno.Size = new System.Drawing.Size(72, 71);
            this.BtnUno.TabIndex = 6;
            this.BtnUno.Text = "1";
            this.BtnUno.UseVisualStyleBackColor = true;
            this.BtnUno.Click += new System.EventHandler(this.BtnUno_Click);
            // 
            // BtnCero
            // 
            this.BtnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCero.Location = new System.Drawing.Point(20, 437);
            this.BtnCero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCero.Name = "BtnCero";
            this.BtnCero.Size = new System.Drawing.Size(72, 71);
            this.BtnCero.TabIndex = 7;
            this.BtnCero.Text = "0";
            this.BtnCero.UseVisualStyleBackColor = true;
            this.BtnCero.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // BtnOcho
            // 
            this.BtnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOcho.Location = new System.Drawing.Point(99, 162);
            this.BtnOcho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOcho.Name = "BtnOcho";
            this.BtnOcho.Size = new System.Drawing.Size(72, 71);
            this.BtnOcho.TabIndex = 8;
            this.BtnOcho.Text = "8";
            this.BtnOcho.UseVisualStyleBackColor = true;
            this.BtnOcho.Click += new System.EventHandler(this.BtnOcho_Click);
            // 
            // BtnCinco
            // 
            this.BtnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCinco.Location = new System.Drawing.Point(100, 252);
            this.BtnCinco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCinco.Name = "BtnCinco";
            this.BtnCinco.Size = new System.Drawing.Size(72, 71);
            this.BtnCinco.TabIndex = 9;
            this.BtnCinco.Text = "5";
            this.BtnCinco.UseVisualStyleBackColor = true;
            this.BtnCinco.Click += new System.EventHandler(this.BtnCinco_Click);
            // 
            // BtnDos
            // 
            this.BtnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDos.Location = new System.Drawing.Point(100, 345);
            this.BtnDos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDos.Name = "BtnDos";
            this.BtnDos.Size = new System.Drawing.Size(72, 71);
            this.BtnDos.TabIndex = 10;
            this.BtnDos.Text = "2";
            this.BtnDos.UseVisualStyleBackColor = true;
            this.BtnDos.Click += new System.EventHandler(this.BtnDos_Click);
            // 
            // BtnPunto
            // 
            this.BtnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPunto.Location = new System.Drawing.Point(100, 437);
            this.BtnPunto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPunto.Name = "BtnPunto";
            this.BtnPunto.Size = new System.Drawing.Size(72, 71);
            this.BtnPunto.TabIndex = 11;
            this.BtnPunto.Text = ".";
            this.BtnPunto.UseVisualStyleBackColor = true;
            this.BtnPunto.Click += new System.EventHandler(this.BtnPunto_Click);
            // 
            // BtnNueve
            // 
            this.BtnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNueve.Location = new System.Drawing.Point(180, 162);
            this.BtnNueve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNueve.Name = "BtnNueve";
            this.BtnNueve.Size = new System.Drawing.Size(72, 71);
            this.BtnNueve.TabIndex = 12;
            this.BtnNueve.Text = "9";
            this.BtnNueve.UseVisualStyleBackColor = true;
            this.BtnNueve.Click += new System.EventHandler(this.BtnNueve_Click);
            // 
            // BtnSeis
            // 
            this.BtnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeis.Location = new System.Drawing.Point(182, 252);
            this.BtnSeis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSeis.Name = "BtnSeis";
            this.BtnSeis.Size = new System.Drawing.Size(72, 71);
            this.BtnSeis.TabIndex = 13;
            this.BtnSeis.Text = "6";
            this.BtnSeis.UseVisualStyleBackColor = true;
            this.BtnSeis.Click += new System.EventHandler(this.BtnSeis_Click);
            // 
            // BtnTres
            // 
            this.BtnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTres.Location = new System.Drawing.Point(182, 345);
            this.BtnTres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTres.Name = "BtnTres";
            this.BtnTres.Size = new System.Drawing.Size(72, 71);
            this.BtnTres.TabIndex = 14;
            this.BtnTres.Text = "3";
            this.BtnTres.UseVisualStyleBackColor = true;
            this.BtnTres.Click += new System.EventHandler(this.BtnTres_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIgual.Location = new System.Drawing.Point(182, 437);
            this.BtnIgual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(72, 71);
            this.BtnIgual.TabIndex = 15;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            this.BtnIgual.MouseEnter += new System.EventHandler(this.BtnIgual_MouseEnter);
            this.BtnIgual.MouseLeave += new System.EventHandler(this.BtnIgual_MouseLeave);
            // 
            // BtnSumar
            // 
            this.BtnSumar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSumar.Location = new System.Drawing.Point(262, 437);
            this.BtnSumar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSumar.Name = "BtnSumar";
            this.BtnSumar.Size = new System.Drawing.Size(72, 71);
            this.BtnSumar.TabIndex = 16;
            this.BtnSumar.Text = "+";
            this.BtnSumar.UseVisualStyleBackColor = false;
            this.BtnSumar.Click += new System.EventHandler(this.BtnSumar_Click);
            // 
            // BtnRestar
            // 
            this.BtnRestar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestar.Location = new System.Drawing.Point(262, 345);
            this.BtnRestar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRestar.Name = "BtnRestar";
            this.BtnRestar.Size = new System.Drawing.Size(72, 71);
            this.BtnRestar.TabIndex = 17;
            this.BtnRestar.Text = "-";
            this.BtnRestar.UseVisualStyleBackColor = false;
            this.BtnRestar.Click += new System.EventHandler(this.BtnRestar_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMulti.Location = new System.Drawing.Point(262, 252);
            this.BtnMulti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(72, 71);
            this.BtnMulti.TabIndex = 18;
            this.BtnMulti.Text = "X";
            this.BtnMulti.UseVisualStyleBackColor = false;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.Location = new System.Drawing.Point(262, 162);
            this.BtnDiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(72, 71);
            this.BtnDiv.TabIndex = 19;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnPosandNeg
            // 
            this.BtnPosandNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPosandNeg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPosandNeg.Location = new System.Drawing.Point(20, 102);
            this.BtnPosandNeg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPosandNeg.Name = "BtnPosandNeg";
            this.BtnPosandNeg.Size = new System.Drawing.Size(100, 51);
            this.BtnPosandNeg.TabIndex = 20;
            this.BtnPosandNeg.Text = "+/-";
            this.BtnPosandNeg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPosandNeg.UseVisualStyleBackColor = true;
            this.BtnPosandNeg.Click += new System.EventHandler(this.BtnPosandNeg_Click);
            this.BtnPosandNeg.MouseEnter += new System.EventHandler(this.BtnPosandNeg_MouseEnter);
            this.BtnPosandNeg.MouseLeave += new System.EventHandler(this.BtnPosandNeg_MouseLeave);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(128, 102);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(99, 51);
            this.BtnLimpiar.TabIndex = 21;
            this.BtnLimpiar.Text = "C";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            this.BtnLimpiar.MouseEnter += new System.EventHandler(this.BtnLimpiar_MouseEnter);
            this.BtnLimpiar.MouseLeave += new System.EventHandler(this.BtnLimpiar_MouseLeave);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(236, 102);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(99, 51);
            this.BtnSalir.TabIndex = 22;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.BtnSalir.MouseEnter += new System.EventHandler(this.BtnSalir_MouseEnter);
            this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            // 
            // TbDisplayMini
            // 
            this.TbDisplayMini.BackColor = System.Drawing.SystemColors.MenuText;
            this.TbDisplayMini.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbDisplayMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDisplayMini.ForeColor = System.Drawing.SystemColors.Window;
            this.TbDisplayMini.Location = new System.Drawing.Point(18, 8);
            this.TbDisplayMini.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbDisplayMini.Multiline = true;
            this.TbDisplayMini.Name = "TbDisplayMini";
            this.TbDisplayMini.Size = new System.Drawing.Size(316, 28);
            this.TbDisplayMini.TabIndex = 23;
            this.TbDisplayMini.TextChanged += new System.EventHandler(this.TbDisplayMini_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(356, 526);
            this.Controls.Add(this.TbDisplayMini);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnPosandNeg);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.BtnRestar);
            this.Controls.Add(this.BtnSumar);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.BtnTres);
            this.Controls.Add(this.BtnSeis);
            this.Controls.Add(this.BtnNueve);
            this.Controls.Add(this.BtnPunto);
            this.Controls.Add(this.BtnDos);
            this.Controls.Add(this.BtnCinco);
            this.Controls.Add(this.BtnOcho);
            this.Controls.Add(this.BtnCero);
            this.Controls.Add(this.BtnUno);
            this.Controls.Add(this.BtnCuatro);
            this.Controls.Add(this.BtnSiete);
            this.Controls.Add(this.TbDisplay);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbDisplay;
        private System.Windows.Forms.Button BtnSiete;
        private System.Windows.Forms.Button BtnCuatro;
        private System.Windows.Forms.Button BtnUno;
        private System.Windows.Forms.Button BtnCero;
        private System.Windows.Forms.Button BtnOcho;
        private System.Windows.Forms.Button BtnCinco;
        private System.Windows.Forms.Button BtnDos;
        private System.Windows.Forms.Button BtnPunto;
        private System.Windows.Forms.Button BtnNueve;
        private System.Windows.Forms.Button BtnSeis;
        private System.Windows.Forms.Button BtnTres;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Button BtnSumar;
        private System.Windows.Forms.Button BtnRestar;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnPosandNeg;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TbDisplayMini;
    }
}

