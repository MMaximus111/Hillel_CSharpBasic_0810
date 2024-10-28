namespace Lesson5_WindowsForms
{
    public partial class Form1 : Form
    {
        bool _lastCharIsOperator = false;
        bool _anyOperatorsAddedBefore = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_anyOperatorsAddedBefore)
            {
                label1.Text += '1';
            }

            AddNumberToMainLabelNumber('1');
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_anyOperatorsAddedBefore)
            {
                label1.Text += "0";
            }

            AddNumberToMainLabelNumber('0');
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label1.Text = string.Join("", label1.Text.Take(label1.Text.Length - 1));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0 && label1.Text.Last() == '+')
            {
                return;
            }

            if (_anyOperatorsAddedBefore == false)
            {
                label1.Text = $"{label2.Text}+";
            }
            else
            {
                label1.Text = $"{label1.Text}+";
            }
          
            _lastCharIsOperator = true;
            _anyOperatorsAddedBefore = true;
        }

        private void AddNumberToMainLabelNumber(char c)
        {
            if (_lastCharIsOperator)
            {
                label2.Text = c.ToString();
                _lastCharIsOperator = false;
            }
            else
            {
                label2.Text += c;
            }
            
        }
    }
}
