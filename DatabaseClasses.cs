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
		public string employeeID { get; set; }
		public string companyID { get; set; }
		public string employeeName { get; set; }
		public string employeeSurname { get; set; }
		public string position { get; set; }
		public string phone { get; set; }
		public string email { get; set; }

		public Employee(string employeeID, string companyID, string employeeName, string employeeSurname, string position, string phone, string email)
		{
			this.employeeID = employeeID;
			this.companyID = companyID;
			this.employeeName = employeeName;
			this.employeeSurname = employeeSurname;
			this.position = position;
			this.phone = phone;
			this.email = email;
		}
	}

	public class Computer
	{
		public string computerID { get; set; }
		public string companyID { get; set; }
		public string employeeID { get; set; }
		public string dateOfPurchase { get; set; }
		public string CPU { get; set; }
		public string ramSize { get; set; }
		public string diskSize { get; set; }
		public string windowsKey { get; set; }

		public Computer(string computerID, string companyID, string employeeID, string dateOfPurchase, string CPU, string ramSize, string diskSize, string windowsKey)
		{
			this.computerID = computerID;
			this.employeeID = employeeID;
			this.companyID = companyID;
			this.dateOfPurchase = dateOfPurchase;
			this.CPU = CPU;
			this.ramSize = ramSize;
			this.diskSize = diskSize;
			this.windowsKey = windowsKey;
		}
	}
}
