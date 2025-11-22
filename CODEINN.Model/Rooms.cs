using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEINN.Model
{
    public class Rooms
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public bool IsAvailable { get; set; }

    }
}
