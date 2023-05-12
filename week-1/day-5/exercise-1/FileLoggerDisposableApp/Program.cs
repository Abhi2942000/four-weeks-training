namespace FileLoggerDisposableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use FileLogger and dispose of it properly
        }
    }

    class FileLogger : IDisposable
    {
        private StreamWriter _writer;

        public FileLogger(string filePath)
        {
            // Initialize StreamWriter instance
        }

        public void Dispose()
        {
            // Implement IDisposable pattern
        }

        public void Log(string message)
        {
            // Write message to the file
        }
    }
}

using System;
using System.IO;

//Created a class called "FileLogger" that implements the IDisposable interface.

public class FileLogger : IDisposable
{
    private StreamWriter _writer;                                  //Added a private field called "_writer" which is an instance of StreamWriter.

    public FileLogger(string filePath)                            //Created a constructor that takes a file path as a parameter and initializes the "_writer" field with that file path.
    {
        _writer = new StreamWriter(filePath);
    }

    public void Log(string message)                               //We have added a method called "Log" that writes a log entry to the file.
    {
        _writer.WriteLine($"{DateTime.Now.ToString()} - {message}");
    }

    public void Dispose()                                         //Implemented the IDisposable pattern by defining a "Dispose" method,
    {
        Dispose(true);
        GC.SuppressFinalize(this);                                // We have also added a call to "GC.SuppressFinalize(this)" to ensure that the finalizer does not attempt to dispose of the object again.
    }

    protected virtual void Dispose(bool disposing)                // "Dispose(bool disposing)" method, which is used to properly dispose of the object
    {
        if (disposing)
        {
            if (_writer != null)
            {
                _writer.Dispose();
                _writer = null;
            }
        }
    }
}


public class Program
{
    public static void Main()
    {
        using (var logger = new FileLogger("log.txt"))           //we have created a "FileLogger" instance and used it to write two log entries to the file "log.txt".
        {
            logger.Log("Abhi");
            logger.Log("Sharvil");
        }
    }
}

