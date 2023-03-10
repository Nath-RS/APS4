using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Aps
{
    public partial class frmCrud : Form
    {
        public frmCrud()
        {
            InitializeComponent();
        }
        RegraNegocio auxRegraNegocio = null;
        Arquivo auxArquivo = null;
        Stopwatch stopwatch = new Stopwatch();


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NodeUserGrid()
        {
            DgvRelatorio.Columns[0].Visible = true;
            DgvRelatorio.Columns[1].Visible = true;
            DgvRelatorio.Columns[2].Visible = true;
            DgvRelatorio.Columns[3].Visible = true;
            DgvRelatorio.Columns[4].Visible = true;
            DgvRelatorio.Columns[5].Visible = false;
            DgvRelatorio.Columns[6].Visible = false;

            DgvRelatorio.Columns[0].Width = 40;
            DgvRelatorio.Columns[1].Width = 100;
            DgvRelatorio.Columns[2].Width = 130;
            DgvRelatorio.Columns[3].Width = 170;
            DgvRelatorio.Columns[4].Width = 50;

            DgvRelatorio.Columns[0].ReadOnly = true;

            DgvRelatorio.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvRelatorio.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvRelatorio.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvRelatorio.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvRelatorio.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DgvRelatorio.Columns[0].HeaderText = "ID";
            DgvRelatorio.Columns[1].HeaderText = "Data registro";
            DgvRelatorio.Columns[2].HeaderText = "Nome do Fiscal";
            DgvRelatorio.Columns[3].HeaderText = "Crime";
            DgvRelatorio.Columns[4].HeaderText = "Região";

            DgvRelatorio.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8.75F, FontStyle.Bold);
            DgvRelatorio.ScrollBars = ScrollBars.Vertical;
            DgvRelatorio.RowHeadersVisible = false;
            DgvRelatorio.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvRelatorio.RowHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            DgvRelatorio.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }


        private void setRegDGV(List<Registro> Ordenado)
        {
            auxRegraNegocio = new RegraNegocio();
            auxArquivo = new Arquivo();
            DgvRelatorio.DataSource = null;
            DgvRelatorio.Rows.Clear();
            DgvRelatorio.Refresh();
            auxArquivo.LocalArquivo = txtLocalFile.Text;
            DgvRelatorio.DataSource = Ordenado;
        }

        private void OrderBuckets(List<Registro> OrdenaReg)
        {
            try
            {
                List<Registro>[] Buckets = new List<Registro>[DgvRelatorio.Rows.Count];
                Registro auxReg = null;

                if (DgvRelatorio.Rows.Count <= 0)
                {
                    return;
                }


                for (int i = 0; i < DgvRelatorio.Rows.Count; i++)
                {
                    Buckets[i] = new List<Registro>();

                }
                for (int i = 0; i < DgvRelatorio.Rows.Count; i++)
                {
                    
                    auxReg = new Registro();

                    auxReg.IdRegistro = Convert.ToInt32(DgvRelatorio.Rows[i].Cells[0].Value);
                    auxReg.dataRegistro = DgvRelatorio.Rows[i].Cells[1].Value.ToString();
                    auxReg.nomeFiscal = DgvRelatorio.Rows[i].Cells[2].Value.ToString();
                    auxReg.Crime = DgvRelatorio.Rows[i].Cells[3].Value.ToString();
                    auxReg.regiao = DgvRelatorio.Rows[i].Cells[4].Value.ToString();

                    float idx = (auxReg.IdRegistro /10);
                    Buckets[(int)idx].Add(auxReg);
                }

                for (int i = 0; i < DgvRelatorio.Rows.Count/10; i++)
                {
                    Buckets[i] = auxRegraNegocio.OrdenarBucketsRegistros(Buckets[i]);
                }

                for (int i = 0; i < DgvRelatorio.Rows.Count; i++)
                {
                    for (int j = 0; j < Buckets[i].Count; j++)
                    {
                        OrdenaReg.Add(Buckets[i][j]);
                    }
                }
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void OrderInsertion(List<Registro> OrdenaReg)
        {
            Registro auxReg = null; try
            {
                for (int i = 0; i < DgvRelatorio.Rows.Count; i++)
                {
                    auxReg = new Registro();
                    auxReg.IdRegistro = Convert.ToInt32(DgvRelatorio.Rows[i].Cells[0].Value);
                    auxReg.dataRegistro = DgvRelatorio.Rows[i].Cells[1].Value.ToString();
                    auxReg.nomeFiscal = DgvRelatorio.Rows[i].Cells[2].Value.ToString();
                    auxReg.Crime = DgvRelatorio.Rows[i].Cells[3].Value.ToString();
                    auxReg.regiao = DgvRelatorio.Rows[i].Cells[4].Value.ToString();

                    OrdenaReg.Add(auxReg);
                }

                OrdenaReg = auxRegraNegocio.OrdenarInsertionRegistros(OrdenaReg);
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void OrderSelection(List<Registro> OrdenaReg)
        {
            try
            {
                Registro auxReg = null;

                for (int i = 0; i < DgvRelatorio.Rows.Count; i++)
                {
                    auxReg = new Registro();
                    auxReg.IdRegistro = Convert.ToInt32(DgvRelatorio.Rows[i].Cells[0].Value);
                    auxReg.dataRegistro = DgvRelatorio.Rows[i].Cells[1].Value.ToString();
                    auxReg.nomeFiscal = DgvRelatorio.Rows[i].Cells[2].Value.ToString();
                    auxReg.Crime = DgvRelatorio.Rows[i].Cells[3].Value.ToString();
                    auxReg.regiao = DgvRelatorio.Rows[i].Cells[4].Value.ToString();

                    OrdenaReg.Add(auxReg);
                }

                OrdenaReg = auxRegraNegocio.OrdenarSelectionRegistros(OrdenaReg);
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TypeArq(Arquivo auxarqlog)
        {
            if (rdbtnAleatorio.Checked)
            {
                auxarqlog.tipo = "Aleatorio";
            }
            else if (rdbtnSemiAleatorio.Checked)
            {
                auxarqlog.tipo = "Semi-Aleatorio";
            }
            else if (rdbtnOrdenado.Checked)
            {
                auxarqlog.tipo = "Ordenado";
            }
        }
        private void btnGetInformation_Click(object sender, EventArgs e)
        {
            int indexfile;

            auxRegraNegocio = new RegraNegocio();
            List<Registro> txtDados = new List<Registro>();
            auxArquivo = new Arquivo();

            auxArquivo.LocalArquivo = txtLocalFile.Text;
            indexfile = auxArquivo.LocalArquivo.Length;

            if (String.IsNullOrEmpty(txtLocalFile.Text))
            {
                MessageBox.Show("Caminho não informado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (auxArquivo.LocalArquivo.Substring(indexfile - 4, 4) != ".txt" | !File.Exists(auxArquivo.LocalArquivo))
            {
                MessageBox.Show("Formato de Arquivo ou Caminho inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DgvRelatorio.DataSource = null;
                DgvRelatorio.Rows.Clear();
                DgvRelatorio.Refresh();
                txtDados = auxRegraNegocio.SelectRegistros(auxArquivo);
                DgvRelatorio.DataSource = txtDados;

                if (auxArquivo.Status == "OK" && txtDados[0].Status == "OK")
                {
                    this.NodeUserGrid();
                    gpbArquivo.Enabled = true;
                    btnSave.Enabled = true;
                    btnDesordenar.Enabled = true;
                    txtResultOrder.Text = "0";
                }

            }


        }
        private void btnProcurarArquivo_Click(object sender, EventArgs e)
        {
            btnDesordenar.Enabled = false;
            btnOrdenar.Enabled = false;
            gpbMetodos.Enabled = false;
            gpbArquivo.Enabled = false;

            rdbtnAleatorio.Checked = false;
            rdbtnOrdenado.Checked = false;
            rdbtnSemiAleatorio.Checked = false;

            rdbtnInsertionSort.Checked = false;
            rdbtnBucketSort.Checked = false;
            rdbtnSelectionSort.Checked = false;


            auxRegraNegocio = new RegraNegocio();
            auxArquivo = new Arquivo();
            ofdArqtxt.ShowDialog();

            auxArquivo.LocalArquivo = ofdArqtxt.FileName;
            txtLocalFile.Text = ofdArqtxt.FileName;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            List<Registro> OrdenarRegistro = new List<Registro>();
            auxArquivo = new Arquivo();
            stopwatch.Reset();
            if (rdbtnBucketSort.Checked)
            {
                
                stopwatch.Start();
                this.OrderBuckets(OrdenarRegistro);
                this.setRegDGV(OrdenarRegistro);
                this.NodeUserGrid();
                auxArquivo.NomeArquivo = "Bucket";

            }
            else if (rdbtnInsertionSort.Checked)
            {
                stopwatch.Start();
                this.OrderInsertion(OrdenarRegistro);
                this.setRegDGV(OrdenarRegistro);
                this.NodeUserGrid();
                auxArquivo.NomeArquivo = "Insertion";
            }
            else if (rdbtnSelectionSort.Checked)
            {
                stopwatch.Start();
                this.OrderSelection(OrdenarRegistro);
                this.setRegDGV(OrdenarRegistro);
                this.NodeUserGrid();
                auxArquivo.NomeArquivo = "Selection";
            }
            DgvRelatorio.Refresh();
            DgvRelatorio.Update();

            stopwatch.Stop();
            txtResultOrder.Text = (stopwatch.ElapsedMilliseconds / 1000.00).ToString("F3");

            auxArquivo.LocalArquivo = txtLocalFile.Text;
            auxArquivo.msg = txtResultOrder.Text + " seconds";
            this.TypeArq(auxArquivo);
            auxRegraNegocio.OrdenaArqlog(auxArquivo,OrdenarRegistro);

            btnDesordenar.Enabled = false;
            btnOrdenar.Enabled = false;
            gpbMetodos.Enabled = false;

            rdbtnAleatorio.Checked = false;
            rdbtnOrdenado.Checked = false;
            rdbtnSemiAleatorio.Checked = false;

            rdbtnInsertionSort.Checked = false;
            rdbtnBucketSort.Checked = false;
            rdbtnSelectionSort.Checked = false;

            //if (OrdenarRegistro[0].Status == "OK")
            //{
            //    MessageBox.Show("Registros ordenados Com sucesso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            auxArquivo = new Arquivo();

            DialogResult WindowSave = (DialogResult) svfdArqtxt.ShowDialog();

            if(WindowSave == DialogResult.OK)
            {
                auxArquivo.LocalArquivo = svfdArqtxt.FileName;
                auxArquivo.conteudo = new string[DgvRelatorio.Rows.Count];

                string[] conteudo = new string[DgvRelatorio.Rows.Count];

                for (int i = 0; i < DgvRelatorio.Rows.Count; i++)
                {
                    auxArquivo.conteudo[i] = DgvRelatorio.Rows[i].Cells[0].Value.ToString() + ",";
                    auxArquivo.conteudo[i] = auxArquivo.conteudo[i] + DgvRelatorio.Rows[i].Cells[1].Value.ToString() + ",";
                    auxArquivo.conteudo[i] = auxArquivo.conteudo[i] + DgvRelatorio.Rows[i].Cells[2].Value.ToString() + ",";
                    auxArquivo.conteudo[i] = auxArquivo.conteudo[i] + DgvRelatorio.Rows[i].Cells[3].Value.ToString() + ",";
                    auxArquivo.conteudo[i] = auxArquivo.conteudo[i] + DgvRelatorio.Rows[i].Cells[4].Value.ToString() + ";";
                }

                auxRegraNegocio.SaveArquivotxt(auxArquivo);

                if (auxArquivo.Status != "OK")
                {
                    MessageBox.Show(auxArquivo.msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Arquivo Salvo com sucesso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
        private void btnDesordenar_Click(object sender, EventArgs e)
        {
            List<Registro> OrdenarRegistro = new List<Registro>();
            auxArquivo = new Arquivo();

            Registro auxReg = null;
            try
            {
                for (int i = 0; i < DgvRelatorio.Rows.Count; i++)
                {
                    auxReg = new Registro();
                    auxReg.IdRegistro = Convert.ToInt32(DgvRelatorio.Rows[i].Cells[0].Value);
                    auxReg.dataRegistro = DgvRelatorio.Rows[i].Cells[1].Value.ToString();
                    auxReg.nomeFiscal = DgvRelatorio.Rows[i].Cells[2].Value.ToString();
                    auxReg.Crime = DgvRelatorio.Rows[i].Cells[3].Value.ToString();
                    auxReg.regiao = DgvRelatorio.Rows[i].Cells[4].Value.ToString();

                    OrdenarRegistro.Add(auxReg);
                }

                OrdenarRegistro = auxRegraNegocio.DesordenaRegistros(OrdenarRegistro);

                btnSave.Enabled = true;
                this.setRegDGV(OrdenarRegistro);
                this.NodeUserGrid();

                DgvRelatorio.Refresh();
                DgvRelatorio.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbtnAleatorio_Click(object sender, EventArgs e)
        {
            gpbMetodos.Enabled = true;   
        }

        private void rdbtnSemiAleatorio_Click(object sender, EventArgs e)
        {
            gpbMetodos.Enabled = true;
        }

        private void rdbtnOrdenado_Click(object sender, EventArgs e)
        {
            gpbMetodos.Enabled = true;
        }

        private void rdbtnBucketSort_Click(object sender, EventArgs e)
        {
            btnDesordenar.Enabled = true;
            btnOrdenar.Enabled = true;
        }

        private void rdbtnInsertionSort_Click(object sender, EventArgs e)
        {
            btnDesordenar.Enabled = true;
            btnOrdenar.Enabled = true;
        }

        private void rdbtnSelectionSort_Click(object sender, EventArgs e)
        {
            btnDesordenar.Enabled = true;
            btnOrdenar.Enabled = true;
        }
    }
}
