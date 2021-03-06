﻿using System;
using System.IO;
using GameBoy.IO;

namespace GameBoy
{
	public class Program
	{
		public static void Main(string[] args) 
		{
			Console.WriteLine ("Starting");

			string filename = args?[0];
			if (filename == null) {
				Console.WriteLine ("ERROR: No ROM path supplied.");
			} else if (!File.Exists (filename)) {
				Console.WriteLine("ERROR: {0} does not exist in {1}", filename, Directory.GetCurrentDirectory().ToString()); 
			}

			var gameboy = new GameBoy (filename);

			gameboy.Start ();
		}

		public static void Quit ()
		{
			Environment.Exit (0);
		}
	}
}