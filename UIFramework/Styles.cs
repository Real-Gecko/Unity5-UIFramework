/*
 * UI Framework licensed under BSD 3-clause license
 * https://github.com/Real-Gecko/Unity5-Overdriveramework/blob/master/LICENSE.md
*/


using System;
using UnityEngine;

namespace UIFramework
{
	internal class Styles
	{
		internal static GUIStyle textCommon;

		internal static GUIStyle box;
		internal static GUIStyle label;
		internal static GUIStyle textField;
		internal static GUIStyle textArea;
		internal static GUIStyle button;
		internal static GUIStyle toggle;
		internal static GUIStyle window;
		internal static GUIStyle horizontalSlider;
		internal static GUIStyle horizontalSliderThumb;
		internal static GUIStyle verticalSlider;
		internal static GUIStyle verticalSliderThumb;
		internal static GUIStyle horizontalScrollbar;
		internal static GUIStyle horizontalScrollbarThumb;
		internal static GUIStyle horizontalScrollbarLeftButton;
		internal static GUIStyle horizontalScrollbarRightButton;
		internal static GUIStyle verticalScrollbar;
		internal static GUIStyle verticalScrollbarThumb;
		internal static GUIStyle verticalScrollbarUpButton;
		internal static GUIStyle verticalScrollbarDownButton;
		internal static GUIStyle scrollView;

		internal static GUIStyle selectionGrid;

		internal const int fontSize = 14;
		internal static Font mainFont = GUI.skin.font;
		internal static FontStyle fontStyle = FontStyle.Bold;

