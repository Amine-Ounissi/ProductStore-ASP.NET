using Domain;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Domain
{
	public class Chemical : Product
	{
		public Address MyAdress { get; set; }
		public String LabName { get; set; }

		public override void GetDetails()
		{
			base.GetDetails();
			Console.WriteLine("Lab name  : {0}, City : {1}", LabName, MyAdress.City);
		}
		public override void GetMyType()
		{
			Console.WriteLine("Chemical");
		}

		private PropertyInfo[] _PropertyInfos = null;

		public override string ToString()
		{
			if (_PropertyInfos == null)
				_PropertyInfos = this.GetType().GetProperties();

			var sb = new StringBuilder();

			foreach (var info in _PropertyInfos)
			{
				var value = info.GetValue(this, null) ?? "(null)";
				sb.AppendLine(info.Name + ": " + value.ToString());
			}

			return sb.ToString();
		}

	}
}

