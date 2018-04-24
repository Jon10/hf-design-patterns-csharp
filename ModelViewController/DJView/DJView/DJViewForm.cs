using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DJView
{
    public partial class DJViewForm : Form, IBeatObserver, IBPMObserver
    {
        IController controller;
        IBeatModel model;

        public DJViewForm(IController controller, IBeatModel model)
        {
            InitializeComponent();

            this.controller = controller;
            this.model = model;
            this.model.RegisterObserver((IBeatObserver)this);
            this.model.RegisterObserver((IBPMObserver)this);

            setButton.Click += new EventHandler(this.ClickEvent);
            decreaseButton.Click += new EventHandler(this.ClickEvent);
            increaseButton.Click += new EventHandler(this.ClickEvent);
            startToolStripMenuItem.Click += new EventHandler(this.ClickEvent);
            stopToolStripMenuItem.Click += new EventHandler(this.ClickEvent);
            quitToolStripMenuItem.Click += new EventHandler(this.ClickEvent);
        }

        public void EnableStartMenuItem() => startToolStripMenuItem.Enabled = true;
        public void DisableStartMenuItem() => startToolStripMenuItem.Enabled = false;
        public void EnableStopMenuItem() => stopToolStripMenuItem.Enabled = true;
        public void DisableStopMenuItem() => stopToolStripMenuItem.Enabled = false;

        private void ClickEvent(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "setButton":
                        if (Int32.TryParse(bpmText.Text, out int bpm))
                            controller.SetBPM(bpm);
                        break;
                    case "decreaseButton":
                        controller.DecreaseBPM();
                        break;
                    case "increaseButton":
                        controller.IncreaseBPM();
                        break;
                }
            }
            else if (sender is ToolStripMenuItem menuItem)
            {                switch (menuItem.Name)
                {
                    case "startToolStripMenuItem":
                        controller.Start();
                        break;
                    case "stopToolStripMenuItem":
                        controller.Stop();
                        break;
                    case "quitToolStripMenuItem":
                        break;
                }
            }
        }

        public void UpdateBeat()
        {
            bpmBar.Value = 100;
        }

        public void UpdateBPM()
        {
            currentBPMLabel.Text = "Current BPM: " + model.GetBPM();
        }
    }
}
