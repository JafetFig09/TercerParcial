namespace PracticaUno
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
            textBox1 = new TextBox();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnEliminar = new Button();
            btnBuscar = new Button();
            listBox1 = new ListBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 27);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(277, 226);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 40);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(383, 18);
            label1.Name = "label1";
            label1.Size = new Size(432, 41);
            label1.TabIndex = 3;
            label1.Text = "Adnistrador de Libros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 181);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 4;
            label2.Text = "Agregar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 315);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 5;
            label3.Text = "Eliminar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 403);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 6;
            label4.Text = "Buscar:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 317);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 402);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 27);
            textBox3.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(277, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(269, 395);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 40);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(451, 118);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(760, 544);
            listBox1.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(107, 27);
            textBox4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 210);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 13;
            label5.Text = "ISBN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 210);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 14;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 291);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 15;
            label7.Text = "ISBN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(146, 379);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 16;
            label8.Text = "ISBN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1374, 718);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(listBox1);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnEliminar;
        private Button btnBuscar;
        private ListBox listBox1;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}