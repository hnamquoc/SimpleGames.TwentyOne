
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleGames.TwentyOne
{
    /// <summary>
    /// Description of Number.
    /// </summary>
    public class Number : Button
    {
        const int btnSize = 80;
        public int Value { get; private set; }
		
        public Number(int value)
        {
            this.Value = value;
			
            var btn = (Button)this;
            btn.Text = value.ToString();
            btn.Width = btnSize;
            btn.Height = btnSize;
            btn.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Regular);
            btn.ForeColor = Color.Blue;
        }
    }
}
