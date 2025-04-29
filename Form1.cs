namespace ListaDeTarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarefa.Text))
            {
                lstTarefas.Items.Add(txtTarefa.Text);
                txtTarefa.Clear();
                txtTarefa.Focus();
            }
            else
            {
                MessageBox.Show("Digite uma tarefa.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstTarefas.SelectedIndex != -1)
            {
                lstTarefas.Items.RemoveAt(lstTarefas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para remover.");
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            int index = lstTarefas.SelectedIndex;
            if (index != -1)
            {
                string tarefa = lstTarefas.Items[index].ToString();
                lstTarefas.Items[index] = "✔️ " + tarefa;
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para concluir.");
            }
        }
    }
}
