using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ewidencja
{
	public class Company
	{
		public string companyID { get; set; }
		public string companyName { get; set; }
		public string NIP { get; set; }
		public string streetName { get; set; }
		public string buildingNo { get; set; }
		public string postalCode { get; set; }
		public string city { get; set; }

		public Company(string companyID, string companyName, string NIP, string streetName, string buildingNo, string postalCode, string city)
		{
			this.companyID = companyID;
			this.companyName = companyName;
			this.NIP = NIP;
			this.streetName = streetName;
			this.buildingNo = buildingNo;
			this.postalCode = postalCode;
			this.city = city;
		}
	}

	public class Employee
	{
		public Int32 employeeID;
		public Int32 companyID;
		public string employeeName;
		public string employeeSurname;
		public string position;
		public string phone;
		public string email;

		public Employee(string employeeID, string companyID, string employeeName, string employeeSurname, string position, string phone, string email)
		{
			this.employeeID = Int32.Parse(employeeID);
			this.companyID = Int32.Parse(companyID);
			this.employeeName = employeeName;
			this.employeeSurname = employeeSurname;
			this.position = position;
			this.phone = phone;
			this.email = email;
		}
	}

	public class Computer
	{
		public Int32 computerID;
		public Int32 companyID;
		public Int32 employeeID;
		public DateTime dateOfPurchase;
		public string CPU;
		public int ramSize;
		public int diskSize;
		public string windowsKey;

		public Computer(string computerID, string companyID, string employeeID, string dateOfPurchase, string CPU, string ramSize, string diskSize, string windowsKey)
		{
			this.computerID = Int32.Parse(computerID);
			this.employeeID = Int32.Parse(employeeID);
			this.companyID = Int32.Parse(companyID);
			this.dateOfPurchase = DateTime.Parse(dateOfPurchase);
			this.CPU = CPU;
			this.ramSize = Int32.Parse(ramSize);
			this.diskSize = Int32.Parse(diskSize);
			this.windowsKey = windowsKey;
		}
	}
}
