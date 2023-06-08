
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement; 

namespace Fan_s_directory
{

    public partial class Form1 : Form
    {
        public BindingList<Modules> Characters = new BindingList<Modules>();
        private Dictionary<string, List<string>> options;
        private string[] age;
        private string[] typesOfSport;
        public string[] countries;
        private string[] clubs;
        private People people;

        public void LoadCountriesFromFile(string filePath)
        {
            countries = File.ReadAllLines(filePath);
        }

        private void LoadAgesFromFile(string filePath)
        {
            age = File.ReadAllLines(filePath);
        }
        public Form1()
        {
            InitializeComponent();

            
            SortComboBox.Visible = false;
           
        }
        List<string> uniqueClubs = new List<string>();
        private void CheckOnlyOneClubs() {

            uniqueClubs = clubs.Distinct().ToList();

        }
        List<string> uniqueTypeOfSports = new List<string>();
        private void CheckOnlyOneTypeOfSport()
        {
            uniqueTypeOfSports = typesOfSport.Distinct().ToList();  
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string countriesFilePath = "TextFile5.txt";
            LoadCountriesFromFile(countriesFilePath);

            string ageFilePath = "TextFile6.txt";
            LoadAgesFromFile(ageFilePath);


            


            people = new People(); // Создание экземпляра класса People

            LoadCharactersFromJson();
            dataGridView1.DataSource = Characters;
            clubs = Characters.Select(c => c.Club).ToArray();
            typesOfSport = Characters.Select(c => c.TypeOfSport).ToArray();

            CheckOnlyOneClubs();
            CheckOnlyOneTypeOfSport();
            dataGridView1.Refresh();
            
            InitializeComboBoxes();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            

           
            

        }



        private void InitializeComboBoxes()
        {
            options = new Dictionary<string, List<string>>
        {
            { "nation", countries.ToList() },
            { "origin", countries.ToList() },
            { "type of sport", uniqueTypeOfSports.ToList() },
            { "club", uniqueClubs.ToList() },
            { "age", age.ToList() },
        };
            SortTypesComboBox.Items.AddRange(options.Keys.ToArray());
            // Заполнение первого ComboBox
            //People people = new People(); // Создание экземпляра класса People
            //foreach (Modules person in people.PeopleList)
            //{
            //    SportstmenComboBox.Items.Add(person);
            //}

        }
        public void SaveCharactersToJson()
        {
            string json = JsonConvert.SerializeObject(Characters);
            File.WriteAllText("events.json", json);
        }
        public void LoadCharactersFromJson()
        {
            string json = File.ReadAllText("events.json");
            Characters = JsonConvert.DeserializeObject<BindingList<Modules>>(json);
        }
        public void SortTypesOfComboBox()
        {
            string selectedOption = SortTypesComboBox.SelectedItem.ToString();
            if (options.ContainsKey(selectedOption))
            {
                SortComboBox.Items.Clear();
                foreach (string subtype in options[selectedOption])
                {
                    SortComboBox.Items.Add(subtype);
                    SortComboBox.Visible = true;
                }
            }
        }
        private void SortTypesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortTypesOfComboBox();
        }
        public void SortOfComboBox()
        {
            string searchText = SortComboBox.Text.Trim();

            SortComboBox.Items.Clear();

            // Фильтрация элементов списка
            foreach (string item in countries)
            {
                if (item.StartsWith(searchText))
                {
                    SortComboBox.Items.Add(item);
                }
            }

            SortComboBox.DroppedDown = true; // Открытие выпадающего списка
            SortComboBox.SelectionStart = searchText.Length; // Установка курсора в конец введенного текста
        }
        private void SortComboBox_TextChanged(object sender, EventArgs e)
        {
            SortOfComboBox();
        }

        public void SortComboBoxIndex()
        {
            string selectedType = SortComboBox.SelectedItem?.ToString();

            // Создаем новый список для отфильтрованных данных
            List<Modules> filteredPeopleList = new List<Modules>();

            foreach (Modules person in Characters)
            {
                if (person.Nation == selectedType || person.Club == selectedType || person.TypeOfSport == selectedType 
                    || person.Origin == selectedType || person.Age.ToString() == selectedType)
                {
                    filteredPeopleList.Add(person);
                }
            }

            // Обновляем источник данных таблицы
            dataGridView1.DataSource = null; // Отсоединяем текущий источник данных
            dataGridView1.DataSource = filteredPeopleList; // Привязываем новый отфильтрованный список

            // Убедитесь, что столбцы таблицы соответствуют свойствам класса Modules
            dataGridView1.AutoGenerateColumns = true;
        }
        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortComboBoxIndex();
        }


        private bool IsMatchCategory(Modules person, string selectedType)
        {
            bool hasRecords = person.Records != "";
            bool isSelectedType = person.Nation == selectedType ||
                                  person.Club == selectedType ||
                                  person.TypeOfSport == selectedType ||
                                  person.Origin == selectedType ||
                                  person.Age.ToString() == selectedType;

            return hasRecords && isSelectedType;
        }
        private bool IsMatchCategory1(Modules person)
        {
            bool hasRecords = person.Records != "";
            

            return hasRecords;
        }
        public void ShowRecordsmen()
        {
            DialogResult result = MessageBox.Show("Do you want to display only athletes with records?", "Filter of records", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string selectedType = SortComboBox.SelectedItem?.ToString();

                // Создаем новый список для отфильтрованных данных
                List<Modules> filteredPeopleList = new List<Modules>();

                foreach (Modules person in Characters)
                {
                    if (IsMatchCategory(person, selectedType))
                    {
                        filteredPeopleList.Add(person);
                    }
                    if (string.IsNullOrEmpty(selectedType))
                    {
                        if (IsMatchCategory1(person))
                        {
                            filteredPeopleList.Add(person);
                        }
                    } 

                }

                // Обновляем источник данных таблицы
                dataGridView1.DataSource = null; // Отсоединяем текущий источник данных
                dataGridView1.DataSource = filteredPeopleList; // Привязываем новый отфильтрованный список

                // Убедитесь, что столбцы таблицы соответствуют свойствам класса Modules
                dataGridView1.AutoGenerateColumns = true;
            }
        }
        private void ShowRecord_Click(object sender, EventArgs e)
        {
            ShowRecordsmen();
        }
        public void SearchSportsmen()
        {
            string searchText = SearchPanel.Text.ToUpper();

            List<Modules> filteredPeopleList = new List<Modules>();

            foreach (Modules person in Characters)
            {
                if (person.FirstName.Contains(searchText) || person.SecondName.Contains(searchText))
                {
                    filteredPeopleList.Add(person);
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredPeopleList;
            dataGridView1.AutoGenerateColumns = true;
        }
         
        
        private void SearchPanel_TextChanged(object sender, EventArgs e)
        {
            SearchSportsmen();
        }




        private void SortLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowRecord_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateChange_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoForm infoForm = new InfoForm();
            infoForm.Show();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }


    }
