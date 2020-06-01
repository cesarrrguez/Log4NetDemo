# Log4NET Demo

[![RELEASE](https://img.shields.io/badge/version-v1.0.0-blue)](https://github.com/cesarrrguez/Log4NetDemo/releases/tag/v1.0.0)
[![LICENSE](https://img.shields.io/badge/license-MIT-green)](LICENSE)

Application to see _Log4Net_ examples.

## Examples

### ConsoleAppender_Thread

Console appender with the number of the current thread.

### ConsoleAppender_Logger

Console appender with the name of the log file called.

### ConsoleAppender_LevelRangeFilter

Console appender with a level range filter for filter in these case logs between _WARN_ and _ERROR_ levels, excluding _DEBUG_, _INFO_ AND _FATAL_ logs.

### ConsoleAppender_StringMatchFilter

Console appender with a string match filter for filter in these case logs with _application_ word.

### ConsoleAppender_LevelMatchFilter

Console appender with a level match filter for filter in these case _DEBUG_ logs, excluding the other levels.

### ConsoleAppender_Data

Console appender with full complete data at the pattern layout.

### ConsoleAppender_Property

Console appender with an own property at the pattern layout.

### ColoredConsoleAppender

Colored console appender with a defined style for _ERROR_ logs.

### FileAppender

File appender with a log file at _Logs\LogFile.txt_.

### RollingFileAppender

Rolling file appender with a log file at _Logs\RollingFileLog.txt_.

### RollingFileAppender_Date

Complete rolling file appender with a log file at _\logs_ path with date file name.

## License

The MIT License (MIT). Please see [License](LICENSE) for more information.
