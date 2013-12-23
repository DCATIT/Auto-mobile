using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AUTOPARTS.DCAT.MODELS
{
    public class Model_ItemMaster
    {
        public string ITEMCODE { get; set; }
        public string ITEMDESCRIPTION { get; set; }
        public string PARTNO { get; set; }
        public string PARTNAME { get; set; }
        public string ALTPARTNO { get; set; }
        public string ALTPARTNAME { get; set; }
        public string SPECIAL { get; set; }
        public string UOM { get; set; }
        public string BIN { get; set; }
        public int GENSTATUS { get; set; }
        public string SUBCATID { get; set; }
        public int ACTIVE { get; set; }
    }
}
