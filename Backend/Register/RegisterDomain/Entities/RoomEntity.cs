using System;
namespace RegisterDomain.Entities
{
	public class RoomTypeEntity
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Acronym { get; set; }

        public RoomTypeEntity(Guid id, string name, string acronym)
		{
			Id = id;
			Name = name;
			Acronym = acronym;
		}
	}
}

