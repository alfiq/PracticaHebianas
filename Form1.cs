using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NeuronaHebianaLuis
{
    public partial class Form1 : Form
    {
        private NeuronaHebiana NH = new NeuronaHebiana();
        private NeuronaPerceptron NP = new NeuronaPerceptron();
        Random RNG = new Random();

        public Form1()
        {
            InitializeComponent();
            actualizarEntradas();
            actualizarPesos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDown1.Value < 1)
            {
                this.numericUpDown1.Value = 1;
            }

            actualizarControles();
            actualizarPesos();
        }
        private void actualizarControles()
        {
            actualizarEntradas();
        }
        private void actualizarEntradas()
        {

            int numEnt = (int)this.numericUpDown1.Value;
            int numCont = numeroDeLabels(this.panelEntradas);
            Point np = new Point(10, 10);
            if (numEnt > numCont)
            {
                for (int i = numCont; i < numEnt; i++)
                {

                    AddColumn(i, "x");
                    addLabel(this.panelEntradas, i, "x");
                    addTextBox(this.panelEntradas, i, "x");

                }
            }

            if (numEnt < numCont)
            {
                removeColumn();
                removeLabel(this.panelEntradas);
                removeTextBox(this.panelEntradas);
            }
        }
        private void actualizarPesos()
        {

            int numEnt = (int)this.numericUpDown1.Value;
            int numCont = numeroDeTextBox(this.panelPesos) / 2;
            Point np = new Point(10, 10);
            if (numEnt > numCont)
            {
                for (int i = numCont; i < numEnt; i++)
                {
                    addLabel(this.panelPesos, i, "w");
                    addTextBox(this.panelPesos, i, "wi");
                    addTextBox2(this.panelPesos, i, "wo");
                }
            }

            if (numEnt < numCont)
            {
                removeLabel(this.panelPesos);
                removeTextBox(this.panelPesos);
                removeTextBox(this.panelPesos);
            }
        }
        private void addLabel(Panel p, int i, string name)
        {
            Label lastLabel = new Label();
            Point np = new Point(0, 20 + 30 * i);
            lastLabel.Text = name + i.ToString();
            lastLabel.Name = "label" + name + i.ToString();
            lastLabel.Location = np;
            lastLabel.AutoSize = true;
            if (!p.Controls.Contains(lastLabel))
                p.Controls.Add(lastLabel);
        }
        private void addTextBox(Panel p, int i, string name)
        {
            TextBox lastTextBox = new TextBox();
            Point np = new Point(25, 17 + 30 * i);
            lastTextBox.Text = "0";
            lastTextBox.Name = "textBox" + name + i.ToString(); ;
            lastTextBox.Location = np;
            lastTextBox.Size -= new Size(70, 0);
            if (!p.Controls.Contains(lastTextBox))
                p.Controls.Add(lastTextBox);
        }
        private void addTextBox2(Panel p, int i, string name)
        {
            TextBox lastTextBox = new TextBox();
            Point np = new Point(60, 17 + 30 * i);
            lastTextBox.Text = "NA";
            lastTextBox.Name = "textBox" + name + i.ToString(); ;
            lastTextBox.Location = np;
            lastTextBox.Size -= new Size(70, 0);
            p.Controls.Add(lastTextBox);
        }
        private void AddColumn(int i, string name)
        {
            int index = this.dataGridViewDatosEntrenamiento.Columns.Add(name + i.ToString(), name + i.ToString());
            this.dataGridViewDatosEntrenamiento.Columns[index].Width = 30;
        }
        private void removeLabel(Panel p)
        {
            this.Controls.Remove(p.Controls[p.Controls.Count - 1]);
            p.Controls.Remove(p.Controls[p.Controls.Count - 1]);
        }
        private void removeTextBox(Panel p)
        {
            this.Controls.Remove(p.Controls[p.Controls.Count - 1]);
            p.Controls.Remove(p.Controls[p.Controls.Count - 1]);
        }
        private void removeColumn()
        {
            this.dataGridViewDatosEntrenamiento.Columns.Remove(this.dataGridViewDatosEntrenamiento.Columns[this.dataGridViewDatosEntrenamiento.Columns.Count - 1]);
        }
        private int numeroDeLabels(Panel p)
        {
            int numLab = 0;
            foreach (Control l in p.Controls)
            {
                if (l is Label)
                    numLab++;
            }
            return numLab;
        }
        private int numeroDeTextBox(Panel p)
        {
            int numTex = 0;
            foreach (Control l in p.Controls)
            {
                if (l is TextBox)
                    numTex++;
            }
            return numTex;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButtonHebiana.Checked)
            {
                double exito = 0;
                double auxExito = 0;
                double[] mejoresPesosFinales = new double[0];
                double[] mejoresPesosIniciales = new double[0];
                double mejorBiasFinal = 0;
                double mejorBiasInicial = 0;
                NeuronaHebiana auxNH = new NeuronaHebiana();
                NH.Init(obtenerPesos(), obtenerBias());
                for (int j = 0; j < Convert.ToInt32(this.textBoxIteraciones.Text); j++)
                {
                    if (j != 0)
                    {
                        NH.Init(GenerarPesos(), GenerarBias());
                    }
                    foreach (DataGridViewRow r in this.dataGridViewDatosEntrenamiento.Rows)
                    {
                        if (r.IsNewRow)
                        {
                            continue;
                        }
                        int len = this.dataGridViewDatosEntrenamiento.Columns.Count;
                        double[] epoch = new double[len];
                        for (int i = 0; i < len; i++)
                        {
                            epoch[i] = Convert.ToDouble(r.Cells[i].Value);
                        }
                        NH.NuevaEpoca(epoch.SubArray(1, len - 1).ToArray(), epoch[0]);
                    }

                    exito = ObtenerSalidas();
                    if (exito > auxExito)
                    {
                        auxNH.Init(obtenerPesos(), obtenerBias());
                        auxExito = exito;

                        mejoresPesosFinales = NH.ObtenerPesosFinales();
                        mejoresPesosIniciales = NH.ObtenerPesosIniciales() ;
                        mejorBiasFinal = NH.ObtenerBiasFinal();
                        mejorBiasInicial =NH.ObtenerBiasInicial();

                        this.maskedTextBoxExito.Text = auxExito.ToString();

                        if (auxExito >= 99)
                        {
                            break;
                        }
                    }
                }
                
                
                insertarNuevosPesos(mejoresPesosFinales);
                insertarNuevoBias(mejorBiasFinal);
                RellenarPesosExitosos(mejoresPesosIniciales);
                rellenearBiasExitoso(mejorBiasInicial);
            }

            else if (this.radioButtonPerceptron.Checked)
            {
                NP.Init(obtenerPesos(), Convert.ToDouble(this.textBoxTheta.Text));
                for (int j = 0; j < Convert.ToDouble(this.textBoxIteraciones.Text); j++)
                {
                    foreach (DataGridViewRow r in this.dataGridViewDatosEntrenamiento.Rows)
                    {
                        if (r.IsNewRow)
                        {
                            continue;
                        }

                        int len = this.dataGridViewDatosEntrenamiento.Columns.Count;
                        double[] epoch = new double[len];
                        for (int i = 0; i < len; i++)
                        {
                            epoch[i] = Convert.ToDouble(r.Cells[i].Value);
                        }

                        NP.NuevaEpoca(epoch.SubArray(1, len - 1).ToArray(), epoch[0]);
                    }
                }
                insertarNuevosPesos(NP.ObtenerPesosFinales());
                this.maskedTextBoxExito.Text = ObtenerSalidas().ToString();
            }
        }
        private double[] GenerarPesos()
        {
            double[] pesos = new double[numeroDeTextBox(panelPesos) / 2];
            int i = 0;
            foreach (Control tb in panelPesos.Controls)
            {
                if (tb is TextBox)
                {
                    if (!tb.Name.Contains("wo"))
                    {
                        double maxNumber = Convert.ToDouble(this.textBoxRangoMax.Text);
                        tb.Text = (RNG.Next() % (2 * maxNumber) - (maxNumber)).ToString();
                        pesos[i] = Convert.ToDouble(tb.Text);
                        i++;
                    }
                }
            }
            return pesos;
        }
        private void RellenarPesosExitosos(double[] pesos)
        {
            int i = 0;
            foreach (Control tb in panelPesos.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name.Contains("wi"))
                    {
                        tb.Text = pesos[i].ToString();
                        i++;
                    }
                }
            }
        }
        private double GenerarBias()
        {
            double maxNumber = Convert.ToDouble(this.textBoxRangoMax.Text);
            this.textBoxBiasEntrada.Text = (RNG.Next() % (2 * maxNumber) - (maxNumber)).ToString();
            return Convert.ToDouble(this.textBoxBiasEntrada.Text);
        }
        private void rellenearBiasExitoso(double bias)
        {
            this.textBoxBiasEntrada.Text = bias.ToString();
        }
        private double[] obtenerPesos()
        {
            double[] pesos = new double[numeroDeTextBox(panelPesos) / 2];
            int i = 0;
            foreach (Control tb in panelPesos.Controls)
            {
                if (tb is TextBox)
                {
                    if (!tb.Name.Contains("wo"))
                    {
                        pesos[i] = Convert.ToDouble(tb.Text);
                        i++;
                    }
                }
            }
            return pesos;
        }
        private void insertarNuevosPesos(double[] pesos)
        {
            int i = 0;
            foreach (Control tb in panelPesos.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name.Contains("wo"))
                    {
                        tb.Text = pesos[i].ToString();
                        i++;
                    }
                }
            }
        }
        private void insertarNuevoBias(double bias)
        {
            this.textBoxBiasSalida.Text = bias.ToString();
        }
        private double obtenerBias()
        {
            return Convert.ToDouble(this.textBoxBiasEntrada.Text);
        }
        private void buttonEvaluar_Click(object sender, EventArgs e)
        {
            if (this.radioButtonHebiana.Checked)
                this.textBoxSalida.Text = NH.obtenerSalida(ObtenerEntradas()).ToString();
            else
                this.textBoxSalida.Text = NP.obtenerSalida(ObtenerEntradas()).ToString();
        }
        private double[] ObtenerEntradas()
        {
            double[] entradas = new double[numeroDeTextBox(this.panelEntradas)];
            int i = 0;
            foreach (Control tb in panelEntradas.Controls)
            {
                if (tb is TextBox)
                {
                    entradas[i] = Convert.ToDouble(tb.Text);
                    i++;
                }
            }
            return entradas;
        }
        private double ObtenerSalidas()
        {
            double isTrained = 0;
            if (this.radioButtonHebiana.Checked)
            {
                int j = 0;
                foreach (DataGridViewRow r in this.dataGridViewDatosEntrenamiento.Rows)
                {
                    if (r.IsNewRow)
                    {
                        continue;
                    }
                    int len = this.dataGridViewDatosEntrenamiento.Columns.Count;
                    double[] epoch = new double[len];
                    for (int i = 0; i < len; i++)
                    {
                        epoch[i] = Convert.ToDouble(r.Cells[i].Value);
                    }
                    bool CorrectValue = (NH.funcionDeExitacion(NH.obtenerSalida(epoch.SubArray(1, len - 1).ToArray()))
                        == NH.funcionDeExitacion(epoch[0]));
                    this.dataGridViewSalidasPrueba.Rows[j].Cells[0].Value = CorrectValue.ToString();
                    if (CorrectValue)
                    {
                        isTrained += 100.0/(this.dataGridViewDatosEntrenamiento.RowCount-1);
                        if(isTrained==100)
                        {
                            return isTrained;
                        }
                    }

                    j++;
                }
                return isTrained;
            }

            if (this.radioButtonPerceptron.Checked)
            {
                int j = 0;
                foreach (DataGridViewRow r in this.dataGridViewDatosEntrenamiento.Rows)
                {
                    if (r.IsNewRow)
                    {
                        continue;
                    }
                    int len = this.dataGridViewDatosEntrenamiento.Columns.Count;
                    double[] epoch = new double[len];
                    for (int i = 0; i < len; i++)
                    {
                        epoch[i] = Convert.ToDouble(r.Cells[i].Value);
                    }
                    double realValue = NP.obtenerSalida(epoch.SubArray(1, len - 1).ToArray());
                    double expectedValue = epoch[0];
                    bool CorrectValue =Math.Abs(realValue  - expectedValue) < Convert.ToDouble(this.textBoxError.Text);
                    this.dataGridViewSalidasPrueba.Rows[j].Cells[0].Value = CorrectValue.ToString();
                    if (CorrectValue)
                    {
                        isTrained += 100.0 / (this.dataGridViewDatosEntrenamiento.RowCount - 1);
                    }
                    j++;
                }
            }
            return isTrained;
        }
        private void dataGridViewDatosEntrenamiento_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int ind = this.dataGridViewSalidasPrueba.Rows.Add();
            this.dataGridViewSalidasPrueba.Rows[ind].Height=15;
        }
        private void dataGridViewDatosEntrenamiento_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataGridViewDatosEntrenamiento.RowCount > 0)
            {
                this.dataGridViewSalidasPrueba.Rows.RemoveAt(this.dataGridViewSalidasPrueba.Rows.GetLastRow(DataGridViewElementStates.None));
            }
        }
        private void dataGridViewDatosEntrenamiento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool esNula = true;
            if (this.dataGridViewDatosEntrenamiento.Rows.Count < 1)
                return;
            foreach (DataGridViewCell c in this.dataGridViewDatosEntrenamiento.Rows[e.RowIndex].Cells)
            {
                if (c == null)
                {
                    esNula &= true;
                }
                else if (c.Value == null)
                {
                    esNula &= true;
                }
                else
                {
                    esNula &= false;
                }
            }
            if (esNula)
            {
                try
                {
                    this.dataGridViewDatosEntrenamiento.Rows.RemoveAt(e.RowIndex);
                }
                catch { }
            }
        }
        private void radioButtonHebiana_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                foreach (Control c in r.Parent.Controls)
                {
                    if (c is RadioButton)
                    {
                        if (c != r)
                        {
                            ((RadioButton)c).Checked = false;
                        }
                    }
                }
                this.labelTheta.Enabled = false;
                this.textBoxTheta.Enabled = false;
                this.textBoxBiasSalida.Enabled = true;
                this.textBoxBiasEntrada.Enabled = true;
            }
        }
        private void radioButtonPerceptron_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                foreach (Control c in r.Parent.Controls)
                {
                    if (c is RadioButton)
                    {
                        if (c != r)
                        {
                            ((RadioButton)c).Checked = false;
                        }
                    }
                }
                this.labelTheta.Enabled = true;
                this.textBoxTheta.Enabled = true;
                this.textBoxBiasSalida.Enabled = false;
                this.textBoxBiasEntrada.Enabled = false;
            }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = this.openFileDialog1.ShowDialog();
            if (r == DialogResult.OK && this.openFileDialog1.CheckPathExists)
            {
                LlenarTabla(AbrirCsv(this.openFileDialog1.FileName));
            }
        }
        private void LlenarTabla(List<List<string>> ll)
        {
            this.dataGridViewDatosEntrenamiento.Rows.Clear();
            this.numericUpDown1.Value = ll[0].Count()-1;
            actualizarEntradas();
            foreach (List<string> l in ll)
            {
                int r = this.dataGridViewDatosEntrenamiento.Rows.Add();
                for(int i  =0;i< this.dataGridViewDatosEntrenamiento.ColumnCount;i++)
                {
                    this.dataGridViewDatosEntrenamiento.Rows[r].Cells[i].Value = l[i];
                    this.dataGridViewDatosEntrenamiento.Rows[r].Height = 15;
                }
            }
        }
        private List<List<string>> AbrirCsv(string path)
        {
            List<List<string>> filas = new List<List<string>>();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    List<string> fila = new List<string>(values);
                    filas.Add(fila);
                }
            }
            return filas;
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarPesos();
            LimpiarBias();
        }
        private void limpiarPesos()
        {
            foreach (Control tb in panelPesos.Controls)
            {
                if (tb is TextBox)
                {
                    if (!tb.Name.Contains("wo"))
                    {
                        tb.Text = "0";
                    }
                }
            }
        }
        private void LimpiarBias()
        {
            this.textBoxBiasEntrada.Text = "0";
        }
    }


    public static class Extensions
    {
        public static T[] SubArray<T>(this T[] array, int offset, int length)
        {
            T[] result = new T[length];
            Array.Copy(array, offset, result, 0, length);
            return result;
        }
    }
}
