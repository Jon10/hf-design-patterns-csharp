using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;

namespace DJView
{
    class BeatModel : IBeatModel
    {
        OutputDevice outputDevice;
        List<IBeatObserver> beatObservers = new List<IBeatObserver>();
        List<IBPMObserver> bpmObservers = new List<IBPMObserver>();
        int bpm = 90;

        public void Initialize()
        {
            SetupMidi();
            BuildTrackAndStart();
        }

        public void On()
        {
            //outputDevice.Open();
            SetBPM(90);
        }

        public void Off()
        {
            SetBPM(0);
            if (outputDevice.IsOpen)
                outputDevice.Close();
        }

        private void SetupMidi()
        {
            
        }

        private void BuildTrackAndStart()
        {

        }

        public void SetBPM(int bpm)
        {
            this.bpm = bpm;
            NotifyBPMObservers();
        }

        public int GetBPM() => bpm;
        public void RegisterObserver(IBeatObserver o) => beatObservers.Add(o);
        public void RemoveObserver(IBeatObserver o) => beatObservers.Remove(o);
        public void RegisterObserver(IBPMObserver o) => bpmObservers.Add(o);
        public void RemoveObserver(IBPMObserver o) => bpmObservers.Remove(o);
        void BeatEvent() => NotifyBeatObservers();
        void NotifyBeatObservers() { foreach (IBeatObserver o in beatObservers) o.UpdateBeat(); }
        void NotifyBPMObservers() { foreach (IBPMObserver o in bpmObservers) o.UpdateBPM(); }
    }
}
