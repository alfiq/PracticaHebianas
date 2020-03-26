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
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBiasSalida = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBiasEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panelSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelBias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosEntrenamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalidasPrueba)).BeginInit();
            this.panelTipoNeurona.SuspendLayout();
            this.panelTheta.SuspendLayout();
            this.panelIteraciones.SuspendLayout();
            this.panelError.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRango.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(132, 134);
            this.buttonIniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "Correr";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de entradas";
            // 
            // panelEntradas
            // 
            this.panelEntradas.AutoScroll = true;
            this.panelEntradas.Location = new System.Drawing.Point(7, 203);
            this.panelEntradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEntradas.Name = "panelEntradas";
            this.panelEntradas.Size = new System.Drawing.Size(85, 358);
            this.panelEntradas.TabIndex = 7;
            // 
            // panelSalidas
            // 
            this.panelSalidas.AutoScroll = true;
            this.panelSalidas.Controls.Add(this.textBoxSalida);
            this.panelSalidas.Controls.Add(this.labelSalidas);
            this.panelSalidas.Location = new System.Drawing.Point(235, 410);
            this.panelSalidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSalidas.Name = "panelSalidas";
            this.panelSalidas.Size = new System.Drawing.Size(132, 66);
            this.panelSalidas.TabIndex = 8;
            // 
            // textBoxSalida
            // 
            this.textBoxSalida.Location = new System.Drawing.Point(16, 23);
            this.textBoxSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSalida.Name = "textBoxSalida";
            this.textBoxSalida.Size = new System.Drawing.Size(100, 22);
            this.textBoxSalida.TabIndex = 1;
            // 
            // labelSalidas
            // 
            this.labelSalidas.AutoSize = true;
            this.labelSalidas.Location = new System.Drawing.Point(41, 2);
            this.labelSalidas.Name = "labelSalidas";
            this.labelSalidas.Size = new System.Drawing.Size(0, 17);
            this.labelSalidas.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 49);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
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
            this.label4.Location = new System.Drawing.Point(7, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Entradas";
            // 
            // panelPesos
            // 
            this.panelPesos.AutoScroll = true;
            this.panelPesos.Location = new System.Drawing.Point(97, 204);
            this.panelPesos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPesos.Name = "panelPesos";
            this.panelPesos.Size = new System.Drawing.Size(135, 358);
            this.panelPesos.TabIndex = 11;
            // 
            // panelBias
            // 
            this.panelBias.AutoScroll = true;
            this.panelBias.Controls.Add(this.label8);
            this.panelBias.Controls.Add(this.textBoxBiasSalida);
            this.panelBias.Controls.Add(this.label9);
            this.panelBias.Controls.Add(this.textBoxBiasEntrada);
            this.panelBias.Controls.Add(this.label2);
            this.panelBias.Location = new System.Drawing.Point(236, 162);
            this.panelBias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBias.Name = "panelBias";
            this.panelBias.Size = new System.Drawing.Size(135, 70);
            this.panelBias.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Finales";
            // 
            // textBoxBiasSalida
            // 
            this.textBoxBiasSalida.Location = new System.Drawing.Point(75, 41);
            this.textBoxBiasSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBiasSalida.Name = "textBoxBiasSalida";
            this.textBoxBiasSalida.Size = new System.Drawing.Size(49, 22);
            this.textBoxBiasSalida.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Iniciales";
            // 
            // textBoxBiasEntrada
            // 
            this.textBoxBiasEntrada.Location = new System.Drawing.Point(19, 41);
            this.textBoxBiasEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBiasEntrada.Name = "textBoxBiasEntrada";
            this.textBoxBiasEntrada.Size = new System.Drawing.Size(49, 22);
            this.textBoxBiasEntrada.TabIndex = 0;
            this.textBoxBiasEntrada.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bias";
            // 
            // dataGridViewDatosEntrenamiento
            // 
            this.dataGridViewDatosEntrenamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDatosEntrenamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosEntrenamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.y});
            this.dataGridViewDatosEntrenamiento.Location = new System.Drawing.Point(377, 117);
            this.dataGridViewDatosEntrenamiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDatosEntrenamiento.Name = "dataGridViewDatosEntrenamiento";
            this.dataGridViewDatosEntrenamiento.RowHeadersWidth = 5;
            this.dataGridViewDatosEntrenamiento.RowTemplate.Height = 24;
            this.dataGridViewDatosEntrenamiento.Size = new System.Drawing.Size(283, 444);
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
            this.label3.Location = new System.Drawing.Point(144, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pesos";
            // 
            // buttonEvaluar
            // 
            this.buttonEvaluar.Location = new System.Drawing.Point(265, 364);
            this.buttonEvaluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEvaluar.Name = "buttonEvaluar";
            this.buttonEvaluar.Size = new System.Drawing.Size(75, 23);
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
            this.dataGridViewSalidasPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalidasPrueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewSalidasPrueba.Location = new System.Drawing.Point(665, 117);
            this.dataGridViewSalidasPrueba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSalidasPrueba.Name = "dataGridViewSalidasPrueba";
            this.dataGridViewSalidasPrueba.RowHeadersWidth = 5;
            this.dataGridViewSalidasPrueba.RowTemplate.Height = 24;
            this.dataGridViewSalidasPrueba.Size = new System.Drawing.Size(129, 444);
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
            this.panelTipoNeurona.Controls.Add(this.radioButtonPerceptron);
            this.panelTipoNeurona.Controls.Add(this.radioButtonHebiana);
            this.panelTipoNeurona.Location = new System.Drawing.Point(13, 79);
            this.panelTipoNeurona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTipoNeurona.Name = "panelTipoNeurona";
            this.panelTipoNeurona.Size = new System.Drawing.Size(107, 49);
            this.panelTipoNeurona.TabIndex = 18;
            // 
            // radioButtonPerceptron
            // 
            this.radioButtonPerceptron.AutoSize = true;
            this.radioButtonPerceptron.Location = new System.Drawing.Point(3, 27);
            this.radioButtonPerceptron.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPerceptron.Name = "radioButtonPerceptron";
            this.radioButtonPerceptron.Size = new System.Drawing.Size(99, 21);
            this.radioButtonPerceptron.TabIndex = 1;
            this.radioButtonPerceptron.TabStop = true;
            this.radioButtonPerceptron.Text = "Perceptron";
            this.radioButtonPerceptron.UseVisualStyleBackColor = true;
            this.radioButtonPerceptron.CheckedChanged += new System.EventHandler(this.radioButtonPerceptron_CheckedChanged);
            // 
            // radioButtonHebiana
            // 
            this.radioButtonHebiana.AutoSize = true;
            this.radioButtonHebiana.Location = new System.Drawing.Point(3, 2);
            this.radioButtonHebiana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHebiana.Name = "radioButtonHebiana";
            this.radioButtonHebiana.Size = new System.Drawing.Size(90, 21);
            this.radioButtonHebiana.TabIndex = 0;
            this.radioButtonHebiana.TabStop = true;
            this.radioButtonHebiana.Text = "Hebbiana";
            this.radioButtonHebiana.UseVisualStyleBackColor = true;
            this.radioButtonHebiana.CheckedChanged += new System.EventHandler(this.radioButtonHebiana_CheckedChanged);
            // 
            // panelTheta
            // 
            this.panelTheta.Controls.Add(this.textBoxTheta);
            this.panelTheta.Controls.Add(this.labelTheta);
            this.panelTheta.Location = new System.Drawing.Point(236, 254);
            this.panelTheta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTheta.Name = "panelTheta";
            this.panelTheta.Size = new System.Drawing.Size(136, 63);
            this.panelTheta.TabIndex = 19;
            // 
            // textBoxTheta
            // 
            this.textBoxTheta.Location = new System.Drawing.Point(16, 21);
            this.textBoxTheta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTheta.Name = "textBoxTheta";
            this.textBoxTheta.Size = new System.Drawing.Size(100, 22);
            this.textBoxTheta.TabIndex = 0;
            this.textBoxTheta.Text = "0";
            // 
            // labelTheta
            // 
            this.labelTheta.AutoSize = true;
            this.labelTheta.Location = new System.Drawing.Point(48, 2);
            this.labelTheta.Name = "labelTheta";
            this.labelTheta.Size = new System.Drawing.Size(45, 17);
            this.labelTheta.TabIndex = 20;
            this.labelTheta.Text = "Theta";
            // 
            // panelIteraciones
            // 
            this.panelIteraciones.Controls.Add(this.textBoxIteraciones);
            this.panelIteraciones.Controls.Add(this.labelIteraciones);
            this.panelIteraciones.Location = new System.Drawing.Point(11, 132);
            this.panelIteraciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelIteraciones.Name = "panelIteraciones";
            this.panelIteraciones.Size = new System.Drawing.Size(109, 47);
            this.panelIteraciones.TabIndex = 21;
            // 
            // textBoxIteraciones
            // 
            this.textBoxIteraciones.Location = new System.Drawing.Point(3, 20);
            this.textBoxIteraciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIteraciones.Name = "textBoxIteraciones";
            this.textBoxIteraciones.Size = new System.Drawing.Size(100, 22);
            this.textBoxIteraciones.TabIndex = 1;
            this.textBoxIteraciones.Text = "20";
            // 
            // labelIteraciones
            // 
            this.labelIteraciones.AutoSize = true;
            this.labelIteraciones.Location = new System.Drawing.Point(12, 2);
            this.labelIteraciones.Name = "labelIteraciones";
            this.labelIteraciones.Size = new System.Drawing.Size(77, 17);
            this.labelIteraciones.TabIndex = 22;
            this.labelIteraciones.Text = "Iteraciones";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(35, 1);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(40, 17);
            this.labelError.TabIndex = 24;
            this.labelError.Text = "Error";
            // 
            // panelError
            // 
            this.panelError.Controls.Add(this.textBoxError);
            this.panelError.Controls.Add(this.labelError);
            this.panelError.Location = new System.Drawing.Point(125, 81);
            this.panelError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(104, 47);
            this.panelError.TabIndex = 23;
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(7, 18);
            this.textBoxError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(88, 22);
            this.textBoxError.TabIndex = 1;
            this.textBoxError.Text = "0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Iniciales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Finales";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Valores de entrenamiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(697, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(147, 48);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 30;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // labelFitness
            // 
            this.labelFitness.AutoSize = true;
            this.labelFitness.Location = new System.Drawing.Point(35, 1);
            this.labelFitness.Name = "labelFitness";
            this.labelFitness.Size = new System.Drawing.Size(38, 17);
            this.labelFitness.TabIndex = 24;
            this.labelFitness.Text = "Exito";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBoxExito);
            this.panel1.Controls.Add(this.labelFitness);
            this.panel1.Location = new System.Drawing.Point(677, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 47);
            this.panel1.TabIndex = 25;
            // 
            // maskedTextBoxExito
            // 
            this.maskedTextBoxExito.Location = new System.Drawing.Point(7, 18);
            this.maskedTextBoxExito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxExito.Name = "maskedTextBoxExito";
            this.maskedTextBoxExito.ReadOnly = true;
            this.maskedTextBoxExito.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxExito.TabIndex = 31;
            this.maskedTextBoxExito.Text = "0";
            this.maskedTextBoxExito.ValidatingType = typeof(int);
            // 
            // panelRango
            // 
            this.panelRango.Controls.Add(this.textBoxRangoMax);
            this.panelRango.Controls.Add(this.textBoxRangoMin);
            this.panelRango.Controls.Add(this.labelRango);
            this.panelRango.Location = new System.Drawing.Point(236, 44);
            this.panelRango.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRango.Name = "panelRango";
            this.panelRango.Size = new System.Drawing.Size(135, 47);
            this.panelRango.TabIndex = 23;
            // 
            // textBoxRangoMax
            // 
            this.textBoxRangoMax.Location = new System.Drawing.Point(69, 20);
            this.textBoxRangoMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRangoMax.Name = "textBoxRangoMax";
            this.textBoxRangoMax.Size = new System.Drawing.Size(60, 22);
            this.textBoxRangoMax.TabIndex = 23;
            this.textBoxRangoMax.Text = "20";
            // 
            // textBoxRangoMin
            // 
            this.textBoxRangoMin.Location = new System.Drawing.Point(3, 20);
            this.textBoxRangoMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRangoMin.Name = "textBoxRangoMin";
            this.textBoxRangoMin.Size = new System.Drawing.Size(60, 22);
            this.textBoxRangoMin.TabIndex = 1;
            this.textBoxRangoMin.Text = "-20";
            // 
            // labelRango
            // 
            this.labelRango.AutoSize = true;
            this.labelRango.Location = new System.Drawing.Point(40, 2);
            this.labelRango.Name = "labelRango";
            this.labelRango.Size = new System.Drawing.Size(50, 17);
            this.labelRango.TabIndex = 22;
            this.labelRango.Text = "Rango";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSalidas.ResumeLayout(false);
            this.panelSalidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelBias.ResumeLayout(false);
            this.panelBias.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.TextBox textBoxSalida;
        private System.Windows.Forms.TextBox textBoxBiasEntrada;
        private System.Windows.Forms.TextBox textBoxBiasSalida;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
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
    }
}

