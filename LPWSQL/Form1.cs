using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace LPWSQL
{
    public partial class Form1 : Form
    {
        // Define SQL connection string (update with your connection details)
       private readonly string connectionString =
     @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aarzo\OneDrive\Documents\locker.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;";


        public Form1()
        {
            InitializeComponent();
        }
        private string RunAdbCommand(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "adb",
                Arguments = command,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process proc = Process.Start(psi))
            {
                string output = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit();
                return output;
            }
        }

        // Event handler for Load Data button click
        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                string cpuInfo = RunAdbCommand("shell cat /proc/cpuinfo");
                string memInfo = RunAdbCommand("shell cat /proc/meminfo");
                LoadContactsData();
                LoadSmsData();
                LoadCallLogsData();
                LoadDeviceInfoData();

                MessageBox.Show("Data loaded successfully!", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Load Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Save to Database button click
        private void BtnSaveToDB_Click(object sender, EventArgs e)
        {
            try
            {
                SaveContactsData();
                SaveSmsData();
                SaveCallLogsData();
                SaveDeviceInfoData();

                MessageBox.Show("Data saved to database successfully!", "Save to Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data to database: {ex.Message}", "Save Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for View Report button click
        private void BtnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Report functionality is not implemented yet.", "View Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error viewing report: {ex.Message}", "View Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Database Operations

        private void LoadContactsData()
        {
            string query = "SELECT Name, PhoneNumber, Email FROM ContactsTable";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvContacts.DataSource = dt;
            }
        }

        private void LoadSmsData()
        {

            string query = "SELECT Sender, MessageContent, Timestamp FROM MessagesTable";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSMS.DataSource = dt;
            }
        }

        private void LoadCallLogsData()
        {
            string query = "SELECT PhoneNumber, CallType, Duration FROM CallLogsTable";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCallLogs.DataSource = dt;
            }
        }

        private void LoadDeviceInfoData()
        {
            string query = "SELECT CPUInfo, MemoryInfo FROM DeviceInfoTable";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDeviceInfo.DataSource = dt;
            }
        }

        private void SaveContactsData()
        {
            foreach (DataGridViewRow row in dgvContacts.Rows)
            {
                if (row.IsNewRow) continue;

                string query = "INSERT INTO ContactsTable (Name, PhoneNumber, Email) VALUES (@Name, @PhoneNumber, @Email)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Name", row.Cells["Name"].Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", row.Cells["Phone Number"].Value);
                    cmd.Parameters.AddWithValue("@Email", row.Cells["Email"].Value);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void SaveSmsData()
        {
            foreach (DataGridViewRow row in dgvSMS.Rows)
            {
                if (row.IsNewRow) continue;

                string query = "INSERT INTO MessagesTable (Sender, MessageContent, Timestamp) VALUES (@Sender, @MessageContent, @Timestamp)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Sender", row.Cells["From"].Value);
                    cmd.Parameters.AddWithValue("@MessageContent", row.Cells["Message"].Value);
                    cmd.Parameters.AddWithValue("@Timestamp", row.Cells["Date"].Value);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void SaveCallLogsData()
        {
            foreach (DataGridViewRow row in dgvCallLogs.Rows)
            {
                if (row.IsNewRow) continue;

                string query = "INSERT INTO CallLogsTable (PhoneNumber, CallType, Duration) VALUES (@PhoneNumber, @CallType, @Duration)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@PhoneNumber", row.Cells["Caller"].Value);
                    cmd.Parameters.AddWithValue("@CallType", row.Cells["Call Type"].Value);
                    cmd.Parameters.AddWithValue("@Duration", row.Cells["Duration (sec)"].Value);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void SaveDeviceInfoData()
        {
            foreach (DataGridViewRow row in dgvDeviceInfo.Rows)
            {
                if (row.IsNewRow) continue;

                string query = "INSERT INTO DeviceInfoTable (CPUInfo, MemoryInfo) VALUES (@CPUInfo, @MemoryInfo)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@CPUInfo", row.Cells["Parameter"].Value);
                    cmd.Parameters.AddWithValue("@MemoryInfo", row.Cells["Value"].Value);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        #endregion
    }
}


