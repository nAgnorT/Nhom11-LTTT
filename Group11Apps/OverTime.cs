using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11Apps
{
    class OverTime
    {
        [Key, AutoIncrement]
        public int Id { get; set; }
        public string TuNgay {get; set;}
        public string DenNgay { get; set; }
        public string TuGio { get; set; }
        public string DenGio { get; set; }
        public string NguoiDangKy { get; set; }
        public string LyDo { get; set; }
        public override string ToString()
        {
            return $"{TuNgay} - {DenNgay} - {TuGio} - {DenGio} - {NguoiDangKy}-{LyDo}";
        }
    }
}
