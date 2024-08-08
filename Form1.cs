using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace 鼠标测试工具
{
    public partial class Form1 : AntdUI.Window
    {


        int leftClickNumber = 0;
        int rightClickNumber = 0;
        int wheelUpNumber = 0;
        int wheelDownNumber = 0;
        bool leftIsDown = false;
        bool rightIsDown = false;
        Color downColor = Color.FromArgb(42, 68, 128);
        Color upColor = Color.FromArgb(70, 113, 213);
        Point lastPoint;

        public Form1()
        {
            InitializeComponent();

            // 监听鼠标按键点击事件
            panel_run.MouseDown += OnMouseDown;
            // 监听鼠标按键松开事件
            panel_run.MouseUp += OnMouseUp;
            // 监听鼠标滚轮滚动事件
            panel_run.MouseWheel += OnMouseWheel;
            // 监听鼠标移动事件
            panel_run.MouseMove += OnMouseMove;
        }

        private void OnMouseMove(object? sender, MouseEventArgs e)
        {
            //int x = e.Location.X;
            //int y = e.Location.Y;
            //label_xy.Location=new Point(x+5,y-10);
            //label_xy.Text = label_xy.Location.ToString();
            if (leftIsDown)
            {
                Graphics g = panel_run.CreateGraphics();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.LawnGreen, 5);
                //g.DrawRectangle(pen, e.X, e.Y, 1, 1);
                g.DrawLine(pen, lastPoint, e.Location);
                pen.Dispose();
                g.Dispose();
            }
            if (rightIsDown)
            {
                Graphics g = panel_run.CreateGraphics();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.LightPink, 5);
                //g.DrawRectangle(pen, e.X, e.Y, 1, 1);
                g.DrawLine(pen, lastPoint, e.Location);
                pen.Dispose();
                g.Dispose();
            }
            lastPoint = e.Location;

        }

        private void OnMouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                wheelUpNumber++;
                label_wheelUp.Text = wheelUpNumber.ToString();
                panel_wheelUp.Back = downColor;
                panel_wheeldown.Back = upColor;
            }
            if (e.Delta < 0)
            {
                wheelDownNumber++;
                label_wheelDown.Text = wheelDownNumber.ToString();
                panel_wheelUp.Back = upColor;
                panel_wheeldown.Back = downColor;
            }
        }

        private void OnMouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panel_leftClick.Back = upColor;
                leftIsDown = false;
                Graphics g = panel_run.CreateGraphics();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.Red, 10);
                g.DrawRectangle(pen, e.X, e.Y, 1, 1);
                pen.Dispose();
                g.Dispose();
            }
            else if (e.Button == MouseButtons.Right)
            {
                panel_rightClick.Back = upColor;
                rightIsDown = false;
                Graphics g = panel_run.CreateGraphics();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.Red, 10);
                g.DrawRectangle(pen, e.X, e.Y, 1, 1);
                pen.Dispose();
                g.Dispose();
            }
            lastPoint = e.Location;
        }

        private void OnMouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                leftIsDown = true;
                leftClickNumber++;
                label_left.Text = leftClickNumber.ToString();
                panel_leftClick.Back = downColor;
                Graphics g = panel_run.CreateGraphics();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.White, 10);
                g.DrawEllipse(pen, e.X - 2, e.Y - 2, 4, 4);
                //g.DrawRectangle(pen, e.X, e.Y, 1, 1);
                pen.Dispose();
                g.Dispose();
            }
            else if (e.Button == MouseButtons.Right)
            {
                rightIsDown = true;
                rightClickNumber++;
                label_right.Text = rightClickNumber.ToString();
                panel_rightClick.Back = downColor;
                Graphics g = panel_run.CreateGraphics();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.White, 10);
                g.DrawEllipse(pen, e.X-2, e.Y-2, 4, 4);
                //g.DrawRectangle(pen, e.X, e.Y, 1, 1);
                pen.Dispose();
                g.Dispose();
            }

        }

        private void button_github_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/ZeroDeng01";
            try
            {
                // 使用默认浏览器打开指定网址
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            panel_run.Refresh();
            leftClickNumber = 0;
            rightClickNumber = 0;
            wheelUpNumber = 0;
            wheelDownNumber = 0;

            label_right.Text = rightClickNumber.ToString();
            label_left.Text = leftClickNumber.ToString();
            label_wheelUp.Text = wheelUpNumber.ToString();
            label_wheelDown.Text = wheelDownNumber.ToString();
            panel_wheelUp.Back = upColor;
            panel_wheeldown.Back = upColor;
        }
    }
}
