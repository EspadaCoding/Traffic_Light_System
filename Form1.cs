namespace Traffic_Light_System
{
    public partial class Form1 : Form
    {
        private Model model;
        private Painter painter;
        private DateTime fix;
        private System.Windows.Forms.Timer timer1;
        private Button butStart;
        private Button butStop;
        private string navigation = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.model = new Model();
            this.painter = new Painter(this.model);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Painter painter = this.painter;
            Graphics graphics = e.Graphics;
            Size clientSize = this.ClientSize;
            int w = clientSize.Width - 20;
            clientSize = this.ClientSize;
            int h = clientSize.Height - 40;
            painter.paintTo(graphics, w, h);
            this.navigation = string.Empty;
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.fix = DateTime.Now;
            this.model.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.model.Update(now - this.fix, this.navigation);
            this.Refresh();
            this.fix = now;
        }

        private void Form1_Resize(object sender, EventArgs e) => this.Refresh();

        private void butStop_Click(object sender, EventArgs e) => this.timer1.Enabled = false;

        private void UP_Click(object sender, EventArgs e)
        {
            this.navigation += "up";
        }

        private void DOWN_Click(object sender, EventArgs e)
        {
            this.navigation += "down";
        }

        private void RIGHT_Click(object sender, EventArgs e)
        {
            this.navigation += "right";
        }

        private void LEFT_Click(object sender, EventArgs e)
        {
            this.navigation += "left";
        }


    }
}