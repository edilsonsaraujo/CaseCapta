namespace TransacaoForm
{
    partial class TransacaoForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TransacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrosGroupBox = new System.Windows.Forms.GroupBox();
            this.cnpjlabel = new System.Windows.Forms.Label();
            this.cnpjtextBox = new System.Windows.Forms.TextBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.DataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bandeiraLabel = new System.Windows.Forms.Label();
            this.bandeiraTextBox = new System.Windows.Forms.TextBox();
            this.PeriodoLabel = new System.Windows.Forms.Label();
            this.periodoNnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LimparButton = new System.Windows.Forms.Button();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.dataCheckBox = new System.Windows.Forms.CheckBox();
            this.MaquinaLabel = new System.Windows.Forms.Label();
            this.maquinaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TransacaoDataGridView)).BeginInit();
            this.FiltrosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodoNnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TransacaoDataGridView
            // 
            this.TransacaoDataGridView.AllowUserToAddRows = false;
            this.TransacaoDataGridView.AllowUserToDeleteRows = false;
            this.TransacaoDataGridView.AllowUserToOrderColumns = true;
            this.TransacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransacaoDataGridView.Location = new System.Drawing.Point(12, 183);
            this.TransacaoDataGridView.Name = "TransacaoDataGridView";
            this.TransacaoDataGridView.ReadOnly = true;
            this.TransacaoDataGridView.Size = new System.Drawing.Size(776, 255);
            this.TransacaoDataGridView.TabIndex = 0;
            // 
            // FiltrosGroupBox
            // 
            this.FiltrosGroupBox.Controls.Add(this.maquinaTextBox);
            this.FiltrosGroupBox.Controls.Add(this.MaquinaLabel);
            this.FiltrosGroupBox.Controls.Add(this.dataCheckBox);
            this.FiltrosGroupBox.Controls.Add(this.filtrarButton);
            this.FiltrosGroupBox.Controls.Add(this.LimparButton);
            this.FiltrosGroupBox.Controls.Add(this.periodoNnumericUpDown);
            this.FiltrosGroupBox.Controls.Add(this.PeriodoLabel);
            this.FiltrosGroupBox.Controls.Add(this.bandeiraTextBox);
            this.FiltrosGroupBox.Controls.Add(this.bandeiraLabel);
            this.FiltrosGroupBox.Controls.Add(this.DataDateTimePicker);
            this.FiltrosGroupBox.Controls.Add(this.DataLabel);
            this.FiltrosGroupBox.Controls.Add(this.cnpjtextBox);
            this.FiltrosGroupBox.Controls.Add(this.cnpjlabel);
            this.FiltrosGroupBox.Location = new System.Drawing.Point(12, 14);
            this.FiltrosGroupBox.Name = "FiltrosGroupBox";
            this.FiltrosGroupBox.Size = new System.Drawing.Size(775, 160);
            this.FiltrosGroupBox.TabIndex = 1;
            this.FiltrosGroupBox.TabStop = false;
            this.FiltrosGroupBox.Text = "Filtros";
            // 
            // cnpjlabel
            // 
            this.cnpjlabel.AutoSize = true;
            this.cnpjlabel.Location = new System.Drawing.Point(6, 16);
            this.cnpjlabel.Name = "cnpjlabel";
            this.cnpjlabel.Size = new System.Drawing.Size(34, 13);
            this.cnpjlabel.TabIndex = 0;
            this.cnpjlabel.Text = "CNPJ";
            // 
            // cnpjtextBox
            // 
            this.cnpjtextBox.Location = new System.Drawing.Point(9, 32);
            this.cnpjtextBox.Name = "cnpjtextBox";
            this.cnpjtextBox.Size = new System.Drawing.Size(110, 20);
            this.cnpjtextBox.TabIndex = 1;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(6, 55);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(30, 13);
            this.DataLabel.TabIndex = 2;
            this.DataLabel.Text = "Data";
            // 
            // DataDateTimePicker
            // 
            this.DataDateTimePicker.CustomFormat = " ";
            this.DataDateTimePicker.Location = new System.Drawing.Point(9, 71);
            this.DataDateTimePicker.Name = "DataDateTimePicker";
            this.DataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DataDateTimePicker.TabIndex = 4;
            // 
            // bandeiraLabel
            // 
            this.bandeiraLabel.AutoSize = true;
            this.bandeiraLabel.Location = new System.Drawing.Point(353, 56);
            this.bandeiraLabel.Name = "bandeiraLabel";
            this.bandeiraLabel.Size = new System.Drawing.Size(117, 13);
            this.bandeiraLabel.TabIndex = 5;
            this.bandeiraLabel.Text = "Bandeira ou adquirente";
            // 
            // bandeiraTextBox
            // 
            this.bandeiraTextBox.Location = new System.Drawing.Point(356, 72);
            this.bandeiraTextBox.Name = "bandeiraTextBox";
            this.bandeiraTextBox.Size = new System.Drawing.Size(200, 20);
            this.bandeiraTextBox.TabIndex = 6;
            // 
            // PeriodoLabel
            // 
            this.PeriodoLabel.AutoSize = true;
            this.PeriodoLabel.Location = new System.Drawing.Point(353, 16);
            this.PeriodoLabel.Name = "PeriodoLabel";
            this.PeriodoLabel.Size = new System.Drawing.Size(104, 13);
            this.PeriodoLabel.TabIndex = 7;
            this.PeriodoLabel.Text = "Período da Consulta";
            // 
            // periodoNnumericUpDown
            // 
            this.periodoNnumericUpDown.Location = new System.Drawing.Point(356, 33);
            this.periodoNnumericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.periodoNnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.periodoNnumericUpDown.Name = "periodoNnumericUpDown";
            this.periodoNnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.periodoNnumericUpDown.TabIndex = 8;
            this.periodoNnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // LimparButton
            // 
            this.LimparButton.Location = new System.Drawing.Point(576, 110);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(75, 23);
            this.LimparButton.TabIndex = 9;
            this.LimparButton.Text = "Limpar";
            this.LimparButton.UseVisualStyleBackColor = true;
            this.LimparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // filtrarButton
            // 
            this.filtrarButton.Location = new System.Drawing.Point(657, 110);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(75, 23);
            this.filtrarButton.TabIndex = 10;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // dataCheckBox
            // 
            this.dataCheckBox.AutoSize = true;
            this.dataCheckBox.Location = new System.Drawing.Point(215, 71);
            this.dataCheckBox.Name = "dataCheckBox";
            this.dataCheckBox.Size = new System.Drawing.Size(15, 14);
            this.dataCheckBox.TabIndex = 11;
            this.dataCheckBox.UseVisualStyleBackColor = true;
            this.dataCheckBox.CheckedChanged += new System.EventHandler(this.dataCheckBox_CheckedChanged);
            // 
            // MaquinaLabel
            // 
            this.MaquinaLabel.AutoSize = true;
            this.MaquinaLabel.Location = new System.Drawing.Point(6, 94);
            this.MaquinaLabel.Name = "MaquinaLabel";
            this.MaquinaLabel.Size = new System.Drawing.Size(48, 13);
            this.MaquinaLabel.TabIndex = 12;
            this.MaquinaLabel.Text = "Máquina";
            // 
            // maquinaTextBox
            // 
            this.maquinaTextBox.Location = new System.Drawing.Point(6, 110);
            this.maquinaTextBox.Name = "maquinaTextBox";
            this.maquinaTextBox.Size = new System.Drawing.Size(148, 20);
            this.maquinaTextBox.TabIndex = 13;
            // 
            // TransacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FiltrosGroupBox);
            this.Controls.Add(this.TransacaoDataGridView);
            this.Name = "TransacaoForm";
            this.Text = "Relatorio de Transacao";
            ((System.ComponentModel.ISupportInitialize)(this.TransacaoDataGridView)).EndInit();
            this.FiltrosGroupBox.ResumeLayout(false);
            this.FiltrosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodoNnumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TransacaoDataGridView;
        private System.Windows.Forms.GroupBox FiltrosGroupBox;
        private System.Windows.Forms.DateTimePicker DataDateTimePicker;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.TextBox cnpjtextBox;
        private System.Windows.Forms.Label cnpjlabel;
        private System.Windows.Forms.Label PeriodoLabel;
        private System.Windows.Forms.TextBox bandeiraTextBox;
        private System.Windows.Forms.Label bandeiraLabel;
        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.Button LimparButton;
        private System.Windows.Forms.NumericUpDown periodoNnumericUpDown;
        private System.Windows.Forms.CheckBox dataCheckBox;
        private System.Windows.Forms.TextBox maquinaTextBox;
        private System.Windows.Forms.Label MaquinaLabel;
    }
}

