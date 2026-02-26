using System.Windows.Forms;

namespace JoseEspinoza_Proyecto_Cadenas
{
    partial class VentanaPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.botonOpcionesTop = new System.Windows.Forms.Button();
            this.campoPalabra = new System.Windows.Forms.TextBox();
            this.grupoResultados = new System.Windows.Forms.GroupBox();
            this.campoResultados = new System.Windows.Forms.TextBox();
            this.grupoOperaciones = new System.Windows.Forms.GroupBox();
            this.botonPosicion = new System.Windows.Forms.Button();
            this.botonReves = new System.Windows.Forms.Button();
            this.boton1Letra = new System.Windows.Forms.Button();
            this.botonInverso = new System.Windows.Forms.Button();
            this.botonLetraxLetra = new System.Windows.Forms.Button();
            this.botonComparar = new System.Windows.Forms.Button();
            this.botonResetTop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grupoTexto = new System.Windows.Forms.GroupBox();
            this.campoTexto = new System.Windows.Forms.TextBox();
            this.campoResultados2 = new System.Windows.Forms.TextBox();
            this.grupoResultadosTexto = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPalabras = new System.Windows.Forms.Label();
            this.labelVocales = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelConsonantes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.botonResetBot = new System.Windows.Forms.Button();
            this.botonPalabraxPalabra = new System.Windows.Forms.Button();
            this.botonMapVocales = new System.Windows.Forms.Button();
            this.botonMapConsonantes = new System.Windows.Forms.Button();
            this.botonPalabraInversa = new System.Windows.Forms.Button();
            this.botonOpcionesBot = new System.Windows.Forms.Button();
            this.botonContar = new System.Windows.Forms.Button();
            this.grupoResultados.SuspendLayout();
            this.grupoOperaciones.SuspendLayout();
            this.grupoTexto.SuspendLayout();
            this.grupoResultadosTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabra";
            // 
            // botonOpcionesTop
            // 
            this.botonOpcionesTop.Location = new System.Drawing.Point(303, 6);
            this.botonOpcionesTop.Name = "botonOpcionesTop";
            this.botonOpcionesTop.Size = new System.Drawing.Size(140, 28);
            this.botonOpcionesTop.TabIndex = 1;
            this.botonOpcionesTop.Text = "Activar opciones";
            this.botonOpcionesTop.UseVisualStyleBackColor = true;
            this.botonOpcionesTop.Click += new System.EventHandler(this.botonOpcionesTop_Click);
            // 
            // campoPalabra
            // 
            this.campoPalabra.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPalabra.Location = new System.Drawing.Point(107, 11);
            this.campoPalabra.Multiline = true;
            this.campoPalabra.Name = "campoPalabra";
            this.campoPalabra.Size = new System.Drawing.Size(156, 25);
            this.campoPalabra.TabIndex = 2;
            // 
            // grupoResultados
            // 
            this.grupoResultados.BackColor = System.Drawing.Color.SteelBlue;
            this.grupoResultados.Controls.Add(this.campoResultados);
            this.grupoResultados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupoResultados.Location = new System.Drawing.Point(523, 29);
            this.grupoResultados.Name = "grupoResultados";
            this.grupoResultados.Size = new System.Drawing.Size(460, 123);
            this.grupoResultados.TabIndex = 3;
            this.grupoResultados.TabStop = false;
            this.grupoResultados.Text = "Resultados";
            // 
            // campoResultados
            // 
            this.campoResultados.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoResultados.Location = new System.Drawing.Point(28, 21);
            this.campoResultados.Multiline = true;
            this.campoResultados.Name = "campoResultados";
            this.campoResultados.ReadOnly = true;
            this.campoResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.campoResultados.Size = new System.Drawing.Size(401, 87);
            this.campoResultados.TabIndex = 0;
            // 
            // grupoOperaciones
            // 
            this.grupoOperaciones.Controls.Add(this.botonPosicion);
            this.grupoOperaciones.Controls.Add(this.botonReves);
            this.grupoOperaciones.Controls.Add(this.boton1Letra);
            this.grupoOperaciones.Controls.Add(this.botonInverso);
            this.grupoOperaciones.Controls.Add(this.botonLetraxLetra);
            this.grupoOperaciones.Controls.Add(this.botonComparar);
            this.grupoOperaciones.Enabled = false;
            this.grupoOperaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupoOperaciones.Location = new System.Drawing.Point(29, 50);
            this.grupoOperaciones.Name = "grupoOperaciones";
            this.grupoOperaciones.Size = new System.Drawing.Size(460, 102);
            this.grupoOperaciones.TabIndex = 4;
            this.grupoOperaciones.TabStop = false;
            this.grupoOperaciones.Text = "Operaciones";
            // 
            // botonPosicion
            // 
            this.botonPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPosicion.ForeColor = System.Drawing.Color.Blue;
            this.botonPosicion.Location = new System.Drawing.Point(291, 21);
            this.botonPosicion.Name = "botonPosicion";
            this.botonPosicion.Size = new System.Drawing.Size(161, 25);
            this.botonPosicion.TabIndex = 8;
            this.botonPosicion.Text = "Posición letra";
            this.botonPosicion.UseVisualStyleBackColor = true;
            this.botonPosicion.Click += new System.EventHandler(this.botonPosicion_Click);
            // 
            // botonReves
            // 
            this.botonReves.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReves.ForeColor = System.Drawing.Color.Blue;
            this.botonReves.Location = new System.Drawing.Point(156, 21);
            this.botonReves.Name = "botonReves";
            this.botonReves.Size = new System.Drawing.Size(129, 25);
            this.botonReves.TabIndex = 7;
            this.botonReves.Text = "Imprimir al revés";
            this.botonReves.UseVisualStyleBackColor = true;
            this.botonReves.Click += new System.EventHandler(this.botonReves_Click);
            // 
            // boton1Letra
            // 
            this.boton1Letra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1Letra.ForeColor = System.Drawing.Color.Blue;
            this.boton1Letra.Location = new System.Drawing.Point(13, 21);
            this.boton1Letra.Name = "boton1Letra";
            this.boton1Letra.Size = new System.Drawing.Size(135, 25);
            this.boton1Letra.TabIndex = 6;
            this.boton1Letra.Text = "Letra 1 y final";
            this.boton1Letra.UseVisualStyleBackColor = true;
            this.boton1Letra.Click += new System.EventHandler(this.boton1Letra_Click);
            // 
            // botonInverso
            // 
            this.botonInverso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInverso.ForeColor = System.Drawing.Color.Blue;
            this.botonInverso.Location = new System.Drawing.Point(291, 62);
            this.botonInverso.Name = "botonInverso";
            this.botonInverso.Size = new System.Drawing.Size(161, 25);
            this.botonInverso.TabIndex = 5;
            this.botonInverso.Text = "Letra por letra inverso";
            this.botonInverso.UseVisualStyleBackColor = true;
            this.botonInverso.Click += new System.EventHandler(this.botonInverso_Click);
            // 
            // botonLetraxLetra
            // 
            this.botonLetraxLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLetraxLetra.ForeColor = System.Drawing.Color.Blue;
            this.botonLetraxLetra.Location = new System.Drawing.Point(156, 62);
            this.botonLetraxLetra.Name = "botonLetraxLetra";
            this.botonLetraxLetra.Size = new System.Drawing.Size(129, 25);
            this.botonLetraxLetra.TabIndex = 4;
            this.botonLetraxLetra.Text = "Letra por letra";
            this.botonLetraxLetra.UseVisualStyleBackColor = true;
            this.botonLetraxLetra.Click += new System.EventHandler(this.botonLetraxLetra_Click);
            // 
            // botonComparar
            // 
            this.botonComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonComparar.ForeColor = System.Drawing.Color.Blue;
            this.botonComparar.Location = new System.Drawing.Point(13, 62);
            this.botonComparar.Name = "botonComparar";
            this.botonComparar.Size = new System.Drawing.Size(135, 25);
            this.botonComparar.TabIndex = 3;
            this.botonComparar.Text = "Comparar palabra";
            this.botonComparar.UseVisualStyleBackColor = true;
            this.botonComparar.Click += new System.EventHandler(this.botonComparar_Click);
            // 
            // botonResetTop
            // 
            this.botonResetTop.Enabled = false;
            this.botonResetTop.ForeColor = System.Drawing.Color.Blue;
            this.botonResetTop.Location = new System.Drawing.Point(454, 173);
            this.botonResetTop.Name = "botonResetTop";
            this.botonResetTop.Size = new System.Drawing.Size(99, 25);
            this.botonResetTop.TabIndex = 5;
            this.botonResetTop.Text = "Resetear";
            this.botonResetTop.UseVisualStyleBackColor = true;
            this.botonResetTop.Click += new System.EventHandler(this.botonResetTop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(29, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 1);
            this.panel1.TabIndex = 6;
            // 
            // grupoTexto
            // 
            this.grupoTexto.BackColor = System.Drawing.Color.SteelBlue;
            this.grupoTexto.Controls.Add(this.campoTexto);
            this.grupoTexto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupoTexto.Location = new System.Drawing.Point(29, 222);
            this.grupoTexto.Name = "grupoTexto";
            this.grupoTexto.Size = new System.Drawing.Size(460, 218);
            this.grupoTexto.TabIndex = 7;
            this.grupoTexto.TabStop = false;
            this.grupoTexto.Text = "Texto";
            // 
            // campoTexto
            // 
            this.campoTexto.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTexto.Location = new System.Drawing.Point(25, 21);
            this.campoTexto.Multiline = true;
            this.campoTexto.Name = "campoTexto";
            this.campoTexto.Size = new System.Drawing.Size(389, 176);
            this.campoTexto.TabIndex = 0;
            // 
            // campoResultados2
            // 
            this.campoResultados2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoResultados2.Location = new System.Drawing.Point(25, 21);
            this.campoResultados2.Multiline = true;
            this.campoResultados2.Name = "campoResultados2";
            this.campoResultados2.ReadOnly = true;
            this.campoResultados2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.campoResultados2.Size = new System.Drawing.Size(404, 176);
            this.campoResultados2.TabIndex = 0;
            // 
            // grupoResultadosTexto
            // 
            this.grupoResultadosTexto.BackColor = System.Drawing.Color.SteelBlue;
            this.grupoResultadosTexto.Controls.Add(this.campoResultados2);
            this.grupoResultadosTexto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupoResultadosTexto.Location = new System.Drawing.Point(523, 222);
            this.grupoResultadosTexto.Name = "grupoResultadosTexto";
            this.grupoResultadosTexto.Size = new System.Drawing.Size(460, 218);
            this.grupoResultadosTexto.TabIndex = 8;
            this.grupoResultadosTexto.TabStop = false;
            this.grupoResultadosTexto.Text = "Resultados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(35, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Palabras";
            // 
            // labelPalabras
            // 
            this.labelPalabras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPalabras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalabras.Location = new System.Drawing.Point(116, 528);
            this.labelPalabras.Name = "labelPalabras";
            this.labelPalabras.Size = new System.Drawing.Size(34, 33);
            this.labelPalabras.TabIndex = 12;
            this.labelPalabras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVocales
            // 
            this.labelVocales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelVocales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVocales.Location = new System.Drawing.Point(252, 528);
            this.labelVocales.Name = "labelVocales";
            this.labelVocales.Size = new System.Drawing.Size(34, 33);
            this.labelVocales.TabIndex = 14;
            this.labelVocales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(171, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vocales";
            // 
            // labelConsonantes
            // 
            this.labelConsonantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelConsonantes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsonantes.Location = new System.Drawing.Point(418, 528);
            this.labelConsonantes.Name = "labelConsonantes";
            this.labelConsonantes.Size = new System.Drawing.Size(34, 33);
            this.labelConsonantes.TabIndex = 16;
            this.labelConsonantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(309, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Consonantes";
            // 
            // botonResetBot
            // 
            this.botonResetBot.Enabled = false;
            this.botonResetBot.Location = new System.Drawing.Point(454, 591);
            this.botonResetBot.Name = "botonResetBot";
            this.botonResetBot.Size = new System.Drawing.Size(99, 25);
            this.botonResetBot.TabIndex = 17;
            this.botonResetBot.Text = "Resetear";
            this.botonResetBot.UseVisualStyleBackColor = true;
            this.botonResetBot.Click += new System.EventHandler(this.botonResetBot_Click);
            // 
            // botonPalabraxPalabra
            // 
            this.botonPalabraxPalabra.Enabled = false;
            this.botonPalabraxPalabra.ForeColor = System.Drawing.Color.Blue;
            this.botonPalabraxPalabra.Location = new System.Drawing.Point(503, 486);
            this.botonPalabraxPalabra.Name = "botonPalabraxPalabra";
            this.botonPalabraxPalabra.Size = new System.Drawing.Size(248, 25);
            this.botonPalabraxPalabra.TabIndex = 18;
            this.botonPalabraxPalabra.Text = "Imprimir palabra por palabra";
            this.botonPalabraxPalabra.UseVisualStyleBackColor = true;
            // 
            // botonMapVocales
            // 
            this.botonMapVocales.Enabled = false;
            this.botonMapVocales.ForeColor = System.Drawing.Color.Blue;
            this.botonMapVocales.Location = new System.Drawing.Point(757, 486);
            this.botonMapVocales.Name = "botonMapVocales";
            this.botonMapVocales.Size = new System.Drawing.Size(248, 25);
            this.botonMapVocales.TabIndex = 19;
            this.botonMapVocales.Text = "Mapa de vocales";
            this.botonMapVocales.UseVisualStyleBackColor = true;
            // 
            // botonMapConsonantes
            // 
            this.botonMapConsonantes.Enabled = false;
            this.botonMapConsonantes.ForeColor = System.Drawing.Color.Blue;
            this.botonMapConsonantes.Location = new System.Drawing.Point(757, 528);
            this.botonMapConsonantes.Name = "botonMapConsonantes";
            this.botonMapConsonantes.Size = new System.Drawing.Size(248, 25);
            this.botonMapConsonantes.TabIndex = 21;
            this.botonMapConsonantes.Text = "Mapa de consonantes";
            this.botonMapConsonantes.UseVisualStyleBackColor = true;
            // 
            // botonPalabraInversa
            // 
            this.botonPalabraInversa.Enabled = false;
            this.botonPalabraInversa.ForeColor = System.Drawing.Color.Blue;
            this.botonPalabraInversa.Location = new System.Drawing.Point(503, 528);
            this.botonPalabraInversa.Name = "botonPalabraInversa";
            this.botonPalabraInversa.Size = new System.Drawing.Size(248, 25);
            this.botonPalabraInversa.TabIndex = 20;
            this.botonPalabraInversa.Text = "Imprimir palabra por palabra la inversa";
            this.botonPalabraInversa.UseVisualStyleBackColor = true;
            // 
            // botonOpcionesBot
            // 
            this.botonOpcionesBot.Location = new System.Drawing.Point(38, 456);
            this.botonOpcionesBot.Name = "botonOpcionesBot";
            this.botonOpcionesBot.Size = new System.Drawing.Size(140, 24);
            this.botonOpcionesBot.TabIndex = 22;
            this.botonOpcionesBot.Text = "Activar opciones";
            this.botonOpcionesBot.UseVisualStyleBackColor = true;
            this.botonOpcionesBot.Click += new System.EventHandler(this.botonOpcionesBot_Click);
            // 
            // botonContar
            // 
            this.botonContar.Enabled = false;
            this.botonContar.ForeColor = System.Drawing.Color.Blue;
            this.botonContar.Location = new System.Drawing.Point(38, 487);
            this.botonContar.Name = "botonContar";
            this.botonContar.Size = new System.Drawing.Size(140, 24);
            this.botonContar.TabIndex = 23;
            this.botonContar.Text = "Acción contar";
            this.botonContar.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1017, 628);
            this.Controls.Add(this.botonContar);
            this.Controls.Add(this.botonOpcionesBot);
            this.Controls.Add(this.botonMapConsonantes);
            this.Controls.Add(this.botonPalabraInversa);
            this.Controls.Add(this.botonMapVocales);
            this.Controls.Add(this.botonPalabraxPalabra);
            this.Controls.Add(this.botonResetBot);
            this.Controls.Add(this.labelConsonantes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelVocales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPalabras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grupoResultadosTexto);
            this.Controls.Add(this.grupoTexto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botonResetTop);
            this.Controls.Add(this.grupoOperaciones);
            this.Controls.Add(this.grupoResultados);
            this.Controls.Add(this.campoPalabra);
            this.Controls.Add(this.botonOpcionesTop);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADENAS";
            this.grupoResultados.ResumeLayout(false);
            this.grupoResultados.PerformLayout();
            this.grupoOperaciones.ResumeLayout(false);
            this.grupoTexto.ResumeLayout(false);
            this.grupoTexto.PerformLayout();
            this.grupoResultadosTexto.ResumeLayout(false);
            this.grupoResultadosTexto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonOpcionesTop;
        private System.Windows.Forms.TextBox campoPalabra;
        private System.Windows.Forms.GroupBox grupoResultados;
        private System.Windows.Forms.TextBox campoResultados;
        private System.Windows.Forms.GroupBox grupoOperaciones;
        private System.Windows.Forms.Button botonResetTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grupoTexto;
        private System.Windows.Forms.TextBox campoTexto;
        private System.Windows.Forms.TextBox campoResultados2;
        private System.Windows.Forms.GroupBox grupoResultadosTexto;
        private System.Windows.Forms.Button botonComparar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPalabras;
        private System.Windows.Forms.Label labelVocales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelConsonantes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botonResetBot;
        private System.Windows.Forms.Button botonPalabraxPalabra;
        private System.Windows.Forms.Button botonMapVocales;
        private System.Windows.Forms.Button botonMapConsonantes;
        private System.Windows.Forms.Button botonPalabraInversa;
        private System.Windows.Forms.Button botonOpcionesBot;
        private System.Windows.Forms.Button botonContar;
        private System.Windows.Forms.Button botonPosicion;
        private System.Windows.Forms.Button botonReves;
        private System.Windows.Forms.Button boton1Letra;
        private System.Windows.Forms.Button botonInverso;
        private System.Windows.Forms.Button botonLetraxLetra;

        public void activaOpcionesTop()
        {

            if (string.IsNullOrWhiteSpace(campoPalabra.Text))
            {
                MessageBox.Show("Debe introducir una palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoPalabra.Focus();
            }
            else
            {
                grupoOperaciones.Enabled = true;
                botonResetTop.Enabled = true;
                campoPalabra.Enabled = false;
            }
        }
        public void activaOpcionesBot()
        {
            if (string.IsNullOrWhiteSpace(campoTexto.Text))
            {
                MessageBox.Show("Debe introducir un texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoTexto.Focus();
            }
            else
            {
                botonContar.Enabled = true;
                botonPalabraxPalabra.Enabled = true;
                botonPalabraInversa.Enabled = true;
                botonMapVocales.Enabled = true;
                botonMapConsonantes.Enabled = true;
                botonResetBot.Enabled = true;
                campoTexto.Enabled = false;
            }
        }
        public void resetearTop()
        {
            campoPalabra.Clear();
            campoPalabra.Enabled = true;
            campoResultados.Clear();
            botonResetTop.Enabled = false;
            grupoOperaciones.Enabled = false;
            campoPalabra.Focus();
        }
        public void resetearBot()
        {
            campoTexto.Clear();
            campoTexto.Enabled = true;
            campoResultados2.Clear();
            labelPalabras.Text = "";
            labelVocales.Text = "";
            labelConsonantes.Text = "";
            botonContar.Enabled = false;
            botonPalabraxPalabra.Enabled = false;
            botonPalabraInversa.Enabled = false;
            botonMapVocales.Enabled = false;
            botonMapConsonantes.Enabled = false;
            botonResetBot.Enabled = false;
            campoTexto.Focus();
        }
    }
}

