namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dont need this but cant erase without causing issues
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr =  // 'DialogResult' is a variable type like 'int' or 'string'.
                MessageBox.Show(
                "Are you sure you want to leave?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToUpper();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToLower();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MessageBox.Show("welcome to the program.", //The main text to be shown
               "Welcome", //The caption
               MessageBoxButtons.OK, // different buttons to be used
               MessageBoxIcon.Information, // different icons to be used
               MessageBoxDefaultButton.Button2, // determines which button is highlighted byt default
               MessageBoxOptions.ServiceNotification); // determines the general look and shape of the message box
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dont need this but cant erase without causing issues
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //this function closes the current form.
                         //'this' refers to the current form.
        }
    }
}