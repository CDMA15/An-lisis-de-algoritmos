namespace ProyectoArbol
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
            textBoxNumero = new TextBox();
            buttonAgregar = new Button();
            listBoxArbol = new ListBox();
            buttonMostrarPreOrden = new Button();
            label2 = new Label();
            label3 = new Label();
            buttonMostrarNodos = new Button();
            buttonMostrarHojas = new Button();
            listBoxNodo = new ListBox();
            listBoxHoja = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 29);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Proyecto Arboles";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(212, 76);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(202, 27);
            textBoxNumero.TabIndex = 1;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(441, 74);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(162, 29);
            buttonAgregar.TabIndex = 2;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // listBoxArbol
            // 
            listBoxArbol.FormattingEnabled = true;
            listBoxArbol.ItemHeight = 20;
            listBoxArbol.Location = new Point(212, 118);
            listBoxArbol.Name = "listBoxArbol";
            listBoxArbol.Size = new Size(202, 284);
            listBoxArbol.TabIndex = 3;
            // 
            // buttonMostrarPreOrden
            // 
            buttonMostrarPreOrden.Location = new Point(441, 118);
            buttonMostrarPreOrden.Name = "buttonMostrarPreOrden";
            buttonMostrarPreOrden.Size = new Size(162, 29);
            buttonMostrarPreOrden.TabIndex = 4;
            buttonMostrarPreOrden.Text = "Mostrar pre-orden";
            buttonMostrarPreOrden.UseVisualStyleBackColor = true;
            buttonMostrarPreOrden.Click += buttonMostrarPreOrden_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 460);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 5;
            label2.Text = "Numero de nodos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 506);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 6;
            label3.Text = "Numero de hojas";
            // 
            // buttonMostrarNodos
            // 
            buttonMostrarNodos.Location = new Point(253, 456);
            buttonMostrarNodos.Name = "buttonMostrarNodos";
            buttonMostrarNodos.Size = new Size(106, 29);
            buttonMostrarNodos.TabIndex = 9;
            buttonMostrarNodos.Text = "mostrar";
            buttonMostrarNodos.UseVisualStyleBackColor = true;
            buttonMostrarNodos.Click += buttonMostrarNodos_Click;
            // 
            // buttonMostrarHojas
            // 
            buttonMostrarHojas.Location = new Point(253, 506);
            buttonMostrarHojas.Name = "buttonMostrarHojas";
            buttonMostrarHojas.Size = new Size(106, 29);
            buttonMostrarHojas.TabIndex = 10;
            buttonMostrarHojas.Text = "mostrar";
            buttonMostrarHojas.UseVisualStyleBackColor = true;
            buttonMostrarHojas.Click += buttonMostrarHojas_Click;
            // 
            // listBoxNodo
            // 
            listBoxNodo.FormattingEnabled = true;
            listBoxNodo.ItemHeight = 20;
            listBoxNodo.Location = new Point(388, 456);
            listBoxNodo.Name = "listBoxNodo";
            listBoxNodo.Size = new Size(202, 24);
            listBoxNodo.TabIndex = 12;
            // 
            // listBoxHoja
            // 
            listBoxHoja.FormattingEnabled = true;
            listBoxHoja.ItemHeight = 20;
            listBoxHoja.Location = new Point(388, 505);
            listBoxHoja.Name = "listBoxHoja";
            listBoxHoja.Size = new Size(202, 144);
            listBoxHoja.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 656);
            Controls.Add(listBoxHoja);
            Controls.Add(listBoxNodo);
            Controls.Add(buttonMostrarHojas);
            Controls.Add(buttonMostrarNodos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonMostrarPreOrden);
            Controls.Add(listBoxArbol);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumero;
        private Button buttonAgregar;
        private ListBox listBoxArbol;
        private Button buttonMostrarPreOrden;
        private Label label2;
        private Label label3;
        private Button buttonMostrarNodos;
        private Button buttonMostrarHojas;
        private ListBox listBoxNodo;
        private ListBox listBoxHoja;
    }
}