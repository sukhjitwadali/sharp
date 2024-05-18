namespace MyWinFormsApp
{
    partial class Form1
    {
        // Declare the button control
        private Button button;

        // This method initializes the form's controls
        private void InitializeComponent()
        {
            // Other control initialization code...

            // Button
            this.button = new System.Windows.Forms.Button();
            this.button.Location = new System.Drawing.Point(100, 100);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 30);
            this.button.Text = "Click Me";
            // Wire up the Click event to the button_Click method
            this.button.Click += new System.EventHandler(this.button_Click);
            // Add the button to the form
            this.Controls.Add(this.button);

            // Other control initialization code...
        }
    }
}
