# gRPC Server-Sent Events PoC

This project is a proof of concept (PoC) for implementing server-sent events using gRPC in a .NET environment. It demonstrates how to leverage gRPC for real-time communication in .NET applications.

## Project Structure

- **GrpcSSE**: Contains the server-side implementation.
- **GrpcSSEClient**: Contains the client-side implementation.
- **proto**: Contains the `messages.proto` file defining the gRPC service contracts.

## Setup and Execution

### Prerequisites

- [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0) or later
- [gRPC tools](https://grpc.io/docs/languages/csharp/quickstart/)

### Running the Server

1. Navigate to the `GrpcSSE` directory.
2. Run the server using the following command:

   ```bash
   dotnet run
   ```

### Running the Client

1. Navigate to the `GrpcSSEClient` directory.
2. Run the client using the following command:

   ```bash
   dotnet run
   ```

### Testing

- Ensure the server is running before starting the client.
- The client will connect to the server and start receiving streamed events.
- Observe the console output for received events.

## Documentation
# PoC .NET template

A template repository for .NET PoC (Proof of Concept)

---

- Create a new repository using this one as a template (click the green button at the top right of this page).
- Edit [README.md](README.md) file to align with your PoC.
- Change the solution and projects to suit your investigation/test/concept.

## Installation Guide

Follow these steps to set up the project. This guide includes installation scripts for PowerShell, Shell/Bash, and Batch.

### PowerShell

```ps
.\install.ps1
```

### Shell/Bash

```bash
./install.sh
```

### Batch

```batch
.\install.bat
```
