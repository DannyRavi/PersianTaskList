using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Infrastructure
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, System.EventArgs e)
        {

        }

           
            protected override void OnPaintBackground (System.Windows.Forms.PaintEventArgs e )
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                           Color.DeepSkyBlue,
                                                                           Color.Black,
                                                                           90F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
         
        }
    }


