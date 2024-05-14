using ParseMila;

namespace MilaShopParser
{

    public partial class Form1 : Form
    {
        private readonly List<Product> saveProducts = [];
        private int countProductToSave = 0;
        private List<Section> Pages { get; set; }
      

        public Form1(List<Section> pages)
        {
            InitializeComponent();
            logingStatus.Visible = false;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.Pages = pages;
            foreach (var page in pages)
            {
                ListSection.Items.Add(page.GetNameSection());
            }
        }

        private async void StartParsing_Click(object sender, EventArgs e)
        {
            logingStatus.Visible = true;

            if (ListSection.SelectedIndex == -1)
            {
                MessageBox.Show("Элемент не выбран");
                return;

            }
            int selectedItem = ListSection.SelectedIndex;
            int coutProduct = (int)Count.Value;
            List<Product> products = await ParseProduct.GetProducts(Pages[selectedItem].GetUrlSection(), coutProduct);
            foreach (var product in products)
            {
                countProductToSave++;
                logingStatus.Visible = false;
                dataGridView1.Rows.Add(countProductToSave, product.Name, product.DiscountPrice, product.FullPrice,
                    product.Brand, product.Provider, product.AdressProvider, product.CountryOfOrigin);
                saveProducts.Add(product);
            }
        }
        private void Clean_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            saveProducts.Clear();
            countProductToSave = 0;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WorkWithJson.Write(saveProducts, saveFileDialog1.FileName);
            }
        }

        private void ListSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Count.Maximum = Pages[ListSection.SelectedIndex].GetCountProduct();
        }
    }
}


