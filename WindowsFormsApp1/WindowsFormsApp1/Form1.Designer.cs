namespace SimpleInterfaceExample
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBox
            this.textBox.Location = new System.Drawing.Point(20, 20);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(200, 20);
            this.textBox.TabIndex = 0;

            // button
            this.button.Location = new System.Drawing.Point(20, 50);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Нажми меня";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);

            // label
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(20, 90);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Здесь будет результат";

            // MainForm
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.Name = "MainForm";
            this.Text = "Пример простого интерфейса";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

