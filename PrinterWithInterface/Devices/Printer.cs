using System;


namespace PrinterWithInterface.Devices

{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(String document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
