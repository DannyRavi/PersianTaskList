using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace TaskList
{
    public partial class Search : Infrastructure.BaseForm
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, System.EventArgs e)
        {

        }
        Models.Task db = new Models.Task();
        Models.DatabaseContext dt = new Models.DatabaseContext();
        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            var qsearch = dt.Tasks.Where(i => i.TaskTitle.Contains(textBoxSearch.Text));
            dataGridView1.DataSource = qsearch.ToList();
            var a = qsearch.ToList();
            if (a.Count == 0)
                MessageBox.Show(".وظیفه مورد نظر یافت نشد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            int b = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            db  = dt.Tasks.FirstOrDefault(i => i.Id == b);
            dt.Tasks.Remove(db);
            dt.SaveChanges();
            dataGridView1.DataSource = dt.Tasks.ToList();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
          
            btnSearch_Click(sender, e);
            dataGridView1.SelectAll();
        }
    }
}