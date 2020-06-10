using System;

using SFML.Graphics;

using SFML.Window;

namespace MiniBank {

	class Program {
		static void Main(string[] args) { 

			RenderWindow window = new RenderWindow(new VideoMode(1920, 1080), "MiniBank");

			window.SetActive();

			while (window.IsOpen) {

				window.Clear();

				window.Display();

			}

		}
	}
}
