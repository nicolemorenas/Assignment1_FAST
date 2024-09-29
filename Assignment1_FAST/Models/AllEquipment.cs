using System;
namespace Assignment1_FAST.Models
{
	public class AllEquipment
	{

        public class Equipment
        {
            public int Id { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public bool IsAvailable { get; set; }
        }

        public List<Equipment> EquipmentList { get; set; }

		public AllEquipment()
		{
			EquipmentList = new List<Equipment>
			{
				new Equipment {Id = 1, Type ="Phone", Description = "Grey Iphone 11 64GB", IsAvailable = false},
                new Equipment {Id = 2, Type ="Laptop", Description = "Pink Mac Book Pro", IsAvailable = false},
                new Equipment {Id = 3, Type ="Tablet", Description = "Yellow Samsung Tablet", IsAvailable = true},
                new Equipment {Id = 4, Type ="Phone", Description = "Blackberry Blue", IsAvailable = true},
                new Equipment {Id = 5, Type ="Laptop", Description = "Lenovo Intel 8", IsAvailable = true},
                new Equipment {Id = 6, Type ="Tablet", Description = "Ipad Pro Violet", IsAvailable = true},
            };
		}
	}
}

