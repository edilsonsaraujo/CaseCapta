using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransacaoControle;

namespace TransacaoForm
{
    public partial class TransacaoForm : Form
    {
        public TransacaoForm()
        {
            InitializeComponent();
            LimpaCampos();
                      
        }
        private void CarregaTabela(DataTable table)
        {
            TransacaoDataGridView.DataSource = null;
            TransacaoDataGridView.Columns.Clear();
            TransacaoDataGridView.Rows.Clear();
            TransacaoDataGridView.Refresh();

            foreach (DataColumn tableCol in table.Columns)
            {
                var col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                col.HeaderText = tableCol.Caption;
                col.ValueType = tableCol.DataType;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TransacaoDataGridView.Columns.Add(col);
            }
            
            foreach (DataRow tableRow in table.Rows)
                {
                    if (this.IsDisposed) break;
                    TransacaoDataGridView.Rows.Insert(0, tableRow.ItemArray);
                    Application.DoEvents();
            }
            
            TransacaoDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            this.Visible = true;
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void LimpaCampos()
        {
            cnpjtextBox.Text = "";
            bandeiraTextBox.Text = "";
            maquinaTextBox.Text = "";
            periodoNnumericUpDown.Value = -1;
            dataCheckBox.Checked = false;
            DataDateTimePicker.Enabled = false;
            CarregaTabela(new TransacaoControle.TransacaoControl().Inicializa());
        }

        private void dataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dataCheckBox.Checked) DataDateTimePicker.Enabled = true; else DataDateTimePicker.Enabled = false;
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {
            string cnpj = cnpjtextBox.Text;
            string maquina = maquinaTextBox.Text;
            string bandeira = bandeiraTextBox.Text;
            int periodo = decimal.ToInt32(periodoNnumericUpDown.Value);
            if (dataCheckBox.Checked)
            {
                CarregaTabela(new TransacaoControl().FiltroDataTable(cnpj, maquina, bandeira, periodo, DataDateTimePicker.Value));
            }
            else
            {
                CarregaTabela(new TransacaoControl().FiltroDataTable(cnpj, maquina, bandeira, periodo,null));
            }
        }

        
    }
}
