using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private Bitmap canvas;
        private bool isDrawing = false;
        private Point lastPoint;
        private Pen currentPen = new Pen(Color.Black, 1);
        private Color currentColor = Color.Black;

        public MainForm()
        {
            InitializeComponent();
            InitializePen();
            UpdateColorDisplay();
        }

        private void InitializePen()
        {
            currentPen = new Pen(currentColor, (float)numericUpDown1.Value);
            currentPen.StartCap = LineCap.Round;
            currentPen.EndCap = LineCap.Round;
        }

        private void UpdateColorDisplay()
        {
            colorDisplayLabel.BackColor = currentColor;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            var sizeForm = new SizeSelectionForm();
            if (sizeForm.ShowDialog() == DialogResult.OK)
            {
                CreateNewCanvas(sizeForm.ImageWidth, sizeForm.ImageHeight);
            }
        }

        private void CreateNewCanvas(int width, int height)
        {
            canvas = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Image = canvas;
            pictureBox1.Size = canvas.Size;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    canvas = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = canvas;
                    pictureBox1.Size = canvas.Size;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while attempting to open the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (canvas == null) return;

            saveFileDialog1.Filter = "PNG Image|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    canvas.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while attempting to save the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (canvas == null) return;

            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Invalidate();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
                currentPen.Color = currentColor;
                UpdateColorDisplay();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            currentPen.Width = (float)numericUpDown1.Value;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && canvas != null)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            coordinatesLabel.Text = $"X: {e.X}, Y: {e.Y}";

            if (isDrawing && canvas != null)
            {
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawLine(currentPen, lastPoint, e.Location);
                }
                lastPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            coordinatesLabel.Text = "X: 0, Y: 0";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            coordinatesLabel.Text = "X: -, Y: -";
        }
    }

    public class SizeSelectionForm : Form
    {
        public int ImageWidth { get; private set; } = 800;
        public int ImageHeight { get; private set; } = 600;

        public SizeSelectionForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "New Canvas";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(300, 150);

            Label widthLabel = new Label
            {
                Text = "Width:",
                Location = new Point(20, 20),
                AutoSize = true
            };

            NumericUpDown widthNumeric = new NumericUpDown
            {
                Minimum = 10,
                Maximum = 5000,
                Value = ImageWidth,
                Location = new Point(120, 18),
                Width = 100
            };

            Label heightLabel = new Label
            {
                Text = "Height:",
                Location = new Point(20, 50),
                AutoSize = true
            };

            NumericUpDown heightNumeric = new NumericUpDown
            {
                Minimum = 10,
                Maximum = 5000,
                Value = ImageHeight,
                Location = new Point(120, 48),
                Width = 100
            };

            Button okButton = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new Point(50, 90),
                Size = new Size(80, 30)
            };

            Button cancelButton = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(150, 90),
                Size = new Size(80, 30)
            };

            okButton.Click += (sender, e) =>
            {
                ImageWidth = (int)widthNumeric.Value;
                ImageHeight = (int)heightNumeric.Value;
            };

            this.Controls.Add(okButton);
            this.Controls.Add(cancelButton);
            this.Controls.Add(heightLabel);
            this.Controls.Add(heightNumeric);
            this.Controls.Add(widthLabel);
            this.Controls.Add(widthNumeric);
        }
    }
