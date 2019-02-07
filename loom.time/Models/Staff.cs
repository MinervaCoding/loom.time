using System;

using System.Collections.Generic;

using SQLite;

using SQLiteNetExtensions.Attributes;

namespace loom.time.Models
{

public class Staff 
{
		
	public System.Nullable<int> Department { get; set; }
	
	public string FirstName { get; set; }
	
	public System.Nullable<int> HoursPerWeek { get; set; }
	
	public string LastName { get; set; }
	
	public System.Nullable<int> Skill { get; set; }
	
	public int StaffID { get; set; }
	
	public string WindowsUser { get; set; }
	}
}
