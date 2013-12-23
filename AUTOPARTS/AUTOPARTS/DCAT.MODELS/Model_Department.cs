using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AUTOPARTS.DCAT.MODELS
{
    public class Model_Department
    {
        private string depCode;

        public string DepCode
        {
            get { return depCode; }
            set { depCode = value; }
        }
        private string depName;

        public string DepName
        {
            get { return depName; }
            set { depName = value; }
        }
    }
}
