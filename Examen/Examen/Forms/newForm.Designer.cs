namespace Examen.Forms
{
    partial class newForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombEstud = new System.Windows.Forms.TextBox();
            this.IdAsig = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IdEstudi = new System.Windows.Forms.NumericUpDown();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.Departamentos = new System.Windows.Forms.TextBox();
            this.Municipio = new System.Windows.Forms.TextBox();
            this.Carnet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NomAsig = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Creditos = new System.Windows.Forms.NumericUpDown();
            this.Sistem = new System.Windows.Forms.NumericUpDown();
            this.SegParcial = new System.Windows.Forms.NumericUpDown();
            this.PrimParcial = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.newEstudiante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdEstudi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Creditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sistem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimParcial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // NombEstud
            // 
            this.NombEstud.Location = new System.Drawing.Point(75, 104);
            this.NombEstud.Name = "NombEstud";
            this.NombEstud.Size = new System.Drawing.Size(100, 20);
            this.NombEstud.TabIndex = 1;
            // 
            // IdAsig
            // 
            this.IdAsig.Location = new System.Drawing.Point(466, 79);
            this.IdAsig.Name = "IdAsig";
            this.IdAsig.Size = new System.Drawing.Size(120, 20);
            this.IdAsig.TabIndex = 2;
            this.IdAsig.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Municipio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carnet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Departamentos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Registrar Estudiante";
            // 
            // IdEstudi
            // 
            this.IdEstudi.Location = new System.Drawing.Point(75, 58);
            this.IdEstudi.Name = "IdEstudi";
            this.IdEstudi.Size = new System.Drawing.Size(120, 20);
            this.IdEstudi.TabIndex = 12;
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(75, 155);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(100, 20);
            this.apellidos.TabIndex = 13;
            // 
            // Departamentos
            // 
            this.Departamentos.Location = new System.Drawing.Point(105, 301);
            this.Departamentos.Name = "Departamentos";
            this.Departamentos.Size = new System.Drawing.Size(100, 20);
            this.Departamentos.TabIndex = 14;
            // 
            // Municipio
            // 
            this.Municipio.Location = new System.Drawing.Point(75, 260);
            this.Municipio.Name = "Municipio";
            this.Municipio.Size = new System.Drawing.Size(100, 20);
            this.Municipio.TabIndex = 15;
            // 
            // Carnet
            // 
            this.Carnet.Location = new System.Drawing.Point(75, 204);
            this.Carnet.Name = "Carnet";
            this.Carnet.Size = new System.Drawing.Size(100, 20);
            this.Carnet.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(422, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Registrar Notas Del Estudiante";
            // 
            // NomAsig
            // 
            this.NomAsig.Location = new System.Drawing.Point(466, 125);
            this.NomAsig.Name = "NomAsig";
            this.NomAsig.Size = new System.Drawing.Size(100, 20);
            this.NomAsig.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Segundo Parcial";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(392, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Sistematicos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(392, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Creditos";
            // 
            // Creditos
            // 
            this.Creditos.Location = new System.Drawing.Point(466, 175);
            this.Creditos.Name = "Creditos";
            this.Creditos.Size = new System.Drawing.Size(120, 20);
            this.Creditos.TabIndex = 22;
            // 
            // Sistem
            // 
            this.Sistem.Location = new System.Drawing.Point(466, 225);
            this.Sistem.Name = "Sistem";
            this.Sistem.Size = new System.Drawing.Size(120, 20);
            this.Sistem.TabIndex = 23;
            // 
            // SegParcial
            // 
            this.SegParcial.Location = new System.Drawing.Point(466, 331);
            this.SegParcial.Name = "SegParcial";
            this.SegParcial.Size = new System.Drawing.Size(120, 20);
            this.SegParcial.TabIndex = 24;
            // 
            // PrimParcial
            // 
            this.PrimParcial.Location = new System.Drawing.Point(466, 277);
            this.PrimParcial.Name = "PrimParcial";
            this.PrimParcial.Size = new System.Drawing.Size(120, 20);
            this.PrimParcial.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(387, 279);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Primer Parcial";
            // 
            // newEstudiante
            // 
            this.newEstudiante.Location = new System.Drawing.Point(42, 372);
            this.newEstudiante.Name = "newEstudiante";
            this.newEstudiante.Size = new System.Drawing.Size(153, 39);
            this.newEstudiante.TabIndex = 28;
            this.newEstudiante.Text = "Registrar Estudiante";
            this.newEstudiante.UseVisualStyleBackColor = true;
            this.newEstudiante.Click += new System.EventHandler(this.NewEstudiante_Click);
            // 
            // newForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newEstudiante);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PrimParcial);
            this.Controls.Add(this.SegParcial);
            this.Controls.Add(this.Sistem);
            this.Controls.Add(this.Creditos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NomAsig);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Carnet);
            this.Controls.Add(this.Municipio);
            this.Controls.Add(this.Departamentos);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.IdEstudi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdAsig);
            this.Controls.Add(this.NombEstud);
            this.Controls.Add(this.label1);
            this.Name = "newForm";
            this.Text = "newForm";
            this.Load += new System.EventHandler(this.NewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdEstudi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Creditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sistem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimParcial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombEstud;
        private System.Windows.Forms.NumericUpDown IdAsig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown IdEstudi;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.TextBox Departamentos;
        private System.Windows.Forms.TextBox Municipio;
        private System.Windows.Forms.TextBox Carnet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NomAsig;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown Creditos;
        private System.Windows.Forms.NumericUpDown Sistem;
        private System.Windows.Forms.NumericUpDown SegParcial;
        private System.Windows.Forms.NumericUpDown PrimParcial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button newEstudiante;
    }
}