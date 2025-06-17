using System.Drawing;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region

    private void InitializeComponent()
    {
            this.newButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDisplayLabel = new System.Windows.Forms.Label();
            this.coordinatesLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();


 
            this.newButton.Location = new System.Drawing.Point(12, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(100, 30);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
  
        

            this.openButton.Location = new System.Drawing.Point(118, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 30);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
     


            this.saveButton.Location = new System.Drawing.Point(224, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 30);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      


            this.clearButton.Location = new System.Drawing.Point(330, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 30);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
       


            this.exitButton.Location = new System.Drawing.Point(436, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 30);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);



            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 350);
            this.panel1.TabIndex = 5;


 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);



            this.colorButton.Location = new System.Drawing.Point(12, 404);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(100, 30);
            this.colorButton.TabIndex = 6;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);



            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Size:";


 
            this.numericUpDown1.Location = new System.Drawing.Point(213, 408);
            this.numericUpDown1.Maximum = new decimal(new int[] {50,0,0,0});
            this.numericUpDown1.Minimum = new decimal(new int[] {1,0,0,0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {1,0,0,0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);



            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Color:";



            this.colorDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorDisplayLabel.Location = new System.Drawing.Point(310, 408);
            this.colorDisplayLabel.Name = "colorDisplayLabel";
            this.colorDisplayLabel.Size = new System.Drawing.Size(30, 20);
            this.colorDisplayLabel.TabIndex = 10;


            this.coordinatesLabel.AutoSize = true;
            this.coordinatesLabel.Location = new System.Drawing.Point(346, 410);
            this.coordinatesLabel.Name = "coordinatesLabel";
            this.coordinatesLabel.Size = new System.Drawing.Size(50, 16);
            this.coordinatesLabel.TabIndex = 11;
            this.coordinatesLabel.Text = "X: -, Y: -";
 

            this.ClientSize = new System.Drawing.Size(548, 446);
            this.Controls.Add(this.coordinatesLabel);
            this.Controls.Add(this.colorDisplayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.newButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Simple SAI Analogue";
            this.Icon = new Icon("img.ico");
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button newButton;
    private System.Windows.Forms.Button openButton;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.Button exitButton;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button colorButton;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label colorDisplayLabel;
    private System.Windows.Forms.Label coordinatesLabel;
}

