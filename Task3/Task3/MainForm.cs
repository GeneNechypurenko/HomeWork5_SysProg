using System.Threading;

namespace Task3
{
    public partial class MainForm : Form
    {
        private Semaphore semaphore;
        public MainForm()
        {
            InitializeComponent();

            bool createdNew;
            string semaphoreName = "UniqueInstanceSemaphore";
            semaphore = new Semaphore(3, 3, semaphoreName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("Превышено максимальное количество запусков приложения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void OpenNewFormButton_Click(object sender, EventArgs e)
        {
            if (semaphore.WaitOne(TimeSpan.Zero, true))
            {
                ChildForm childForm = new ChildForm();
                childForm.Show();
            }
            else
            {
                MessageBox.Show("Превышено максимальное количество открытых окон.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
