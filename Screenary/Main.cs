/**
 * Screenary: Real-Time Collaboration Redefined.
 * Main
 *
 * Copyright 2011 Marc-Andre Moreau <marcandre.moreau@gmail.com>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using Gtk;

namespace Screenary
{
	class MainClass
	{
		public static string WorkingDirectory;
		
		public static void Main (string[] args)
		{
			MainWindow window;
			
			Application.Init();
			
			WorkingDirectory = Directory.GetCurrentDirectory();
			
			if (!WorkingDirectory.EndsWith("/"))
				WorkingDirectory += "/";
			
			Directory.SetCurrentDirectory(WorkingDirectory + "../../");
			
			window = new MainWindow();
			window.Show();
			
			Application.Run();
		}
	}
}
