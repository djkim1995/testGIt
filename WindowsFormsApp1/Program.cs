﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점이다.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

        static void someThing()
        {
            int a = 1;
        }
	}
}