		internal static void InitStyles() {

			// Common text style
			textCommon = new GUIStyle();
			textCommon.name = "OverdriveTextCommon";

			textCommon.font = GUI.skin.font;
			textCommon.fontSize = fontSize;
			textCommon.fontStyle = fontStyle;

			textCommon.normal.textColor = Palette.white;

			// Box style
			box = new GUIStyle(textCommon);
			box.name = "OverdriveBox";
			box.normal.background = Palette.tGrimGray;

			box.border		= Offsets.square6;
			box.margin		= Offsets.horizontal4;
			box.alignment = TextAnchor.MiddleCenter;

			box.wordWrap = true;
			box.clipping = TextClipping.Clip;

			// Label style
			label = new GUIStyle (textCommon);
			label.name = "OverdriveLabel";

			label.normal.background = Palette.tTransparent;

			label.margin		= Offsets.square4;
			label.padding		= Offsets.vertical3;

			label.wordWrap		= true;
			label.stretchWidth	= false;

			// TextField style
			textField = new GUIStyle(textCommon);
			textField.name = "OverdriveTextField";

			textField.normal.background = Palette.tGrimGray;
			textField.normal.textColor = Palette.dimWhite;

			textField.hover.background = Palette.tGrimGray;
			textField.hover.textColor = Palette.yellow;

			textField.onNormal.background = Palette.tGrimGray;
			textField.onHover.textColor = Palette.white;

			textField.focused.background = Palette.tGrimGray;
			textField.focused.textColor = Palette.white;

			textField.border = Offsets.square4;
			textField.margin = Offsets.square2;
			textField.padding = new RectOffset (9, 3, 3, 3);
			textField.overflow = new RectOffset (0, 0, 2, 2);

			textField.imagePosition = ImagePosition.TextOnly;
			textField.clipping = TextClipping.Clip;
			textField.fixedWidth = 0;
			textField.fixedHeight = 0;
			textField.stretchWidth = true;
			textField.stretchHeight = false;

			// TextArea style
			textArea = new GUIStyle(textCommon);
			textArea.name = "OverdriveTextArea";

			textArea.normal.background = Palette.tDarkGray;
			textArea.normal.textColor = Palette.dimWhite;

			textArea.hover.textColor = Palette.yellow;

			textArea.onNormal.textColor = Palette.white;

			textArea.border = Offsets.square6;
			textArea.margin = Offsets.horizontal4;
			textArea.padding = Offsets.square8;
			textArea.wordWrap = true;
			textArea.clipping = TextClipping.Clip;

			// Button style
			button = new GUIStyle (textCommon);
			button.name = "OverdriveButton";
			button.normal.background = Palette.tGray;
			button.normal.textColor = Palette.white;

			button.hover.background = Palette.tLightGray;
			button.hover.textColor = Palette.yellow;

			button.active.background = Palette.tGrimGray;
			button.active.textColor = Palette.yellow;

			button.onNormal.background = Palette.tGrimGray;
			button.onNormal.textColor = Palette.white;

			button.onHover.background = Palette.tLightGray;
			button.onHover.textColor = Palette.yellow;

			button.onActive.background = Palette.tGrimGray;
			button.onActive.textColor = Palette.white;

			button.border = new RectOffset (15, 15, 8, 8);
			button.margin = Offsets.square2;
			button.padding = new RectOffset(4, 4, 6, 6);
			button.alignment = TextAnchor.MiddleCenter;

			// Toggle
			toggle = new GUIStyle (textCommon);
			toggle.name = "OverdriveToggle";

			toggle.normal.background = Palette.tDarkGray;
			toggle.normal.textColor = Palette.red;

			toggle.hover.background = Palette.tGray;
			toggle.hover.textColor = Palette.red;

			toggle.active.background = Palette.tDarkGray;
			toggle.active.textColor = Palette.green;

			toggle.onNormal.background = Palette.tGrimGray;
			toggle.onNormal.textColor = Palette.green;

			toggle.onHover.background = Palette.tGrimGray;
			toggle.onHover.textColor = Palette.green;

			toggle.onActive.background = Palette.tGrimGray;
			toggle.onActive.textColor = Palette.green;

			toggle.border = new RectOffset (15, 15, 8, 8);
			toggle.margin = Offsets.square2;
			toggle.padding = new RectOffset(4, 4, 6, 6);
//			toggle.overflow = new RectOffset (-1, 0, -4, 0);

			toggle.clipping = TextClipping.Clip;
//			toggle.contentOffset = new Vector2 (22.6f, 5);
//			toggle.fixedWidth = 30;
//			toggle.fixedHeight = 30;
//			toggle.stretchWidth = false;

			// Window style
			window = new GUIStyle(textCommon);
			window.name = "OverdriveWindow";

			window.normal.background = Palette.tBorder;
			window.normal.textColor = Palette.yellow;

			window.active.background = Palette.tBorder;
			window.active.textColor = Palette.yellow;

			window.onNormal.background = Palette.tBorder;
			window.onNormal.textColor = Palette.yellow;

			window.focused.background = Palette.tBorder;
			window.focused.textColor = Palette.yellow;

			window.border = Offsets.square2;
			window.padding = new RectOffset (8, 6, 28, 8);

			window.alignment = TextAnchor.UpperCenter;
			window.clipping = TextClipping.Clip;
			window.contentOffset = new Vector2 (0.0f, -20.0f);
			window.fontSize = 16;

			// HorizontalSlider
			horizontalSlider = new GUIStyle();
			horizontalSlider.name = "OverdriveHorizontalSlider";

			horizontalSlider.normal.background = Palette.tGrimGray;
			horizontalSlider.normal.textColor = Palette.transparent;

			horizontalSlider.border = Offsets.square4;
			horizontalSlider.margin = Offsets.square2;
			horizontalSlider.overflow = new RectOffset (0, 0, 2, 2);
			horizontalSlider.imagePosition = ImagePosition.ImageOnly;
			horizontalSlider.clipping = TextClipping.Clip;
			horizontalSlider.fixedHeight = 12;

			// HorizontalSliderThumb
			horizontalSliderThumb = new GUIStyle();
			horizontalSliderThumb.name = "OverdriveHorizontalSliderThumb";

			horizontalSliderThumb.normal.background = Palette.tDarkGray;
			horizontalSliderThumb.normal.textColor = Palette.transparent;

			horizontalSliderThumb.hover.background = Palette.tGray;
			horizontalSliderThumb.hover.textColor = Palette.transparent;

			horizontalSliderThumb.active.background = Palette.tLightGray;
			horizontalSliderThumb.active.textColor = Palette.transparent;

			horizontalSliderThumb.border = Offsets.horizontal4;
			horizontalSliderThumb.padding = Offsets.horizontal7;
			horizontalSliderThumb.overflow = new RectOffset (-1, -1, 0, 0);

			horizontalSliderThumb.imagePosition = ImagePosition.ImageOnly;
			horizontalSliderThumb.clipping = TextClipping.Clip;
			horizontalSliderThumb.fixedWidth = 28.1975f;
			horizontalSliderThumb.fixedHeight = 12;

			//Vertical slider
			verticalSlider = new GUIStyle();
			verticalSlider.name = "OverdriveVerticalSlider";

			verticalSlider.normal.background = Palette.tGrimGray;
			verticalSlider.normal.textColor = Palette.transparent;

			verticalSlider.border = Offsets.vertical3;
			verticalSlider.margin = Offsets.square2;
			verticalSlider.padding = new RectOffset (0, 0, -1, -1);
			verticalSlider.overflow = new RectOffset (-2, -3, 0, 0);

			verticalSlider.fixedWidth = 12;
			verticalSlider.stretchWidth = false;
			verticalSlider.stretchHeight = true;

			// Vertical slider thumb
			verticalSliderThumb = new GUIStyle();
			verticalSliderThumb.name = "OverdriveVerticalSliderThumb";

			verticalSliderThumb.normal.background = Palette.tDarkGray;
			verticalSliderThumb.normal.textColor = Palette.transparent;

			verticalSliderThumb.hover.background = Palette.tGray;
			verticalSliderThumb.hover.textColor = Palette.transparent;

			verticalSliderThumb.active.background = Palette.tLightGray;
			verticalSliderThumb.active.textColor = Palette.transparent;

			verticalSliderThumb.padding = Offsets.vertical7;
			verticalSliderThumb.overflow = new RectOffset (0, 0, -1, -1);
			verticalSliderThumb.clipping = TextClipping.Clip;

			verticalSliderThumb.fixedWidth = 12;
			verticalSliderThumb.fixedHeight = 0;

			verticalSliderThumb.stretchWidth = false;
			verticalSliderThumb.stretchHeight = true;

			// Horizontal scroll bar
			horizontalScrollbar = new GUIStyle(textCommon);
			horizontalScrollbar.name = "OverdriveHorizontalScrollbar";

			horizontalScrollbar.normal.background = Palette.tGrimGray;
			horizontalScrollbar.normal.textColor = Palette.transparent;

			horizontalScrollbar.border = Offsets.horizontal9;
			horizontalScrollbar.margin = Offsets.square2;

			horizontalScrollbar.imagePosition = ImagePosition.ImageOnly;
			horizontalScrollbar.clipping = TextClipping.Clip;

			horizontalScrollbar.fixedHeight = 15;

			// Horizontal Scrollbar Thumb
			horizontalScrollbarThumb = new GUIStyle();
			horizontalScrollbarThumb.normal.background = Palette.tDarkGray;
			horizontalScrollbarThumb.normal.textColor = Palette.transparent;

			horizontalScrollbarThumb.border = Offsets.square6;
			horizontalScrollbarThumb.padding = Offsets.horizontal6;
			horizontalScrollbarThumb.overflow = new RectOffset (0, 0, -1, -1);

			horizontalScrollbarThumb.clipping = TextClipping.Clip;
			horizontalScrollbarThumb.fixedHeight = 13;

			// Horizontal scrollbar left button
			horizontalScrollbarLeftButton = new GUIStyle ();
			horizontalScrollbarLeftButton.name = "OverdriveHorizontalScrollbarLeftButton";

			horizontalScrollbarLeftButton.clipping = TextClipping.Clip;

			// Horizontal scrollbar right button
			horizontalScrollbarRightButton = new GUIStyle ();
			horizontalScrollbarRightButton.name = "OverdriveHorizontalScrollbarRightButton";

			horizontalScrollbarRightButton.clipping = TextClipping.Clip;

			// Vertical scrollbar
			verticalScrollbar = new GUIStyle();
			verticalScrollbar.name = "OverdriveVerticalScrollbar";

			verticalScrollbar.normal.background = Palette.tGrimGray;

			verticalScrollbar.border = Offsets.vertical9;
			verticalScrollbar.margin = Offsets.square2;
			verticalScrollbar.padding = new RectOffset(0, 0, 1, 1);

			verticalScrollbar.clipping = TextClipping.Clip;
			verticalScrollbar.fixedWidth = 15;

			// Vertical scrollbar thumb
			verticalScrollbarThumb = new GUIStyle();
			verticalScrollbarThumb.name = "OverdriveVerticalScrollbarThumb";

			verticalScrollbarThumb.normal.background = Palette.tGray;

			verticalScrollbarThumb.border = Offsets.square6;
			verticalScrollbarThumb.padding = Offsets.vertical6;
			verticalScrollbarThumb.overflow = new RectOffset (-1, -1, 0, 0);

			verticalScrollbarThumb.imagePosition = ImagePosition.ImageOnly;
			verticalScrollbarThumb.clipping = TextClipping.Clip;

			verticalScrollbarThumb.fixedWidth = 15;
			verticalScrollbarThumb.stretchWidth = false;

			// verticalScrollbarUpButton
			verticalScrollbarUpButton = new GUIStyle(textCommon);
			verticalScrollbarUpButton.name = "OverdriveVerticalScrollbarUpButton";

			verticalScrollbarUpButton.clipping = TextClipping.Clip;

			//verticalScrollbarDownButton
			verticalScrollbarDownButton = new GUIStyle (textCommon);
			verticalScrollbarDownButton.name = "OverdriveVerticalScrollbarDownButton";

			verticalScrollbarDownButton.clipping = TextClipping.Clip;

			// Scrollview style
			scrollView = new GUIStyle(textCommon);
			scrollView.name = "OverdriveScrollView";
			scrollView.normal.background = Palette.tGrimGray;

			scrollView.border = Offsets.square8;
			scrollView.margin = new RectOffset (6, 3, 0, 0);
			scrollView.padding = new RectOffset(11, 0, 0, -23);
			scrollView.overflow = new RectOffset (0, 0, 0, 1);

			scrollView.clipping = TextClipping.Clip;

			// Selection grid buttons
			selectionGrid = new GUIStyle (button);
			selectionGrid.name = "OverdriveSelectionGrid";
			selectionGrid.alignment = TextAnchor.MiddleCenter;

			selectionGrid.normal.textColor = Palette.darkGray;
			selectionGrid.normal.textColor = Palette.dimWhite;

			selectionGrid.onNormal.background = Palette.tGrimGray;
			selectionGrid.onNormal.textColor = Palette.green;
		}

