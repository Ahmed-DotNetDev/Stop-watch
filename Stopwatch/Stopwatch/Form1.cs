using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Stopwatch
{
	public partial class Form1 : Form
	{
		System.Timers.Timer timer;
		int hour, minute, second, millisecond;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnstart_Click(object sender, EventArgs e)
		{
			timer.Start();
		}

		private void btnstop_Click(object sender, EventArgs e)
		{
			timer.Stop();
		}

		private void btnreset_Click(object sender, EventArgs e)
		{
			timer.Stop();
			label1.Text = "00:00:00:00";
			hour = 0;
			minute = 0;
			second = 0;
			millisecond = 0;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer = new System.Timers.Timer();
			timer.Interval = 1;
			timer.Elapsed += OnTimeEvent;
			
		}

		private void OnTimeEvent( object sender , ElapsedEventArgs e)
		{
			Invoke(new Action(() => {
				millisecond += 1;
				if(millisecond==100)
				{
					millisecond = 0;
					second += 1;
				}

				else if (label1.Text=="00:00:01:00")
				{
					SoundPlayer simpleSound = new SoundPlayer("alarm buzzer.wav");
					simpleSound.PlaySync();
					timer.Enabled = false;
				}

				else if (second==60)
				{
					
					second = 0;
					minute += 1;
				}

				else if (minute == 60)
				{
					minute = 0;
					hour += 1;
				}
				
				label1.Text = string.Format("{0}:{1}:{2}:{3}",hour.ToString().PadLeft(2,'0') ,minute.ToString().PadLeft(2,'0') ,second.ToString().PadLeft(2,'0'),millisecond.ToString().PadLeft(2,'0') );

			}));
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
