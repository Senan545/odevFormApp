namespace odevvv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fastButton_Click(object sender, EventArgs e)
        {
            if (fastButton.BackColor == Color.Yellow)
            {
                fastButton.BackColor = Color.Lime;
            }
            if (cheapButton.BackColor == Color.Lime && goodButton.BackColor == Color.Lime)
            {
                fastButton.BackColor = Color.Lime;
                goodButton.BackColor = Color.Red;
                cheapButton.BackColor = Color.Lime;
            }
           
        }

        private void goodButton_Click(object sender, EventArgs e)
        {
            if (goodButton.BackColor == Color.Yellow)
            {
                goodButton.BackColor = Color.Lime;
            }
            if (cheapButton.BackColor == Color.Lime && fastButton.BackColor == Color.Lime)
            {
                goodButton.BackColor = Color.Lime;
                fastButton.BackColor = Color.Lime;
                cheapButton.BackColor = Color.Red;
            }
            
        }

        private void cheapButton_Click(object sender, EventArgs e)
        {
            if (cheapButton.BackColor == Color.Yellow)
            {
                cheapButton.BackColor = Color.Lime;
            }
            if (goodButton.BackColor == Color.Lime && fastButton.BackColor == Color.Lime)
            {
                cheapButton.BackColor = Color.Lime;
                fastButton.BackColor = Color.Red;
                goodButton.BackColor = Color.Lime;
            }
            
        }
    }
}