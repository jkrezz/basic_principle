using task4_SOLID;

IPrinter printer = new Printer();
printer.Print("Документ\n");

MFU multiPrinter = new MFU();
multiPrinter.Print("Документ 2");
Console.WriteLine(multiPrinter.Scan());