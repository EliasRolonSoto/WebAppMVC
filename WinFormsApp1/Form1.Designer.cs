namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            cbTamañoPagina = new ComboBox();
            txtSearch = new TextBox();
            txtPageIndex = new TextBox();
            lblBusqueda = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(598, 312);
            dataGridView1.TabIndex = 0;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(396, 387);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 1;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(552, 387);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "Siguiente >";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // cbTamañoPagina
            // 
            cbTamañoPagina.FormattingEnabled = true;
            cbTamañoPagina.Items.AddRange(new object[] { "5", "10", "25", "50", "100" });
            cbTamañoPagina.Location = new Point(29, 40);
            cbTamañoPagina.Name = "cbTamañoPagina";
            cbTamañoPagina.Size = new Size(147, 23);
            cbTamañoPagina.TabIndex = 3;
            cbTamañoPagina.SelectedIndexChanged += cbTamañoPagina_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(29, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(188, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtPageIndex
            // 
            txtPageIndex.Location = new Point(495, 387);
            txtPageIndex.Name = "txtPageIndex";
            txtPageIndex.Size = new Size(40, 23);
            txtPageIndex.TabIndex = 5;
            txtPageIndex.TextChanged += txtPageIndex_TextChanged;
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Location = new Point(51, 395);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(0, 15);
            lblBusqueda.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBusqueda);
            Controls.Add(txtPageIndex);
            Controls.Add(txtSearch);
            Controls.Add(cbTamañoPagina);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAnterior;
        private Button btnSiguiente;
        private ComboBox cbTamañoPagina;
        private TextBox txtSearch;
        private TextBox txtPageIndex;
        private Label lblBusqueda;
    }
}