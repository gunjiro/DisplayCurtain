using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepDisplay
{
    public partial class MainForm : Form
    {
        private const int WAITING_SECOND = 10;
        private readonly Display display;
        private readonly Timer timer;

        public MainForm()
        {
            InitializeComponent();
            display = new Display();
            timer = new Timer(WAITING_SECOND, UpdateTime);
            UpdateTimeRemainLabel(WAITING_SECOND);
            timer.Start();
        }

        private void UpdateTime(int second)
        {
            if (second > 0)
            {
                UpdateTimeRemainLabel(second);
            }
            else
            {
                display.Off();
                Close();
            }
        }

        private void UpdateTimeRemainLabel(int second)
        {
            timeRemainLabel.Text = String.Format("残り{0}秒", second);
        }
    }
}
