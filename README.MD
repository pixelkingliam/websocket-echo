# **Websocket# Echo server**

websocket-echo is a simple websocket server in C# for testing out websocket clients

this server waits for a message and then once it receives a message it responds with the content of the message

#### Compile

---

The only library this project uses is [websocket#-obranu](https://github.com/pixelkingliam/websocket-sharp-obranu) but the official builds of [websocket#](https://github.com/sta/websocket-sharp) should work fine

since this project was made using [Mono](https://github.com/mono/mono) it is compiled with `msbuild server.csproj`  similar utilities from [.NET FrameWork 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)

#### Usage

---

The compiled binaries can be ran from the [Mono](https://github.com/mono/mono) runtime on Linux and [Mono](https://github.com/mono/mono)/[.NET FW 4.72](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472) on Windows

to execute the program on most linux distributions run

`mono server.exe <port>` 

Rn command prompt you can run

`server.exe <port>`

Replace `<port>` with your desired port

To connect to the server you can use any common websocket client, there any many extensions for web browsers that accomplish this, along with standalone applications,

I personally recommend

* [Websocket King Client](https://chrome.google.com/webstore/detail/websocket-king-client/cbcbkhdmedgianpaifchdaddpnmgnknn) for Chromium-based browsers
* [Websocket Weasel](https://addons.mozilla.org/en-US/firefox/addon/websocket-weasel/) for Firefox
