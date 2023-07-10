using _45.Domain.Abstract;
using _45.Domain.Entities;

namespace _45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox
            //MessageBox.Show("Mahammad Agayev");


            DialogResult result = MessageBox.Show("Do you want to close the application?", "Clicked", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                result = MessageBox.Show("The application will be closed, Are you sure?", "Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                IUnitOfWork unitOfWork = DbFactory.GetUnitOfWork();

                unitOfWork.CreateTransaction();

                Book b = new Book();
                b.Name = txtBookName.Text;
                b.PageNumber = (int)npdPageNumber.Value;

                int authorId = (int)npdAuthorId.Value;

                Author author = unitOfWork.AuthorRepository.Get(authorId);

                unitOfWork.BookRepository.Add(b);

                AuthorBook ab = new AuthorBook
                {
                    Author = author,
                    Book = b
                };

                unitOfWork.AuthorBookRepository.Add(ab);

                unitOfWork.Commit();

                MessageBox.Show("Kitab uğurla əlavə edildi", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kitab əlavə edilən zaman xəta baş verdi", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}