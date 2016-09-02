using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GridViewSample : Form
    {
        public GridViewSample()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //init the DataGridView
            GenerateColumns(this.gvSample);
            //load data from Azure Table
            var dataItems = LoadData();
            //Bind the datasource
            gvSample.DataSource = dataItems;
            gvSample.Refresh();
        }

        /// <summary>
        /// Initialize the DataGridView.
        /// </summary>
        /// <param name="gv"></param>
        private void GenerateColumns(DataGridView gv)
        {
            gv.AutoGenerateColumns = false;
            gv.AutoSize = true;
            //IssueTitle, initialize and add a text box column.
            var issueTitleCol = new DataGridViewTextBoxColumn();
            issueTitleCol.DataPropertyName = "IssueTitle";
            issueTitleCol.Name = "IssueTitle";
            gv.Columns.Add(issueTitleCol);
            //IssueContent, initialize and add a text box column.
            var issueContentCol = new DataGridViewTextBoxColumn();
            issueContentCol.DataPropertyName = "IssueContent";
            issueContentCol.Name = "IssueContent";
            gv.Columns.Add(issueContentCol);
            //Timestamp, initialize and add a text box column.
            var issueTimestampCol = new DataGridViewTextBoxColumn();
            issueTimestampCol.DataPropertyName = "Timestamp";
            issueTimestampCol.Name = "Timestamp";
            gv.Columns.Add(issueTimestampCol);
        }

        /// <summary>
        /// Load data from Azure Table
        /// </summary>
        /// <returns></returns>
        private IList<IssueEntity> LoadData()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
            CloudConfigurationManager.GetSetting("BruceChenStorageConnectionString"));
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
            CloudTable cloudTable = tableClient.GetTableReference("TelephonyIssueLog");
            cloudTable.CreateIfNotExists();
            TableQuery<IssueEntity> query = new TableQuery<IssueEntity>()
                .Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "Issues"));
            return cloudTable.ExecuteQuery(query).ToList();
        }
    }

    public class IssueEntity : TableEntity
    {
        public IssueEntity(string partitionKey, string rowKey)
        {
            this.PartitionKey = partitionKey;
            this.RowKey = rowKey;
        }
        public IssueEntity() { }
        public string IssueTitle { get; set; }
        public string IssueContent { get; set; }
    }
}
