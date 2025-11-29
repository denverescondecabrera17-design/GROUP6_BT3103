using System.Collections.Generic;
using CODEINN.Model;
using CODEINN.Repository;

namespace CODEINN.Controller
{
    public class RoomController
    {
        private readonly RoomRepository roomRepository;

        public RoomController()
        {
            roomRepository = new RoomRepository();
        }

        public int GetUnavailableRoomsCount()
        {
            return roomRepository.GetUnavailableRoomsCount();
        }

        public List<Rooms> GetAllRooms()
        {
            return roomRepository.GetAllRooms();
        }

        public int AddRoom(Rooms room)
        {
            return roomRepository.AddRoom(room);
        }

        public void EditRoom(Rooms room)
        {
            roomRepository.EditRoom(room);
        }

        public void DeleteRoom(int roomId)
        {
            roomRepository.DeleteRoom(roomId);
        }

        public int GetAvailableRoomsCount()
        {
            return roomRepository.GetAvailableRoomsCount(); 
        }
        public int GetOccupiedRoomsCount()
        {
            return roomRepository.GetOccupiedRoomsCount();
        }

    }
}