		internal static void OverrideKSP() {
			HighLogic.Skin.box = box;
			HighLogic.Skin.label = label;
			HighLogic.Skin.textField = textField;
			HighLogic.Skin.textArea = textArea;
			HighLogic.Skin.button = button;
			HighLogic.Skin.toggle = toggle;
			HighLogic.Skin.window	= window;
			HighLogic.Skin.horizontalSlider = horizontalSlider;
			HighLogic.Skin.horizontalSliderThumb = horizontalSliderThumb;
			HighLogic.Skin.verticalSlider = verticalSlider;
			HighLogic.Skin.verticalSliderThumb = verticalSliderThumb;
			HighLogic.Skin.horizontalScrollbar = horizontalScrollbar;
			HighLogic.Skin.horizontalScrollbarThumb = horizontalScrollbarThumb;
			HighLogic.Skin.horizontalScrollbarLeftButton = horizontalScrollbarLeftButton;
			HighLogic.Skin.horizontalScrollbarRightButton = horizontalScrollbarRightButton;
			HighLogic.Skin.verticalScrollbar = verticalScrollbar;
			HighLogic.Skin.verticalScrollbarThumb = verticalScrollbarThumb;
			HighLogic.Skin.verticalScrollbarUpButton = verticalScrollbarUpButton;
			HighLogic.Skin.verticalScrollbarDownButton = verticalScrollbarDownButton;
			HighLogic.Skin.scrollView = scrollView;

			HighLogic.Skin.font = mainFont;
		}

