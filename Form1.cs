namespace Cshap_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clildFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm1 cf1= new ChildForm1();
            cf1.MdiParent = this;
            cf1.Show();
        }
    }
}
