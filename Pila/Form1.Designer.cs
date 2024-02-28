namespace Pila
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
            label1 = new Label();
            nombre = new TextBox();
            label2 = new Label();
            apilar = new Button();
            listBoxPila = new ListBox();
            mostrar = new Button();
            desapilar = new Button();
            label3 = new Label();
            año = new TextBox();
            label4 = new Label();
            autor = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Ejercicio PILA";
            // 
            // nombre
            // 
            nombre.Location = new Point(232, 48);
            nombre.Name = "nombre";
            nombre.Size = new Size(347, 27);
            nombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 51);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE DEL LIBRO";
            // 
            // apilar
            // 
            apilar.Location = new Point(614, 48);
            apilar.Name = "apilar";
            apilar.Size = new Size(150, 93);
            apilar.TabIndex = 3;
            apilar.Text = "AGREGAR A LA BIBLIOTECA";
            apilar.UseVisualStyleBackColor = true;
            apilar.Click += Bto_apilar_Click;
            // 
            // listBoxPila
            // 
            listBoxPila.FormattingEnabled = true;
            listBoxPila.ItemHeight = 20;
            listBoxPila.Location = new Point(232, 205);
            listBoxPila.Name = "listBoxPila";
            listBoxPila.Size = new Size(532, 224);
            listBoxPila.TabIndex = 4;
            listBoxPila.SelectedIndexChanged += listBoxPila_SelectedIndexChanged;
            // 
            // mostrar
            // 
            mostrar.Location = new Point(41, 205);
            mostrar.Name = "mostrar";
            mostrar.Size = new Size(138, 29);
            mostrar.TabIndex = 5;
            mostrar.Text = "Mostrar Libros";
            mostrar.UseVisualStyleBackColor = true;
            mostrar.Click += Mostrar_Pila_Click;
            // 
            // desapilar
            // 
            desapilar.Location = new Point(41, 400);
            desapilar.Name = "desapilar";
            desapilar.Size = new Size(150, 29);
            desapilar.TabIndex = 6;
            desapilar.Text = "Sacar libro";
            desapilar.UseVisualStyleBackColor = true;
            desapilar.Click += bto_desapilar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 84);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 8;
            label3.Text = "AÑO DE PUBLICACIÓN";
            // 
            // año
            // 
            año.Location = new Point(232, 81);
            año.Name = "año";
            año.Size = new Size(347, 27);
            año.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 117);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 10;
            label4.Text = "AUTOR";
            // 
            // autor
            // 
            autor.Location = new Point(232, 114);
            autor.Name = "autor";
            autor.Size = new Size(347, 27);
            autor.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(autor);
            Controls.Add(label3);
            Controls.Add(año);
            Controls.Add(desapilar);
            Controls.Add(mostrar);
            Controls.Add(listBoxPila);
            Controls.Add(apilar);
            Controls.Add(label2);
            Controls.Add(nombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nombre;
        private Label label2;
        private Button apilar;
        private ListBox listBoxPila;
        private Button mostrar;
        private Button desapilar;
        private Label label3;
        private TextBox año;
        private Label label4;
        private TextBox autor;
    }
}