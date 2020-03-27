namespace NeuronaHebianaLuis
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
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEntradas = new System.Windows.Forms.Panel();
            this.panelSalidas = new System.Windows.Forms.Panel();
            this.textBoxSalida = new System.Windows.Forms.TextBox();
            this.labelSalidas = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPesos = new System.Windows.Forms.Panel();
            this.panelBias = new System.Windows.Forms.Panel();
            this.dataGridViewDatosEntrenamiento = new System.Windows.Forms.DataGridView();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEvaluar = new System.Windows.Forms.Button();
            this.dataGridViewSalidasPrueba = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTipoNeurona = new System.Windows.Forms.Panel();
            this.radioButtonPerceptron = new System.Windows.Forms.RadioButton();
            this.radioButtonHebiana = new System.Windows.Forms.RadioButton();
            this.panelTheta = new System.Windows.Forms.Panel();
            this.textBoxTheta = new System.Windows.Forms.TextBox();
            this.labelTheta = new System.Windows.Forms.Label();
            this.panelIteraciones = new System.Windows.Forms.Panel();
            this.textBoxIteraciones = new System.Windows.Forms.TextBox();
            this.labelIteraciones = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.panelError = new System.Windows.Forms.Panel();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.labelFitness = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxExito = new System.Windows.Forms.MaskedTextBox();
            this.panelRango = new System.Windows.Forms.Panel();
            this.textBoxRangoMax = new System.Windows.Forms.TextBox();
            this.textBoxRangoMin = new System.Windows.Forms.TextBox();
            this.labelRango = new System.Windows.Forms.Label();
            this.numericUpDownNumeroSalidas = new System.Windows.Forms.NumericUpDown();
            this.labelNumeroSalidas = new System.Windows.Forms.Label();
            this.panelSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosEntrenamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalidasPrueba)).BeginInit();
            this.panelTipoNeurona.SuspendLayout();
            this.panelTheta.SuspendLayout();
            this.panelIteraciones.SuspendLayout();
            this.panelError.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRango.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(230, 111);
            this.buttonIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(56, 19);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "Entrenar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de entradas";
            // 
            // panelEntradas
            // 
            this.panelEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelEntradas.AutoScroll = true;
            this.panelEntradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEntradas.Location = new System.Drawing.Point(1, 130);
            this.panelEntradas.Margin = new System.Windows.Forms.Padding(2);
            this.panelEntradas.Name = "panelEntradas";
            this.panelEntradas.Size = new System.Drawing.Size(65, 292);
            this.panelEntradas.TabIndex = 7;
            // 
            // panelSalidas
            // 
            this.panelSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSalidas.AutoScroll = true;
            this.panelSalidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSalidas.Controls.Add(this.textBoxSalida);
            this.panelSalidas.Controls.Add(this.labelSalidas);
            this.panelSalidas.Location = new System.Drawing.Point(194, 404);
            this.panelSalidas.Margin = new System.Windows.Forms.Padding(2);
            this.panelSalidas.Name = "panelSalidas";
            this.panelSalidas.Size = new System.Drawing.Size(114, 54);
            this.panelSalidas.TabIndex = 8;
            // 
            // textBoxSalida
            // 
            this.textBoxSalida.Location = new System.Drawing.Point(12, 19);
            this.textBoxSalida.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSalida.Name = "textBoxSalida";
            this.textBoxSalida.Size = new System.Drawing.Size(76, 20);
            this.textBoxSalida.TabIndex = 1;
            // 
            // labelSalidas
            // 
            this.labelSalidas.AutoSize = true;
            this.labelSalidas.Location = new System.Drawing.Point(31, 2);
            this.labelSalidas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalidas.Name = "labelSalidas";
            this.labelSalidas.Size = new System.Drawing.Size(0, 13);
            this.labelSalidas.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 50);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Entradas";
            // 
            // panelPesos
            // 
            this.panelPesos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPesos.AutoScroll = true;
            this.panelPesos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPesos.Location = new System.Drawing.Point(68, 131);
            this.panelPesos.Margin = new System.Windows.Forms.Padding(2);
            this.panelPesos.Name = "panelPesos";
            this.panelPesos.Size = new System.Drawing.Size(122, 292);
            this.panelPesos.TabIndex = 11;
            // 
            // panelBias
            // 
            this.panelBias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBias.AutoScroll = true;
            this.panelBias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBias.Location = new System.Drawing.Point(194, 133);
            this.panelBias.Margin = new System.Windows.Forms.Padding(2);
            this.panelBias.Name = "panelBias";
            this.panelBias.Size = new System.Drawing.Size(114, 191);
            this.panelBias.TabIndex = 12;
            // 
            // dataGridViewDatosEntrenamiento
            // 
            this.dataGridViewDatosEntrenamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDatosEntrenamiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDatosEntrenamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosEntrenamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.y});
            this.dataGridViewDatosEntrenamiento.Location = new System.Drawing.Point(314, 99);
            this.dataGridViewDatosEntrenamiento.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDatosEntrenamiento.Name = "dataGridViewDatosEntrenamiento";
            this.dataGridViewDatosEntrenamiento.RowHeadersWidth = 5;
            this.dataGridViewDatosEntrenamiento.RowTemplate.Height = 24;
            this.dataGridViewDatosEntrenamiento.Size = new System.Drawing.Size(182, 361);
            this.dataGridViewDatosEntrenamiento.TabIndex = 13;
            this.dataGridViewDatosEntrenamiento.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDatosEntrenamiento_CellEndEdit);
            this.dataGridViewDatosEntrenamiento.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewDatosEntrenamiento_RowsAdded);
            this.dataGridViewDatosEntrenamiento.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewDatosEntrenamiento_RowsRemoved);
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.Width = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pesos";
            // 
            // buttonEvaluar
            // 
            this.buttonEvaluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEvaluar.Location = new System.Drawing.Point(230, 381);
            this.buttonEvaluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEvaluar.Name = "buttonEvaluar";
            this.buttonEvaluar.Size = new System.Drawing.Size(56, 19);
            this.buttonEvaluar.TabIndex = 16;
            this.buttonEvaluar.Text = "Evaluar";
            this.buttonEvaluar.UseVisualStyleBackColor = true;
            this.buttonEvaluar.Click += new System.EventHandler(this.buttonEvaluar_Click);
            // 
            // dataGridViewSalidasPrueba
            // 
            this.dataGridViewSalidasPrueba.AllowUserToAddRows = false;
            this.dataGridViewSalidasPrueba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSalidasPrueba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSalidasPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalidasPrueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewSalidasPrueba.Location = new System.Drawing.Point(500, 95);
            this.dataGridViewSalidasPrueba.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSalidasPrueba.Name = "dataGridViewSalidasPrueba";
            this.dataGridViewSalidasPrueba.RowHeadersWidth = 5;
            this.dataGridViewSalidasPrueba.RowTemplate.Height = 24;
            this.dataGridViewSalidasPrueba.Size = new System.Drawing.Size(184, 361);
            this.dataGridViewSalidasPrueba.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "y";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // panelTipoNeurona
            // 
            this.panelTipoNeurona.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTipoNeurona.Controls.Add(this.radioButtonPerceptron);
            this.panelTipoNeurona.Controls.Add(this.radioButtonHebiana);
            this.panelTipoNeurona.Location = new System.Drawing.Point(206, 36);
            this.panelTipoNeurona.Margin = new System.Windows.Forms.Padding(2);
            this.panelTipoNeurona.Name = "panelTipoNeurona";
            this.panelTipoNeurona.Size = new System.Drawing.Size(81, 41);
            this.panelTipoNeurona.TabIndex = 18;
            // 
            // radioButtonPerceptron
            // 
            this.radioButtonPerceptron.AutoSize = true;
            this.radioButtonPerceptron.Location = new System.Drawing.Point(2, 22);
            this.radioButtonPerceptron.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPerceptron.Name = "radioButtonPerceptron";
            this.radioButtonPerceptron.Size = new System.Drawing.Size(77, 17);
            this.radioButtonPerceptron.TabIndex = 1;
            this.radioButtonPerceptron.TabStop = true;
            this.radioButtonPerceptron.Text = "Perceptron";
            this.radioButtonPerceptron.UseVisualStyleBackColor = true;
            this.radioButtonPerceptron.CheckedChanged += new System.EventHandler(this.radioButtonPerceptron_CheckedChanged);
            // 
            // radioButtonHebiana
            // 
            this.radioButtonHebiana.AutoSize = true;
            this.radioButtonHebiana.Location = new System.Drawing.Point(2, 2);
            this.radioButtonHebiana.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHebiana.Name = "radioButtonHebiana";
            this.radioButtonHebiana.Size = new System.Drawing.Size(71, 17);
            this.radioButtonHebiana.TabIndex = 0;
            this.radioButtonHebiana.TabStop = true;
            this.radioButtonHebiana.Text = "Hebbiana";
            this.radioButtonHebiana.UseVisualStyleBackColor = true;
            this.radioButtonHebiana.CheckedChanged += new System.EventHandler(this.radioButtonHebiana_CheckedChanged);
            // 
            // panelTheta
            // 
            this.panelTheta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTheta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTheta.Controls.Add(this.textBoxTheta);
            this.panelTheta.Controls.Add(this.labelTheta);
            this.panelTheta.Location = new System.Drawing.Point(194, 327);
            this.panelTheta.Margin = new System.Windows.Forms.Padding(2);
            this.panelTheta.Name = "panelTheta";
            this.panelTheta.Size = new System.Drawing.Size(117, 52);
            this.panelTheta.TabIndex = 19;
            // 
            // textBoxTheta
            // 
            this.textBoxTheta.Location = new System.Drawing.Point(12, 17);
            this.textBoxTheta.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTheta.Name = "textBoxTheta";
            this.textBoxTheta.Size = new System.Drawing.Size(76, 20);
            this.textBoxTheta.TabIndex = 0;
            this.textBoxTheta.Text = "0";
            // 
            // labelTheta
            // 
            this.labelTheta.AutoSize = true;
            this.labelTheta.Location = new System.Drawing.Point(36, 2);
            this.labelTheta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTheta.Name = "labelTheta";
            this.labelTheta.Size = new System.Drawing.Size(35, 13);
            this.labelTheta.TabIndex = 20;
            this.labelTheta.Text = "Theta";
            // 
            // panelIteraciones
            // 
            this.panelIteraciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelIteraciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelIteraciones.Controls.Add(this.textBoxIteraciones);
            this.panelIteraciones.Controls.Add(this.labelIteraciones);
            this.panelIteraciones.Location = new System.Drawing.Point(291, 37);
            this.panelIteraciones.Margin = new System.Windows.Forms.Padding(2);
            this.panelIteraciones.Name = "panelIteraciones";
            this.panelIteraciones.Size = new System.Drawing.Size(83, 39);
            this.panelIteraciones.TabIndex = 21;
            // 
            // textBoxIteraciones
            // 
            this.textBoxIteraciones.Location = new System.Drawing.Point(2, 16);
            this.textBoxIteraciones.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIteraciones.Name = "textBoxIteraciones";
            this.textBoxIteraciones.Size = new System.Drawing.Size(76, 20);
            this.textBoxIteraciones.TabIndex = 1;
            this.textBoxIteraciones.Text = "20";
            // 
            // labelIteraciones
            // 
            this.labelIteraciones.AutoSize = true;
            this.labelIteraciones.Location = new System.Drawing.Point(9, 2);
            this.labelIteraciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIteraciones.Name = "labelIteraciones";
            this.labelIteraciones.Size = new System.Drawing.Size(59, 13);
            this.labelIteraciones.TabIndex = 22;
            this.labelIteraciones.Text = "Iteraciones";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(10, 2);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(29, 13);
            this.labelError.TabIndex = 24;
            this.labelError.Text = "Error";
            // 
            // panelError
            // 
            this.panelError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelError.Controls.Add(this.textBoxError);
            this.panelError.Controls.Add(this.labelError);
            this.panelError.Location = new System.Drawing.Point(375, 37);
            this.panelError.Margin = new System.Windows.Forms.Padding(2);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(54, 39);
            this.panelError.TabIndex = 23;
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(2, 15);
            this.textBoxError.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(49, 20);
            this.textBoxError.TabIndex = 1;
            this.textBoxError.Text = "0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Iniciales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Finales";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Valores de entrenamiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(598, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Taza de exito";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLimpiar.Location = new System.Drawing.Point(82, 425);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(56, 19);
            this.buttonLimpiar.TabIndex = 30;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // labelFitness
            // 
            this.labelFitness.AutoSize = true;
            this.labelFitness.Location = new System.Drawing.Point(50, 0);
            this.labelFitness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFitness.Name = "labelFitness";
            this.labelFitness.Size = new System.Drawing.Size(30, 13);
            this.labelFitness.TabIndex = 24;
            this.labelFitness.Text = "Exito";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.maskedTextBoxExito);
            this.panel1.Controls.Add(this.labelFitness);
            this.panel1.Location = new System.Drawing.Point(536, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 39);
            this.panel1.TabIndex = 25;
            // 
            // maskedTextBoxExito
            // 
            this.maskedTextBoxExito.Location = new System.Drawing.Point(2, 14);
            this.maskedTextBoxExito.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxExito.Name = "maskedTextBoxExito";
            this.maskedTextBoxExito.ReadOnly = true;
            this.maskedTextBoxExito.Size = new System.Drawing.Size(126, 20);
            this.maskedTextBoxExito.TabIndex = 31;
            this.maskedTextBoxExito.Text = "0";
            this.maskedTextBoxExito.ValidatingType = typeof(int);
            // 
            // panelRango
            // 
            this.panelRango.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRango.Controls.Add(this.textBoxRangoMax);
            this.panelRango.Controls.Add(this.textBoxRangoMin);
            this.panelRango.Controls.Add(this.labelRango);
            this.panelRango.Location = new System.Drawing.Point(430, 37);
            this.panelRango.Margin = new System.Windows.Forms.Padding(2);
            this.panelRango.Name = "panelRango";
            this.panelRango.Size = new System.Drawing.Size(102, 39);
            this.panelRango.TabIndex = 23;
            // 
            // textBoxRangoMax
            // 
            this.textBoxRangoMax.Location = new System.Drawing.Point(52, 16);
            this.textBoxRangoMax.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRangoMax.Name = "textBoxRangoMax";
            this.textBoxRangoMax.Size = new System.Drawing.Size(46, 20);
            this.textBoxRangoMax.TabIndex = 23;
            this.textBoxRangoMax.Text = "20";
            // 
            // textBoxRangoMin
            // 
            this.textBoxRangoMin.Location = new System.Drawing.Point(2, 16);
            this.textBoxRangoMin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRangoMin.Name = "textBoxRangoMin";
            this.textBoxRangoMin.Size = new System.Drawing.Size(46, 20);
            this.textBoxRangoMin.TabIndex = 1;
            this.textBoxRangoMin.Text = "-20";
            // 
            // labelRango
            // 
            this.labelRango.AutoSize = true;
            this.labelRango.Location = new System.Drawing.Point(30, 2);
            this.labelRango.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRango.Name = "labelRango";
            this.labelRango.Size = new System.Drawing.Size(39, 13);
            this.labelRango.TabIndex = 22;
            this.labelRango.Text = "Rango";
            // 
            // numericUpDownNumeroSalidas
            // 
            this.numericUpDownNumeroSalidas.Location = new System.Drawing.Point(114, 50);
            this.numericUpDownNumeroSalidas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownNumeroSalidas.Name = "numericUpDownNumeroSalidas";
            this.numericUpDownNumeroSalidas.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownNumeroSalidas.TabIndex = 32;
            this.numericUpDownNumeroSalidas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumeroSalidas.ValueChanged += new System.EventHandler(this.numericUpDownNumeroSalidas_ValueChanged);
            // 
            // labelNumeroSalidas
            // 
            this.labelNumeroSalidas.AutoSize = true;
            this.labelNumeroSalidas.Location = new System.Drawing.Point(104, 32);
            this.labelNumeroSalidas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeroSalidas.Name = "labelNumeroSalidas";
            this.labelNumeroSalidas.Size = new System.Drawing.Size(96, 13);
            this.labelNumeroSalidas.TabIndex = 31;
            this.labelNumeroSalidas.Text = "Numero de Salidas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 465);
            this.Controls.Add(this.numericUpDownNumeroSalidas);
            this.Controls.Add(this.labelNumeroSalidas);
            this.Controls.Add(this.panelRango);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelError);
            this.Controls.Add(this.panelIteraciones);
            this.Controls.Add(this.panelTheta);
            this.Controls.Add(this.panelTipoNeurona);
            this.Controls.Add(this.dataGridViewSalidasPrueba);
            this.Controls.Add(this.buttonEvaluar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewDatosEntrenamiento);
            this.Controls.Add(this.panelBias);
            this.Controls.Add(this.panelPesos);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panelSalidas);
            this.Controls.Add(this.panelEntradas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSalidas.ResumeLayout(false);
            this.panelSalidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosEntrenamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalidasPrueba)).EndInit();
            this.panelTipoNeurona.ResumeLayout(false);
            this.panelTipoNeurona.PerformLayout();
            this.panelTheta.ResumeLayout(false);
            this.panelTheta.PerformLayout();
            this.panelIteraciones.ResumeLayout(false);
            this.panelIteraciones.PerformLayout();
            this.panelError.ResumeLayout(false);
            this.panelError.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRango.ResumeLayout(false);
            this.panelRango.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroSalidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEntradas;
        private System.Windows.Forms.Panel panelSalidas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSalidas;
        private System.Windows.Forms.Panel panelPesos;
        private System.Windows.Forms.Panel panelBias;
        private System.Windows.Forms.DataGridView dataGridViewDatosEntrenamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.TextBox textBoxSalida;
        private System.Windows.Forms.Button buttonEvaluar;
        private System.Windows.Forms.DataGridView dataGridViewSalidasPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panelTipoNeurona;
        private System.Windows.Forms.RadioButton radioButtonPerceptron;
        private System.Windows.Forms.RadioButton radioButtonHebiana;
        private System.Windows.Forms.Panel panelTheta;
        private System.Windows.Forms.TextBox textBoxTheta;
        private System.Windows.Forms.Label labelTheta;
        private System.Windows.Forms.Panel panelIteraciones;
        private System.Windows.Forms.Label labelIteraciones;
        private System.Windows.Forms.TextBox textBoxIteraciones;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label labelFitness;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxExito;
        private System.Windows.Forms.Panel panelRango;
        private System.Windows.Forms.TextBox textBoxRangoMin;
        private System.Windows.Forms.Label labelRango;
        private System.Windows.Forms.TextBox textBoxRangoMax;
        private System.Windows.Forms.NumericUpDown numericUpDownNumeroSalidas;
        private System.Windows.Forms.Label labelNumeroSalidas;
    }
}

