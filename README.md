# VideoSetupNX

I threw together a quick app for creating HTML files (using https://gbatemp.net/threads/html-video-template-nx.520956/) and converting files to switch compatible formats. I know the code is probably unoptimized. I plan on working on that, but right now it's just a quick POC. (Warning: hacky and possibly shitty code here!)

__Features__
- Generates customized HTML from a folder of switch-compatible video files
- Converts video files to Switch-compatible format with optional resizing. (requires ffmpeg pre-installed)
- Autocreates episode preview snapshots
- Automatically sets up directories, HTML/CSS/JS files. Just drop your videos into the vids folder!

__Issues__
- Video files containing subs will lose subtitles upon Conversion. This will be fixed in an update soon.

__Usage__

Follow each step, then hit "Generate project". It'll open the output directory when it's complete. Copy the videos you selected in Step 2 into the "vids" folder, then build the entire output folder (the stuff in the folder, not the folder itself!) with the Homebrew Web Framework.

__Screenshots__

![GUI Screenshot](http://aida.moe/share/BJeY.png)

![End Result](http://aida.moe/share/I3rd.png)

__Credits__

SuperOkazaki/OkazakiTheOtaku for their awesome HTML work (https://github.com/SuperOkazaki/HTML-Video-Template-NX)
