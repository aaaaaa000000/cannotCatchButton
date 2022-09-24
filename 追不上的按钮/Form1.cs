namespace 追不上的按钮
{
    public partial class Form1 : Form
    {
        int width = new Random().Next(100, 500);
        int height = new Random().Next(100, 500);
        public Form1()
        {
            InitializeComponent();
            Size = new Size(width, height);
            button1.Location = new Point(new Random().Next(width-90), new Random().Next(height-70));
            button1.Text = "点我!!!";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(new Random().Next(width - 90), new Random().Next(height - 70));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "牛逼!!!";
        }
    }
}