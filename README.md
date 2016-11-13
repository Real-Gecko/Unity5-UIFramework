### UI Framework created to make UI styling and layouting easier for Unity 5

## Dev notes

### Styling
- normal	- normal element rendering
- hover	- when element is hovered
- active	- when mouse is pressed down on element, but it's not yet on
- onNormal	- when element is on
- onHover	- when element is on and hovered
- onActive	- when element is on and mouse pressed down

### New GUIStyle defaults
- normal, hover, active, onNormal, onHover, onActive, focused, onFocused
- --- background = null
- --- textColor = RGBA(0.000, 0.000, 0.000, 1.000)
			//
- border = RectOffset (l:0 r:0 t:0 b:0)
- margin = RectOffset (l:0 r:0 t:0 b:0)
- padding = RectOffset (l:0 r:0 t:0 b:0)
- overflow = RectOffset (l:0 r:0 t:0 b:0)
- clipOffset = Vector2 (0.0, 0.0)
			//
- font = null
- imagePosition = ImagePosition.ImageLeft
- alignment = TextAnchor.UpperLeft
- wordWrap = false
- clipping = TextClipping.Overflow
- contentOffset = Vector2 (0.0, 0.0)
- fixedWidth = 0
- fixedHeight = 0
- stretchWidth = true
- stretchHeight = false
- fontSize = 0
- fontStyle = FontStyle.Normal
- richText = true

Defining textColor with background = null won't work

### Workflow if element is turned on by mouse button: (button, toggle, selection grid)

1. cursor is out there				- normal
2. cursor hovered element			- hover
3. mouse button pressed down
   element is not yet "ON"
   at this point						- active
4. mouse button unpressed
   element is "ON" now
   cursor is still over element		- onHover
5. cursor leaves the element			- onNormal
6. cursor hovers element once more	- onHover
7. mouse button pressed down
   element is still "ON"
   at this point						- onActive
8. mouse button unpressed
   cursor is still over element		- hover
9. cursor leaves the element			- normal
10. ?????
11. PROFIT!!!!111oneoneone
