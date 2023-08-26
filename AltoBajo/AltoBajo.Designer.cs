namespace AltoBajo
{
    partial class AltoBajo
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
            label2 = new Label();
            label3 = new Label();
            txtUnidades = new TextBox();
            txtCostosIngresados = new TextBox();
            btnAgregar = new Button();
            lvTabla = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnCalcular = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCostosTotales = new TextBox();
            txtCostosFijos = new TextBox();
            txtCostosVariables = new TextBox();
            btnBorrar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(226, 32);
            label1.Name = "label1";
            label1.Size = new Size(643, 45);
            label1.TabIndex = 0;
            label1.Text = "Metodo para calcular costos ALTOBAJO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 123);
            label2.Name = "label2";
            label2.Size = new Size(306, 32);
            label2.TabIndex = 1;
            label2.Text = "Horas/Unidades Producidas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(593, 112);
            label3.Name = "label3";
            label3.Size = new Size(85, 32);
            label3.TabIndex = 2;
            label3.Text = "Costos";
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(168, 167);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(200, 39);
            txtUnidades.TabIndex = 3;
            // 
            // txtCostosIngresados
            // 
            txtCostosIngresados.Location = new Point(536, 167);
            txtCostosIngresados.Name = "txtCostosIngresados";
            txtCostosIngresados.Size = new Size(200, 39);
            txtCostosIngresados.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(830, 141);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 46);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lvTabla
            // 
            lvTabla.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvTabla.Location = new Point(45, 277);
            lvTabla.Name = "lvTabla";
            lvTabla.Size = new Size(846, 347);
            lvTabla.TabIndex = 6;
            lvTabla.UseCompatibleStateImageBehavior = false;
            lvTabla.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Numero";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Horas/Unidades producidas";
            columnHeader2.Width = 360;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Costos totales";
            columnHeader3.Width = 360;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(480, 650);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 46);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 721);
            label4.Name = "label4";
            label4.Size = new Size(200, 32);
            label4.TabIndex = 8;
            label4.Text = "COSTOS TOTALES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 721);
            label5.Name = "label5";
            label5.Size = new Size(265, 32);
            label5.TabIndex = 9;
            label5.Text = "COSTOS FIJOS TOTALES";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(699, 721);
            label6.Name = "label6";
            label6.Size = new Size(321, 32);
            label6.TabIndex = 10;
            label6.Text = "COSTOS VARIABLES TOTALES";
            // 
            // txtCostosTotales
            // 
            txtCostosTotales.Location = new Point(116, 783);
            txtCostosTotales.Name = "txtCostosTotales";
            txtCostosTotales.Size = new Size(200, 39);
            txtCostosTotales.TabIndex = 11;
            // 
            // txtCostosFijos
            // 
            txtCostosFijos.Location = new Point(442, 783);
            txtCostosFijos.Name = "txtCostosFijos";
            txtCostosFijos.Size = new Size(200, 39);
            txtCostosFijos.TabIndex = 12;
            // 
            // txtCostosVariables
            // 
            txtCostosVariables.Location = new Point(753, 783);
            txtCostosVariables.Name = "txtCostosVariables";
            txtCostosVariables.Size = new Size(200, 39);
            txtCostosVariables.TabIndex = 13;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(902, 301);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(150, 46);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(902, 378);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 46);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // AltoBajo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 922);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBorrar);
            Controls.Add(txtCostosVariables);
            Controls.Add(txtCostosFijos);
            Controls.Add(txtCostosTotales);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(lvTabla);
            Controls.Add(btnAgregar);
            Controls.Add(txtCostosIngresados);
            Controls.Add(txtUnidades);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltoBajo";
            Text = "AltoBajo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUnidades;
        private TextBox txtCostosIngresados;
        private Button btnAgregar;
        private ListView lvTabla;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnCalcular;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCostosTotales;
        private TextBox txtCostosFijos;
        private TextBox txtCostosVariables;
        private Button btnBorrar;
        private Button btnLimpiar;
    }
}