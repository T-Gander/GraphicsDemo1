namespace GraphicsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            Random random = new Random();
            Car car1 = new Car(this, random.Next(0, formWidth), random.Next(0, formHeight));

        }
    }
}