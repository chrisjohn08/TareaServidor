namespace AppServidor
{
    partial class ServidorForm
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
            label1 = new Label();
            btnAgregarServidor = new Button();
            btnEliminarServidor = new Button();
            btnModicarServidor = new Button();
            label3 = new Label();
            pnResultado = new Panel();
            label2 = new Label();
            label4 = new Label();
            btnAgregarComando = new Button();
            btnElimnarComando = new Button();
            btnEjecutarComando = new Button();
            btnModicarComando = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 182);
            label1.TabIndex = 0;
            label1.Text = "Servicios Disponibles";
            // 
            // btnAgregarServidor
            // 
            btnAgregarServidor.Image = Properties.Resources.boton_mas;
            btnAgregarServidor.Location = new Point(135, 102);
            btnAgregarServidor.Name = "btnAgregarServidor";
            btnAgregarServidor.Size = new Size(66, 73);
            btnAgregarServidor.TabIndex = 3;
            btnAgregarServidor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarServidor
            // 
            btnEliminarServidor.Image = Properties.Resources.basura;
            btnEliminarServidor.Location = new Point(207, 102);
            btnEliminarServidor.Name = "btnEliminarServidor";
            btnEliminarServidor.Size = new Size(65, 73);
            btnEliminarServidor.TabIndex = 4;
            btnEliminarServidor.UseVisualStyleBackColor = true;
            // 
            // btnModicarServidor
            // 
            btnModicarServidor.Image = Properties.Resources.escribir;
            btnModicarServidor.Location = new Point(278, 102);
            btnModicarServidor.Name = "btnModicarServidor";
            btnModicarServidor.Size = new Size(71, 73);
            btnModicarServidor.TabIndex = 5;
            btnModicarServidor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.servidor;
            label3.Location = new Point(11, 29);
            label3.Name = "label3";
            label3.Size = new Size(118, 146);
            label3.TabIndex = 7;
            // 
            // pnResultado
            // 
            pnResultado.BackColor = SystemColors.ActiveCaptionText;
            pnResultado.Location = new Point(1, 301);
            pnResultado.Name = "pnResultado";
            pnResultado.Size = new Size(802, 155);
            pnResultado.TabIndex = 9;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Location = new Point(365, 9);
            label2.Name = "label2";
            label2.Size = new Size(438, 180);
            label2.TabIndex = 10;
            label2.Text = "Comandos del Servidor";
            // 
            // label4
            // 
            label4.Image = Properties.Resources.formulario__1_;
            label4.Location = new Point(374, 29);
            label4.Name = "label4";
            label4.Size = new Size(118, 146);
            label4.TabIndex = 11;
            // 
            // btnAgregarComando
            // 
            btnAgregarComando.Image = Properties.Resources.boton_agregar;
            btnAgregarComando.Location = new Point(498, 102);
            btnAgregarComando.Name = "btnAgregarComando";
            btnAgregarComando.Size = new Size(66, 73);
            btnAgregarComando.TabIndex = 12;
            btnAgregarComando.UseVisualStyleBackColor = true;
            // 
            // btnElimnarComando
            // 
            btnElimnarComando.Image = Properties.Resources.cerrar;
            btnElimnarComando.Location = new Point(570, 102);
            btnElimnarComando.Name = "btnElimnarComando";
            btnElimnarComando.Size = new Size(70, 73);
            btnElimnarComando.TabIndex = 13;
            btnElimnarComando.UseVisualStyleBackColor = true;
            // 
            // btnEjecutarComando
            // 
            btnEjecutarComando.Image = Properties.Resources.youtube;
            btnEjecutarComando.Location = new Point(727, 102);
            btnEjecutarComando.Name = "btnEjecutarComando";
            btnEjecutarComando.Size = new Size(66, 73);
            btnEjecutarComando.TabIndex = 14;
            btnEjecutarComando.UseVisualStyleBackColor = true;
            // 
            // btnModicarComando
            // 
            btnModicarComando.BackColor = SystemColors.ButtonHighlight;
            btnModicarComando.FlatStyle = FlatStyle.Popup;
            btnModicarComando.Image = Properties.Resources.edit_modify_icon_196940;
            btnModicarComando.Location = new Point(646, 102);
            btnModicarComando.Name = "btnModicarComando";
            btnModicarComando.Size = new Size(75, 73);
            btnModicarComando.TabIndex = 15;
            btnModicarComando.UseVisualStyleBackColor = false;
            // 
            // ServidorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModicarComando);
            Controls.Add(btnEjecutarComando);
            Controls.Add(btnElimnarComando);
            Controls.Add(btnAgregarComando);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pnResultado);
            Controls.Add(label3);
            Controls.Add(btnModicarServidor);
            Controls.Add(btnEliminarServidor);
            Controls.Add(btnAgregarServidor);
            Controls.Add(label1);
            Name = "ServidorForm";
            Text = "ServidorForm";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAgregarServidor;
        private Button btnEliminarServidor;
        private Button btnModicarServidor;
        private Label label3;
        private Panel pnResultado;
        private Label label2;
        private Label label4;
        private Button btnAgregarComando;
        private Button btnElimnarComando;
        private Button btnEjecutarComando;
        private Button btnModicarComando;
    }
}