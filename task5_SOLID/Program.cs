using task5_SOLID;

ILogger consoleLogger = new ConsoleLogger();
ServiceLogger userServiceWithConsoleLogger = new ServiceLogger(consoleLogger);
userServiceWithConsoleLogger.CreateMes("Message1");

ILogger fileLogger = new FileLogger();
ServiceLogger userServiceWithFileLogger = new ServiceLogger(fileLogger);
userServiceWithFileLogger.CreateMes("Message2");