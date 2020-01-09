using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReliefGenerator
{
    public partial class MainForm : Form
    {
        private int[,] _fieldDepths;
        private Panel[,] _field;

        FileManager _fileManager;

        public MainForm()
        {
            InitializeComponent();

            _fileManager = new FileManager("map.txt");
        }

        private void button_createField_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            if(textBox_x.Text != "")
            {
                x = Convert.ToInt32(textBox_x.Text);
            }

            if (textBox_y.Text != "")
            {
                y = Convert.ToInt32(textBox_y.Text);
            }

            if (x > 0 && x < 45 &&
                y > 0 && y <45)
            {
                CreateField(panel_field, x, y);
            }
            else
            {
                MessageBox.Show("Введенные размеры поля должны быть в пределах от 0 до 45!");
            }
        }

        public void CreateField(Panel panelField, int xFieldSize, int yFieldSize)
        {
            _field = new Panel[yFieldSize, xFieldSize];
            _fieldDepths = new int[yFieldSize, xFieldSize];

            int xLocation = 10;
            int yLocation = 10;

            int xLocationStart = xLocation;
            int yLocationStart = yLocation;

            int xSize = 50;
            int ySize = 50;

            for (int i = 0; i < yFieldSize; i++)
            {
                for (int k = 0; k < xFieldSize; k++)
                {
                    _field[i, k] = new Panel();
                    _field[i, k].Location = new Point(xLocation, yLocation);
                    _field[i, k].Size = new Size(xSize, ySize);
                    _field[i, k].BackColor = Color.Gray;
                    _field[i, k].Click += new EventHandler(HandleFieldClick);

                    panelField.Controls.Add(_field[i, k]);

                    xLocation += xSize + 5;
                }

                xLocation = xLocationStart;
                yLocation += ySize + 5;
            }
        }

        private void HandleFieldClick(object sender, EventArgs e)
        {
            int blueDegree = 255 - (int)(255 * Convert.ToInt32(textBox_depth.Text) / 100 * 0.66);

            Panel clickedPanel = (Panel)sender;
            clickedPanel.BackColor = Color.FromArgb(70, 70, blueDegree);

            // Saving depth info:
            int[] clickedObjectIndexes = FindObjIndexesByPanel(clickedPanel);

            _fieldDepths[clickedObjectIndexes[0], clickedObjectIndexes[1]] = Convert.ToInt32(textBox_depth.Text);
        }

        private int[] FindObjIndexesByPanel(Panel panel)
        {
            for (int i = 0; i < _field.GetLength(0); i++)
            {
                for (int k = 0; k < _field.GetLength(1); k++)
                {
                    if (_field[i,k] == panel)
                    {
                        return new Int32[2] { i, k };
                    }
                }
            }

            return null;
        }

        private void button_saveMap_Click(object sender, EventArgs e)
        {
            _fileManager.SaveMap(_fieldDepths);
        }
    }
}
