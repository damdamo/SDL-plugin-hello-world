# SDL-plugin-hello-world

A simple Trados 2021 plugin to display a "Hello World" message inside a window form.
This project aims to give some basics to interact through a custom plugin using Trados 2021.

## Build plugin

To be able to build the plugin, you need to sign it with a `Strongly Named Key (snk)`.
Furthermore, you should add a `*.snk` file and link it to the project.
Look at [here](https://learn.microsoft.com/en-us/dotnet/standard/assembly/strong-named) for more information.

Once it is configured and linked to your solution (`Properties -> Signing`), all you have to do is compile it.
Then, go to the target of the output, which is in `bin/Debug` or `bin/Release`.
You should look for `TestPluginWindowHello.sdlplugin` that is the plugin for Trados. Double click on it and install it for Trados 2021.
Open Trados and go to your `Add-Ins`, you should see a new plugin appears.