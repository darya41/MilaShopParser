using Newtonsoft.Json;
using ParseMila;
using System.Windows.Forms;

namespace MilaShopParser
{

    public partial class Form1 : Form
    {
        public List<Product> saveProducts= [];
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }

        private async void GoToParse_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            int selectedItem = 0;
            if (comboBox1.SelectedIndex != -1)
            {
                selectedItem = comboBox1.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Элемент не выбран");
            }
            string textBoxContent = KolProducts.Text;

            if (string.IsNullOrWhiteSpace(textBoxContent))
            {
                MessageBox.Show("Текстовое поле пустое. Пожалуйста, введите число.");
            }
            else if (!double.TryParse(textBoxContent, out double number))
            {
                MessageBox.Show("Введенное значение не является числом. Пожалуйста, введите число.");
            }
            else if (number <= 0)
            {
                MessageBox.Show("Введенное число должно быть больше 0. Пожалуйста, введите число больше 0.");
            }
            List<string> pages =await ParseLinkSection.ParseLinkMilaAsync();

            List<string> alllinks = await SitePages.ParsePageAsync(pages[selectedItem + 2]);
            List<Product> products = [];
            int productCount = int.Parse(KolProducts.Text);
            if (productCount > alllinks.Count)
            {
                MessageBox.Show("Запрошенное количество продуктов больше, чем доступно. Будут показаны все доступные продукты.");
                productCount = alllinks.Count;
            }
            saveProducts = [];

            for (int i = 0; i < productCount; i++)
            {
                label3.Visible = false;
                Product product = await ParseProduct.ParseSinglePageAsync(alllinks[i]);
                products.Add(product);
                dataGridView1.Rows.Add(i + 1, product.Name, product.DiscountPrice, product.FullPrice,
                    product.Brand, product.Provider, product.AdressProvider, product.CountryOfOrigin);
                saveProducts.Add(product);
            }



        }

        private void Clean_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                string json = JsonConvert.SerializeObject(saveProducts, Formatting.Indented);

                try
                {
                    File.WriteAllText(saveFileDialog.FileName, json);
                    MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


