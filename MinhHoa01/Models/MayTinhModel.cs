using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhHoa01.Models
{
    public class MayTinhModel
    {
        public double So1 { get; set; }

        public double So2 { get; set; }

        public string PhepTinh { get; set; }

        public double KetQua()
        {
            double ketqua = 0;
            switch (PhepTinh)
            {
                case "+": ketqua = So1 + So2; break;
                case "-": ketqua = So1 - So2; break;
                case "*": ketqua = So1 * So2; break;
                case "/": ketqua = So1 / So2; break;
            }
            return ketqua;
            
        }
    }
}
