using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AUTOPARTS.DCAT.MODELS
{
    public class Model_User
    {
        public int USID { get; set; }
        public string UNAME { get; set; }
        public string UPW { get; set; }
        public int UGID { get; set; }
        public int LOGINSTATUS { get; set; }
        public int ACTIVE { get; set; }

    }
}
