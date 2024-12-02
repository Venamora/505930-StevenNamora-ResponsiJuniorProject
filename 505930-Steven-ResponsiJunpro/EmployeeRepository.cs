using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace _505930_Steven_ResponsiJunpro
{
    internal class EmployeeRepository : employee
    {
        private const string conn = "Host=localhost;Username=postgres;Password=steven;Database=responsi";
        private static NpgsqlConnection connection;
        private static NpgsqlCommand cmd;
        private static DataTable dt;

        private DataGridView dgvData;
        private DataGridViewRow row;

        public DataGridViewRow Row
        {
            set { row = value; }
        }

        public EmployeeRepository(DataGridView dgvData)
        {
            this.dgvData = dgvData;
        }

        private Dictionary<string, string> departmentMapping = new Dictionary<string, string>()
        {
            {  "HR" , "Human Resources" },
            {  "ENG" , "Engineer" },
            {  "DEV" , "Developer" },
            {  "PM" , "Product Manager" },
            {  "FIN" , "Finance" }
        };

        public void Load()
        {
            connection = new NpgsqlConnection(conn);
            try
            {
                connection.Open();
                dgvData.DataSource = null;
                dt = new DataTable();
                string sql = "SELECT * FROM emp_select() ORDER BY id";
                cmd = new NpgsqlCommand(sql, connection);

                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                dgvData.ClearSelection();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            finally
            {
                connection.Close();
            }
        }

        public void Insert(TextBox tbName, ComboBox cbDept, Button btnLoad)
        {
            using (var connection = new NpgsqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    string fullDeptName = departmentMapping.ContainsKey(cbDept.Text) ? departmentMapping[cbDept.Text] : cbDept.Text;


                    if (string.IsNullOrWhiteSpace(tbName.Text))
                    {
                        MessageBox.Show("Employee cannot be empty");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(cbDept.Text))
                    {
                        MessageBox.Show("Department cannot be empty");
                        return;
                    }
                    string sql = @"SELECT emp_insert(:name_emp, :name_dept)";
                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("name_emp", tbName.Text);
                        cmd.Parameters.AddWithValue("name_dept", fullDeptName);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result > 0)
                        {
                            MessageBox.Show("Employee added successfully");
                            tbName.Text = string.Empty;
                            cbDept.Text = string.Empty;
                            btnLoad.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured: {ex.Message}");
                }
            }
        }

        public void Edit(TextBox tbName, ComboBox cbDept, Button btnLoad)
        {
            if (row == null)
            {
                MessageBox.Show("Please select a row to edit", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Employee cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbDept.Text))
            {
                MessageBox.Show("Department cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fullDeptName = departmentMapping.ContainsKey(cbDept.Text) ? departmentMapping[cbDept.Text] : cbDept.Text;

            using (var connection = new NpgsqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    string sql = @"SELECT emp_update(:p_id_emp, :p_name_emp, :p_name_dept)";
                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("p_id_emp", Convert.ToInt32(row.Cells["id"].Value));
                        cmd.Parameters.AddWithValue("p_name_emp", tbName.Text);
                        cmd.Parameters.AddWithValue("p_name_dept", fullDeptName);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result == 1)
                        {
                            MessageBox.Show("Employee updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbName.Text = string.Empty;
                            cbDept.Text = string.Empty;
                            row = null;
                            btnLoad.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Delete(TextBox tbName, ComboBox cbDept, Button btnLoad)
        {
            if (row == null)
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }

            using(var connection = new NpgsqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    string sql = @"SELECT emp_delete(:id_emp)";
                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("id_emp", Convert.ToInt32(row.Cells["id"].Value));
                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result == 1)
                        {
                            MessageBox.Show("Employee deleted successfully");
                            tbName.Text = string.Empty;
                            cbDept.Text = string.Empty;
                            row = null;
                            btnLoad.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured: {ex.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
