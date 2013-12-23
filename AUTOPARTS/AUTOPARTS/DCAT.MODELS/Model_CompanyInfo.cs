using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AUTOPARTS.DCAT.MODELS
{
    public class Model_CompanyInfo
    {
      public int CMPID { get; set; }
      public string CMPNAME { get; set; }
      public string CMPTAXID { get; set; }
      public string CMPADDL1 { get; set; }
      public string CMPADDL2 { get; set; }
      public string CMPPHONE1 { get; set; }
      public string CMPPHONE2 { get; set; }
      public string CMPFAX1 { get; set; }
      public string CMPFAX2 { get; set; }
      public string CMPEMAIL { get; set; }
      public string CMPWEB { get; set; }
      public byte CMPLOGO { get; set; }
    }
}
