namespace ListaDeTarefas
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
            txtTarefa = new TextBox();
            txtAdicionar = new Button();
            lstTarefas = new ListBox();
            btnRemover = new Button();
            btnConcluir = new Button();
            SuspendLayout();
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(12, 12);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(237, 23);
            txtTarefa.TabIndex = 0;
            // 
            // txtAdicionar
            // 
            txtAdicionar.Location = new Point(12, 146);
            txtAdicionar.Name = "txtAdicionar";
            txtAdicionar.Size = new Size(75, 23);
            txtAdicionar.TabIndex = 1;
            txtAdicionar.Text = "Adicionar";
            txtAdicionar.UseVisualStyleBackColor = true;
            txtAdicionar.Click += txtAdicionar_Click;
            // 
            // lstTarefas
            // 
            lstTarefas.FormattingEnabled = true;
            lstTarefas.Location = new Point(12, 41);
            lstTarefas.Name = "lstTarefas";
            lstTarefas.Size = new Size(237, 94);
            lstTarefas.TabIndex = 2;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(93, 146);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnConcluir
            // 
            btnConcluir.Location = new Point(174, 146);
            btnConcluir.Name = "btnConcluir";
            btnConcluir.Size = new Size(75, 23);
            btnConcluir.TabIndex = 4;
            btnConcluir.Text = "Concluir";
            btnConcluir.UseVisualStyleBackColor = true;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 191);
            Controls.Add(btnConcluir);
            Controls.Add(btnRemover);
            Controls.Add(lstTarefas);
            Controls.Add(txtAdicionar);
            Controls.Add(txtTarefa);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarefa;
        private Button txtAdicionar;
        private ListBox lstTarefas;
        private Button btnRemover;
        private Button btnConcluir;
    }
}