		internal static void OverrideUnity() {
			GUI.skin.box = box;
			GUI.skin.label = label;
			GUI.skin.textField = textField;
			GUI.skin.textArea = textArea;
			GUI.skin.button = button;
			GUI.skin.toggle = toggle;
			GUI.skin.window	= window;
			GUI.skin.horizontalSlider = horizontalSlider;
			GUI.skin.horizontalSliderThumb = horizontalSliderThumb;
			GUI.skin.verticalSlider = verticalSlider;
			GUI.skin.verticalSliderThumb = verticalSliderThumb;
			GUI.skin.horizontalScrollbar = horizontalScrollbar;
			GUI.skin.horizontalScrollbarThumb = horizontalScrollbarThumb;
			GUI.skin.horizontalScrollbarLeftButton = horizontalScrollbarLeftButton;
			GUI.skin.horizontalScrollbarRightButton = horizontalScrollbarRightButton;
			GUI.skin.verticalScrollbar = verticalScrollbar;
			GUI.skin.verticalScrollbarThumb = verticalScrollbarThumb;
			GUI.skin.verticalScrollbarUpButton = verticalScrollbarUpButton;
			GUI.skin.verticalScrollbarDownButton = verticalScrollbarDownButton;
			GUI.skin.scrollView = scrollView;

			GUI.skin.font = mainFont;
		}
	}
}

