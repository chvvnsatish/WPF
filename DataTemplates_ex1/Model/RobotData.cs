using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplates.Model
{
    public class RobotData
    {
        public string SubType { get; set; }

        public List<string> FunctionGroups { get; set; }

        public bool IsChecked5Axis { get; set; }

        public bool IsChecked7Axis { get; set; }

        public bool IsCheckedToolChanger { get; set; }
    }
}
