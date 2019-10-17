﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace PepperDash.Core.PasswordManagement
{
	// Example JSON password configuration object
	//{
	//    "global":{
	//        "passwords":[
	//            {
	//                "key": "Password01",
	//                "name": "Technician Password",
	//                "enabled": true,
	//                "password": "1988"
	//            }
	//        ]
	//    }
	//}

	/// <summary>
	/// Passwrod manager JSON configuration
	/// </summary>
	public class PasswordConfig
	{
		/// <summary>
		/// Key used to search for object in JSON array
		/// </summary>
		public string key { get; set; }
		/// <summary>
		/// Friendly name of password object
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// Password object enabled
		/// </summary>
		public bool enabled { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public ushort simplEnabled
		{
			get { return (ushort)(enabled ? 1 : 0); }
			set { enabled = Convert.ToBoolean(value); }
		}
		/// <summary>
		/// Password object configured password
		/// </summary>
		public string password { get; set; }
		/// <summary>
		/// Password type
		/// </summary>
		private int type { get; set; }
		/// <summary>
		/// Password Type for S+
		/// </summary>
		public ushort simplType
		{
			get { return Convert.ToUInt16(type); }
			set { type = value; }
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public PasswordConfig()
		{
			simplEnabled = 0;
			simplType = 0;
		}
	}

	/// <summary>
	/// Global JSON object
	/// </summary>
	public class GlobalConfig
	{
		public List<PasswordConfig> passwords { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		public GlobalConfig()
		{

		}
	}

	/// <summary>
	/// Root JSON object
	/// </summary>
	public class RootObject
	{
		public GlobalConfig global { get; set; }
	}
}