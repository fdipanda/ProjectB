# Project B: Inter-Process Communication

## Overview

This repository contains a simple C# example demonstrating inter-process communication (IPC) using Named Pipes. The sample shows a basic client-server communication pattern where:

- A server pipe waits for incoming connections
- A client pipe connects to the server
- The client sends a message to the server
- The server receives and displays the message

This pattern is useful for communication between processes on the same machine, providing a reliable and secure communication channel.

## Features

- Simple Named Pipe server implementation
- Corresponding client implementation
- Basic message passing between processes
- Synchronization between client and server
- Clean resource management with `using` statements

## Dependencies

- .NET 6.0 SDK or later
- Visual Studio 2022 or Visual Studio Code (recommended)

## Installation

1. Ensure you have the .NET SDK installed. You can download it from [Microsoft's .NET download page](https://dotnet.microsoft.com/download).

2. Clone this repository:
   ```
   git clone https://github.com/fdipanda/ProjectB.git
   cd ProjectB
   ```

## Building the Project

### Using Visual Studio:
1. Open the solution file (`ProjectB.sln`) in Visual Studio
2. Build the solution using `Build > Build Solution` or press `Ctrl+Shift+B`

### Using .NET CLI:
```
dotnet build
```

## Running the Example

### Using Visual Studio:
1. Set the project as the startup project
2. Press `F5` to run with debugging, or `Ctrl+F5` to run without debugging

### Using .NET CLI:
```
dotnet run
```

## Expected Output

When you run the program, you should see output similar to:

```
[Server] Waiting for connection...
[Client] Connected to server.
[Client] Message sent.
[Server] Client connected.
[Server] Received: Hello from Client!
```

## How It Works

1. The program starts both a server and client in the same process
2. The server runs asynchronously in a separate task and waits for connections
3. After a brief delay to ensure the server is ready, the client connects to the server
4. The client sends a message to the server through the pipe
5. The server reads the message and displays it
6. Both client and server properly dispose of their resources

## Extending the Example

This example can be extended in several ways:

- Implement bidirectional communication
- Add message serialization for complex data structures
- Implement authentication and security features
- Create separate processes for client and server
- Add error handling and recovery
- Implement asynchronous communication patterns

