
namespace CRUD_Aps
{
    partial class frmCrud
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLocalFile = new System.Windows.Forms.TextBox();
            this.btnProcurarArquivo = new System.Windows.Forms.Button();
            this.btnExtrair = new System.Windows.Forms.Button();
            this.DgvRelatorio = new System.Windows.Forms.DataGridView();
            this.ofdArqtxt = new System.Windows.Forms.OpenFileDialog();
            this.gpbMetodos = new System.Windows.Forms.GroupBox();
            this.rdbtnSelectionSort = new System.Windows.Forms.RadioButton();
            this.rdbtnInsertionSort = new System.Windows.Forms.RadioButton();
            this.rdbtnBucketSort = new System.Windows.Forms.RadioButton();
            this.lblTitleSeconds = new System.Windows.Forms.Label();
            this.txtResultOrder = new System.Windows.Forms.TextBox();
            this.lblTitleTimeResult = new System.Windows.Forms.Label();
            this.tmrResult = new System.Windows.Forms.Timer(this.components);
            this.svfdArqtxt = new System.Windows.Forms.SaveFileDialog();
            this.btnDesordenar = new System.Windows.Forms.Button();
            this.gpbArquivo = new System.Windows.Forms.GroupBox();
            this.rdbtnOrdenado = new System.Windows.Forms.RadioButton();
            this.rdbtnSemiAleatorio = new System.Windows.Forms.RadioButton();
            this.rdbtnAleatorio = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelatorio)).BeginInit();
            this.gpbMetodos.SuspendLayout();
            this.gpbArquivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(664, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(22, 21);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.lblTitle);
            this.pnlControl.Controls.Add(this.btnExit);
            this.pnlControl.Location = new System.Drawing.Point(-2, -1);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(695, 29);
            this.pnlControl.TabIndex = 34;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrdenar.Enabled = false;
            this.btnOrdenar.FlatAppearance.BorderSize = 0;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Location = new System.Drawing.Point(540, 290);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(124, 24);
            this.btnOrdenar.TabIndex = 36;
            this.btnOrdenar.Text = "Iniciar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(540, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 25);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLocalFile
            // 
            this.txtLocalFile.Location = new System.Drawing.Point(23, 48);
            this.txtLocalFile.Name = "txtLocalFile";
            this.txtLocalFile.Size = new System.Drawing.Size(491, 23);
            this.txtLocalFile.TabIndex = 39;
            // 
            // btnProcurarArquivo
            // 
            this.btnProcurarArquivo.BackColor = System.Drawing.Color.Gray;
            this.btnProcurarArquivo.FlatAppearance.BorderSize = 0;
            this.btnProcurarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarArquivo.Location = new System.Drawing.Point(523, 48);
            this.btnProcurarArquivo.Name = "btnProcurarArquivo";
            this.btnProcurarArquivo.Size = new System.Drawing.Size(77, 23);
            this.btnProcurarArquivo.TabIndex = 40;
            this.btnProcurarArquivo.Text = "Procurar";
            this.btnProcurarArquivo.UseVisualStyleBackColor = false;
            this.btnProcurarArquivo.Click += new System.EventHandler(this.btnProcurarArquivo_Click);
            // 
            // btnExtrair
            // 
            this.btnExtrair.BackColor = System.Drawing.Color.Gray;
            this.btnExtrair.FlatAppearance.BorderSize = 0;
            this.btnExtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtrair.Location = new System.Drawing.Point(600, 48);
            this.btnExtrair.Name = "btnExtrair";
            this.btnExtrair.Size = new System.Drawing.Size(77, 23);
            this.btnExtrair.TabIndex = 41;
            this.btnExtrair.Text = "Extrair";
            this.btnExtrair.UseVisualStyleBackColor = false;
            this.btnExtrair.Click += new System.EventHandler(this.btnGetInformation_Click);
            // 
            // DgvRelatorio
            // 
            this.DgvRelatorio.AllowUserToAddRows = false;
            this.DgvRelatorio.AllowUserToDeleteRows = false;
            this.DgvRelatorio.AllowUserToResizeColumns = false;
            this.DgvRelatorio.AllowUserToResizeRows = false;
            this.DgvRelatorio.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRelatorio.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvRelatorio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvRelatorio.Location = new System.Drawing.Point(24, 126);
            this.DgvRelatorio.MultiSelect = false;
            this.DgvRelatorio.Name = "DgvRelatorio";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRelatorio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRelatorio.Size = new System.Drawing.Size(501, 278);
            this.DgvRelatorio.TabIndex = 42;
            // 
            // ofdArqtxt
            // 
            this.ofdArqtxt.FileName = "ofdArqtxt";
            this.ofdArqtxt.Filter = "txt files (*.txt)|*.txt";
            this.ofdArqtxt.Title = "Procurar arquivo";
            // 
            // gpbMetodos
            // 
            this.gpbMetodos.Controls.Add(this.rdbtnSelectionSort);
            this.gpbMetodos.Controls.Add(this.rdbtnInsertionSort);
            this.gpbMetodos.Controls.Add(this.rdbtnBucketSort);
            this.gpbMetodos.Enabled = false;
            this.gpbMetodos.Location = new System.Drawing.Point(533, 129);
            this.gpbMetodos.Name = "gpbMetodos";
            this.gpbMetodos.Size = new System.Drawing.Size(144, 153);
            this.gpbMetodos.TabIndex = 43;
            this.gpbMetodos.TabStop = false;
            this.gpbMetodos.Text = "Métodos de Ordenação";
            // 
            // rdbtnSelectionSort
            // 
            this.rdbtnSelectionSort.AutoSize = true;
            this.rdbtnSelectionSort.Location = new System.Drawing.Point(7, 112);
            this.rdbtnSelectionSort.Name = "rdbtnSelectionSort";
            this.rdbtnSelectionSort.Size = new System.Drawing.Size(113, 20);
            this.rdbtnSelectionSort.TabIndex = 2;
            this.rdbtnSelectionSort.Text = "SelectionSort";
            this.rdbtnSelectionSort.UseVisualStyleBackColor = true;
            this.rdbtnSelectionSort.Click += new System.EventHandler(this.rdbtnSelectionSort_Click);
            // 
            // rdbtnInsertionSort
            // 
            this.rdbtnInsertionSort.AutoSize = true;
            this.rdbtnInsertionSort.Location = new System.Drawing.Point(7, 73);
            this.rdbtnInsertionSort.Name = "rdbtnInsertionSort";
            this.rdbtnInsertionSort.Size = new System.Drawing.Size(113, 20);
            this.rdbtnInsertionSort.TabIndex = 1;
            this.rdbtnInsertionSort.Text = "InsertionSort";
            this.rdbtnInsertionSort.UseVisualStyleBackColor = true;
            this.rdbtnInsertionSort.Click += new System.EventHandler(this.rdbtnInsertionSort_Click);
            // 
            // rdbtnBucketSort
            // 
            this.rdbtnBucketSort.AutoSize = true;
            this.rdbtnBucketSort.Location = new System.Drawing.Point(7, 37);
            this.rdbtnBucketSort.Name = "rdbtnBucketSort";
            this.rdbtnBucketSort.Size = new System.Drawing.Size(98, 20);
            this.rdbtnBucketSort.TabIndex = 0;
            this.rdbtnBucketSort.Text = "BucketSort";
            this.rdbtnBucketSort.UseVisualStyleBackColor = true;
            this.rdbtnBucketSort.Click += new System.EventHandler(this.rdbtnBucketSort_Click);
            // 
            // lblTitleSeconds
            // 
            this.lblTitleSeconds.AutoSize = true;
            this.lblTitleSeconds.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTitleSeconds.Location = new System.Drawing.Point(307, 414);
            this.lblTitleSeconds.Name = "lblTitleSeconds";
            this.lblTitleSeconds.Size = new System.Drawing.Size(15, 16);
            this.lblTitleSeconds.TabIndex = 44;
            this.lblTitleSeconds.Text = "s";
            // 
            // txtResultOrder
            // 
            this.txtResultOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultOrder.Enabled = false;
            this.txtResultOrder.Location = new System.Drawing.Point(174, 414);
            this.txtResultOrder.Name = "txtResultOrder";
            this.txtResultOrder.Size = new System.Drawing.Size(133, 16);
            this.txtResultOrder.TabIndex = 45;
            this.txtResultOrder.Text = "0";
            this.txtResultOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTitleTimeResult
            // 
            this.lblTitleTimeResult.AutoSize = true;
            this.lblTitleTimeResult.Location = new System.Drawing.Point(29, 414);
            this.lblTitleTimeResult.Name = "lblTitleTimeResult";
            this.lblTitleTimeResult.Size = new System.Drawing.Size(143, 16);
            this.lblTitleTimeResult.TabIndex = 46;
            this.lblTitleTimeResult.Text = "Tempo de Execução :";
            // 
            // tmrResult
            // 
            this.tmrResult.Interval = 1000;
            // 
            // svfdArqtxt
            // 
            this.svfdArqtxt.DefaultExt = "txt";
            this.svfdArqtxt.Filter = "txt files (*.txt)|*.txt";
            this.svfdArqtxt.Title = "Salvar como";
            // 
            // btnDesordenar
            // 
            this.btnDesordenar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDesordenar.Enabled = false;
            this.btnDesordenar.FlatAppearance.BorderSize = 0;
            this.btnDesordenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesordenar.Location = new System.Drawing.Point(540, 352);
            this.btnDesordenar.Name = "btnDesordenar";
            this.btnDesordenar.Size = new System.Drawing.Size(124, 24);
            this.btnDesordenar.TabIndex = 47;
            this.btnDesordenar.Text = "Desordenar";
            this.btnDesordenar.UseVisualStyleBackColor = false;
            this.btnDesordenar.Click += new System.EventHandler(this.btnDesordenar_Click);
            // 
            // gpbArquivo
            // 
            this.gpbArquivo.Controls.Add(this.rdbtnOrdenado);
            this.gpbArquivo.Controls.Add(this.rdbtnSemiAleatorio);
            this.gpbArquivo.Controls.Add(this.rdbtnAleatorio);
            this.gpbArquivo.Enabled = false;
            this.gpbArquivo.Location = new System.Drawing.Point(324, 77);
            this.gpbArquivo.Name = "gpbArquivo";
            this.gpbArquivo.Size = new System.Drawing.Size(353, 43);
            this.gpbArquivo.TabIndex = 48;
            this.gpbArquivo.TabStop = false;
            this.gpbArquivo.Text = "Tipo de Arquivo";
            // 
            // rdbtnOrdenado
            // 
            this.rdbtnOrdenado.AutoSize = true;
            this.rdbtnOrdenado.Location = new System.Drawing.Point(261, 17);
            this.rdbtnOrdenado.Name = "rdbtnOrdenado";
            this.rdbtnOrdenado.Size = new System.Drawing.Size(89, 20);
            this.rdbtnOrdenado.TabIndex = 2;
            this.rdbtnOrdenado.Text = "Ordenado";
            this.rdbtnOrdenado.UseVisualStyleBackColor = true;
            this.rdbtnOrdenado.Click += new System.EventHandler(this.rdbtnOrdenado_Click);
            // 
            // rdbtnSemiAleatorio
            // 
            this.rdbtnSemiAleatorio.AutoSize = true;
            this.rdbtnSemiAleatorio.Location = new System.Drawing.Point(122, 18);
            this.rdbtnSemiAleatorio.Name = "rdbtnSemiAleatorio";
            this.rdbtnSemiAleatorio.Size = new System.Drawing.Size(122, 20);
            this.rdbtnSemiAleatorio.TabIndex = 1;
            this.rdbtnSemiAleatorio.Text = "Semi-Aleatorio";
            this.rdbtnSemiAleatorio.UseVisualStyleBackColor = true;
            this.rdbtnSemiAleatorio.Click += new System.EventHandler(this.rdbtnSemiAleatorio_Click);
            // 
            // rdbtnAleatorio
            // 
            this.rdbtnAleatorio.AutoSize = true;
            this.rdbtnAleatorio.Location = new System.Drawing.Point(6, 18);
            this.rdbtnAleatorio.Name = "rdbtnAleatorio";
            this.rdbtnAleatorio.Size = new System.Drawing.Size(86, 20);
            this.rdbtnAleatorio.TabIndex = 0;
            this.rdbtnAleatorio.Text = "Aleatório";
            this.rdbtnAleatorio.UseVisualStyleBackColor = true;
            this.rdbtnAleatorio.Click += new System.EventHandler(this.rdbtnAleatorio_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(21, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 16);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "Programa de Testes de Métodos de Ordenação (PTMO)";
            // 
            // frmCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(692, 446);
            this.Controls.Add(this.gpbArquivo);
            this.Controls.Add(this.btnDesordenar);
            this.Controls.Add(this.lblTitleTimeResult);
            this.Controls.Add(this.lblTitleSeconds);
            this.Controls.Add(this.txtResultOrder);
            this.Controls.Add(this.gpbMetodos);
            this.Controls.Add(this.DgvRelatorio);
            this.Controls.Add(this.btnExtrair);
            this.Controls.Add(this.btnProcurarArquivo);
            this.Controls.Add(this.txtLocalFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.pnlControl);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crud";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelatorio)).EndInit();
            this.gpbMetodos.ResumeLayout(false);
            this.gpbMetodos.PerformLayout();
            this.gpbArquivo.ResumeLayout(false);
            this.gpbArquivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLocalFile;
        private System.Windows.Forms.Button btnProcurarArquivo;
        private System.Windows.Forms.Button btnExtrair;
        private System.Windows.Forms.DataGridView DgvRelatorio;
        private System.Windows.Forms.OpenFileDialog ofdArqtxt;
        private System.Windows.Forms.GroupBox gpbMetodos;
        private System.Windows.Forms.RadioButton rdbtnSelectionSort;
        private System.Windows.Forms.RadioButton rdbtnInsertionSort;
        private System.Windows.Forms.RadioButton rdbtnBucketSort;
        private System.Windows.Forms.Label lblTitleSeconds;
        private System.Windows.Forms.TextBox txtResultOrder;
        private System.Windows.Forms.Label lblTitleTimeResult;
        private System.Windows.Forms.Timer tmrResult;
        private System.Windows.Forms.SaveFileDialog svfdArqtxt;
        private System.Windows.Forms.Button btnDesordenar;
        private System.Windows.Forms.GroupBox gpbArquivo;
        private System.Windows.Forms.RadioButton rdbtnOrdenado;
        private System.Windows.Forms.RadioButton rdbtnSemiAleatorio;
        private System.Windows.Forms.RadioButton rdbtnAleatorio;
        private System.Windows.Forms.Label lblTitle;
    }
}

