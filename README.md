![Logo Image]["MzansiDownloader\logo icon.png"]


# Mzansi downloader:

Data privacy is a buzzword these days and like many people I was concerned with my digital footprint. Many online Youtube downloader use Advertisements to earn revenue and this can lead to all sorts of digital fingerprinting and tracking. As such I decided to create my own youtube downloader in VB.Net that is both functional and does not collect my data.

# Libraries used:  
As a big fan of Open source I looked around and found a erfect candidate library to do the heavy-lifting for me. The library of choice is  ** VideoLibrary 3.0.9 **  by Bar Arnon, OMANSAK.

It would be better to clarify that this project is only a wrapper built to use VideoLibrary, simply provides a GUI and uses multi-threading to achieve its goal.

# Installation:
1. Download the installer, open the install.
2. Read and Accept the Term of Agreement for using the software.
3. When prompted to create a desktop shortcut, select yes.
4. Done.

## Using the software:
1. Go to Youtube and copy the video link.
2. Open the downloader and paste the link on the provided textbox.
3. Select the destination / folder to save the file / video to.
4. A message box will be shown to indicate to you whether the video download was successful or not.

# Contributing to this project:
You may contribute to this project by forking it. All the help would be appreciated.

## Features still missing:
- Choosing the video quality e.g. 360p, 720p etc.
- Downloading multiple videos at once.
- Show the user how much time is left until download is finished.

## Getting the VideoLibary:
After opening the solution you need to run the following Nu-Get command on the CLI.

"
	Install-Package VideoLibrary -Version 3.0.9
"

And if you encounter some errors. Please follow this link to [VideoLibrary page](https://www.nuget.org/packages/VideoLibrary). 