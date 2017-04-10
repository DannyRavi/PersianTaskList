using System.Data.Entity;
using System.Linq;


namespace TaskList
{
    public partial class Main : Infrastructure.BaseForm
    {
        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, System.EventArgs e)
        {
          //  Models.Task db = new Models.Task();
            Models.DatabaseContext dt = new Models.DatabaseContext();
           dataGridView1.DataSource = dt.Tasks.ToList();
           dataGridView1.Columns["Id"].HeaderText = "شماره";
           dataGridView1.Columns["TaskTitle"].HeaderText = "عنوان";
           dataGridView1.Columns["TaskDescription"].HeaderText = "توضیحات";
           dataGridView1.Columns["ImportanceLevel"].HeaderText = "درجه اهمیت";
           dataGridView1.Columns["Date"].HeaderText = "تاریخ";
        }

        private void NewPlanButton_Click(object sender, System.EventArgs e)
        {

            Tasks frmnewTask = new Tasks();

            frmnewTask.Show();
           

        }

        private void Rfresh_Click(object sender, System.EventArgs e)
        {
            Main_Load(sender, e);
        }

        private void TaskManagementButton_Click(object sender, System.EventArgs e)
        {
            Search Se = new Search();
            Se.Show();
        }

        private void AboutusButton_Click(object sender, System.EventArgs e)
        {
            About_Us ab = new About_Us();
            ab.ShowDialog();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult enmResult =
            System.Windows.Forms.MessageBox.Show
                (text: "آیا به خروج از برنامه اطمینان دارید؟",
                caption: "سوال",
                buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                icon: System.Windows.Forms.MessageBoxIcon.Question,
                defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                options: System.Windows.Forms.MessageBoxOptions.RightAlign |
                System.Windows.Forms.MessageBoxOptions.RtlReading);

            if (enmResult == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
