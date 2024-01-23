using MyClass;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab02_06_BiblWorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        List<Item> its = new List<Item>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = PeriodUse = 10;
            InvNumber = 1;
            Year = 1700;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magazine b = new Magazine(Volume, Numbers, Titles, Years, InvNumbers, Existences);
            if (Returns)
                b.ReturnSrok1();
            b.Subs();
            its.Add(b);
            Volume = Numbers = InvNumbers = 1;
            Titles = "";
            Years = 1700;
            Existences = Returns = false;
        }

        public int PeriodUses // ����������� �����
        {
            get { return (int)numericUpDown8.Value; }
            set { numericUpDown8.Value = value; }
        }

        public bool Returns // ����������� � ����
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }

        public bool Existences // �������
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }

        public int InvNumbers // ����������� ����� ��������
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }

        public int Years // ���� �������
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public string Titles // ��������
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }

        public int Numbers // �����
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public int Volume // ���
        {
            get { return (int)numericUpDown9.Value; }
            set { numericUpDown9.Value = value; }
        }
        public string Author // �����
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // ��������
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string PublishHouse // ������������
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public int Page // ���������� �������
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // ��� �������
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // ����������� �����
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // �������
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // ���������� �� ������������ ������ 
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // ����������� � ����
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // ����������� �����
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

    }
}
