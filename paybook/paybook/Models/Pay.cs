using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace paybook.Models
{
    public class Pay
    {
        public int id { get; set; }
        [DisplayName("種別")]
        public int Type { get; set; }//種別
        [DisplayName("支払金額")]
        public int money { get; set; }//金額
        [DisplayName("振込口座")]
        public int bank { get; set; }//口座名
        [DisplayName("引落日")]
        public String payDay { get; set; }//引き落とし日
        [DisplayName("引落月")]
        public String payMonth { get; set; }//引き落とし月
        [DisplayName("入力日")]
        public DateTime insdate { get; set; }//入力日
        
    }
}
