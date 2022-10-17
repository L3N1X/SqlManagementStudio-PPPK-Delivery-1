using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task.Dal;
using Task.Models;

namespace Task
{
    public partial class ManagementStudioForm : Form
    {
        public ManagementStudioForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ManagementStudioForm_Load(object sender, EventArgs e)
        {
            this.cbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());
        }

        private void ManagementStudioForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Clear();
            this.lbTables.DataSource = (this.cbDatabases.SelectedItem as Database).Tables;
            this.lbViews.DataSource = (this.cbDatabases.SelectedItem as Database).Views;
            this.lbProcedures.DataSource = (this.cbDatabases.SelectedItem as Database).Procedures;

        }

        private void Clear()
        {
            this.lbTableColumns.DataSource = null;
            this.lbViewColumns.DataSource = null;
            this.lbProcedureParams.DataSource = null;
        }

        private void lbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbTableColumns.DataSource = (this.lbTables.SelectedItem as DBEntity).Columns;
        }

        private void lbViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbViewColumns.DataSource = (this.lbViews.SelectedItem as DBEntity).Columns;
        }

        private void lbProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbProcedureParams.DataSource = (this.lbProcedures.SelectedItem as Procedure).Params;
        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            string query = this.tbQueryEditor.Text.Trim();
            string currentDatabaseName = (this.cbDatabases.SelectedItem as Database).Name;
            try
            {
                if (query.ToLower().Contains("select"))
                {
                    DataSet ds = RepositoryFactory.GetRepository().CreateDataSet(query, currentDatabaseName);
                    DataTable table = ds.Tables[0];
                    this.dgResults.DataSource = table;
                    this.tbMessages.Text = "Query executed sucessfully.";
                }
                else
                {
                    int affectedRowCount = RepositoryFactory.GetRepository().ExecuteDML(query, currentDatabaseName);
                    this.dgResults.DataSource = null;
                    string message = $"{affectedRowCount} row(s) have been affected";
                    this.tbMessages.Text = message;
                }
            }
            catch(Exception ex)
            {
                this.tbMessages.Text = ex.Message;
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
