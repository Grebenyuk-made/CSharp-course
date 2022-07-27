namespace WinFormsApp1
{
    public partial class cdRandom : Form
    {
        int count = 0;
        Random rnd;
        private string spec_chars;
        char[] spec_Chars = new char[] { '%', '*', ')', '?', '$', '^', '&', };
        Dictionary<string, double> metrica; 

        public cdRandom()
        {
            InitializeComponent();
            rnd = new Random();
            char[] spec_Chars = new char[] { '%', '*', ')', '?', '$', '^', '&', };
        metrica = new Dictionary<string, double>();
        metrica.Add("mm", 1);
        metrica.Add("cm", 10);
        metrica.Add("dm", 100);
        metrica.Add("m", 1000);
        metrica.Add("kl", 1000000);
        metrica.Add("mile", 1609344);

        }

        private void помоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа мои утилиты, содержит ряд не больших программ, которые могут пригодится в жизни." ,"О программе." );
        }

        private void Programm1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btmPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();   
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            count--;
            lblCount.Text = count.ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = Convert.ToString(count);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)+1);
            lblRandom.Text = n.ToString();
            if (cbRandom.Checked)
            {
                int i = 0;
                while (tbRandom.Text.IndexOf(n.ToString()) !=  -1);
                {
                    n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    i++;
                    if (i > 1000) ;         
                }
                    if ( i < 1000) tbRandom.AppendText(n + "\n");

            }
            else tbRandom.AppendText(n + "\n");
        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
            rtbNotePad.AppendText(DateTime.Now.ToShortDateString()+"\n");
        }

        private void tsmiInsertTime_Click(object sender, EventArgs e)
        {
            rtbNotePad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotePad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении.");
            }
        }

        void LoadNotePad()
        {
            try
            {
                rtbNotePad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке.");
            }


        }

        private void btnCreatePasword_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < nudPasslangth.Value; i++)
            {
                int n = rnd.Next(0,clbPassword.CheckedItems.Count);
                string s = clbPassword.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры": password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы":password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Строчные буквы": password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_chars; rnd.Next(spec_chars.Length) ;
                        break;
                }
                tbPassword.Text = password; 
                Clipboard.SetText(password);


            }
        }

        private void clbPassword_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cbFrom.Text];
            double m2 = metrica[cbTo.Text];
            double n = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (n * m1 / m2).ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string t =cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            tbTo.Text = t; 
        }
    }
    
}