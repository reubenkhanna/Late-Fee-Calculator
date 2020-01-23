namespace WindowsFormsApplication1
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboBoxItem(string v1, string v2)
        {
            this.Text = v1;
            this.Value = v2;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}