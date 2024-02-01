using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH_OP
{
    public partial class FormMain : Form
    {
        private List<Point> cities = new List<Point>(); // список вершин городов
        private bool isDrawingGraph = false; // флаг, указывающий, идет ли в данный момент рисование графа
        

        public FormMain()
        {
            InitializeComponent();
        }

        

        private void buttonGeneration_Click_1(object sender, EventArgs e)
        {
            isDrawingGraph = true;

            // Очищаем pictureBoxGraphs перед началом нового рисунка
            pictureBoxGraphs.Refresh();

            // Сбрасываем список городов, чтобы начать нумерацию снова
            cities.Clear();
        }
        public void DrawGraph(List<Point> path, Graphics g)
        {
            Pen pen = new Pen(Color.Red);
            AdjustableArrowCap arrow = new AdjustableArrowCap(7, 7);
            pen.CustomEndCap = arrow;

            Font font = new Font("Arial", 12);
            Brush brush = new SolidBrush(Color.Black);

            int totalDistance = 0;

            for (int i = 0; i < path.Count - 1; i++)
            {
                g.DrawLine(pen, path[i], path[i + 1]);

                // Вычисляем расстояние между городами
                int distance = (int)NearestNeighbor.CalculateDistance(path[i], path[i + 1]);

                // Вычисляем координаты середины между городами
                int midX = (path[i].X + path[i + 1].X) / 2;
                int midY = (path[i].Y + path[i + 1].Y) / 2;

                // Отображаем расстояние между городами
                g.DrawString(distance.ToString(), font, brush, midX, midY);

                totalDistance += distance;
            }

            // Соединяем последний город с первым
            g.DrawLine(pen, path[path.Count - 1], path[0]);

            // Отображаем расстояние между последним и первым городами
            int distanceToFirst = (int)NearestNeighbor.CalculateDistance(path[path.Count - 1], path[0]);
            int midXFirstLast = (path[path.Count - 1].X + path[0].X) / 2;
            int midYFirstLast = (path[path.Count - 1].Y + path[0].Y) / 2;
            g.DrawString(distanceToFirst.ToString(), font, brush, midXFirstLast, midYFirstLast);
        }

        private void buttonOtvet_Click_1(object sender, EventArgs e)
        {
            if (!isDrawingGraph)
            {
                MessageBox.Show("Необходимо выбрать вершины.");
                return;
            }
            isDrawingGraph = false;
            List<Point> optimalPath = NearestNeighbor.NearestNeighborAlgorithm(cities);

            int totalDistance = 0;
            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.Append("Оптимальный маршрут: ");

            for (int i = 0; i < optimalPath.Count - 1; i++)
            {
                int distance = (int)NearestNeighbor.CalculateDistance(optimalPath[i], optimalPath[i + 1]);
                totalDistance += distance;
                resultBuilder.Append($"{cities.IndexOf(optimalPath[i]) + 1} -> ");
            }

            int distanceToFirst = (int)NearestNeighbor.CalculateDistance(optimalPath[optimalPath.Count - 1], optimalPath[0]);
            totalDistance += distanceToFirst;

            resultBuilder.Append($"{cities.IndexOf(optimalPath[optimalPath.Count - 1]) + 1} -> {cities.IndexOf(optimalPath[0]) + 1}"); // Добавляем последнюю стрелку к первому городу
            resultBuilder.AppendLine();

            resultBuilder.Append("Общее расстояние: " + totalDistance);

            textBoxOtvet.Text = resultBuilder.ToString();
        }

        private void buttonGraphs2_Click(object sender, EventArgs e)
        {
            if (cities.Count != 0)
            {
                using (Graphics g = pictureBoxGraphs.CreateGraphics())
                {
                    List<Point> optimalPath = NearestNeighbor.NearestNeighborAlgorithm(cities);
                    DrawGraph(optimalPath, g);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать вершины.");
                return;
            }
        }

        private void pictureBoxGraphs_Click_1(object sender, EventArgs e)
        {

            if (isDrawingGraph) 
            {
                Point pointClicked = pictureBoxGraphs.PointToClient(MousePosition);
                cities.Add(pointClicked);

                using (Graphics g = pictureBoxGraphs.CreateGraphics())
                {
                    int cityNumber = cities.Count;
                    string cityLabel = cityNumber.ToString();

                    // Рисуем синюю точку
                    g.FillEllipse(Brushes.Blue, pointClicked.X - 10, pointClicked.Y - 10, 20, 20);

                    // Рисуем номер города с отступом 12 пикселей от точки
                    // Располагаем текст на координатах, с учетом отступа 12 пикселей
                    Font font = new Font(SystemFonts.DefaultFont.FontFamily, 15, FontStyle.Bold); // Устанавливаем размер шрифта 15 и жирное начертание
                    g.DrawString(cityLabel, font, Brushes.Black, pointClicked.X + 12, pointClicked.Y + 12);
                }
            }
            else
            {
                
            }
        }

        private void SavePictureBoxAsImage(string filePath, PictureBox pictureBox, List<Point> cities)
        {
            // Создаем новый Bitmap для хранения содержимого PictureBox
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);

            // Создаем новый Graphics объект для рисования на Bitmap
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Копируем содержимое pictureBox на Bitmap
                g.CopyFromScreen(pictureBox.PointToScreen(new Point(0, 0)), new Point(0, 0), pictureBox.Size);

                // Рисуем точки и номера городов
                using (Brush drawBrush = new SolidBrush(Color.Black))
                using (Font drawFont = new Font(SystemFonts.DefaultFont.FontFamily, 15, FontStyle.Bold))
                {
                    for (int i = 0; i < cities.Count; i++)
                    {
                        string cityLabel = (i + 1).ToString();
                        g.FillEllipse(Brushes.Blue, cities[i].X - 10, cities[i].Y - 10, 20, 20);
                        g.DrawString(cityLabel, drawFont, drawBrush, cities[i].X + 12, cities[i].Y + 12);
                    }
                }
            }

            // Сохраняем Bitmap в файл
            bmp.Save(filePath, ImageFormat.Png);

            // Освобождаем ресурсы Bitmap
            bmp.Dispose();
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            SavePictureBoxAsImage("Граф_курсач_ОП.png", pictureBoxGraphs, cities);
            MessageBox.Show("Изображение сохранено");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
