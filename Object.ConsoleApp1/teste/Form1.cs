using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Defina o caminho base onde suas imagens estão localizadas
            string basePath = "C:\\Users\\Acer\\Documents\\0.0 - C#_Curso\\object_Base\\Object.ConsoleApp1\\teste\\Resources\\";

            // Nome da imagem (pode ser obtido de uma entrada do usuário ou de uma variável)
            string imageName = "Daniii.jpg";

            // Combinar o caminho base com o nome da imagem
            string imagePath = System.IO.Path.Combine(basePath, imageName);

            // Verifica se o arquivo existe antes de tentar carregar
            if (System.IO.File.Exists(imagePath))
            {
                // Carrega a imagem e define no PictureBox
                pictureBox1.Image = Image.FromFile(imagePath);
                // Ajusta o tamanho da imagem ao tamanho do PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                // Mensagem de erro se a imagem não for encontrada
                MessageBox.Show("Imagem não encontrada: " + imagePath);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

            // Defina o caminho base onde suas imagens estão localizadas
            string basePath = "C:\\Users\\Acer\\Documents\\0.0 - C#_Curso\\object_Base\\Object.ConsoleApp1\\teste\\Resources\\";

            // Nome da imagem (pode ser obtido de uma entrada do usuário ou de uma variável)
            string imageName = "Familia.jpg";

            // Combinar o caminho base com o nome da imagem
            string imagePath = System.IO.Path.Combine(basePath, imageName);

            // Verifica se o arquivo existe antes de tentar carregar
            if (System.IO.File.Exists(imagePath))
            {
                // Carrega a imagem e define no PictureBox
                pictureBox1.Image = Image.FromFile(imagePath);
                // Ajusta o tamanho da imagem ao tamanho do PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                // Mensagem de erro se a imagem não for encontrada
                MessageBox.Show("Imagem não encontrada: " + imagePath);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
