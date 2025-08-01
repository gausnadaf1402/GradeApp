using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeApp
{
    public partial class MainForm : Form
    {
        private bool isPanelVisible = false;
        private int panelWidth;
        private int hiddenXPosition;
        private int shownXPosition;
        private int selectedGradeId = -1;
        public MainForm()
        {
            InitializeComponent();


           
            dataGridViewGrades.AllowUserToAddRows = false;
            dataGridViewGrades.RowHeadersVisible = false;
            dataGridViewGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrades.MultiSelect = true;
            dataGridViewGrades.DataBindingComplete += dataGridViewGrades_DataBindingComplete;
            panelWidth = panelShowGrades.Width;
            hiddenXPosition = this.Width;                  // Panel fully hidden off-screen
            shownXPosition = this.Width - panelWidth;      // Visible position

            panelShowGrades.Left = hiddenXPosition;             // Start hidden
            panelShowGrades.Top = 0;
            //panelShowGrades.Height = this.Height;

            // Safety hookup (in case not done in designer)

            dataGridViewGrades.SelectionChanged += dataGridViewGrades_SelectionChanged;
            btnshow.Click += btnshow_Click;
            btnhide.Click += btnhide_Click;
            TimerSlideGrid.Tick += timerSlide_Tick;
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }
        private void timerSlide_Tick(object sender, EventArgs e)
        {
            if (!isPanelVisible)
            {
                // Slide in
                if (panelShowGrades.Left > shownXPosition)
                {
                    panelShowGrades.Left -= 20;
                }
                else
                {
                    panelShowGrades.Left = shownXPosition;
                    TimerSlideGrid.Stop();
                    isPanelVisible = true;

                    btnshow.Enabled = false;
                }
            }
            else
            {
                // Slide out
                if (panelShowGrades.Left < hiddenXPosition)
                {
                    panelShowGrades.Left += 20;
                }
                else
                {
                    panelShowGrades.Left = hiddenXPosition;
                    TimerSlideGrid.Stop();
                    isPanelVisible = false;
                    btnshow.Enabled = true;
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Basic validation (optional)
            if (string.IsNullOrWhiteSpace(txbgradename.Text))
            {
                MessageBox.Show("Grade Name is required.");
                return;
            }

            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO dbo.MstGrades 
                         (GradeName, Description, ActiveStatus, IsDeleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
                         VALUES 
                         (@GradeName, @Description, @ActiveStatus, @IsDeleted, @CreatedBy, GETDATE(), @ModifiedBy, GETDATE())";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GradeName", txbgradename.Text);
                    cmd.Parameters.AddWithValue("@Description", txbdesc.Text);
                    cmd.Parameters.AddWithValue("@ActiveStatus", checkBoxactivestatus.Checked);
                    cmd.Parameters.AddWithValue("@IsDeleted", checkBoxisdeleted.Checked);
                    cmd.Parameters.AddWithValue("@CreatedBy", txbcreatedby.Text);
                    cmd.Parameters.AddWithValue("@ModifiedBy", txbmodifiedby.Text);

                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Record added successfully.");
                            ClearForm(); // optional: clear inputs after insert
                        }
                        else
                        {
                            MessageBox.Show("Insert failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error****************: " + ex.Message);
                    }
                }
            }
        }

        private void ClearForm()
        {
            txbgradename.Clear();
            txbdesc.Clear();
            checkBoxactivestatus.Checked = false;
            checkBoxisdeleted.Checked = false;
            txbcreatedby.Clear();
            txbmodifiedby.Clear();

            // Optional: set focus to the first field
            txbgradename.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            TimerSlideGrid.Start();
            panelShowGrades.Visible = true;
            LoadGrades();
        }

        private void LoadGrades()
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT GradeID, GradeName, Description, ActiveStatus, IsDeleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate FROM dbo.MstGrades";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewGrades.DataSource = table;

                // Only show these columns
                dataGridViewGrades.Columns["GradeId"].Visible = true;
                dataGridViewGrades.Columns["GradeName"].Visible = true;
                dataGridViewGrades.Columns["Description"].Visible = true;

                // Hide these columns
                dataGridViewGrades.Columns["ActiveStatus"].Visible = false;
                dataGridViewGrades.Columns["CreatedBy"].Visible = false;
                dataGridViewGrades.Columns["ModifiedBy"].Visible = false;
                dataGridViewGrades.Columns["IsDeleted"].Visible = false;
                dataGridViewGrades.Columns["CreatedDate"].Visible = false;
                dataGridViewGrades.Columns["ModifiedDate"].Visible = false;


            }
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
                panelShowGrades.Visible = true;
                TimerSlideGrid.Start();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filterText))
            {
                (dataGridViewGrades.DataSource as DataTable).DefaultView.RowFilter = "";
            }
            else
            {
                (dataGridViewGrades.DataSource as DataTable).DefaultView.RowFilter =
                    $"GradeName LIKE '%{filterText}%' OR Description LIKE '%{filterText}%'";
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Get the selected row's ID
                    int selectedRowIndex = dataGridViewGrades.SelectedRows[0].Index;
                    int GradeID = Convert.ToInt32(dataGridViewGrades.Rows[selectedRowIndex].Cells["GradeID"].Value);

                    string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;TrustServerCertificate=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM dbo.MstGrades WHERE GradeID = @GradeID", con);
                        cmd.Parameters.AddWithValue("@GradeID", GradeID);
                        cmd.ExecuteNonQuery();
                    }

                    // Reload data after deletion
                    LoadGrades();

                    MessageBox.Show("Record deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void dataGridViewGrades_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SelectLastRealRow();
        }

        private void SelectLastRealRow()
        {
            if (dataGridViewGrades.Rows.Count == 0) return;

            int lastIndex = dataGridViewGrades.Rows.Count - 1;

            // If the last row is the placeholder new row, step back
            if (dataGridViewGrades.AllowUserToAddRows && dataGridViewGrades.Rows[lastIndex].IsNewRow)
            {
                lastIndex--;
            }

            if (lastIndex < 0) return;

            dataGridViewGrades.ClearSelection();
            dataGridViewGrades.Rows[lastIndex].Selected = true;
            dataGridViewGrades.FirstDisplayedScrollingRowIndex = lastIndex;
        }

        private void dataGridViewGrades_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedRows.Count == 0)
                return;

            var row = dataGridViewGrades.SelectedRows[0];
            if (row.Cells["GradeID"].Value == null)
                return;

            selectedGradeId = Convert.ToInt32(row.Cells["GradeID"].Value);
            txbgradename.Text = row.Cells["GradeName"].Value?.ToString() ?? "";
            txbdesc.Text = row.Cells["Description"].Value?.ToString() ?? "";
            checkBoxactivestatus.Checked = row.Cells["ActiveStatus"].Value is bool b && b;

            txbcreatedby.Text = row.Cells["CreatedBy"].Value?.ToString() ?? "";

            txbmodifiedby.Text = row.Cells["ModifiedBy"].Value?.ToString() ?? "";

            checkBoxisdeleted.Checked = row.Cells["IsDeleted"].Value is bool a && a;

        }
    }
}
