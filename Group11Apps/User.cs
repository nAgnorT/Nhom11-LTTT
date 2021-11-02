using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Group11Apps
{
    class User
    {
        [Key, AutoIncrement]
        public int Id { get; set; }
        public string HoTen { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string TrangThai { get; set; }
        public string Quyen { get; set; }
        public override string ToString()
        {
            return $"{HoTen} - {Username} - {Password} - {TrangThai} - {Quyen}";
        }
    }
}
