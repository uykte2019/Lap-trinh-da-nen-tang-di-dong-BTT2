using System;
using System.Collections.Generic;
using System.Text;

namespace PageListViewGroup
{
    public class hoa
    {
        public string TenHoa { get; set; }
        public string Hinh { get; set; }
        public double Gia { get; set; }
        public string MoTa { get; set; }
    }

    public class LoaiHoa : List<hoa>
    {
        public string TenLoai { get; set; }
        private LoaiHoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<LoaiHoa> Loaihoas { get; set; }
        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {


                new LoaiHoa("Hoa cúc")
                {



                    new hoa { TenHoa = "Đón Xuân", Gia = 50000, Hinh = "cuc1.jpg", MoTa = "Hoa cúc các :trắng ,vàng, cam" },
                    new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "cuc2.jpg", MoTa = "Hoa Cúc các vàng, cam, lá măng " },
                    new hoa { TenHoa = "Tím thuỷ chung", Gia = 45000, Hinh = "cuc3.jpg", MoTa = "Hoa Cúc tím" }


                },
                new LoaiHoa("Hoa cưới")
                {
                    new hoa { TenHoa = "Dây tơ hồng", Gia = 250000, Hinh = "cuc4.jpg", MoTa = "Hoa hồng màu hồng đậm, hoa hồng xanh, các loại lá măng" },
                    new hoa { TenHoa = "Cầu thuỷ tinh", Gia = 220000, Hinh = "cuc5.jpg", MoTa = "Hoa hồng và hoa thuỷ tinh trắng" },
                    new hoa { TenHoa = "Duyên thầm", Gia = 260000, Hinh = "cuc6.jpg", MoTa = "Hoa cúc trắng, baby, lá măng" }

                }
            };

            Loaihoas = l;
        }


    }
}
