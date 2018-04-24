using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJView
{
    class BeatController : IController
    {
        IBeatModel model;
        DJViewForm view;

        public BeatController(IBeatModel model)
        {
            this.model = model;
            view = new DJViewForm(this, model)
            {
                Visible = true
            };
            view.Activate();
            view.DisableStopMenuItem();
            view.EnableStartMenuItem();
            model.Initialize();
            
        }

        public void Start()
        {
            model.On();
            view.DisableStartMenuItem();
            view.EnableStopMenuItem();
        }

        public void Stop()
        {
            model.Off();
            view.DisableStopMenuItem();
            view.EnableStartMenuItem();
        }

        public void IncreaseBPM()
        {
            int bpm = model.GetBPM();
            model.SetBPM(bpm + 1);
        }

        public void DecreaseBPM()
        {
            int bpm = model.GetBPM();
            model.SetBPM(bpm - 1);
        }

        public void SetBPM(int bpm)
        {
            model.SetBPM(bpm);
        }
    }
}
