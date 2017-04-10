using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace TaskList
{
    public partial class Tasks : Infrastructure.BaseForm
    {
        public Tasks()
            :base()
        {
            InitializeComponent();
        }


        private void RegistrationButton_Click(object sender, System.EventArgs e)
        {
            
            Models.DatabaseContext oDatabaseContext = null;
           

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.Task oTask =
                    new Models.Task();


                oTask.TaskTitle = TitleTextBox.Text;

                oTask.TaskDescription = DescriptionTextBox.Text;
                oTask.ImportanceLevel = ImportanceComboBox.Text;
                oTask.Date = dateTimePicker1.Text;


                           

                oDatabaseContext.Tasks.Add(oTask);
               
                oDatabaseContext.SaveChanges();


                System.Windows.Forms.MessageBox.Show("کار جدید مورد نظر شما اضافه گردید.");

                TitleTextBox.Text = string.Empty;
                DescriptionTextBox.Text = string.Empty;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                    Main oMian = new Main();
                    oMian.Show();
                }
            }


        }

    
    }
}


