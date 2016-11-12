/*
 * UI Framework licensed under BSD 3-clause license
 * https://github.com/Real-Gecko/Unity5-UIFramework/blob/master/LICENSE.md
*/


using System;
using UnityEngine;

namespace UIFramework
{
	internal struct Palette {
		// Colors
		public static Color dimWhite = new Color(0.9f, 0.9f, 0.9f, 0.9f);
		public static Color white = new Color(1.0f, 1.0f, 1.0f);
		public static Color red = new Color (1.0f, 0.8f, 0.8f);
		public static Color green = new Color (0.8f, 1.0f, 0.8f);
		public static Color blue = new Color (0.7f, 0.7f, 1.0f);
		public static Color yellow = new Color(1.0f, 1.0f, 0.5f);
		public static Color gray = new Color (0.5f, 0.5f, 0.5f);
		public static Color lightGray = new Color(0.55f, 0.55f, 0.55f);
		public static Color darkGray = new Color(0.3f, 0.3f, 0.3f);
		public static Color grimGray = new Color(0.2f, 0.2f, 0.2f);
		public static Color transparent = new Color (0.0f, 0.0f, 0.0f, 0.0f);

		// Color filled textures
		public static Texture2D tRed = new Texture2D(1, 1);
		public static Texture2D tGreen = new Texture2D(1, 1);
		public static Texture2D tGray = new Texture2D(1, 1);
		public static Texture2D tLightGray = new Texture2D(1, 1);
		public static Texture2D tDarkGray = new Texture2D(1, 1);
		public static Texture2D tGrimGray = new Texture2D(1, 1);
		public static Texture2D tTransparent = new Texture2D(1, 1);
		public static Texture2D tBorder = new Texture2D(4, 4);

		internal static void InitPalette() {
			tRed.SetPixel (0, 0, red);
			tRed.Apply ();

			tGreen.SetPixel (0, 0, green);
			tGreen.Apply ();

			tGray.SetPixel(0, 0, gray);
			tGray.Apply();

			tLightGray.SetPixel(0, 0, lightGray);
			tLightGray.Apply();

			tDarkGray.SetPixel(0, 0, darkGray);
			tDarkGray.Apply();

			tGrimGray.SetPixel(0, 0, grimGray);
			tGrimGray.Apply();

			tTransparent.SetPixel (0, 0, transparent);
			tTransparent.Apply ();

			tBorder.SetPixel (0, 0, lightGray);
			tBorder.SetPixel (0, 1, lightGray);
			tBorder.SetPixel (0, 2, lightGray);
			tBorder.SetPixel (0, 3, lightGray);
			tBorder.SetPixel (1, 0, lightGray);
			tBorder.SetPixel (1, 1, darkGray);
			tBorder.SetPixel (1, 2, darkGray);
			tBorder.SetPixel (1, 3, lightGray);
			tBorder.SetPixel (2, 0, lightGray);
			tBorder.SetPixel (2, 1, darkGray);
			tBorder.SetPixel (2, 2, darkGray);
			tBorder.SetPixel (2, 3, lightGray);
			tBorder.SetPixel (3, 0, lightGray);
			tBorder.SetPixel (3, 1, lightGray);
			tBorder.SetPixel (3, 2, lightGray);
			tBorder.SetPixel (3, 3, lightGray);
		}
	}
}

