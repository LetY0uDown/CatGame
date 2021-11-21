using System;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labelCatName.Text = cat.Name;

            labelHungryState.Text = cat.Hungry + "%";
            labelMoodState.Text = cat.Mood + "%";
            labelSleepState.Text = cat.Sleep + "%";

            Task.Run(LifeCycle);
        }
        private Random random = new Random();
        public Cat cat = new Cat("Мурзик");
        private const int STATE_CHANGER = 10;
        private async void bFeed_Click(object sender, EventArgs e)
        {
            cat.Hungry += STATE_CHANGER;
            labelHungryState.Text = cat.Hungry + "%";

            await ButtonLocker(2000);
        }

        private async void bPlay_Click(object sender, EventArgs e)
        {
            cat.Mood += STATE_CHANGER;
            labelMoodState.Text = cat.Mood + "%";

            await ButtonLocker(2000);
        }

        private void bSleep_Click(object sender, EventArgs e)
        {
            cat.Sleep += STATE_CHANGER;
            labelSleepState.Text = cat.Sleep + "%";

            Task.Run(Sleep);
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async Task Sleep()
        {
            BackColor = Color.Black;

            await ButtonLocker(2000);

            BackColor = Color.Silver;
        }

        private async Task LifeCycle()
        {
            await Task.Delay(random.Next(10, 100) * 100);

            cat.Hungry -= (sbyte)random.Next(0, 15);
            labelHungryState.Text = cat.Hungry + "%";

            cat.Mood -= (sbyte)random.Next(0, 15);
            labelMoodState.Text = cat.Mood + "%";

            cat.Sleep -= (sbyte)random.Next(0, 15);
            labelSleepState.Text = cat.Sleep + "%";

            if (cat.Hungry == 0 || cat.Mood == 0 || cat.Sleep == 0)
                KillCat();

            await LifeCycle();
        }

        public void KillCat()
        {
            foreach (var label in Controls.OfType<Label>())
                label.Hide();
            foreach (var button in panelButtons.Controls.OfType<Button>())
                button.Enabled = true;

            iconCat.Hide();

            labelDeath.Text = cat.Name + " умер от недостатка внимания";
            labelDeath.Show();
        }

        private async Task ButtonLocker(int time)
        {
            foreach (var button in panelButtons.Controls.OfType<Button>())
                button.Enabled = false;    

            await Task.Delay(time);

            foreach (var button in panelButtons.Controls.OfType<Button>())
                button.Enabled = true;
        }
    }
}
