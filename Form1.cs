namespace Timer
{
    public partial class Form1 : Form
    {

        private int countdownTime; // 倒數計時的時間（秒）
        public Form1()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // 設置計時器的間隔為 1 秒
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            // 從 TextBox 中獲取用戶輸入的秒數
            if (int.TryParse(textBox1.Text, out int userInput))
            {
                // 如果用戶輸入有效，設置倒數計時
                countdownTime = userInput;

                // 顯示剩餘時間
                label1.Text = $"{countdownTime} 秒";

                // 啟動計時器
                timer1.Start();
            }
            else
            {
                // 如果用戶輸入無效，提醒重新輸入數字
                MessageBox.Show("請輸入有效數字！");

                // 清空 TextBox 讓用戶重新輸入
                textBox1.Clear();

                // 將焦點返回給 TextBox
                textBox1.Focus();

                // 在用戶輸入無效數字時不啟動計時器
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 每次觸發時減少剩餘時間
            countdownTime--;

            // 更新顯示
            label1.Text = $"{countdownTime} 秒";

            // 如果倒數結束
            if (countdownTime <= 0)
            {
                // 停止計時器
                timer1.Stop();

                // 顯示計時器結束的消息
                MessageBox.Show("時間到！");
            }
        }
    }
}