using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp142.Models
{
    public class Mission
    {
        public Mission(string missionName, MissionState state)
        {
            this.MissionName = missionName;
            this.State = state;
        }

        public string MissionName { get; set; }

        public MissionState State { get; set; }

        public void CompleteMission()
        {
            this.State = MissionState.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {this.MissionName} State: {this.State}";
        }
    }
    public enum MissionState
    {
        inProgress,
        Finished
    }
}
