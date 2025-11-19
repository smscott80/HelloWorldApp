using System;
using System.Windows.Forms;

namespace HelloWorldApp
{
    public class Form1 : Form
    {
        private Button helloButton = null!;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.helloButton = new Button();
            this.SuspendLayout();

            // helloButton
            this.helloButton.Location = new System.Drawing.Point(100, 80);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(120, 40);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "Click Me!";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new EventHandler(this.HelloButton_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.helloButton);
            this.Name = "Form1";
            this.Text = "Hello World Application";
            this.ResumeLayout(false);
        }

        private void HelloButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
