using System.Collections.Generic;
using System.Linq;
using DataTemplates.Model;
using GalaSoft.MvvmLight;

namespace DataTemplates.ViewModel
{
    public class RobotDataViewModel : ViewModelBase
    {
        readonly IList<RobotData> robotsData;
        RobotData selectedValue;

        public RobotDataViewModel()
        {
            robotsData = new List<RobotData>
            {
                new RobotData
                {
                    SubType = "HandlingRobots",
                    FunctionGroups =new List<string> { "010RB_100", "010RB_200" },
                    IsChecked5Axis=true
                },
                new RobotData
                {
                    SubType = "ClinchingRobots",
                    FunctionGroups =new List<string> { "110RB_100", "110RB_200" },
                    IsChecked7Axis=true
                },
                new RobotData
                {
                    SubType = "WeldingRobots",
                    FunctionGroups =new List<string> { "160RB_100", "170RB_200" },
                    IsCheckedToolChanger=true
                }
            };
            SelectedValue = robotsData.First();
        }

        public RobotData SelectedValue
        {
            get
            {
                return selectedValue;
            }
            set
            {
                selectedValue = value;
                RaisePropertyChanged(() => SelectedValue);
            }
        }

        public IEnumerable<RobotData> RobotsData
        {
            get
            {
                return robotsData;
            }
        }
    }
}