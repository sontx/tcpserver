# TcpServer

A simple tcp server which can be able to listen tcp connections from clients and then sends or receives text or hex to/from these clients.

![screenshot](https://raw.githubusercontent.com/sontx/tcpserver/master/screenshot.png)

## Getting Started


### Prerequisites

You need at least [.net 4.6.1](https://www.microsoft.com/en-us/download/details.aspx?id=49981) to run this tool.

If you want to build by yourself, you need [Visual Studio 2019](https://visualstudio.microsoft.com/vs/) or later

### Installing

Just download binary files from [release](https://github.com/sontx/tcpserver/releases) page and run it directly. There are two binaries:

- **TcpServer.exe**: tcp server
- **Emulator.exe**: simulates tcp client, you can use this tool to connect to any tcp server and then sends ro receives text/hex from this server

## Deployment

This tool is written in C# with .net 4.6.1 and also uses [Blackcat](https://github.com/sontx/blackcat) to manipulate with settings.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/sontx/tcpserver/tags). 

## Authors

* **Tran Xuan Son** - [sontx](https://github.com/sontx)

See also the list of [contributors](https://github.com/sontx/tcpserver/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details