# Krome Dialog Editor
This tool was created to assist in creating MK1 .dlg files quickly.
The format is fairly simple and consists of a few key sections.

## Format

### Actors
The actors section is used to set up the models that need to be present in the scene.
By default, no actors are drawn during dialog sequences. To make an actor visible, it must be specified here.
For a lot of Krome's actors there are two versions of the .mdl. One version is the base .mdl used to display the actor during gameplay
and the other (often labelled SYNKER) is a model used for more detailed animation during dialog sequences.

### Cameras
Each camera can be thought of as a camera sequence rather than an object.
A camera sequence consists of an FOV, near plane, far plane, and a time, along with a set of TCBInfo and a set of CamSplines.
Whilst it is not confirmed what TCB stands for, the data contains two floats which act as interpolation weights.
Each TCB spline that is created makes a new interpolation keyframe and the camera position along the splines can thus be shifted accordingly.
The CamSplines data contains 6 floats per spline. The first three floats are the camera source (where the camera should be) and the last
three floats are the camera target (what position the camera should be pointed at.)

### Phrases
Phrases are the core of the other data structure in the file. For each phrase defined in the file, a phoneme should be created and a cell is needed for each actor. The phrase data itself has a camera index, some effect parameters, and an effect delay.
The first effect parameter must be an event but the others have little documentation. It's recommended that you look over the vanilla files
for examples of effect parameters.

### Phonemes
Phonemes are individual audio clips along with their subtitle lines. 
The phoneme name should be a valid subtitle file name without the extension, which is then used to reference the audio and subtitle files.
A subtitle file (.ENGLISH (or other language)) is formatted such that each set of 255 bytes after the initial six are a line. The line is read until a null terminator (0x0) byte is found. The subtitleNr is the index of the subtitle text from the subtitle file that you want to apply to the phrase. 

### Cells
Think of the cells section like a table. The rows are the phrases and the columns are the actors.
So for each phrase, we create a new cell for each actor.
The data within each cell is related to the animations belonging to the actor and defines the head, body, and lip animations along with
a few other self-explanatory properties.

## Using The Tool
Using the tool is fairly simple. Simply go through each tab, adding the relevant data.
The lists on the right hand side of each section can be navigated to view and edit the existing data structres and pressing delete or backspace with an item selected will remove it completely.
Once you're happy with your file, you can switch to the output tab to see the file and copy/paste it to a new file ready for use.
