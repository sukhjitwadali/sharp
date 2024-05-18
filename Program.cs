partial class Form1
{
    private Button button;

    private void InitializeComponent()
    {
        this.button = new System.Windows.Forms.Button();
        // Other control initialization code...

        // Button
        this.button.Location = new System.Drawing.Point(100, 100);
        this.button.Name = "button";
        this.button.Size = new System.Drawing.Size(100, 30);
        this.button.Text = "Click Me";
        this.button.Click += new System.EventHandler(this.button_Click);
        // Add the button to the form
        this.Controls.Add(this.button);

        // Other control initialization code...
    }
}
