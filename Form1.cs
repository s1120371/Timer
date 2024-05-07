namespace Timer
{
    public partial class Form1 : Form
    {

        private int countdownTime; // �˼ƭp�ɪ��ɶ��]��^
        public Form1()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // �]�m�p�ɾ������j�� 1 ��
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            // �q TextBox ������Τ��J�����
            if (int.TryParse(textBox1.Text, out int userInput))
            {
                // �p�G�Τ��J���ġA�]�m�˼ƭp��
                countdownTime = userInput;

                // ��ܳѾl�ɶ�
                label1.Text = $"{countdownTime} ��";

                // �Ұʭp�ɾ�
                timer1.Start();
            }
            else
            {
                // �p�G�Τ��J�L�ġA�������s��J�Ʀr
                MessageBox.Show("�п�J���ļƦr�I");

                // �M�� TextBox ���Τ᭫�s��J
                textBox1.Clear();

                // �N�J�I��^�� TextBox
                textBox1.Focus();

                // �b�Τ��J�L�ļƦr�ɤ��Ұʭp�ɾ�
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // �C��Ĳ�o�ɴ�ֳѾl�ɶ�
            countdownTime--;

            // ��s���
            label1.Text = $"{countdownTime} ��";

            // �p�G�˼Ƶ���
            if (countdownTime <= 0)
            {
                // ����p�ɾ�
                timer1.Stop();

                // ��ܭp�ɾ�����������
                MessageBox.Show("�ɶ���I");
            }
        }
    }
}