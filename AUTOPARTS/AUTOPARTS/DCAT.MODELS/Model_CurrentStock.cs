using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AUTOPARTS.DCAT.MODELS
{
    public  class Model_CurrentStock
    {
        public string ITEMCODE { get; set; }
        public decimal OPNBAL_QTY { get; set; }
        public decimal OPENBAL_VAL { get; set; }
        public decimal PUR_QTY { get; set; }
        public decimal PUR_VAL { get; set; }
        public decimal PURRET_QTY { get; set; }
        public decimal PURRET_VAL { get; set; }
        public decimal SAL_QTY { get; set; }
        public decimal SAL_VAL { get; set; }
        public decimal SALRET_QTY { get; set; }
        public decimal SALRET_VAL { get; set; }
        public decimal DMG_QTY { get; set; }
        public decimal DMG_VAL { get; set; }
        public decimal ADJ_QTY { get; set; }
        public decimal ADJ_VAL { get; set; }        
        public decimal COSTPRICE { get; set; }
        public decimal SELLINGPRICE { get; set; }
        public decimal SIH { get; set; }

        public string SUP_CODE { get; set; }
        public string LOC_CODE { get; set; }
        
    }
}
