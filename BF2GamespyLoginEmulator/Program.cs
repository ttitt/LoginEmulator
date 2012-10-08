﻿using System;

namespace Gamespy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set window title
            Console.Title = "Battlefield 2 Gamespy Login Emulator";

            // Run the server
            Server iServer;

            try
            {
                iServer = new Server();
                iServer.Start();

            }
            catch( System.Net.Sockets.SocketException e )
            {
                Console.WriteLine( e.ToString() );
            }
            catch( System.Threading.ThreadInterruptedException e )
            {
                Console.WriteLine( e.ToString() );
            }
            catch( Exception e )
            {
                Console.WriteLine( e.ToString() );
            }
        }
    } 
}