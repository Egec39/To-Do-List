namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void UpdateTaskCount1()
        {
            lblTotalTasks.Text = "Total Tasks: " + txtTasks.Items.Count;
        }

        private void BtnMarkComplete_Click1(object sender, EventArgs e)
        {
            if (txtTasks.SelectedItem != null)
            {
#pragma warning disable CS8600 // Null sabit değeri veya olası null değeri, boş değer atanamaz türe dönüştürülüyor.
                string task = txtTasks.SelectedItem.ToString();
#pragma warning restore CS8600 // Null sabit değeri veya olası null değeri, boş değer atanamaz türe dönüştürülüyor.
                if (task.StartsWith("✔"))
                {
                }
                else
                {
                    txtTasks.Items[txtTasks.SelectedIndex] = "✔ " + task;
                }
                UpdateTaskCount1();
            }
        }

        private void BtnDelete_Click1(object sender, EventArgs e)
        {
            if (txtTasks.SelectedItem != null)
            {
                txtTasks.Items.Remove(txtTasks.SelectedItem);
                UpdateTaskCount1();
            }
        }

        private void BtnEdit_Click1(object sender, EventArgs e)
        {
            if (txtTasks.SelectedItem != null)
            {
                txtTask.Text = txtTasks.SelectedItem.ToString();
                txtTasks.Items.Remove(txtTasks.SelectedItem);
            }
        }

        private void BtnAdd_Click1(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                txtTasks.Items.Add(task);
                UpdateTaskCount1();
                txtTask.Clear();
            }
        }

        private void txtTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}