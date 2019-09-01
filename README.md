# 2d-lighting
From https://www.youtube.com/watch?v=ZJvCphxCGJU&amp;t=4s

## Setup
_Note: This is currently an experimental package._

* Window -> Package Manager
* Expand Lightweight RP
  * Install latest version
* Right-click in the Project tab and select Create -> Rendering -> Lightweight Rendering Pipeline -> Pipeline Asset
* Edit -> Project Settings...
  *Select Graphics settings from the left panel
  * Under Scriptable Render Pipeline Settings select the previously created Pipeline Asset File
* Right-click in the Project tab and select Create -> Rendering -> Lightweight Rendering Pipeline -> 2D Renderer
* Select the previously created Pipeline Asset file under the Project panel
* In the Inspector under the General settings, change Renderer Type to Custom
  * Drag the 2D Renderer from the Project panel to the Data field


** Creating Lights
Access the newly added 2D lights from GameObject -> Light -> 2D

** Flickering Lights
This repository utilizes _light cookies_, which are sprite images that act as illumination maps with white areas having more light and dark areas with less light. The `FlickeringLight` script randomly cycles between different light cookies specified within a sprite array.
