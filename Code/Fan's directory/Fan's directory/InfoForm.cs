using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Pipes;

namespace Fan_s_directory
{
    public partial class InfoForm : Form
    {
        private People people;
        private Form1 form;
        public InfoForm()
        {
            InitializeComponent();
            
        }




        private void InfoForm_Load_1(object sender, EventArgs e)
        {
            people = new People();
            form = new Form1();
            string countriesFilePath = "E:\\TextFile5.txt";
            form.LoadCountriesFromFile(countriesFilePath);
            // передача ссылки на Form1

            // Заполнение списка людей

            

            form.LoadCharactersFromJson();
            dataGridView1.DataSource = form.Characters;

            Age.KeyPress += Age_KeyPress;
            Birthday.KeyPress += Birthday_KeyPress;

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            dataGridView1.Refresh();

        }
        public bool CheckCorrectOrigin()
        {
            string origin = Origin.Text.Trim();
            bool isCorrect = false;
            foreach (string country in form.countries)
            {
                if (origin == country)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return isCorrect;
        }
        public bool CheckCorrectCountry()
        {
            string origin = Nation.Text.Trim();
            bool isCorrect = false;
            foreach (string country in form.countries)
            {
                if (origin == country)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return isCorrect;
        }
        public void CreateNewCharacter()
        {

            bool isEverythingCorrect = true;
            string firstName = FirstName.Text.Trim();
            string secondName = SecondName.Text.Trim();
            string origin = Origin.Text.Trim();
            bool correctOrigin = CheckCorrectOrigin();
            if(correctOrigin == false)
            {
                MessageBox.Show("No such origin exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isEverythingCorrect = false;
                Origin.Text = string.Empty;
            }            
            string age = Age.Text.Trim();
            string nation = Nation.Text.Trim();
            bool isCorrectCountry = CheckCorrectCountry();
            if (isCorrectCountry == false)
            {
                MessageBox.Show("No such country exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isEverythingCorrect = false;
                Nation.Text = string.Empty;
            }
            string club = Club.Text.Trim();
            string typeOfSport = TypesOfSport.Text.Trim();
            string records = Records.Text.Trim();
            string birthday = Birthday.Text.Trim();
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(secondName) || string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(nation) 
             || string.IsNullOrEmpty(birthday) || string.IsNullOrEmpty(typeOfSport) || string.IsNullOrEmpty(age))
            {
                MessageBox.Show("Please fill in all gaps", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isEverythingCorrect = false;
                return;
            }
            foreach( Modules person in form.Characters)
            {
                if(person.FirstName == firstName && person.SecondName == secondName && person.Club == club && person.Birthday == birthday && person.Age == age &&
                    person.Nation == nation && person.TypeOfSport == typeOfSport && person.Origin == origin)
                {
                    MessageBox.Show("A sportsmen with such parameters already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isEverythingCorrect = true;
                    return;
                }
            }
            if (isEverythingCorrect)
            {
                Modules character = new Modules(firstName, secondName, origin, age, birthday, nation, typeOfSport, records, club);
                form.Characters.Add(character);
                form.SaveCharactersToJson();
                form.LoadCharactersFromJson();
                dataGridView1.DataSource = form.Characters;
            }
                FirstName.Text = string.Empty;
                SecondName.Text = string.Empty;
                Origin.Text = string.Empty;
                Age.Text = string.Empty;
                Nation.Text = string.Empty;
                Club.Text = string.Empty;
                TypesOfSport.Text = string.Empty;
                Records.Text = string.Empty;
                Birthday.Text = string.Empty;
                
            
        }
        public void DeleteTheCharacter()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string warning = "Are you really want to delete this character?";

                DialogResult result = MessageBox.Show(warning, "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    List<Modules> deletedCharacter = new List<Modules>();

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        Modules selectedCharacter = row.DataBoundItem as Modules;
                        deletedCharacter.Add(selectedCharacter);
                    }

                    foreach (Modules selectedCharacter in deletedCharacter)
                    {
                        form.Characters.Remove(selectedCharacter); // Видаляємо обрану подію зі списку
                    }

                    form.SaveCharactersToJson(); // Зберігаємо події у JSON файл
                    form.LoadCharactersFromJson();
                    dataGridView1.DataSource = form.Characters;
                }
            }
        }
        public void TextBoxToUpper(object sender)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                string correctedText = char.ToUpper(text[0]) + text.Substring(1);
                textBox.Text = correctedText;
                textBox.Select(correctedText.Length, 0);
            }
            
        }
        private void Origin_TextChanged_1(object sender, EventArgs e)
        {
            TextBoxToUpper(sender);
            
        }
        private void SecondName_TextChanged(object sender, EventArgs e)
        {

            TextBoxToUpper(sender);
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            TextBoxToUpper(sender);

        }

        private void Nation_TextChanged(object sender, EventArgs e)
        {
            TextBoxToUpper(sender);
        }

        private void Birthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypesOfSport_TextChanged(object sender, EventArgs e)
        {
            TextBoxToUpper(sender);
        }

        private void Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отменить ввод символа, если он не является цифрой
                MessageBox.Show("Only numbers can be entered");
            }
        }
        private void Birthday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Отменить ввод символа, если он не является цифрой или "."
                MessageBox.Show("You can enter the date only according to the format: dd.mm.yyyy");
            }
        }

        

        private void Records_TextChanged(object sender, EventArgs e)
        {

        }

        private void Club_TextChanged(object sender, EventArgs e)
        {
            TextBoxToUpper(sender);
        }
        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Create_Click(object sender, EventArgs e)
        {
            CreateNewCharacter();
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            DeleteTheCharacter();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }
            private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void ToForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        
    }
}
