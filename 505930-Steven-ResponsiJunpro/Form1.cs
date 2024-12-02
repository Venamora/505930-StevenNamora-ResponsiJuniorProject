using System.Data;
using Npgsql;



namespace _505930_Steven_ResponsiJunpro
{
    public partial class Form1 : Form
    {
        public static NpgsqlCommand cmd;
        public DataTable dt;
        private DataGridViewRow r;
        private employee emp;
        private EmployeeRepository EmployeeRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmployeeRepository = new EmployeeRepository(dgvData);
            emp = new employee();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            EmployeeRepository.Load();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeRepository.Insert(tbName, cbDept, btnLoad);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                EmployeeRepository.Delete(tbName, cbDept, btnLoad);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Edit Employee : {emp.Name}, Department : {emp.Department}");
            EmployeeRepository.Edit(tbName, cbDept, btnLoad);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbName.Text = r.Cells["name"].Value.ToString();
                cbDept.Text = r.Cells["department"].Value.ToString();

                EmployeeRepository.Row = r;
                emp.Name = r.Cells["name"].Value.ToString();
                emp.Department = r.Cells["department"].Value.ToString();
                MessageBox.Show($"Selected Employee : {emp.Name}, Department : {emp.Department}");
            }
        }
    }
}
