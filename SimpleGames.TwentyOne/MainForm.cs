
using System;
using System.Linq;
using System.Windows.Forms;

namespace SimpleGames.TwentyOne
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        static readonly Random rnd = new Random();
        const int MAX = 5;
		
        int score = 0;
        Number[] numbs = null;
        Timer timer;
		
        public MainForm()
        {
            InitializeComponent();
			
            numbs = new Number[MAX];
            for (var i = 0; i < MAX; i++) {
                var btn = new Number(i + 1);
                btn.Click += new System.EventHandler(btn_Clicked);
                numbs[i] = btn;
                pnlNumber.Controls.Add(btn);
            }
			
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new System.EventHandler(timer_Ticked);
			
            this.Width = pnlNumber.Width + 2 * pnlNumber.Margin.All;
        }
		
        void btn_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Number;
            if (btn != null) {
                score += btn.Value;
                lblScore.Text = score.ToString();
                SetNewNumber(btn);
                if (CheckWins) {
                    MessageBox.Show("You won !");
                    Reset();
                } else
                    timer.Start();
            }
        }
		
        void timer_Ticked(object sender, EventArgs e)
        {
            var i = 0;
            var level = new[] { 21, 15, 9, 6 };
            while (true) {
                if (i < level.Length) {
                    var d = level[i++] - score;
                    if (d > 0 && d <= MAX && numbs[d - 1].Enabled) {
                        score += d;
                        var btn = numbs[d - 1];
                        SetNewNumber(btn);
                        break;
                    }
                } else {
                    var d = GoRandom(1, 3);
                    score += d;
                    SetNewNumber(numbs[d - 1]);
                    break;
                }
            }
            lblScore.Text = score.ToString();
            timer.Stop();
            if (CheckWins) {
                MessageBox.Show("You lost !");
                Reset();
            }
        }
		
        void MainFormLoad(object sender, EventArgs e)
        {
            lblScore.Text = score.ToString();
        }
		
        void SetNewNumber(Button btn)
        {
            var d = 21 - score;
            foreach (Number b in pnlNumber.Controls) {
                if (b.Value <= d) {
                    b.Enabled = true;
                } else {
                    b.Enabled = false;
                }
            }
            btn.Enabled = false;
        }
		
        bool CheckWins {
            get {
                return score >= 21;
            }
        }
		
        void Reset()
        {
            score = 0;
            foreach (Button b in pnlNumber.Controls) {
                b.Enabled = true;
            }
            lblScore.Text = score.ToString();
        }
		
        int GoRandom(int from, int to)
        {
            var d = rnd.Next(from, to);
            while (!numbs[d - 1].Enabled) {
                d = rnd.Next(1, 3);
            }
            return d;
        }
    }
}
