using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json; 

namespace WebAPI_Winform
{
    public partial class Form1 : Form
    {
        // Khởi tạo HttpClient dùng chung cho toàn bộ Form
        private readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:9999/api/")
        };

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Xử lý sự kiện Tìm kiếm (khớp với tên trong Designer)
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtSearch.Text;
                // Gọi API: GET http://localhost:9999/api/books/search?name=...
                var response = await client.GetAsync($"books/search?name={name}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var books = JsonConvert.DeserializeObject<List<Book>>(jsonString);

                    // Hiển thị danh sách lên DataGridView
                    dgvBooks.DataSource = books;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu hoặc lỗi Server.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối API: " + ex.Message);
            }
        }

        // 2. Xử lý sự kiện Thêm sách (khớp với tên trong Designer)
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào cơ bản
                if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                var newBook = new Book
                {
                    Title = txtTitle.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ImageURL = "Content/ImageBooks/default.jpg" // Có thể thay bằng logic chọn file
                };

                var json = JsonConvert.SerializeObject(newBook);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Gọi API: POST http://localhost:9999/api/books
                var response = await client.PostAsync("books", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm sách thành công!");
                    // Reset form và load lại danh sách
                    txtTitle.Clear();
                    txtPrice.Clear();
                    btnSearch_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Mã lỗi: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }

    // 3. Class Model để hứng dữ liệu (nên trùng khớp với Model ở Web API)
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public int CategoryId { get; set; }
    }
}