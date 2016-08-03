using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_a_Simple_Parallel.ForEach_Loop
{
    class Program
    {
        static void Main()
        {
            String[] files = Directory.GetFiles(@"C:\My Documents\My Pictures","*jpg");
            String newDir = @"C:\My Documents\My Pictures\Modified";

            Parallel.ForEach(files, (currentFile)=> 
                                    {
                                        String fileName = Path.GetFileName(currentFile);
                                        var bitmap = new Bitmap(currentFile);

                                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                        bitmap.Save(Path.Combine(newDir, fileName));

                                        Console.WriteLine("Processing {0} on thread {1}", fileName, Thread.CurrentThread.ManagedThreadId);
                                    });

            Console.WriteLine("Processing complete. Press Any Key");
            Console.ReadKey();
        }

    }
}
