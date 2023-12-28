using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace sdxl_turbo_0._1_beta
{
    public partial class Form1 : Form
    {
        string url = "https://modal-labs--stable-diffusion-xl-turbo-model-inference.modal.run/";
        int generate_start = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void SelectPhoto(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Изображения|*.jpg;*.png;*.jpeg|All Files|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture_input.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private async void generate_Click(object sender, EventArgs e)
        {
            string prompet = promp.Text;
            if (prompet != "")
            {
                if (picture_input.Image != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        generate.Enabled = false;
                        generate.Text = "Генерирую...";
                        picture_input.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                        byte[] imageBytes = memoryStream.ToArray();

                        var fileContent = new ByteArrayContent(imageBytes);

                        using (var client = new HttpClient())
                        {
                            var formData = new MultipartFormDataContent();
                            formData.Headers.Add("promp", prompet);
                            formData.Add(fileContent, "image", "photo.png");
                            formData.Add(new StringContent("2"), "num_iterations");
                            formData.Add(new StringContent(prompet), "prompt");

                            client.DefaultRequestHeaders.Add("authority", "modal-labs--stable-diffusion-xl-turbo-model-inference.modal.run");
                            client.DefaultRequestHeaders.Add("accept", "*/*");
                            client.DefaultRequestHeaders.Add("accept-language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
                            client.DefaultRequestHeaders.Add("origin", "https://turbo.art");
                            client.DefaultRequestHeaders.Add("referer", "https://turbo.art/");
                            client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Opera\";v=\"105\", \"Chromium\";v=\"119\", \"Not?A_Brand\";v=\"24\"");
                            client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                            client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
                            client.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
                            client.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
                            client.DefaultRequestHeaders.Add("sec-fetch-site", "cross-site");
                            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 OPR/105.0.0.0 (Edition Yx 05)");

                            var response = await client.PostAsync(url, formData);
                            if (response.IsSuccessStatusCode)
                            {
                                var resultImageBytes = await response.Content.ReadAsByteArrayAsync();
                                generate.Text = "Генерировать";
                                generate.Enabled = true;
                                using (MemoryStream ms = new MemoryStream(resultImageBytes))
                                {
                                    System.Drawing.Image resultImage = System.Drawing.Image.FromStream(ms);
                                    picture_result.Image = resultImage;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ошибка: " + response.StatusCode);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Вы забыли выбрать изображение для модификации");
                }
            }
            else
            {
                MessageBox.Show("Вы забыли указать Promp");
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (picture_result.Image != null)
            {
                Clipboard.SetImage((System.Drawing.Image)picture_result.Image);
                MessageBox.Show("Изображение скопировано в буфер обмена!");
            }
            else
            {
                MessageBox.Show("Нет изображения для копирования!");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (picture_result.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Изображения (*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg|Все файлы (*.*)|*.*";
                saveFileDialog.Title = "Сохранить изображение как...";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    ImageFormat imageFormat = ImageFormat.Png;

                    switch (System.IO.Path.GetExtension(filePath).ToLower())
                    {
                        case ".jpg":
                        case ".jpeg":
                            imageFormat = ImageFormat.Jpeg;
                            break;
                    }

                    picture_result.Image.Save(filePath, imageFormat);

                    MessageBox.Show($"Изображение успешно сохранено по пути:\n{filePath}", "Сохранение завершено");
                }
            }
            else
            {
                MessageBox.Show("Нет изображения для сохранения!");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsImage())
                {
                    System.Drawing.Image clipboardImage = Clipboard.GetImage();
                    picture_input.Image = clipboardImage;
                }
            }
        }

        private void promp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsImage())
                {
                    System.Drawing.Image clipboardImage = Clipboard.GetImage();
                    picture_input.Image = clipboardImage;
                }
            }
        }
    }
}
