using System;
namespace RegisterDomain.Entities
{
	public class RoomEntity
	{
		public Guid Id { get; set; }
		public int Number { get; set; }
        public int Flor { get; set; }
        public Guid RoomTypeId { get; set; }
        public string? Description { get; set; }

        public RoomEntity(Guid id, int number, int flor, Guid roomType)
		{
			Id = id;
			Number = number;
			Flor = flor;
			RoomTypeId = roomType;
		}
	}
}

