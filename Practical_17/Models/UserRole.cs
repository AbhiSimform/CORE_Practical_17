﻿namespace Practical_17.Models
{
	public class UserRole
	{
		public User User { get; set; }

		public int UserId { get; set; }

		public int RoleId { get; set; }

		public Role Role { get; set; }
	}
}
