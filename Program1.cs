using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;

class Program1
{
    static void Main()
    {
        Task.Run(() => StartServer()); // Start the server in a separate task
        Thread.Sleep(500); // Ensure server starts before client
        StartClient(); // Start the client
    }

    static void StartServer()
    {
        using (NamedPipeServerStream server = new NamedPipeServerStream("mypipe"))
        {
            Console.WriteLine("[Server] Waiting for connection...");
            server.WaitForConnection();
            Console.WriteLine("[Server] Client connected.");

            using (StreamReader reader = new StreamReader(server))
            {
                string message = reader.ReadLine();
                Console.WriteLine("[Server] Received: " + message);
            }
        }
    }

    static void StartClient()
    {
        using (NamedPipeClientStream client = new NamedPipeClientStream("mypipe"))
        {
            client.Connect();
            Console.WriteLine("[Client] Connected to server.");

            using (StreamWriter writer = new StreamWriter(client))
            {
                writer.AutoFlush = true;
                writer.WriteLine("Hello from Client!");
                Console.WriteLine("[Client] Message sent.");
            }
        }
    }
}
