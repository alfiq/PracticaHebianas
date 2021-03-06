﻿using System;
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
        private List<NeuronaHebiana> NH = new List<NeuronaHebiana>();
        private List<NeuronaPerceptron> NP = new List<NeuronaPerceptron>();
        Random RNG = new Random();

        public Form1()
        {
            InitializeComponent();
            actualizarEntradasSalidas();
            actualizarPesos();
            ActualizarNumeroDeNeuronas();
            actualizarNumeroDeBias();

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
            actualizarEntradasSalidas();
        }
        private void actualizarEntradasSalidas()
        {

            int numEnt = (int)this.numericUpDown1.Value;
            int numSal = (int)this.numericUpDownNumeroSalidas.Value;

            foreach (Control c in this.panelEntradas.Controls)
            {
                this.Controls.Remove(c);
            }
            this.panelEntradas.Controls.Clear();
            this.dataGridViewDatosEntrenamiento.Columns.Clear();
            this.dataGridViewSalidasPrueba.Columns.Clear();
            for (int i = 0; i < numSal; i++)
            {
                AddOutputColumn(i);
                AddResultColumn(i);
            }

            for (int j = 0; j < numEnt; j++)
            {
                AddInputColumn(j);
                addLabel(this.panelEntradas, 0, j, "x", 0);
                addTextBox(this.panelEntradas, 0, j, "x", 0);
            }

        }
        private void actualizarPesos()
        {

            int numEnt = (int)this.numericUpDown1.Value;
            int numSal = (int)this.numericUpDownNumeroSalidas.Value;
            Point np = new Point(10, 10);

            foreach (Control c in this.panelPesos.Controls)
            {
                this.Controls.Remove(c);
            }
            this.panelPesos.Controls.Clear();
            for (int i = 0; i < numSal; i++)
            {
                for (int j = 0; j < numEnt; j++)
                {
                    addLabel(this.panelPesos, i, j, "w", numEnt * i);
                    addTextBox(this.panelPesos, i, j, "wi", numEnt * i);
                    addTextBox2(this.panelPesos, i, j, "wo", numEnt * i);
                }
            }
        }
        private void addLabel(Panel p, int i, int j, string name, int controlCont, int leftMargin = -1)
        {
            Label lastLabel = new Label();
            Point np = new Point(leftMargin, 20 + 30 * (j + controlCont));
            lastLabel.Text = name + i.ToString() + j.ToString();
            lastLabel.Name = "label" + name + i.ToString() + j.ToString();
            lastLabel.Location = np;
            lastLabel.AutoSize = true;
            if (!p.Controls.Contains(lastLabel))
                p.Controls.Add(lastLabel);
        }
        private void addTextBox(Panel p, int i, int j, string name, int controlCont,int leftMargin = 30)
        {
            TextBox lastTextBox = new TextBox();
            Point np = new Point(leftMargin, 17 + 30 * (j + controlCont));
            lastTextBox.Text = "0";
            lastTextBox.Name = "textBox" + name + i.ToString() + j.ToString();
            lastTextBox.Location = np;
            lastTextBox.Size -= new Size(70, 0);
            if (!p.Controls.Contains(lastTextBox))
                p.Controls.Add(lastTextBox);
        }
        private void addTextBox2(Panel p, int i, int j, string name, int controlCont, int leftMargin = 60)
        {
            TextBox lastTextBox = new TextBox();
            Point np = new Point(leftMargin, 17 + 30 * (j + controlCont));
            lastTextBox.Text = "NA";
            lastTextBox.Name = "textBox" + name + i.ToString() + j.ToString();
            lastTextBox.Location = np;
            lastTextBox.Size -= new Size(70, 0);
            lastTextBox.ReadOnly = true;
            if (!p.Controls.Contains(lastTextBox))
                p.Controls.Add(lastTextBox);
        }
        private void AddInputColumn(int i)
        {
            int index = this.dataGridViewDatosEntrenamiento.Columns.Add("x" + i.ToString(), "x" + i.ToString());
            this.dataGridViewDatosEntrenamiento.Columns[index].Width = 30;
        }
        private void AddOutputColumn(int i)
        {
            int index = this.dataGridViewDatosEntrenamiento.Columns.Add("y" + i.ToString(), "y" + i.ToString());
            this.dataGridViewDatosEntrenamiento.Columns[index].Width = 30;
        }

        private void AddResultColumn(int i)
        {
            int index = this.dataGridViewSalidasPrueba.Columns.Add("y" + i.ToString(), "y" + i.ToString());
            this.dataGridViewSalidasPrueba.Columns[index].Width = 30;
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
                int numNeuronas = NH.Count;
                int numEntradas = ((int)this.numericUpDown1.Value);
                int numIteraciones = Convert.ToInt32(this.textBoxIteraciones.Text);
                double[] exito = new double[numNeuronas];
                double[] auxExito = new double[numNeuronas];
                this.maskedTextBoxExito.Text = "";
                List<NeuronaHebiana> auxClone = new List<NeuronaHebiana>();
                foreach (NeuronaHebiana nh in NH)
                {
                    auxClone.Add(nh.Clone());
                }
                for (int i = 0; i < numNeuronas; i++)
                {
                    double[] nuevosPesos = obtenerPesos(i);
                    double[] nuevosBias = obtenerBias();
                    NH[i].Init(nuevosPesos, nuevosBias[i]);
                    for (int iteraciones = 0; iteraciones < numIteraciones; iteraciones++)
                    {
                        if (iteraciones != 0)
                        {
                            nuevosPesos = GenerarPesos(i, numEntradas);
                            nuevosBias = GenerarBias();
                            NH[i].Init(nuevosPesos, nuevosBias[i]);
                        }
                        foreach (DataGridViewRow r in this.dataGridViewDatosEntrenamiento.Rows)
                        {
                            if (r.IsNewRow)
                            {
                                continue;
                            }

                            double[] epochY = obtenerEpochY(r);
                            double[] epochX = obtenerEpochX(r, epochY.Length);

                            NH[i].NuevaEpoca(epochX, epochY[i]);
                        }

                        exito[i] = ObtenerSalidas(i);
                        if (exito[i] > auxExito[i])
                        {
                            auxExito[i] = exito[i];
                            auxClone[i] = NH[i].Clone();

                            if (auxExito[i] == 100)
                            {
                                break;
                            }
                        }
                    }

                    this.maskedTextBoxExito.Text += auxExito[i].ToString() + " ";
                    insertarNuevosPesos(auxClone[i].ObtenerPesosFinales(), i);
                    insertarNuevoBias(auxClone[i].ObtenerBiasFinal(), i);
                    rellenarPesosExitosos(auxClone[i].ObtenerPesosIniciales(), i);
                    rellenarBiasExitoso(auxClone[i].ObtenerBiasInicial(), i);
                    NH[i] = auxClone[i].Clone();
                }

            }

            else if (this.radioButtonPerceptron.Checked)
            {
                int numNeuronas = NP.Count;
                double[] auxExito = new double[numNeuronas];
                this.maskedTextBoxExito.Text = "";
                for (int i = 0; i < numNeuronas; i++)
                {
                    NP[i].Init(obtenerPesos(i), Convert.ToDouble(this.textBoxTheta.Text),EsContinua:true);
                    for (int j = 0; j < Convert.ToDouble(this.textBoxIteraciones.Text); j++)
                    {
                        foreach (DataGridViewRow r in this.dataGridViewDatosEntrenamiento.Rows)
                        {
                            if (r.IsNewRow)
                            {
                                continue;
                            }

                            double[] epochY = obtenerEpochY(r);
                            double[] epochX = obtenerEpochX(r, epochY.Length);

                            NP[i].NuevaEpoca(epochX, epochY[i]);
                        }

                    }
                    auxExito[i] = ObtenerSalidas(i);
                    this.maskedTextBoxExito.Text += auxExito[i].ToString() + " ";
                    insertarNuevosPesos(NP[i].ObtenerPesosFinales(), i);
                }
            }
        }

        private double[] obtenerEpochX(DataGridViewRow r,int numEntradas)
        {

            int lenX = 0;

            foreach (DataGridViewColumn c in this.dataGridViewDatosEntrenamiento.Columns)
            {
                if (c.Name.Contains("x"))
                {
                    lenX++;
                }
            }

            double[] epochX = new double[lenX];

            for (int k = 0; k < lenX; k++)
            {
                epochX[k] = Convert.ToDouble(r.Cells[k+numEntradas].Value);
            }

            return epochX;
        }
        private double[] obtenerEpochY(DataGridViewRow r)
        {
            int lenY = 0;

            foreach (DataGridViewColumn c in this.dataGridViewDatosEntrenamiento.Columns)
            {
                if (c.Name.Contains("y"))
                {
                    lenY++;
                }
            }

            double[] epochY = new double[lenY];

            for (int k = 0; k < lenY; k++)
            {
                epochY[k] = Convert.ToDouble(r.Cells[k].Value);
            }

            return epochY;
        }
        private double[] GenerarPesos(int numNeurona,int numEntradas)
        {
            double[] pesos = new double[numEntradas];
            int i = 0;
            foreach (Control tb in panelPesos.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name.Contains("wi"+ numNeurona.ToString()))
                    {
                        double maxNumber = Convert.ToDouble(this.textBoxRangoMax.Text);
                        double randNum = (RNG.Next() % (2 * maxNumber) - (maxNumber));
                        tb.Text = randNum.ToString();
                        pesos[i] = randNum;
                        i++;
                    }
                }
            }
            return pesos;
        }
        private void rellenarPesosExitosos(double[] pesos, int numNeurona)
        {
            int i = 0;
            foreach (Control tb in panelPesos.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name.Contains("wi"+numNeurona.ToString()))
                    {
                        tb.Text = pesos[i].ToString();
                        i++;
                    }
                }
            }
        }
        private double[] GenerarBias()
        {


            double maxNumber = Convert.ToDouble(this.textBoxRangoMax.Text);
            double[] resultingBias = new double[this.panelBias.Controls.Count/3];

            int i = 0;
            foreach (Control tb in this.panelBias.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name.Contains("biasI"))
                    {
                        resultingBias[i] = (RNG.Next() % (2 * maxNumber) - (maxNumber));
                        tb.Text = resultingBias[i].ToString();
                        i++;
                    }
                }
            }

            return resultingBias;
        }
        private void rellenarBiasExitoso(double bias,int numBias )
        {
            int i = 0;
            foreach (Control tb in this.panelBias.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name.Contains("biasI"+numBias.ToString()))
                    {
                        tb.Text = bias.ToString();
                        i++;
                    }
                }
            }
        }
        private double[] obtenerPesos(int numNeurona)
        {
            List<double> pesos = new List<double>();
            int i = 0;
            foreach (Control tb in panelPesos.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name.Contains("wi"+ numNeurona.ToString()))
                    {
                        pesos.Add(Convert.ToDouble(tb.Text));
                        i++;
                    }
                }
            }
            return pesos.ToArray();
        }
        private void insertarNuevosPesos(double[] pesos,int numNeurona)
        {
            int i = 0;
            foreach (Control tb in panelPesos.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name.Contains("wo"+numNeurona.ToString()))
                    {
                        tb.Text = pesos[i].ToString();
                        i++;
                    }
                }
            }
        }
        private void insertarNuevoBias(double bias,int numBias)
        {
            int i = 0;
            foreach (Control tb in this.panelBias.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name.Contains("biasO"+ numBias.ToString()))
                    {
                        tb.Text = bias.ToString();
                        i++;
                    }
                }
            }
        }
        private double[] obtenerBias()
        {
            double[] bias = new double[numeroDeTextBox(this.panelBias) / 2];
            int i = 0;
            foreach (Control tb in this.panelBias.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name.Contains("biasI"))
                    {
                        bias[i] = Convert.ToDouble(tb.Text);
                        i++;
                    }
                }
            }
            return bias;
        }
        private void buttonEvaluar_Click(object sender, EventArgs e)
        {
            this.textBoxSalida.Text = "";
            int numNeuronas = (int)this.numericUpDownNumeroSalidas.Value;
            for (int i = 0; i < numNeuronas; i++)
            {
                if (this.radioButtonHebiana.Checked)
                    this.textBoxSalida.Text += NH[i].obtenerSalida(ObtenerEntradas()).ToString() + " ,";
                else
                    this.textBoxSalida.Text += NP[i].obtenerSalida(ObtenerEntradas()).ToString() + " ,";
            }
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
        private double ObtenerSalidas(int numSalida)
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

                    double[] epochY = obtenerEpochY(r);
                    double[] epochX = obtenerEpochX(r,epochY.Length);

                    double correctValue = NH[numSalida].obtenerSalida(epochX);
                    double expectedValue = obtenerEpochY(r)[numSalida];
                    bool isCorrect = correctValue == expectedValue;
                    this.dataGridViewSalidasPrueba.Rows[j].Cells[numSalida].Value = isCorrect.ToString();
                    if (isCorrect)
                    {
                        isTrained += 100.0 / (this.dataGridViewDatosEntrenamiento.RowCount - 1);
                        if (isTrained == 100)
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
                double err = Convert.ToDouble(this.textBoxError.Text);
                foreach (DataGridViewRow r in this.dataGridViewDatosEntrenamiento.Rows)
                {
                    if (r.IsNewRow)
                    {
                        continue;
                    }

                    double[] epochY = obtenerEpochY(r);
                    double[] epochX = obtenerEpochX(r, epochY.Length);

                    double correctValue = NP[numSalida].obtenerSalida(epochX);
                    double expectedValue = obtenerEpochY(r)[numSalida];
                    bool isCorrect = err > Math.Abs(correctValue - expectedValue);
                    this.dataGridViewSalidasPrueba.Rows[j].Cells[numSalida].Value = isCorrect.ToString();
                    if (isCorrect)
                    {
                        isTrained += 100.0 / (this.dataGridViewDatosEntrenamiento.RowCount - 1);
                        if (isTrained == 100)
                        {
                            return isTrained;
                        }
                    }

                    j++;
                }
                return isTrained;
            
            }
            return isTrained;
        }
        private void dataGridViewDatosEntrenamiento_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (this.dataGridViewSalidasPrueba.Columns.Count > 0)
            {
                int ind = this.dataGridViewSalidasPrueba.Rows.Add();
                this.dataGridViewSalidasPrueba.Rows[ind].Height = 15;
            }
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
            int numEntradas = 0;
            int numSalidas = 0;
            foreach (object elem in ll.First())
            {
                if (elem.ToString().Contains("x"))
                {
                    numEntradas++;
                }
                else if (elem.ToString().Contains("y"))
                {
                    numSalidas++;
                }
            }
            ll.Remove(ll.First());
            this.numericUpDown1.Value = numEntradas;
            this.numericUpDownNumeroSalidas.Value = numSalidas;
            actualizarEntradasSalidas();
            foreach (List<string> l in ll)
            {
                int r = this.dataGridViewDatosEntrenamiento.Rows.Add();
                for (int i = 0; i < this.dataGridViewDatosEntrenamiento.ColumnCount; i++)
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
            foreach (Control tb in this.panelBias.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name.Contains("biasI"))
                    {
                        tb.Text = "0";
                    }
                }
            }
        }

        private void numericUpDownNumeroSalidas_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownNumeroSalidas.Value < 1)
            {
                this.numericUpDownNumeroSalidas.Value = 1;
            }

            actualizarControles();
            actualizarPesos();
            ActualizarNumeroDeNeuronas();
            actualizarNumeroDeBias();
        }

        private void ActualizarNumeroDeNeuronas()
        {
            this.NP.Clear();
            this.NH.Clear();
            for (int i = 0; i < this.numericUpDownNumeroSalidas.Value; i++)
            {
                this.NP.Add(new NeuronaPerceptron());
                this.NH.Add(new NeuronaHebiana());
            }
        }

        private void actualizarNumeroDeBias()
        {
            int numSal = (int)this.numericUpDownNumeroSalidas.Value;

            foreach (Control c in this.panelBias.Controls)
            {
                this.Controls.Remove(c);
            }
            this.panelBias.Controls.Clear();

            for (int i = 0; i < numSal; i++)
            {
                addLabel(this.panelBias, 0, i, "bias", 0);
                addTextBox(this.panelBias, 0, i, "biasI", 0,37);
                addTextBox2(this.panelBias, 0, i, "biasO", 0, 68);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
